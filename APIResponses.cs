using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollabClient
{
    public class AuthServerInformation
    {
        public bool registrationOpen { get; set; }
        public AuthServerInformationCaptcha hcaptcha { get; set; }
    }

    public class AuthServerInformationCaptcha
    {
        public bool required { get; set; }
        public string siteKey { get; set; }
    }


    public class LoginResponse
    {
        public bool success { get; set; }
        public string token { get; set; }
        public string error { get; set; }
        public bool? verificationRequired { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public int rank { get; set; }
        public bool? developer { get; set; } = null;
    }
}
