using System;
using System.Windows.Forms;

namespace CollabClient
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
			if (args.Length > 0)
			{
				Console.Title = "CollabVM .NET Client - Console";
				string prefix = args[0].Split('/')[0];
				switch (prefix)
				{
					case "collabvm:" :
					case "cvm:" :
					{
						try {
						string[] seperators = { "//", "#" };
						string[] purl = args[0].Split(seperators, System.StringSplitOptions.RemoveEmptyEntries);
						string getip = purl[1];
						string getnode = purl[2];
						Globals.vmip = getip;
						Globals.vmname = getnode;
						}
						catch (IndexOutOfRangeException)
						{
						Console.WriteLine("Invaild collabvm://, cvm://, collabvms:// or cvms:// URI!");
						Application.Run(new ConnectDialog());
						break;
						}
						Console.WriteLine("Attempting to connect to "+Globals.vmip+"#"+Globals.vmname+"...");
						Application.Run(new Form1());
						break;
					}					
					case "collabvms:" :
					case "cvms:" :
					{
						try {
						string[] seperators = { "//", "#" };
						string[] purl = args[0].Split(seperators, System.StringSplitOptions.RemoveEmptyEntries);
						string getip = purl[1];
						string getnode = purl[2];
						Globals.vmip = getip;
						Globals.vmname = getnode;
						Globals.isSecure = true;
						}
						catch (IndexOutOfRangeException)
						{
						Console.WriteLine("Invaild collabvm://, cvm://, collabvms:// or cvms:// URI!");
						Application.Run(new ConnectDialog());
						break;
						}
						Console.WriteLine("Attempting to connect with TLS to "+Globals.vmip+"#"+Globals.vmname+"...");
						Application.Run(new Form1());
						break;
					}
					default:
					{
						Console.WriteLine("Enter a valid collabvm:// or cvm:// URI!\nExample: cvm://example.com:6004/#example");
						break;
					}
				}
			}
			else {
            Application.Run(new ConnectDialog());
			}
        }
    }
}