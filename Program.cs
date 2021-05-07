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
						string getip = args[0].Split('/')[2];
						string getnode = args[0].Split('/')[3].Split('#')[1];
						Globals.vmip = getip;
						Globals.vmname = getnode;
						}
						catch (IndexOutOfRangeException)
						{
						Console.WriteLine("Invaild collabvm:// or cvm:// URI!");
						Application.Run(new ConnectDialog());
						}
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