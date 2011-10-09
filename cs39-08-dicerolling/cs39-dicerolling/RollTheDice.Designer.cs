namespace cs39_dicerolling
{
    partial class RollTheDice
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.player1Score = new System.Windows.Forms.Label();
			this.player2Score = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.currentPlayerBox = new System.Windows.Forms.GroupBox();
			this.turnScore = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.rolledValue = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newGameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox1.SuspendLayout();
			this.currentPlayerBox.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(30, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Player 1:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(150, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Player 2:";
			// 
			// player1Score
			// 
			this.player1Score.AutoSize = true;
			this.player1Score.Location = new System.Drawing.Point(48, 37);
			this.player1Score.Name = "player1Score";
			this.player1Score.Size = new System.Drawing.Size(13, 13);
			this.player1Score.TabIndex = 3;
			this.player1Score.Text = "0";
			// 
			// player2Score
			// 
			this.player2Score.AutoSize = true;
			this.player2Score.Location = new System.Drawing.Point(165, 37);
			this.player2Score.Name = "player2Score";
			this.player2Score.Size = new System.Drawing.Size(13, 13);
			this.player2Score.TabIndex = 4;
			this.player2Score.Text = "0";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.player2Score);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.player1Score);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(12, 27);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(231, 62);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Score";
			// 
			// currentPlayerBox
			// 
			this.currentPlayerBox.Controls.Add(this.turnScore);
			this.currentPlayerBox.Controls.Add(this.label4);
			this.currentPlayerBox.Controls.Add(this.rolledValue);
			this.currentPlayerBox.Controls.Add(this.label6);
			this.currentPlayerBox.Location = new System.Drawing.Point(12, 109);
			this.currentPlayerBox.Name = "currentPlayerBox";
			this.currentPlayerBox.Size = new System.Drawing.Size(231, 62);
			this.currentPlayerBox.TabIndex = 6;
			this.currentPlayerBox.TabStop = false;
			this.currentPlayerBox.Text = "Player 1";
			this.currentPlayerBox.TextChanged += new System.EventHandler(this.currentPlayerBox_TextChanged);
			// 
			// turnScore
			// 
			this.turnScore.AutoSize = true;
			this.turnScore.Location = new System.Drawing.Point(165, 37);
			this.turnScore.Name = "turnScore";
			this.turnScore.Size = new System.Drawing.Size(13, 13);
			this.turnScore.TabIndex = 4;
			this.turnScore.Text = "0";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(33, 23);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 13);
			this.label4.TabIndex = 1;
			this.label4.Text = "Rolled:";
			// 
			// rolledValue
			// 
			this.rolledValue.AutoSize = true;
			this.rolledValue.Location = new System.Drawing.Point(47, 38);
			this.rolledValue.Name = "rolledValue";
			this.rolledValue.Size = new System.Drawing.Size(13, 13);
			this.rolledValue.TabIndex = 3;
			this.rolledValue.Text = "0";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(138, 25);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(63, 13);
			this.label6.TabIndex = 2;
			this.label6.Text = "Turn Score:";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(15, 190);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 7;
			this.button1.Text = "Roll";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(153, 190);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 8;
			this.button2.Text = "Stand";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(258, 24);
			this.menuStrip1.TabIndex = 9;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// newGameToolStripMenuItem
			// 
			this.newGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem1,
            this.exitToolStripMenuItem});
			this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
			this.newGameToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.newGameToolStripMenuItem.Text = "File";
			// 
			// newGameToolStripMenuItem1
			// 
			this.newGameToolStripMenuItem1.Name = "newGameToolStripMenuItem1";
			this.newGameToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
			this.newGameToolStripMenuItem1.Text = "New Game";
			this.newGameToolStripMenuItem1.Click += new System.EventHandler(this.newGameToolStripMenuItem1_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// RollTheDice
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(258, 262);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.currentPlayerBox);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.menuStrip1);
			this.Name = "RollTheDice";
			this.Text = "RollTheDice";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.currentPlayerBox.ResumeLayout(false);
			this.currentPlayerBox.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label player1Score;
        private System.Windows.Forms.Label player2Score;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox currentPlayerBox;
        private System.Windows.Forms.Label turnScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label rolledValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

