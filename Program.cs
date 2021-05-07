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
				string uri = args[0].Split('/')[2];
				string prefix = args[0].Split('/')[0];
				switch (prefix)
				{
					case "collabvm:" :
					case "cvm:" :
					{
						string getip = uri.Split('#')[0];
						string getnode = uri.Split('#')[1];
						Globals.vmip = getip;
						Globals.vmname = getnode;
						Globals.vmusername = "tester";
						Application.Run(new Form1());
						break;
					}
					default:
					{
						Console.WriteLine("Enter a valid collabvm:// or cvm:// URI!\nExample: cvm://example.com:6004#example");
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