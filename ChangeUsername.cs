using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollabClient
{
    public partial class ChangeUsername : Form
    {
        public ChangeUsername(string prevnic)
        {
            InitializeComponent();
            textBox1.Text = prevnic;
            textBox1.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nick = textBox1.Text;
        }
        public string nick = "";
    }
}
