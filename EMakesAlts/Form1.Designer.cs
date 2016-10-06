namespace EMakesAlts
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		public System.ComponentModel.IContainer components = null;

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
		public void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.gameId = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.fileLocation = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.altUsername = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.altEmail = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.altPassword = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.console = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.altNumber = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.manualCaptcha = new System.Windows.Forms.TextBox();
			this.getCaptcha = new System.Windows.Forms.PictureBox();
			this.button3 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.getCaptcha)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(157, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Make an alt today!";
			// 
			// gameId
			// 
			this.gameId.Location = new System.Drawing.Point(65, 25);
			this.gameId.Name = "gameId";
			this.gameId.Size = new System.Drawing.Size(384, 20);
			this.gameId.TabIndex = 1;
			this.gameId.Leave += new System.EventHandler(this.SaveData);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 28);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Game Id";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 54);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "File Location";
			// 
			// fileLocation
			// 
			this.fileLocation.BackColor = System.Drawing.SystemColors.Window;
			this.fileLocation.Location = new System.Drawing.Point(85, 51);
			this.fileLocation.Name = "fileLocation";
			this.fileLocation.ReadOnly = true;
			this.fileLocation.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.fileLocation.Size = new System.Drawing.Size(364, 20);
			this.fileLocation.TabIndex = 3;
			this.fileLocation.Text = "C:\\EMakesAlts\\data.txt";
			this.fileLocation.Leave += new System.EventHandler(this.SaveData);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 106);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(70, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Alt Username";
			// 
			// altUsername
			// 
			this.altUsername.Location = new System.Drawing.Point(88, 103);
			this.altUsername.Name = "altUsername";
			this.altUsername.Size = new System.Drawing.Size(361, 20);
			this.altUsername.TabIndex = 7;
			this.altUsername.Text = "MYALT%alt%";
			this.altUsername.Leave += new System.EventHandler(this.SaveData);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 80);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(47, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "Alt Email";
			// 
			// altEmail
			// 
			this.altEmail.Location = new System.Drawing.Point(65, 77);
			this.altEmail.Name = "altEmail";
			this.altEmail.Size = new System.Drawing.Size(384, 20);
			this.altEmail.TabIndex = 5;
			this.altEmail.Text = "MYALT%alt%@alt.com";
			this.altEmail.Leave += new System.EventHandler(this.SaveData);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 132);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(68, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Alt Password";
			// 
			// altPassword
			// 
			this.altPassword.Location = new System.Drawing.Point(86, 129);
			this.altPassword.Name = "altPassword";
			this.altPassword.Size = new System.Drawing.Size(363, 20);
			this.altPassword.TabIndex = 9;
			this.altPassword.Text = "MYALT%alt%";
			this.altPassword.Leave += new System.EventHandler(this.SaveData);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.console);
			this.groupBox1.Location = new System.Drawing.Point(15, 155);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(212, 233);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Console";
			// 
			// console
			// 
			this.console.Location = new System.Drawing.Point(6, 19);
			this.console.Multiline = true;
			this.console.Name = "console";
			this.console.Size = new System.Drawing.Size(200, 208);
			this.console.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(233, 155);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(216, 54);
			this.button1.TabIndex = 12;
			this.button1.Text = "Start Alt Creator";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// altNumber
			// 
			this.altNumber.BackColor = System.Drawing.SystemColors.Window;
			this.altNumber.Location = new System.Drawing.Point(298, 215);
			this.altNumber.Name = "altNumber";
			this.altNumber.ReadOnly = true;
			this.altNumber.Size = new System.Drawing.Size(151, 20);
			this.altNumber.TabIndex = 13;
			this.altNumber.Leave += new System.EventHandler(this.SaveData);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(233, 218);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(59, 13);
			this.label7.TabIndex = 14;
			this.label7.Text = "Alt Number";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.groupBox2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(461, 400);
			this.panel1.TabIndex = 15;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button3);
			this.groupBox2.Controls.Add(this.button2);
			this.groupBox2.Controls.Add(this.manualCaptcha);
			this.groupBox2.Controls.Add(this.getCaptcha);
			this.groupBox2.Location = new System.Drawing.Point(236, 241);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(213, 100);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Enter Captcha Manually";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(133, 68);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(74, 26);
			this.button2.TabIndex = 2;
			this.button2.Text = "Send";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// manualCaptcha
			// 
			this.manualCaptcha.Location = new System.Drawing.Point(6, 70);
			this.manualCaptcha.MaxLength = 4;
			this.manualCaptcha.Name = "manualCaptcha";
			this.manualCaptcha.Size = new System.Drawing.Size(121, 20);
			this.manualCaptcha.TabIndex = 1;
			this.manualCaptcha.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// getCaptcha
			// 
			this.getCaptcha.Location = new System.Drawing.Point(15, 15);
			this.getCaptcha.Name = "getCaptcha";
			this.getCaptcha.Size = new System.Drawing.Size(100, 50);
			this.getCaptcha.TabIndex = 0;
			this.getCaptcha.TabStop = false;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(148, 11);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(60, 22);
			this.button3.TabIndex = 3;
			this.button3.Text = "Refresh";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(461, 400);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.altNumber);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.altPassword);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.altUsername);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.altEmail);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.fileLocation);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.gameId);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Everybody Makes Alts";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Closing);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.getCaptcha)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.Label label1;
		public System.Windows.Forms.TextBox gameId;
		public System.Windows.Forms.Label label2;
		public System.Windows.Forms.Label label3;
		public System.Windows.Forms.TextBox fileLocation;
		public System.Windows.Forms.Label label4;
		public System.Windows.Forms.TextBox altUsername;
		public System.Windows.Forms.Label label5;
		public System.Windows.Forms.TextBox altEmail;
		public System.Windows.Forms.Label label6;
		public System.Windows.Forms.TextBox altPassword;
		public System.Windows.Forms.GroupBox groupBox1;
		public System.Windows.Forms.TextBox console;
		public System.Windows.Forms.Button button1;
		public System.Windows.Forms.TextBox altNumber;
		public System.Windows.Forms.Label label7;
		public System.Windows.Forms.Panel panel1;
		public System.Windows.Forms.GroupBox groupBox2;
		public System.Windows.Forms.Button button2;
		public System.Windows.Forms.TextBox manualCaptcha;
		public System.Windows.Forms.PictureBox getCaptcha;
		private System.Windows.Forms.Button button3;

	}
}

