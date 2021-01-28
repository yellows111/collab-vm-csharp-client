using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSocketSharp;
using System.IO;
using System.Timers;
using Timer = System.Timers.Timer;
using System.Net;
using System.Net.Sockets;
namespace CollabClient
{
    public partial class Form1 : Form
    {
		private static DialogResult ShowConnectDialog(ref string ip, ref string node, ref string username)
		{
			System.Drawing.Size size = new System.Drawing.Size(220, 160);
			Form inputBox = new Form();
			inputBox.Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetExecutingAssembly().Location);
			inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			inputBox.ClientSize = size;
			inputBox.Text = "Connect to...";
			inputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));

			System.Windows.Forms.TextBox textBox = new TextBox();
			textBox.BackColor = System.Drawing.Color.DimGray;
            textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBox.ForeColor = System.Drawing.Color.White;
			textBox.Size = new System.Drawing.Size(size.Width - 75, 23);
			textBox.Location = new System.Drawing.Point(25, 5);
			textBox.Text = ip;
			//textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			inputBox.Controls.Add(textBox);		
			
			System.Windows.Forms.TextBox textBox2 = new TextBox();
			textBox2.BackColor = System.Drawing.Color.DimGray;
            textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBox2.ForeColor = System.Drawing.Color.White;
			textBox2.Size = new System.Drawing.Size(size.Width - 175, 23);
			textBox2.Location = new System.Drawing.Point(169, 5);
			textBox2.Text = node;
			//textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			inputBox.Controls.Add(textBox2);
			
			System.Windows.Forms.TextBox textBox3 = new TextBox();
			textBox3.BackColor = System.Drawing.Color.DimGray;
            textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBox3.ForeColor = System.Drawing.Color.White;
			textBox3.Size = new System.Drawing.Size(size.Width - 79, 27);
			textBox3.Location = new System.Drawing.Point(73, 24);
			textBox3.Text = username;
			textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			inputBox.Controls.Add(textBox3);	

			Button okButton = new Button();
			okButton.BackColor = System.Drawing.Color.Gray;
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            okButton.ForeColor = System.Drawing.SystemColors.ControlText;
			okButton.Name = "okButton";
			okButton.Size = new System.Drawing.Size(75, 23);
			okButton.Text = "&Connect";
			okButton.Location = new System.Drawing.Point(size.Width - 80 - 80, 132);
			okButton.UseVisualStyleBackColor = false;
			inputBox.Controls.Add(okButton);

			Button cancelButton = new Button();
			cancelButton.BackColor = System.Drawing.Color.Gray;
            cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            cancelButton.ForeColor = System.Drawing.SystemColors.ControlText;
			cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			cancelButton.Name = "cancelButton";
			cancelButton.Size = new System.Drawing.Size(75, 23);
			cancelButton.Text = "&Quit";
			cancelButton.Location = new System.Drawing.Point(size.Width - 80, 132);
			inputBox.Controls.Add(cancelButton);
			
			Label namewarning = new Label();
			namewarning.AutoSize = true;
            namewarning.BackColor = System.Drawing.Color.Transparent;
            namewarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            namewarning.ForeColor = System.Drawing.Color.White;
            namewarning.Location = new System.Drawing.Point(0, 68);
            namewarning.Name = "namewarning";
            namewarning.Size = new System.Drawing.Size(375, 30);
            namewarning.TabIndex = 2;
            namewarning.Text = "Usernames can only contain:\r\nANSI alphanumericals, spaces, dashes\r\nunderscores, and periods, And it also\r\nmust be between 3 to 20 characters.";
			inputBox.Controls.Add(namewarning);
			
			Label iptext = new Label();
			iptext.AutoSize = true;
            iptext.BackColor = System.Drawing.Color.Transparent;
            iptext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            iptext.ForeColor = System.Drawing.Color.White;
            iptext.Location = new System.Drawing.Point(5, 5);
            iptext.Name = "namewarning";
            iptext.Size = new System.Drawing.Size(75, 30);
            iptext.TabIndex = 2;
            iptext.Text = "IP: ";
			inputBox.Controls.Add(iptext);
			
			Label nametext = new Label();
			nametext.AutoSize = true;
            nametext.BackColor = System.Drawing.Color.Transparent;
            nametext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            nametext.ForeColor = System.Drawing.Color.White;
            nametext.Location = new System.Drawing.Point(5, 24);
            nametext.Name = "namewarning";
            nametext.Size = new System.Drawing.Size(75, 30);
            nametext.TabIndex = 2;
            nametext.Text = "Username: ";
			inputBox.Controls.Add(nametext);

			inputBox.AcceptButton = okButton;
			inputBox.CancelButton = cancelButton; 
			
			var cb = new ComboBox();
			cb.BackColor = System.Drawing.Color.DimGray;
            //cb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            //cb.BorderColor = System.Drawing.Color.Red;
            cb.ForeColor = System.Drawing.Color.White;
            cb.Location = new System.Drawing.Point(73, 44);
            cb.FlatStyle = FlatStyle.Popup;
            cb.DropDownStyle = ComboBoxStyle.DropDownList;
			cb.Size = new System.Drawing.Size(size.Width - 79, 27);
            cb.Items.AddRange(new[] {"Computernewb VM1","Computernewb VM2","Computernewb VM3","Computernewb VM4","Computernewb VM5","DarkOK Vista","DarkOK X-Ray Man","FSP TempleOS"});
            cb.SelectedIndexChanged += (s, e) => { switch (cb.SelectedIndex+1) {
                    case 1: textBox.Text = "computernewb.com:6004"; textBox2.Text = "vm1"; break;
                    case 2: textBox.Text = "computernewb.com:6005"; textBox2.Text = "vm2"; break;
                    case 3: textBox.Text = "computernewb.com:6006"; textBox2.Text = "vm3"; break;
                    case 4: textBox.Text = "computernewb.com:6007"; textBox2.Text = "vm4"; break;
                    case 5: textBox.Text = "computernewb.com:6008"; textBox2.Text = "vm5"; break;
                    case 6: textBox.Text = "home.darkok.xyz:6004"; textBox2.Text = "pissta"; break;
                    case 7: textBox.Text = "home.darkok.xyz:6004"; textBox2.Text = "xrayman"; break;
					case 8: textBox.Text = "home.funshitposting.xyz:6004"; textBox2.Text = "templeos"; break;
                }
            };
            inputBox.Controls.Add(cb);
			
			Label presetlabel = new Label();
			presetlabel.AutoSize = true;
            presetlabel.BackColor = System.Drawing.Color.Transparent;
            presetlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            presetlabel.ForeColor = System.Drawing.Color.White;
            presetlabel.Location = new System.Drawing.Point(5, 44);
            presetlabel.Name = "namewarning";
            presetlabel.Size = new System.Drawing.Size(75, 30);
            presetlabel.TabIndex = 2;
            presetlabel.Text = "Preset(s): ";
			inputBox.Controls.Add(presetlabel);

			DialogResult result = inputBox.ShowDialog();
			ip = textBox.Text;
			node = textBox2.Text;
			username = textBox3.Text;
			return result;
			
		}
        public Form1()
        {
            InitializeComponent();
			Console.Title="CollabVM .NET Client - Console";
			pictureBox1.MouseEnter += (s, e) => pbfocus = true;
			pictureBox1.MouseEnter += (s, e) => this.ActiveControl = pictureBox1;
            pictureBox1.MouseLeave += (s, e) => pbfocus = false;
            pictureBox1.MouseLeave += (s, e) => this.ActiveControl = textBox1;
        }
		bool pbfocus = false;
        long pboxRefresh = 0;
        WebSocket socket;
        Graphics g;
        System.Media.SoundPlayer notify = new System.Media.SoundPlayer(Properties.Resources.notify);
        Timer muteTimer = new Timer()
        {
            AutoReset = false,
            Enabled = false,
        };
        string username;
        bool hasTurn = false;
        Timer turnTimer = new Timer()
        {
            AutoReset = false,
            Enabled = false,
        };
        List<string> users = new List<string>();
        Timer secondTick = new Timer()
        {
            AutoReset = true,
            Enabled = false,
            Interval = 1000,
        };
        int turntime = 0;
        string vmname;
        string vmip;
		string vmusername;
		double screenx = 1024d;
		double screeny = 768d;
        private void Form1_Load(object sender, EventArgs e)
        {
			string dialogip="home.darkok.xyz:6004";
			string dialognode="pissta";
			string dialogusername = "works on my machine";
			if (ShowConnectDialog(ref dialogip, ref dialognode, ref dialogusername) != DialogResult.OK) { Close();return; };
			vmip = dialogip;
			vmname = dialognode;
			vmusername = dialogusername;

            //pictureBox1.Refresh();
            notify.LoadAsync();
            secondTick.SynchronizingObject = this;
            muteTimer.SynchronizingObject = this;
            muteTimer.Elapsed += delegate { textBox1.Enabled = true; richTextBox1.AppendText("You are now unmuted." + Environment.NewLine); };
            CheckForIllegalCrossThreadCalls = false; // you didn't see anything, this line doesn't exist
            pictureBox1.Image = new Bitmap(1024, 768);
            //pictureBox1.Image = new Bitmap(800, 600);
            g = Graphics.FromImage(pictureBox1.Image);
			this.Text = ("CollabVM .NET Client: "+vmip+"#"+vmname);
            socket = new WebSocket("ws://" + vmip, "guacamole");
            socket.OnClose += Socket_OnClose;
            socket.OnOpen += Socket_OnOpen;
            socket.OnMessage += Socket_OnMessage;
            socket.Compression = CompressionMethod.Deflate;
            //pictureBox1.Image = Properties.Resources.Loading;
            //pictureBox1.Refresh();
            socket.Connect();

            //topleftpicboxpos = new Point((int)(20 / (double)pictureBox1.Width), (int)(20 / (double)pictureBox1.Height));

            pictureBox1_SizeChanged(null, null);
            pictureBox1.MouseWheel += pictureBox1_MouseWheel;

            this.KeyDown += Form1_KeyDown;
            this.KeyPress += Form1_KeyPress;
            this.KeyUp += Form1_KeyUp;

            turnTimer.Elapsed += TurnTimer_Elapsed;
            secondTick.Elapsed += SecondTick_Elapsed;

            //audio = new WaveOutEvent(WaveFormat);
            //new BufferedWaveProvider(
            //var format = new WaveFormat(8000, 16, 1);
            //buffered = new BufferedWaveProvider(format);
            //client = new TcpClient("computernewb.com", vmname == "vm1" ? 7004 : vmname == "vm2" ? 7005 : vmname == "vm3" ? 7006 : vmname == "vm4" ? 7007 : vmname == "vm5" ? 7008 : 7010);

/*             Task.Run(() =>
            {
                var a = client.GetStream();
                //System.Threading.Thread.Sleep(500);
                byte[] info = new byte[6];
                a.Read(info, 0, info.Length);
                buffered = new BufferedWaveProvider(new WaveFormat(BitConverter.ToInt32(info.Take(4).ToArray(), 0), info[4], info[5]));
                buffered.BufferDuration = TimeSpan.FromSeconds(5);
                //buffered.DiscardOnBufferOverflow = true;
                audio.Init(buffered);
                audio.Play();

                for (; ; )
                {
                    byte[] buffer = new byte[16];
                    a.Read(buffer, 0, buffer.Length);
                    buffered.AddSamples(buffer, 0, buffer.Length);
                    //Send(Console.ReadLine().Split('|'));
                };
            }); */
        }

        private void SecondTick_Elapsed(object sender, ElapsedEventArgs e)
        {
            turntime--;
            if (turntime < 0)
            {
                secondTick.Stop();
                label4.Text = "";
            }
            else
            {
                label4.Text = !hasTurn ? "Waiting for turn in ~" + turntime + " seconds" + new String('.', turntime % 4) : "Your turn expires in ~" + turntime + " seconds";
            }
        }

        private void TurnTimer_Elapsed(object sender, ElapsedEventArgs e)
        {

        }

        void UpdateOnline()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var user in users)
            {
                sb.AppendLine(user);
            }
            richTextBox2.Text = sb.ToString();
        }

        void Send(params object[] arg) => Send(arg.Select(x => x.ToString()).ToArray());
        void Send(params string[] arg)
        {
            socket.Send(EncodeGuac(arg));
        }
        void Invoke(Action act)
        {
            //if (this.InvokeRequired) this.Invoke(act);
            //else
            act();
        }
        void LogChat(string text)
        {
            Invoke(() => richTextBox1.AppendText(text + Environment.NewLine));
        }

        private void Socket_OnMessage(object sender, MessageEventArgs e)
        {
            string[] args = DecodeGuac(e.Data);
            switch (args[0])
            {
                case "chat":
                    {
                        for (var i = 1; i < args.Length; i += 2)
                        {
                            if (args[i] == "" && args[i + 1].StartsWith("You have been muted"))
                            {
								if (args[i + 1] == ("You have been muted.")) {
								Invoke(() => textBox1.Enabled = false);
								return;
								}
                                Invoke(() => textBox1.Enabled = false);
                                muteTimer.Interval = int.Parse(args[i + 1].Split(' ').Skip(5).Take(1).ToArray()[0]) * 1000;
                                muteTimer.Start();
                            }
                            Invoke(() =>
                            {
                                LogChat(args[i] + (args[i] != "" ? "▸ " : "") + args[i + 1]);
                                richTextBox1.SelectionStart = richTextBox1.Text.Length;
                                richTextBox1.ScrollToCaret();
                            });
                        }
                        notify.Play();
                        break;
                    }
                case "nop":
                    {
                        Send("nop");
                        socket.Ping();
                        break;
                    }
                case "png":
                    {
                        //string a = "";
                        //foreach (var val in args.Take(5))
                        //{
                        //    a += val + " | ";
                        //}
                        //a = a.Substring(0, a.Length - 3);
                        //Console.WriteLine(a);

                        if (args[2] == "0")
                        {

                            // Convert base 64 string to byte[]
                            byte[] imageBytes = Convert.FromBase64String(args[5]);
                            // Convert byte[] to Image
                            //var g = Graphics.FromImage(pictureBox1.Image);
                            //var img = pictureBox1.Image;
                            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
                            var img = Image.FromStream(ms, true);
                            //var point = new Point(int.Parse(args[3]), int.Parse(args[4]));
                            //g.DrawImage(img, point);
                            g.DrawImage(img, int.Parse(args[3]), int.Parse(args[4]));
                            img.Dispose();
                            ms.Dispose();
                            //pictureBox1.Invalidate(new Rectangle(point, img.Size));
                            //pictureBox1.Invoke((Action)(() => pictureBox1.Update()));
                            if (pboxRefresh < DateTime.UtcNow.Ticks)
                            {
                                Invoke(() => pictureBox1.Refresh());
                                pboxRefresh = DateTime.UtcNow.Ticks + TimeSpan.FromMilliseconds(1000 / 60).Ticks; //limit fps so we won't unnecessarily draw more than x fps and waste cpu
                            }
                            //pictureBox1.Update();
                            //img?.Dispose();
                        }
                        else if (args[2] == "1")//11x16
                        {
                            // cursor image, but why?
                            byte[] imageBytes = Convert.FromBase64String(args[5]);
                            Image img = new Bitmap(new MemoryStream(imageBytes));
                            Image newimg = new Bitmap(21, 32);

                            Graphics gnew = Graphics.FromImage(newimg);
                            gnew.Clear(Color.Transparent);
                            gnew.DrawImage(img, 10, 16);


                            var cur = new Cursor(((Bitmap)newimg).GetHicon());

                            //Console.WriteLine(cur.HotSpot);//5,8
                            //Console.WriteLine(cur.Size);//32,32???
                            //;
                            Invoke(() => pictureBox1.Cursor = cur);
                        }
                        break;
                    }
                case "sync":
                    {
                        // ???
                        break;
                    }
                case "move":
                    {
                        //todo: make cursor move visible on screen somehow?
                        break;
                    }
                case "list":
                    {
						//uhh... implement something with dialog box idk
                        // ¿¿¿
/*                         string a = "";
						
                        foreach (var val in args)
                        {
                            a += val + " | ";
                        }
                        a = a.Substring(0, a.Length - 3);
                        Console.WriteLine(a); */
						Console.WriteLine("list: "+args[1]+" | "+args[2]);
                        break;
                    }
                case "adduser":
                    {
                        List<string> u = new List<string>();
                        for (int i = 2; i < args.Length; i += 2)
                        {
                            u.Add(args[i]);
                        }
                        Invoke(() => users.AddRange(u));

                        if (args[1] == "1")
                        {
                            LogChat($">{args[2]} joined.");
                        }
                        if (args[3] == "2")
                        {
                            LogChat($">{args[2]} authenticated as a adminstrator.");
                        }
						if (args[3] == "3")
                        {
                            LogChat($">{args[2]} authenticated as a moderator.");
                        }
                        Invoke(() => label1.Text = "Users Online: " + users.Count);

                        UpdateOnline();
                        //goto default;
                        break;
                    }
                case "remuser":
                    {
                        Invoke(() =>
                        {
                            users.Remove(args[2]);
                            LogChat($">{args[2]} left.");
                            label1.Text = "Users Online: " + users.Count;
                        });

                        UpdateOnline();
                        //goto default;
                        break;
                    }
					case "size":
                    {
                        Invoke(() =>
						{
						Console.WriteLine("size: "+args[2]+"x"+args[3]+", type"+args[1]);
						//int screenx = Int32.Parse(args[2]);
						//int screeny = Int32.Parse(args[3]);
						if (args[1] == "0") {
/* 	rem this when safe				    pictureBox1.Image.Dispose();
						g.Dispose();
					    pictureBox1.Image = new Bitmap(Convert.ToInt32(screenx), Convert.ToInt32(screeny)); // trolled not making a new bitmapobject :trollface:, also mdkck10
						g = Graphics.FromImage(pictureBox1.Image); */
						scalex = screenx / pictureBox1.Width;
						scaley = screeny / pictureBox1.Height;
						pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
						pictureBox1.Refresh();
						pictureBox1_SizeChanged(null,null);
						};
						});
                        break;
                    }
                case "rename":
                    {
                        /*
                        rename | 0 | 0 | DotNetClient | 0
                        rename | 1 | guest58447 | KIKES | 0
                        if arg[1] == 0 then self.username is arg[3]
                        if arg[1] == 1 
                        then
	                        if arg[2] equals self.username 
	                        then
		                        self.username is arg[3]
	                        else
	                        user arg[2] is now arg[3]
                        end	
                        */
						string a = "";
                        foreach (var val in args)
                        {
                            a += val + " | ";
                        }
                        a = a.Substring(0, a.Length - 3);
                        Console.WriteLine(a);
                        if (args[1] == "0")
                        {
                            username = args[3];
                            Invoke(() => label3.Text = username);
                        }
                        else if (args[1] == "1")
                        {
                            //if (args[3] == username)
                            //    username = args[3];
                            //else
                            if (args[3] != username) LogChat($">{args[2]} left. {args[3]} joined.");
                            Invoke(() =>
                            {
                                users.Remove(args[2]);
                                users.Add(args[3]);
                            });
                            UpdateOnline();
                        }
                        //goto default;
                        break;
                    }
                case "turn":
                    {
                        if (args.Length > 2 && args[2] == "0")
                        {
                            hasTurn = false;
                            turntime = 1;
                        }
                        if (args.Length > 3 && args[3] != username) { hasTurn = false; }
                        if (args.Length > 2 && args[2] != "0")
                        {
                            hasTurn = args[3] == username;
                            var ms = int.Parse(args[1]);
                            /*
                            turn | 17999 | 1 | DotNetClient
                            turn | 3350 | 2 | DotNetClient | kubapolish
                            turn | 17999 | 1 | kubapolish
                            turn | 15410 | 2 | kubapolish | DotNetClient | 15410
                            turn | 17999 | 1 | DotNetClient
                            */

                            //turnTimer.Interval = ms;
                            //turnTimer.Start();

                            turntime = (ms / 1000)*(hasTurn?1:int.Parse(args[2]));
                            secondTick.Start();
                        }
						if (hasTurn == true) {
							Console.WriteLine("You have the turn!");
                        };
                        //goto default;
                        break;
                    }
                default:
                    {
                        string a = "";
                        foreach (var val in args)
                        {
                            a += val + " | ";
                        }
                        a = a.Substring(0, a.Length - 3);
                        Console.WriteLine(a);
                        break;
                    }
            }
        }

        private void Socket_OnOpen(object sender, EventArgs e)
        {
            Console.WriteLine("Connected to "+vmip+"#"+vmname);
			Console.Title="CollabVM .NET Client - Console ["+vmname+"]";
			Send("list"); //lag
            Send("rename", vmusername);
            Send("connect", vmname);
            //Send("list");
            Timer t = new Timer(3000);
            t.Elapsed += (s,ee) => Send("nop");
            t.Enabled = true;
        }

        private void Socket_OnClose(object sender, CloseEventArgs e)
        {
			if (e.Reason == "An exception has occurred while connecting.") {
            MessageBox.Show("Failed to connect to the VM.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			Close();
			return;
			}
			else {
			MessageBox.Show(e.Reason, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
        }

        static string EncodeGuac(params string[] cypher)
        {
            StringBuilder command = new StringBuilder("");
            for (int i = 0; i < cypher.Length; i++)
            {
                var current = cypher[i];
                command.Append(current.Length.ToString());
                command.Append('.');
                command.Append(current);
                command.Append(i < cypher.Length - 1 ? ',' : ';');
            }
            return command.ToString();
        }
        static string[] DecodeGuac(string str)
        {
            int pos = -1;
            List<string> sections = new List<string>();

            for (; ; )
            {
                int len = str.IndexOf('.', pos + 1);
                if (len == -1)
                    break;

                pos = int.Parse(str.Substring(pos + 1, len - (pos + 1))) + len + 1;
                StringBuilder repl = new StringBuilder(str.Substring(len + 1, pos - (len + 1)));
                repl.Replace("&#x27;", "'")
                    .Replace("&quot;", "\"")
                    .Replace("&#x2F;", "/")
                    .Replace("&lt;", "<")
                    .Replace("&gt;", ">")
                    .Replace("&amp;", "&");
                sections.Add(repl.ToString());
                //sections.Add(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(str.Substring(len + 1, pos - (len + 1)),
                //     "&#x27;/g", "'"),
                //     "&quot;/g", "\""),
                //     "&#x2F;/g", "/"),
                //     "&lt;/g", "<"),
                //     "&gt;/g", ">"),
                //     "&amp;/g", "&"));

                if (str.Substring(pos, 1) == ";")
                    break;
            }
            return sections.ToArray();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Send("chat", textBox1.Text);
                textBox1.Text = "";
            }
        }

        //double scale = 1;
        double scalex = 1;
        double scaley = 1;
        //Point topleftpicboxpos = new Point(0, 0);
        private void pictureBox1_SizeChanged(object _, EventArgs __)
        {
			Console.WriteLine("size: "+screenx+"x"+screeny);
            //topleftpicboxpos = new Point(0, 0);
            scalex = screenx / pictureBox1.Width;
            scaley = screeny / pictureBox1.Height;
			Console.WriteLine("mousescale: "+scalex+","+scaley);
            //scalex = pictureBox1.Width / 1024d;
            //scaley = pictureBox1.Height / 768d;
            //scale = Math.Min(1024d / pictureBox1.Width, 768d / pictureBox1.Height);

            //var q = 1024d / pictureBox1.Width;
            //var w = 768d / pictureBox1.Height;
            //var e = Math.Min(q, w);
            //bool h = e == q ? true : false;
            //double da = pictureBox1.Width / 1024d;
            //double db = pictureBox1.Height / 768d;
            //;
            //double l = 0, ll = 0;
            //if (h)
            //{
            //    ll = 0 + pictureBox1.Width - (pictureBox1.Width / da);
            //}
            //else
            //{
            //    l = 0 + pictureBox1.Height - (pictureBox1.Height / db);
            //    ;
            //}


            //;

            //topleftpicboxpos = new Point((int)ll, (int)l);
            //topleftpicboxpos = pictureBox1.Location;
            //var x = (pictureBox1.Width) + pictureBox1.Location.X;
            //var y = (pictureBox1.Height) + pictureBox1.Location.Y;
            //topleftpicboxpos = new Point(x, y);
            /*
             * 
             * double dblHand1X, dblHand1Y;

private void Form1_Load(object sender, EventArgs e)
    {
        dblHand1X= (double)b / (double)pictureBox1.Width;
        dblHand1Y= (double)a / (double)pictureBox1.Height;
    }

private void pictureBox1_SizeChanged(object sender, EventArgs e)
    {
        int x, y;

        x = (int)(dblHand1X* (double)pictureBox1.Width) + pictureBox1.Location.X;
        y = (int)(dblHand1Y* (double)pictureBox1.Height) + pictureBox1.Location.Y;

        x -= d;
        y -= c;
        Hand1.Location = new Point(x, y);

    }*/

            //int x, y;

            //x = (int)(topleftpicboxpos.X * (double)pictureBox1.Width) + pictureBox1.Location.X;
            //y = (int)(topleftpicboxpos.Y * (double)pictureBox1.Height) + pictureBox1.Location.Y;

            ////x -= d;
            ////y -= c;
            //checkBox1.Location = new Point(x, y);




        }


        private void pictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            //if (hasTurn)
            //{
            pictureBox1_MouseDown(sender, e);
            //}
        }

        [Flags()]
        enum MouseKeys
        {
            Left = 1,
            Middle = 2,
            Right = 4,
            ScrollUp = 8,
            ScrollDown = 16,
        }
        MouseKeys mouseFlags;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

            //var a = g;
            //leftPressed = true;
            //mouseFlags = 0;
            if (e.Button.HasFlag(MouseButtons.Left))
            {
                mouseFlags |= MouseKeys.Left;
            }
            if (e.Button.HasFlag(MouseButtons.Middle))
            {
                mouseFlags |= MouseKeys.Middle;
            }
            if (e.Button.HasFlag(MouseButtons.Right))
            {
                mouseFlags |= MouseKeys.Right;
            }
            if (e.Delta > 0)
            {
                mouseFlags |= MouseKeys.ScrollUp;
            }
            if (e.Delta < 0)
            {
                mouseFlags |= MouseKeys.ScrollDown;
            }

            ;

            if (!hasTurn) { if (e.Button.HasFlag(MouseButtons.Left)) Send("turn"); }
            else
            {
                Console.WriteLine("You pressed the "+mouseFlags+" mouse button!");
                Send("mouse", (int)(e.X * scalex), (int)(e.Y * scaley), (int)mouseFlags);
                if (mouseFlags.HasFlag(MouseKeys.ScrollUp) || mouseFlags.HasFlag(MouseKeys.ScrollDown))
                {
                    mouseFlags &= ~MouseKeys.ScrollDown;
                    mouseFlags &= ~MouseKeys.ScrollUp;
                    ;
                    Send("mouse", (int)(e.X * scalex), (int)(e.Y * scaley), (int)mouseFlags);
                }
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            //checkBox1.Location = new Point((int)((e.X * scale) + topleftpicboxpos.X), (int)((e.Y * scale) + topleftpicboxpos.Y));
            //g.DrawRectangle(new Pen(Color.Red, 3), new Rectangle(new Point((int)((e.X) + topleftpicboxpos.X), (int)((e.Y) + topleftpicboxpos.Y)), new Size(3, 3)));
            //this.Refresh();
            if (hasTurn)
            {
                //pictureBox1.client
                //var p = pictureBox1.PointToClient(e.Location);
                //Send("mouse", (int)((e.X * scale) + topleftpicboxpos.X), (int)((e.Y * scale) + topleftpicboxpos.Y), 0); //hh
                Send("mouse", (int)(e.X * scalex), (int)(e.Y * scaley), (int)mouseFlags);
                //Send("mouse", (int)((e.X * scale) - pictureBox1.ClientSize.Width), (int)((e.Y * scale) - pictureBox1.ClientSize.Height), 0);

            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            ;
            //mouseFlags = 0;
            if (e.Button.HasFlag(MouseButtons.Left))
            {
                mouseFlags &= ~MouseKeys.Left;
            }
            if (e.Button.HasFlag(MouseButtons.Middle))
            {
                mouseFlags &= ~MouseKeys.Middle;
            }
            if (e.Button.HasFlag(MouseButtons.Right))
            {
                mouseFlags &= ~MouseKeys.Right;
            }
            //if (e.Delta != 0)
            //{
            //    Console.WriteLine(e.Delta);
            //}
            //if (e.Delta > 0)
            //{
            //    mouseFlags &= ~MouseKeys.ScrollUp;
            //}
            //if (e.Delta < 0)
            //{
            //    mouseFlags |= MouseKeys.ScrollDown;
            //}

            if (hasTurn)
            {
                //Console.WriteLine(mouseFlags);
                Send("mouse", (int)(e.X * scalex), (int)(e.Y * scaley), (int)mouseFlags);
            }
            //mouseFlags = 0;
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", e.LinkText);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChangeUsername ass = new ChangeUsername(username);
            if (ass.ShowDialog() == DialogResult.OK)
            {
                Send("rename", ass.nick);
            }
        }

        ushort handleKey(KeyEventArgs e)
        {
            //Console.WriteLine(e.KeyCode);
            CollabAPI.X11KeyCode k;
            //ree asss
            if (e.KeyValue < 256) 
                k = (CollabAPI.X11KeyCode)
                (
                    char.IsLetter ((char)e.KeyCode) ? 
                         (IsKeyLocked(Keys.CapsLock) ^ ModifierKeys.HasFlag(Keys.Shift)) ? 
                            char.ToUpper((char)e.KeyCode) : char.ToLower((char)e.KeyCode)
                         : (char)e.KeyCode
                );
            else switch (e.KeyCode)
            {
                case Keys.Shift:
                case Keys.ShiftKey:
                case Keys.LShiftKey: k = CollabAPI.X11KeyCode.XK_Shift_L; break;
                case Keys.RShiftKey: k = CollabAPI.X11KeyCode.XK_Shift_R; break;
                case Keys.Control:
                case Keys.ControlKey:
                case Keys.LControlKey:  k = CollabAPI.X11KeyCode.XK_Control_L;break;
                case Keys.Alt:k = CollabAPI.X11KeyCode.XK_Alt_L;break;
                case Keys.LWin:k = CollabAPI.X11KeyCode.XK_Meta_L;break;
                case Keys.RWin:k = CollabAPI.X11KeyCode.XK_Meta_R;break;
                default: k = CollabAPI.X11KeyConverter.UnicodeToX11Key((char)e.KeyValue);break;
            }
            if (k == 0) { Console.Error.WriteLine($"can not find key for: {e.KeyCode}"); return 0; }
            //Console.WriteLine((ushort)k);
            return (ushort)k;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {//https://github.com/glyptodon/guacamole-client/blob/master/guacamole-common-js/src/main/webapp/modules/Keyboard.js //todo, lol
            if (!pbfocus) return;
            var k = handleKey(e);
			Console.WriteLine("up: "+k+" | "+e.KeyCode);
            if (k == 0) return;
            if (k == 8) k = 0xff08;
            if (k == 13) k = 0xff0d;
            if (k == 16) k = 0xffe1;
            if (k == 188) k = 0x002c;
            if (k == 190) k = 0x002e;
            if (k == 191) k = 0x003f;
            if (k == 252) k = 0x005c;
            if (k == 189) k = 0x002d;
            if (k == 187) k = 0x003d;
            if (k == 251) k = 0x005b;
            if (k == 253) k = 0x005d;
            if (k == 186) k = 0x003b;
            if (k == 244) k = 0x0027;
            if (k == 254) k = 0x0023;
            if (k == 223) k = 0x0060;
            if (k == 222) k = 0x007e;
            if (k == 192) k = 0x0022; // should be 0x40, Comm. At symbol, but because US treats shift-2 as @ and not ", we have to do hax
            if (k == 219) k = 0x007b;
            if (k == 221) k = 0x007d;
            Send("key", k, 0);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!pbfocus) return;
            var k = handleKey(e);
            Console.WriteLine("down: "+k+" | "+e.KeyCode);
            if (k == 0) return;
            if (k == 8) k = 0xff08;
            if (k == 13) k = 0xff0d;
            if (k == 16) k = 0xffe1;
            if (k == 188) k = 0x002c;
            if (k == 190) k = 0x002e;
            if (k == 191) k = 0x003f;
            if (k == 252) k = 0x005c;
            if (k == 189) k = 0x002d;
            if (k == 187) k = 0x003d;
            if (k == 251) k = 0x005b;
            if (k == 253) k = 0x005d;
            if (k == 186) k = 0x003b;
            if (k == 244) k = 0x0027;
            if (k == 254) k = 0x0023;
            if (k == 223) k = 0x0060;
            if (k == 222) k = 0x007e;
            if (k == 192) k = 0x0022; // should be 0x40, Comm. At symbol, but because US treats shift-2 as @ and not ", we have to do hax
            if (k == 219) k = 0x007b;
            if (k == 221) k = 0x007d;
            Send("key", k, 1);
        }
    }
}
