using System;
using System.Windows.Forms;

namespace CollabClient
{
    public partial class ConnectDialog : Form
    {
        public ConnectDialog()
        {
            InitializeComponent();
			Console.Title = "CollabVM .NET Client - Console";
        }

        private void Cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cb.SelectedIndex + 1)
            {
                case 1:
                    textBox.Text = "computernewb.com:80/collab-vm/vm1";
                    textBox2.Text = "vm1";
                    break;
                case 2:
                    textBox.Text = "computernewb.com:80/collab-vm/vm2";
                    textBox2.Text = "vm2";
                    break;
                case 3:
                    textBox.Text = "computernewb.com:80/collab-vm/vm3";
                    textBox2.Text = "vm3";
                    break;
                case 4:
                    textBox.Text = "computernewb.com:80/collab-vm/vm4";
                    textBox2.Text = "vm4";
                    break;
                case 5:
                    textBox.Text = "computernewb.com:80/collab-vm/vm5";
                    textBox2.Text = "vm5";
                    break;
                case 6:
                    textBox.Text = "computernewb.com:80/collab-vm/vm6";
                    textBox2.Text = "vm6";
                    break;
                case 7:
                    textBox.Text = "computernewb.com:80/collab-vm/vm0";
                    textBox2.Text = "vm0";
                    break;
                case 8:
                    textBox.Text = "home.darkok.xyz:6004";
                    textBox2.Text = "pissta";
                    break;
                case 9:
                    textBox.Text = "uvm.vmland.cf:2095";
                    textBox2.Text = "WindowsWhistler2257-BP";
                    break;				
				case 10:
                    textBox.Text = "uvm.vmland.cf:2095";
                    textBox2.Text = "WindowsWhistler2296-BP";
                    break;				
				case 11:
                    textBox.Text = "uvm.vmland.cf:2095";
                    textBox2.Text = "WindowsWhistler2419-BP";
                    break;				
				case 12:
                    textBox.Text = "uvm.vmland.cf:2095";
                    textBox2.Text = "WindowsWhistler2430-BP";
                    break;				
				case 13:
                    textBox.Text = "uvm.vmland.cf:2095";
                    textBox2.Text = "WindowsWhistler2463-BP";
                    break;
				case 14:
					textBox.Text = "uvm.vmland.cf:2095";
                    textBox2.Text = "WindowsWhistler2475-BP";
                    break;
				case 15:
					textBox.Text = "darkok.xyz:3037";
                    textBox2.Text = "cvmi-windoze8064";
                    break;
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Globals.vmip = textBox.Text;
            Globals.vmname = textBox2.Text;
            Globals.vmusername = textBox3.Text;
            Hide();
            new Form1().Show();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
