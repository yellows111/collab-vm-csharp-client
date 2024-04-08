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
					textBox2.Text = "vm0b0t";
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
		private void SecureCheck_Click(object sender, EventArgs e)
		{
			try {
				string[] seperators = { ":6004", ":443" }; // Thought it was gonna be :80 huh?
				string[] swapPorts = textBox.Text.Split(seperators, System.StringSplitOptions.RemoveEmptyEntries);
				if (checksecure.Checked)  
				{  
					textBox.Text = ($"{swapPorts[0]}:443{swapPorts[1]}"); 
				}  
				else  
				{
					textBox.Text = ($"{swapPorts[0]}:6004{swapPorts[1]}"); 
				}
			}
			catch(Exception err)
			{
				Console.WriteLine($"{err.Message}\n\tCannot convert a non-6004 IP to 443 or vice-versa.");
			}
		}
	}
}
