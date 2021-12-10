
using System.Drawing;
using System.Windows.Forms;

namespace CollabClient
{
    partial class ConnectDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
			if (disposing && (components != null))
			{
			    components.Dispose();
			}
			base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectDialog));
			this.textBox = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.okButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.namewarning = new System.Windows.Forms.Label();
			this.iptext = new System.Windows.Forms.Label();
			this.nametext = new System.Windows.Forms.Label();
			this.presetlabel = new System.Windows.Forms.Label();
			this.cb = new System.Windows.Forms.ComboBox();
			this.checksecure = new System.Windows.Forms.CheckBox();
			this.checkcompression = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// textBox
			// 
			this.textBox.BackColor = System.Drawing.Color.DimGray;
			this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox.ForeColor = System.Drawing.Color.White;
			this.textBox.Location = new System.Drawing.Point(25, 5);
			this.textBox.Name = "textBox";
			this.textBox.Size = new System.Drawing.Size(145, 20);
			this.textBox.TabIndex = 0;
			this.textBox.Text = Globals.vmip;
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.Color.DimGray;
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox2.ForeColor = System.Drawing.Color.White;
			this.textBox2.Location = new System.Drawing.Point(169, 5);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(45, 20);
			this.textBox2.TabIndex = 1;
			this.textBox2.Text = Globals.vmname;
			// 
			// textBox3
			// 
			this.textBox3.BackColor = System.Drawing.Color.DimGray;
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox3.ForeColor = System.Drawing.Color.White;
			this.textBox3.Location = new System.Drawing.Point(73, 24);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(141, 20);
			this.textBox3.TabIndex = 2;
			this.textBox3.Text = Globals.vmusername;
			this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// okButton
			// 
			this.okButton.BackColor = System.Drawing.Color.Gray;
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.okButton.ForeColor = System.Drawing.SystemColors.ControlText;
			this.okButton.Location = new System.Drawing.Point(60, 182);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 5;
			this.okButton.Text = "&Connect";
			this.okButton.UseVisualStyleBackColor = false;
			this.okButton.Click += new System.EventHandler(this.OkButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.BackColor = System.Drawing.Color.Gray;
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cancelButton.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cancelButton.Location = new System.Drawing.Point(140, 182);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 6;
			this.cancelButton.Text = "&Quit";
			this.cancelButton.UseVisualStyleBackColor = false;
			this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// namewarning
			// 
			this.namewarning.AutoSize = true;
			this.namewarning.BackColor = System.Drawing.Color.Transparent;
			this.namewarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.namewarning.ForeColor = System.Drawing.Color.White;
			this.namewarning.Location = new System.Drawing.Point(0, 68);
			this.namewarning.Name = "namewarning";
			this.namewarning.Size = new System.Drawing.Size(220, 60);
			this.namewarning.TabIndex = 11;
			this.namewarning.Text = "Usernames can only contain:\r\nANSI alphanumericals, spaces, dashes\r\nunderscores, a" +
    "nd periods, And it also\r\nmust be between 3 to 20 characters.";
			// 
			// iptext
			// 
			this.iptext.AutoSize = true;
			this.iptext.BackColor = System.Drawing.Color.Transparent;
			this.iptext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.iptext.ForeColor = System.Drawing.Color.White;
			this.iptext.Location = new System.Drawing.Point(5, 5);
			this.iptext.Name = "iptext";
			this.iptext.Size = new System.Drawing.Size(24, 15);
			this.iptext.TabIndex = 11;
			this.iptext.Text = "IP: ";
			// 
			// nametext
			// 
			this.nametext.AutoSize = true;
			this.nametext.BackColor = System.Drawing.Color.Transparent;
			this.nametext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.nametext.ForeColor = System.Drawing.Color.White;
			this.nametext.Location = new System.Drawing.Point(5, 24);
			this.nametext.Name = "nametext";
			this.nametext.Size = new System.Drawing.Size(71, 15);
			this.nametext.TabIndex = 11;
			this.nametext.Text = "Username: ";
			// 
			// presetlabel
			// 
			this.presetlabel.AutoSize = true;
			this.presetlabel.BackColor = System.Drawing.Color.Transparent;
			this.presetlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.presetlabel.ForeColor = System.Drawing.Color.White;
			this.presetlabel.Location = new System.Drawing.Point(5, 44);
			this.presetlabel.Name = "presetlabel";
			this.presetlabel.Size = new System.Drawing.Size(62, 15);
			this.presetlabel.TabIndex = 11;
			this.presetlabel.Text = "Preset(s): ";
			// 
			// cb
			// 
			this.cb.BackColor = System.Drawing.Color.DimGray;
			this.cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cb.ForeColor = System.Drawing.Color.White;
			this.cb.Items.AddRange(new object[] {
			"Computernewb VM1",
			"Computernewb VM2",
			"Computernewb VM3",
			"Computernewb VM4",
			"Computernewb VM5",
			"Computernewb VM6",
			"Computernewb VM7",
			"Computernewb VM0",
			"DarkOK Vista",
			"Bob's Whistler 2257",
			"Bob's Whistler 2296",
			"Bob's Whistler 2419",
			"Bob's Whistler 2430",
			"Bob's Whistler 2463",
			"Bob's Whistler 2475",
			"ziad87 Win 8064"});
			this.cb.Location = new System.Drawing.Point(73, 44);
			this.cb.Name = "cb";
			this.cb.Size = new System.Drawing.Size(141, 21);
			this.cb.TabIndex = 7;
			this.cb.SelectedIndexChanged += new System.EventHandler(this.Cb_SelectedIndexChanged);
			//
			// checksecure
			//
			this.checksecure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.checksecure.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.checksecure.ForeColor = System.Drawing.Color.White;
			this.checksecure.Location = new System.Drawing.Point(8, 132);
			this.checksecure.Name = "checksecure";
			this.checksecure.Size = new System.Drawing.Size(180, 23);
			this.checksecure.TabIndex = 3;
			this.checksecure.Text = "Connect using TLS 1.2";
			this.checksecure.Checked = false;
			this.checksecure.UseVisualStyleBackColor = false;
			//
			// checkcompression
			//
			this.checkcompression.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.checkcompression.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.checkcompression.ForeColor = System.Drawing.Color.White;
			this.checkcompression.Location = new System.Drawing.Point(8, 152);
			this.checkcompression.Name = "checkcompression";
			this.checkcompression.Size = new System.Drawing.Size(180, 23);
			this.checkcompression.TabIndex = 4;
			this.checkcompression.Text = "Use Deflate Compression";
			this.checkcompression.Checked = true;
			this.checkcompression.UseVisualStyleBackColor = false;
			// 
			// ConnectDialog
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(220, 210);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox);
			this.Controls.Add(this.cb);
			this.Controls.Add(this.presetlabel);
			this.Controls.Add(this.nametext);
			this.Controls.Add(this.iptext);
			this.Controls.Add(this.namewarning);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.checksecure);
			this.Controls.Add(this.checkcompression);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetExecutingAssembly().Location);
			this.Name = "ConnectDialog";
			this.Text = "Connect to...";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label namewarning;
        private System.Windows.Forms.Label iptext;
        private System.Windows.Forms.Label nametext;
        private System.Windows.Forms.Label presetlabel;
		private System.Windows.Forms.CheckBox checksecure;
		private System.Windows.Forms.CheckBox checkcompression;
        private System.Windows.Forms.ComboBox cb;
    }
}