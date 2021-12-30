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
					textBox.Text = "computernewb.com:443/collab-vm/vm1";
					textBox2.Text = "vm1";
					checksecure.Checked = true;
					checkcompression.Checked = true;
					break;
				case 2:
					textBox.Text = "computernewb.com:443/collab-vm/vm2";
					textBox2.Text = "vm2";
					checksecure.Checked = true;
					checkcompression.Checked = true;
					break;
				case 3:
					textBox.Text = "computernewb.com:443/collab-vm/vm3";
					textBox2.Text = "vm3";
					checksecure.Checked = true;
					checkcompression.Checked = true;
					break;
				case 4:
					textBox.Text = "computernewb.com:443/collab-vm/vm4";
					textBox2.Text = "vm4";
					checksecure.Checked = true;
					checkcompression.Checked = true;
					break;
				case 5:
					textBox.Text = "computernewb.com:443/collab-vm/vm5";
					textBox2.Text = "vm5";
					checksecure.Checked = true;
					checkcompression.Checked = true;
					break;
				case 6:
					textBox.Text = "computernewb.com:443/collab-vm/vm6";
					textBox2.Text = "vm6";
					checksecure.Checked = true;
					checkcompression.Checked = true;
					break;
				case 7:
					textBox.Text = "computernewb.com:443/collab-vm/vm7";
					textBox2.Text = "vm7";
					checksecure.Checked = true;
					checkcompression.Checked = true;
					break;				
				case 8:
					textBox.Text = "computernewb.com:443/collab-vm/vm8";
					textBox2.Text = "vm8";
					checksecure.Checked = true;
					checkcompression.Checked = true;
					break;
				case 9:
					textBox.Text = "computernewb.com:443/collab-vm/vm0";
					textBox2.Text = "vm0";
					checksecure.Checked = true;
					checkcompression.Checked = true;
					break;
				case 10:
					textBox.Text = "home.darkok.xyz:6004";
					textBox2.Text = "pissta";
					checksecure.Checked = false;
					checkcompression.Checked = true;
					break;
				case 11:
					textBox.Text = "cvm.ziad87.net:443/cvmws";
					textBox2.Text = "cvmi-windoze8064";
					checksecure.Checked = true;
					checkcompression.Checked = true;
					break;
			}
		}

		private void OkButton_Click(object sender, EventArgs e)
		{
			Globals.vmip = textBox.Text;
			Globals.vmname = textBox2.Text;
			Globals.vmusername = textBox3.Text;
			Globals.isSecure = checksecure.Checked;
			Globals.isCompressed = checkcompression.Checked;
			Hide();
			new Form1().Show();
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
