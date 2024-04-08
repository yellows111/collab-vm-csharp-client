using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace CollabClient
{
    public partial class LoginForm : Form
    {
        private bool addedEvents = false;
        private bool useCaptcha;
        private string apiBaseUrl;
        public bool finished = false;
        public LoginResponse response;

        public LoginForm(string apiBaseUrl, string hcaptchakey)
        {
            InitializeComponent();
            this.apiBaseUrl = apiBaseUrl;
            useCaptcha = hcaptchakey != null;
            // We use a webBrowser for the username and password fields so that the hcaptcha can cover them if need be
            // the alternative is having the window be disproportionately huge to allow the captcha to open
            // hcaptcha refuses to work if it's being loaded from non-http: scheme, so this has to be remote unless we find a way to spoof that
            var url = "https://collabhost.computernewb.com/collabvm-csharp-login.php";
            if (hcaptchakey != null) url += "?hcaptcha=" + HttpUtility.UrlEncode(hcaptchakey);
            webBrowser1.Url = new Uri(url);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (addedEvents) return;
            addedEvents = true;
            var btn = webBrowser1.Document.GetElementById("submit");
            btn.Click += OnSubmit;
        }

        private void OnSubmit(object sender, HtmlElementEventArgs e)
        {
            var username = webBrowser1.Document.GetElementById("username").GetAttribute("value");
            var password = webBrowser1.Document.GetElementById("password").GetAttribute("value");
            string captcharesponse = null;
            if (useCaptcha)
            {
                captcharesponse = webBrowser1.Document.GetElementById("captchabox").Children[0].GetAttribute("data-hcaptcha-response");
                if (string.IsNullOrEmpty(captcharesponse))
                {
                    MessageBox.Show("You must complete the captcha to continue.", "CollabVM CSharp Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username is required.", "CollabVM CSharp Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password is required.", "CollabVM CSharp Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var wc = new WebClient();
            wc.Headers["Content-Type"] = "application/json";
            string raw;
            try
            {
                raw = wc.UploadString(this.apiBaseUrl + "/api/v1/login", JsonConvert.SerializeObject(new LoginPayload
                {
                    username = username,
                    password = password,
                    captchaToken = captcharesponse
                }));
            } catch (WebException ex)
            {
                raw = new StreamReader(ex.Response.GetResponseStream()).ReadToEnd();
            }
            var response = JsonConvert.DeserializeObject<LoginResponse>(raw);
            if (!response.success)
            {
                MessageBox.Show(response.error, "CollabVM CSharp Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                webBrowser1.Document.InvokeScript("resetCaptcha");
                return;
            }
            this.response = response;
            finished = true;
            Close();
        }

    }
}
