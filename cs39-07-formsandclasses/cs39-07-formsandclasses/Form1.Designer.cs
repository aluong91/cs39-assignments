namespace cs39_07_formsandclasses
{
	partial class Form1
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
			if (disposing && (components != null)) {
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
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.firstNameBox = new System.Windows.Forms.TextBox();
			this.lastNameBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.passwordBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.confirmPasswordBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.usernameBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.majorBox = new System.Windows.Forms.ComboBox();
			this.specialtyBox = new System.Windows.Forms.ComboBox();
			this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.form1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.submitButton = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.form1BindingSource1)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "First Name";
			// 
			// firstNameBox
			// 
			this.firstNameBox.Location = new System.Drawing.Point(75, 12);
			this.firstNameBox.Name = "firstNameBox";
			this.firstNameBox.Size = new System.Drawing.Size(100, 20);
			this.firstNameBox.TabIndex = 1;
			// 
			// lastNameBox
			// 
			this.lastNameBox.Location = new System.Drawing.Point(75, 38);
			this.lastNameBox.Name = "lastNameBox";
			this.lastNameBox.Size = new System.Drawing.Size(100, 20);
			this.lastNameBox.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Last Name";
			// 
			// passwordBox
			// 
			this.passwordBox.Location = new System.Drawing.Point(75, 90);
			this.passwordBox.Name = "passwordBox";
			this.passwordBox.PasswordChar = '•';
			this.passwordBox.Size = new System.Drawing.Size(100, 20);
			this.passwordBox.TabIndex = 5;
			this.passwordBox.Leave += new System.EventHandler(this.passwordBox_Leave);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 93);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Password";
			// 
			// confirmPasswordBox
			// 
			this.confirmPasswordBox.Location = new System.Drawing.Point(75, 116);
			this.confirmPasswordBox.Name = "confirmPasswordBox";
			this.confirmPasswordBox.PasswordChar = '•';
			this.confirmPasswordBox.Size = new System.Drawing.Size(100, 20);
			this.confirmPasswordBox.TabIndex = 6;
			this.confirmPasswordBox.Leave += new System.EventHandler(this.confirmPasswordBox_Leave);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 119);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Conf. Pass.";
			// 
			// usernameBox
			// 
			this.usernameBox.Location = new System.Drawing.Point(75, 64);
			this.usernameBox.Name = "usernameBox";
			this.usernameBox.Size = new System.Drawing.Size(100, 20);
			this.usernameBox.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 67);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Username";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 145);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(33, 13);
			this.label6.TabIndex = 11;
			this.label6.Text = "Major";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 171);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(50, 13);
			this.label7.TabIndex = 13;
			this.label7.Text = "Specialty";
			// 
			// majorBox
			// 
			this.majorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.majorBox.FormattingEnabled = true;
			this.majorBox.Items.AddRange(new object[] {
            "Biology",
            "Computer Science",
            "Economics",
            "Literature",
            "Political Science"});
			this.majorBox.Location = new System.Drawing.Point(75, 142);
			this.majorBox.Name = "majorBox";
			this.majorBox.Size = new System.Drawing.Size(121, 21);
			this.majorBox.TabIndex = 7;
			this.majorBox.SelectedIndexChanged += new System.EventHandler(this.majorBox_SelectedIndexChanged);
			// 
			// specialtyBox
			// 
			this.specialtyBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.specialtyBox.FormattingEnabled = true;
			this.specialtyBox.Location = new System.Drawing.Point(75, 168);
			this.specialtyBox.Name = "specialtyBox";
			this.specialtyBox.Size = new System.Drawing.Size(121, 21);
			this.specialtyBox.TabIndex = 8;
			// 
			// submitButton
			// 
			this.submitButton.Location = new System.Drawing.Point(15, 195);
			this.submitButton.Name = "submitButton";
			this.submitButton.Size = new System.Drawing.Size(75, 23);
			this.submitButton.TabIndex = 16;
			this.submitButton.Text = "Submit";
			this.submitButton.UseVisualStyleBackColor = true;
			this.submitButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(96, 195);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 17;
			this.button2.Text = "Clear";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(177, 195);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 18;
			this.button3.Text = "Load Last";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 240);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(284, 22);
			this.statusStrip1.TabIndex = 19;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.submitButton);
			this.Controls.Add(this.specialtyBox);
			this.Controls.Add(this.majorBox);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.usernameBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.confirmPasswordBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.passwordBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lastNameBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.firstNameBox);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.form1BindingSource1)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox firstNameBox;
		private System.Windows.Forms.TextBox lastNameBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox passwordBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox confirmPasswordBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox usernameBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox majorBox;
		private System.Windows.Forms.ComboBox specialtyBox;
		private System.Windows.Forms.BindingSource form1BindingSource;
		private System.Windows.Forms.BindingSource form1BindingSource1;
		private System.Windows.Forms.Button submitButton;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
	}
}

