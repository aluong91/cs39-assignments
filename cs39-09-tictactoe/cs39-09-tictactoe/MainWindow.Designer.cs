namespace cs39_09_tictactoe
{
	partial class MainWindow
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
			this.button1 = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.playerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.firstPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
			this.player1NameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
			this.player2NameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
			this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(12, 27);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(83, 79);
			this.button1.TabIndex = 0;
			this.button1.Tag = "";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.playerToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(284, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// newGameToolStripMenuItem
			// 
			this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
			this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.newGameToolStripMenuItem.Text = "New Game";
			this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
			// 
			// playerToolStripMenuItem
			// 
			this.playerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstPlayerToolStripMenuItem,
            this.player1NameToolStripMenuItem,
            this.player2NameToolStripMenuItem,
            this.xToolStripMenuItem});
			this.playerToolStripMenuItem.Name = "playerToolStripMenuItem";
			this.playerToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
			this.playerToolStripMenuItem.Text = "Player";
			// 
			// firstPlayerToolStripMenuItem
			// 
			this.firstPlayerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox2});
			this.firstPlayerToolStripMenuItem.Name = "firstPlayerToolStripMenuItem";
			this.firstPlayerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.firstPlayerToolStripMenuItem.Text = "First Player";
			// 
			// toolStripComboBox2
			// 
			this.toolStripComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.toolStripComboBox2.Items.AddRange(new object[] {
            "Player 1",
            "Player 2"});
			this.toolStripComboBox2.Name = "toolStripComboBox2";
			this.toolStripComboBox2.Size = new System.Drawing.Size(121, 23);
			this.toolStripComboBox2.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox2_SelectedIndexChanged);
			// 
			// player1NameToolStripMenuItem
			// 
			this.player1NameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
			this.player1NameToolStripMenuItem.Name = "player1NameToolStripMenuItem";
			this.player1NameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.player1NameToolStripMenuItem.Text = "Player 1 Name";
			// 
			// toolStripTextBox1
			// 
			this.toolStripTextBox1.Name = "toolStripTextBox1";
			this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
			this.toolStripTextBox1.Text = "Player 1";
			this.toolStripTextBox1.TextChanged += new System.EventHandler(this.toolStripTextBox_TextChanged);
			// 
			// player2NameToolStripMenuItem
			// 
			this.player2NameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox2});
			this.player2NameToolStripMenuItem.Name = "player2NameToolStripMenuItem";
			this.player2NameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.player2NameToolStripMenuItem.Text = "Player 2 Name";
			// 
			// toolStripTextBox2
			// 
			this.toolStripTextBox2.Name = "toolStripTextBox2";
			this.toolStripTextBox2.Size = new System.Drawing.Size(100, 23);
			this.toolStripTextBox2.Text = "Player 2";
			this.toolStripTextBox2.TextChanged += new System.EventHandler(this.toolStripTextBox_TextChanged);
			// 
			// xToolStripMenuItem
			// 
			this.xToolStripMenuItem.Name = "xToolStripMenuItem";
			this.xToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.xToolStripMenuItem.Text = "Swap Shapes";
			this.xToolStripMenuItem.Click += new System.EventHandler(this.xToolStripMenuItem_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(100, 27);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(83, 79);
			this.button2.TabIndex = 1;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button_Click);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(189, 27);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(83, 79);
			this.button3.TabIndex = 2;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button_Click);
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(12, 112);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(83, 79);
			this.button4.TabIndex = 3;
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button_Click);
			// 
			// button5
			// 
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Location = new System.Drawing.Point(100, 112);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(83, 79);
			this.button5.TabIndex = 4;
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button_Click);
			// 
			// button6
			// 
			this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.Location = new System.Drawing.Point(189, 112);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(83, 79);
			this.button6.TabIndex = 5;
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button_Click);
			// 
			// button7
			// 
			this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button7.Location = new System.Drawing.Point(11, 197);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(83, 79);
			this.button7.TabIndex = 6;
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button_Click);
			// 
			// button8
			// 
			this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button8.Location = new System.Drawing.Point(100, 197);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(83, 79);
			this.button8.TabIndex = 7;
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.button_Click);
			// 
			// button9
			// 
			this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button9.Location = new System.Drawing.Point(189, 197);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(83, 79);
			this.button9.TabIndex = 8;
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.button_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 280);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(284, 22);
			this.statusStrip1.TabIndex = 9;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 302);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainWindow";
			this.Text = "MainWindow";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem playerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem firstPlayerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem player1NameToolStripMenuItem;
		private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
		private System.Windows.Forms.ToolStripMenuItem player2NameToolStripMenuItem;
		private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
		private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem;
		private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;

	}
}