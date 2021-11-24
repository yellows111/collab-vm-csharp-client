using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Timers;
using WebSocketSharp;
using Timer = System.Timers.Timer;

namespace CollabClient
{
    public partial class Form1 : Form
    {
        public static void ViewHTML(ref string htmlText)
        {
            HTMLView htmlView = new HTMLView();
            ((WebBrowser) htmlView.Controls["webBrowser1"]).DocumentText = $@"
<!doctype html>

<html lang=""en"">
<head>
  <meta charset=""utf-8"">
  <title>Message of the Day</title>
  <style>
    body {{
        background-color: #404040;
        color: white;
    }}
    a:link {{color:cyan}};
    a:visited {{color:magenta}};
  </style>
</head>
<body>
{htmlText}
</body>
</html>
";
            // exits here
            htmlView.Show();
        }

        public Form1()
        {
            InitializeComponent();
            pictureBox1.MouseEnter += (s, e) => pbfocus = true;
            pictureBox1.MouseEnter += (s, e) => ActiveControl = pictureBox1;
            pictureBox1.MouseLeave += (s, e) => pbfocus = false;
            pictureBox1.MouseLeave += (s, e) => ActiveControl = textBox1;
        }

        private bool pbfocus;
        private long pboxRefresh;
        private WebSocket socket;
        private Graphics g;
        private readonly System.Media.SoundPlayer notify = new System.Media.SoundPlayer(Properties.Resources.notify);

        private readonly Timer muteTimer = new Timer
        {
            AutoReset = false,
            Enabled = false,
        };

        private string username;
        private bool hasTurn;

        private readonly Timer turnTimer = new Timer
        {
            AutoReset = false,
            Enabled = false,
        };

        private readonly List<string> users = new List<string>();

        private readonly Timer secondTick = new Timer
        {
            AutoReset = true,
            Enabled = false,
            Interval = 1000,
        };

        private int turntime;
        private const double screenx = 1024d;
        private const double screeny = 768d;

        private void Form1_Load(object sender, EventArgs e)
        {
           //pictureBox1.Refresh();
            notify.LoadAsync();
            secondTick.SynchronizingObject = this;
            muteTimer.SynchronizingObject = this;
            muteTimer.Elapsed += delegate
            {
                textBox1.Enabled = true;
                richTextBox1.AppendText("You are now unmuted." + Environment.NewLine);
            };
            CheckForIllegalCrossThreadCalls = false; // you didn't see anything, this line doesn't exist
            pictureBox1.Image = new Bitmap(1024, 768);
            g = Graphics.FromImage(pictureBox1.Image);
            Text = "CollabVM .NET Client: " + Globals.vmip + "#" + Globals.vmname;
			string wsprefix = Globals.isSecure ? "wss" : "ws";
            socket = new WebSocket(wsprefix+"://" + Globals.vmip, "guacamole") {Origin = "http://" + Globals.vmip.Split(':')[0]};
            if (Globals.isSecure){
				socket.SslConfiguration.EnabledSslProtocols = System.Security.Authentication.SslProtocols.Tls12;
			}
			socket.OnClose += Socket_OnClose;
            socket.OnOpen += Socket_OnOpen;
            socket.OnMessage += Socket_OnMessage;
			if (Globals.isCompressed){
				socket.Compression = CompressionMethod.Deflate;
			} else {
				socket.Compression = CompressionMethod.None;
			}
            //pictureBox1.Image = Properties.Resources.Loading;
            //pictureBox1.Refresh();
            socket.Connect();

            //topleftpicboxpos = new Point((int)(20 / (double)pictureBox1.Width), (int)(20 / (double)pictureBox1.Height));

            PictureBox1_SizeChanged(null, null);
            pictureBox1.MouseWheel += PictureBox1_MouseWheel;

            KeyDown += Form1_KeyDown;
            KeyPress += Form1_KeyPress;
            KeyUp += Form1_KeyUp;
			FormClosing += Form1_FormClosing;

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
                label4.Text = !hasTurn
                    ? "Waiting for turn in ~" + turntime + " seconds" + new string('.', turntime % 4)
                    : "Your turn expires in ~" + turntime + " seconds";
            }
        }

        private static void TurnTimer_Elapsed(object sender, ElapsedEventArgs e)
        {

        }

        private void UpdateOnline()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var user in users)
            {
                sb.AppendLine(user);
            }

            richTextBox2.Text = sb.ToString();
        }

        private void Send(params object[] arg) => Send(arg.Select(x => x.ToString()).ToArray());

        private void Send(params string[] arg)
        {
            socket.Send(EncodeGuac(arg));
        }

        private void LogChat(string text)
        {
            richTextBox1.Invoke((MethodInvoker) delegate { richTextBox1.AppendText(text + Environment.NewLine); });
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
                            if (args[i + 1] == "You have been muted.")
                            {
                                Invoke((MethodInvoker) delegate { textBox1.Enabled = false; });
                                return;
                            }

                            Invoke((MethodInvoker) delegate { textBox1.Enabled = false; });
                            muteTimer.Interval = int.Parse(args[i + 1].Split(' ').Skip(5).Take(1).ToArray()[0]) * 1000;
                            muteTimer.Start();
                        }
                        else if (
                            args[1] == ""
                            && !args[i + 1].StartsWith("You have been muted")
                            && !args[i + 1].StartsWith("The vote to")
                            && !args[i + 1].EndsWith("voted yes.")
                            && !args[i + 1].EndsWith("voted no.")
                            && !args[i + 1].EndsWith("started a vote to reset the VM.")
                        )
                        {
                            string html = args[i + 1];
                            Invoke((MethodInvoker) delegate { ViewHTML(ref html); });
                            return;
                        }

                        Invoke((MethodInvoker) delegate
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
                            Invoke((MethodInvoker) delegate { pictureBox1.Refresh(); });
                            pboxRefresh =
                                DateTime.UtcNow.Ticks +
                                TimeSpan.FromMilliseconds(1000 / 60)
                                    .Ticks; //limit fps so we won't unnecessarily draw more than x fps and waste cpu
                        }

                        //pictureBox1.Update();
                        //img?.Dispose();
                    }
                    else if (args[2] == "1") //11x16
                    {
                        // cursor image, but why?
                        byte[] imageBytes = Convert.FromBase64String(args[5]);
                        Image img = new Bitmap(new MemoryStream(imageBytes));
                        Image newimg = new Bitmap(21, 32);

                        Graphics gnew = Graphics.FromImage(newimg);
                        gnew.Clear(Color.Transparent);
                        gnew.DrawImage(img, 10, 16);


                        // var cur = new Cursor(((Bitmap) newimg).GetHicon());

                        //Console.WriteLine(cur.HotSpot);//5,8
                        //Console.WriteLine(cur.Size);//32,32???
                        //;
                        Invoke((MethodInvoker) delegate { pictureBox1.Cursor = System.Windows.Forms.Cursors.Default; }); //cur breaks
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
						if (Globals.vmdiscovery == true){
							string list = "Use the prefix as the node ID in the connection dialog!\n---\n";
							for (var i = 1; i < args.Length; i += 3) {
							list += args[i]+": "+args[i+1]+"\n---\n";
							}
							list = list.Replace("<br>", " | ").Replace("<small>", "").Replace("</small>", "").Replace("<b>"," *").Replace("</b>", "* ").Replace("</p>", "").Replace("  "," ");
							MessageBox.Show(list, "List of VMs on server", MessageBoxButtons.OK, MessageBoxIcon.Information);
							Close();
							Application.Exit();
							break;
							};
						for (var i = 1; i < args.Length; i += 3)
						{
							Console.WriteLine("list | " + args[i] + " | " +args[i + 1]);
                            string html = "<h1>"+args[i]+"</h1><hr>"+args[i + 1]+"<br><br>"+"<img src=\"data:image/png;base64,"+args[i + 2]+"\">";
                            Invoke((MethodInvoker) delegate { ViewHTML(ref html); });
						}
					break;
                }
                case "adduser":
                {
                    List<string> u = new List<string>();
                    for (int i = 2; i < args.Length; i += 2)
                    {
                        u.Add(args[i]);
                    }

                    Invoke((MethodInvoker) delegate { users.AddRange(u); });

                    if (args[1] == "1")
                    {
                        LogChat($">{args[2]} joined.");
                    }

                    if (args[3] == "2")
                    {
						users.Remove(args[2]); // fixes duping
                        LogChat($">{args[2]} authenticated as a adminstrator.");
                    }

                    if (args[3] == "3")
                    {
						users.Remove(args[2]); // fixes duping
                        LogChat($">{args[2]} authenticated as a moderator.");
                    }

                    Invoke((MethodInvoker) delegate { label1.Text = "Users Online: " + users.Count; });

                    UpdateOnline();
                    //goto default;
                    break;
                }
                case "remuser":
                {
                    Invoke((MethodInvoker) delegate
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
                    Invoke((MethodInvoker) delegate
                    {
                        if (args[1] != "0") return;
						Console.WriteLine("size: " + args[2] + "x" + args[3] + ", type" + args[1]);
                        //int screenx = Int32.Parse(args[2]);
                        //int screeny = Int32.Parse(args[3]);
                        /* 	rem this when safe	pictureBox1.Image.Dispose();
						g.Dispose();
					    pictureBox1.Image = new Bitmap(Convert.ToInt32(screenx), Convert.ToInt32(screeny)); // trolled not making a new bitmapobject :trollface:, also mdkck10
						g = Graphics.FromImage(pictureBox1.Image); */
                        scalex = screenx / pictureBox1.Width;
                        scaley = screeny / pictureBox1.Height;
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox1.Refresh();
                        PictureBox1_SizeChanged(null, null);
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
                    string a = args.Aggregate("", (current, val) => current + (val + " | "));

                    a = a.Substring(0, a.Length - 3);
                    Console.WriteLine(a);
                    switch (args[1])
                    {
                        case "0":
                            username = args[3];
                            Invoke((MethodInvoker) delegate { label3.Text = username; });
                            break;
                        case "1":
                        {
                            //if (args[3] == username)
                            //    username = args[3];
                            //else
                            if (args[3] != username)
                            {
                                LogChat($">{args[2]} left. {args[3]} joined.");
                            }

                            Invoke((MethodInvoker) delegate
                            {
                                users.Remove(args[2]);
                                users.Add(args[3]);
                            });
                            UpdateOnline();
                            break;
                        }
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

                    if (args.Length > 3 && args[3] != username)
                    {
                        hasTurn = false;
                    }

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

                        turntime = ms / 1000 * (hasTurn ? 1 : int.Parse(args[2]));
                        secondTick.Start();
                    }

                    if (hasTurn)
                    {
                        Console.WriteLine("You have the turn!");
                    }

                    //goto default;
                    break;
                }
				case "cursor": {
					break; //packet spam
				}
				case "connect":
				{
					switch (args[1]) {
						case "0": {
							var result = MessageBox.Show("The VM you specified does not exist on this server.\nDo you want to search for VMs that exist on this server?", "Just one thing!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
							switch (result) {
								case System.Windows.Forms.DialogResult.Yes: {
									Globals.vmdiscovery = true;
									Send("list");
									break;
								}
								case System.Windows.Forms.DialogResult.No: 
								default:
								{
									Close();
									Application.Exit();
									break;
								}
							}
							break;
						}
						
						case "1": {
							Console.WriteLine("Connected successfully to "+Globals.vmname+" on "+Globals.vmip+".");
							break;
						}
						
						case "2": {
							Console.WriteLine("Disconnected from "+Globals.vmname+".");
							MessageBox.Show("The server closed the connection gracefully.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
							Close();
							Application.Exit();
							break;
						}						
						
						case "3": {
							Console.WriteLine("VM requires a password. [Currently not implemented to client.]");
							break;
						}
					}
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
            Console.WriteLine("Connected to " + Globals.vmip + ".\nWaiting for VM " + Globals.vmname + "...");
            Console.Title = "CollabVM .NET Client - Console [" + Globals.vmname + "]";
            //Send("list"); //lag
            Send("rename", Globals.vmusername);
            Send("connect", Globals.vmname);
            //Send("list");
            Timer t = new Timer(3000);
            t.Elapsed += (s, ee) => Send("nop");
            t.Enabled = true;
        }

        private void Socket_OnClose(object sender, CloseEventArgs e)
        {
            if (e.Reason == "An exception has occurred while connecting.")
            {
                MessageBox.Show("Failed to connect to the VM.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
				Application.Exit();
            }
            else if (e.Reason == "An error has occurred while connecting.")
            {
                MessageBox.Show("Failed to connect to the VM.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
				Application.Exit();
            }
            else
            {
                MessageBox.Show(e.Reason, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string EncodeGuac(params string[] cypher)
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

        private static string[] DecodeGuac(string str)
        {
            int pos = -1;
            List<string> sections = new List<string>();

            for (;;)
            {
                int len = str.IndexOf('.', pos + 1);
                if (len == -1)
                {
                    break;
                }

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
                {
                    break;
                }
            }

            return sections.ToArray();
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            string BoxText = textBox1.Text;
            e.SuppressKeyPress = true;
            textBox1.Text = "";
            switch (BoxText)
            {
                case "!vote yes":
                {
                    Send("vote", "1");
                    break;
                }
                case "!vote no":
                {
                    Send("vote", "0");
                    break;
                }                
				case "!skip":
                {
                    Send("turn", "0");
                    break;
                }    				
				case "!ss":
                {
                    System.Windows.Forms.Clipboard.SetImage(pictureBox1.Image);
                    break;
                }                
				case "!kick":
                {
					ChangeUsername kick = new ChangeUsername("Person to kick");
					if (kick.ShowDialog() == DialogResult.OK)
					{
						Send("admin", "12", kick.nick);
					}
                    break;
                }                
				case "!ban":
                {
					ChangeUsername ban = new ChangeUsername("Person to ban");
					if (ban.ShowDialog() == DialogResult.OK)
					{
						Send("admin", "12", ban.nick);
					}
                    break;
                }				
				case "!araw":
                {
					ChangeUsername raw = new ChangeUsername("admin command to exec (5.admin,$input;)");
					if (raw.ShowDialog() == DialogResult.OK)
					{
						Console.WriteLine("Sending:","5.admin,"+raw.nick+";");
						socket.Send("5.admin,"+raw.nick+";");
					}
                    break;
                }
                case "!debug list":
                {
                    Send("list");
                    break;
                }
                case "!debug motd":
                {
                    string htmltest = "<h1>Please Wait...</h1>";
                    ViewHTML(ref htmltest);
                    break;
                }
                default:
                {
                    Send("chat", BoxText);
                    break;
                }
            }
        }

        //double scale = 1;
        private double scalex = 1;

        private double scaley = 1;

        //Point topleftpicboxpos = new Point(0, 0);
        private void PictureBox1_SizeChanged(object _, EventArgs __)
        {
            Console.WriteLine("[C] size: " + screenx + "x" + screeny);
            //topleftpicboxpos = new Point(0, 0);
            scalex = screenx / pictureBox1.Width;
            scaley = screeny / pictureBox1.Height;
            Console.WriteLine("[C] mousescale: " + scalex + "," + scaley);
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


        private void PictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            //if (hasTurn)
            //{
            PictureBox1_MouseDown(sender, e);
            //}
        }

        [Flags]
        private enum MouseKeys
        {
            Left = 1,
            Middle = 2,
            Right = 4,
            ScrollUp = 8,
            ScrollDown = 16,
        }

        private MouseKeys mouseFlags;

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
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

            if (!hasTurn)
            {
                if (e.Button.HasFlag(MouseButtons.Left))
                {
                    Send("turn");
                }
            }
            else
            {
                Console.WriteLine("You pressed the " + mouseFlags + " mouse button!");
                Send("mouse", (int) (e.X * scalex), (int) (e.Y * scaley), (int) mouseFlags);
                if (!mouseFlags.HasFlag(MouseKeys.ScrollUp) && !mouseFlags.HasFlag(MouseKeys.ScrollDown))
                {
                    return;
                }

                mouseFlags &= ~MouseKeys.ScrollDown;
                mouseFlags &= ~MouseKeys.ScrollUp;
                Send("mouse", (int) (e.X * scalex), (int) (e.Y * scaley), (int) mouseFlags);
            }
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            //checkBox1.Location = new Point((int)((e.X * scale) + topleftpicboxpos.X), (int)((e.Y * scale) + topleftpicboxpos.Y));
            //g.DrawRectangle(new Pen(Color.Red, 3), new Rectangle(new Point((int)((e.X) + topleftpicboxpos.X), (int)((e.Y) + topleftpicboxpos.Y)), new Size(3, 3)));
            //this.Refresh();
            if (hasTurn)
            {
                //pictureBox1.client
                //var p = pictureBox1.PointToClient(e.Location);
                //Send("mouse", (int)((e.X * scale) + topleftpicboxpos.X), (int)((e.Y * scale) + topleftpicboxpos.Y), 0); //hh
                Send("mouse", (int) (e.X * scalex), (int) (e.Y * scaley), (int) mouseFlags);
                //Send("mouse", (int)((e.X * scale) - pictureBox1.ClientSize.Width), (int)((e.Y * scale) - pictureBox1.ClientSize.Height), 0);

            }
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
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
                Send("mouse", (int) (e.X * scalex), (int) (e.Y * scaley), (int) mouseFlags);
            }

            //mouseFlags = 0;
        }

        private void RichTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", e.LinkText);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ChangeUsername ass = new ChangeUsername(username);
            if (ass.ShowDialog() == DialogResult.OK)
            {
                Send("rename", ass.nick);
            }
        }        
		private void Label3_Click(object sender, EventArgs e)
        {
            ChangeUsername login = new ChangeUsername("Give Me The: Password");
            if (login.ShowDialog() == DialogResult.OK)
            {
                Send("admin", "2", login.nick); /**
													Tired: Making a new dialog box
													Hired: Reusing a dialog box with different texts
													Wired: literally use the same dialog box as rename
												**/
            }
        }

        private static ushort HandleKey(KeyEventArgs e)
        {
            //Console.WriteLine(e.KeyCode);
            CollabAPI.X11KeyCode k;
            switch (e.KeyValue < 256)
            {
                //ree asss
                case true:
                    k = (CollabAPI.X11KeyCode)
                    (
                        char.IsLetter((char) e.KeyCode)
                            ? IsKeyLocked(Keys.CapsLock) ^ ModifierKeys.HasFlag(Keys.Shift)
                                ? char.ToUpper((char) e.KeyCode)
                                : char.ToLower((char) e.KeyCode)
                            : (char) e.KeyCode
                    );
                    break;
                default:
                    switch (e.KeyCode)
                    {
                        case Keys.Shift:
                        case Keys.ShiftKey:
                        case Keys.LShiftKey:
                            k = CollabAPI.X11KeyCode.XK_Shift_L;
                            break;
                        case Keys.RShiftKey:
                            k = CollabAPI.X11KeyCode.XK_Shift_R;
                            break;
                        case Keys.Control:
                        case Keys.ControlKey:
                        case Keys.LControlKey:
                            k = CollabAPI.X11KeyCode.XK_Control_L;
                            break;
                        case Keys.Alt:
                            k = CollabAPI.X11KeyCode.XK_Alt_L;
                            break;
                        case Keys.LWin:
                            k = CollabAPI.X11KeyCode.XK_Meta_L;
                            break;
                        case Keys.RWin:
                            k = CollabAPI.X11KeyCode.XK_Meta_R;
                            break;
                        default:
                            k = CollabAPI.X11KeyConverter.UnicodeToX11Key((char) e.KeyValue);
                            break;
                    }

                    break;
            }

            if (k != 0)
            {
                return (ushort) k;
            }

            Console.Error.WriteLine($"can not find key for: {e.KeyCode}");
            return 0;
            //Console.WriteLine((ushort)k);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //https://github.com/glyptodon/guacamole-client/blob/master/guacamole-common-js/src/main/webapp/modules/Keyboard.js //todo, lol
            if (!pbfocus)
            {
                return;
            }

            var k = HandleKey(e);
            Console.WriteLine("up: " + k + " | " + e.KeyCode);
			k = Globals.GetKeycodeByName(e, k);

            Send("key", k, 0);
        }

        private static void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!pbfocus)
            {
                return;
            }
            var k = HandleKey(e);
            Console.WriteLine("down: " + k + " | " + e.KeyCode);
			k = Globals.GetKeycodeByName(e, k);

            Send("key", k, 1);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
			Application.Exit();
        }
    }
}