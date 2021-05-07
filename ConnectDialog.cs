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
                    textBox.Text = "computernewb.com:6004";
                    textBox2.Text = "vm1";
                    break;
                case 2:
                    textBox.Text = "computernewb.com:6005";
                    textBox2.Text = "vm2";
                    break;
                case 3:
                    textBox.Text = "computernewb.com:6006";
                    textBox2.Text = "vm3";
                    break;
                case 4:
                    textBox.Text = "computernewb.com:6007";
                    textBox2.Text = "vm4";
                    break;
                case 5:
                    textBox.Text = "computernewb.com:6008";
                    textBox2.Text = "vm5";
                    break;
                case 6:
                    textBox.Text = "computernewb.com:6009";
                    textBox2.Text = "vm6";
                    break;
                case 7:
                    textBox.Text = "computernewb.com:7000";
                    textBox2.Text = "vm0";
                    break;
                case 8:
                    textBox.Text = "home.darkok.xyz:6004";
                    textBox2.Text = "pissta";
                    break;
                case 9:
                    textBox.Text = "173.252.197.90:6004";
                    textBox2.Text = "gxp4";
                    break;
                case 10:
                    textBox.Text = "173.252.197.90:6004";
                    textBox2.Text = "ubuntu";
                    break;
                case 11:
                    textBox.Text = "173.252.197.90:6004";
                    textBox2.Text = "7989vm";
                    break;
				case 12:
                    textBox.Text = "173.252.197.90:6004";
                    textBox2.Text = "xphomelm9";
                    break;
				case 13:
                    textBox.Text = "173.252.197.90:6004";
                    textBox2.Text = "mac2007";
                    break;
				case 14:
                    textBox.Text = "173.252.197.90:6004";
                    textBox2.Text = "whistler2419";
                    break;				
				case 15:
                    textBox.Text = "173.252.197.90:6004";
                    textBox2.Text = "egg";
                    break;				
				case 16:
                    textBox.Text = "35.192.5.210:6004";
                    textBox2.Text = "fartvm1";
                    break;				
				case 17:
                    textBox.Text = "35.192.5.210:6005";
                    textBox2.Text = "fartvm2";
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