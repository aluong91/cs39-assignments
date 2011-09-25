namespace cs39_06_forms
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
			this.textBox = new System.Windows.Forms.TextBox();
			this.clearButton = new System.Windows.Forms.Button();
			this.clearEntryButton = new System.Windows.Forms.Button();
			this.multiplyButton = new System.Windows.Forms.Button();
			this.divideButton = new System.Windows.Forms.Button();
			this.subtractButton = new System.Windows.Forms.Button();
			this.addButton = new System.Windows.Forms.Button();
			this.sevenButton = new System.Windows.Forms.Button();
			this.eightButton = new System.Windows.Forms.Button();
			this.moduloButton = new System.Windows.Forms.Button();
			this.nineButton = new System.Windows.Forms.Button();
			this.fourButton = new System.Windows.Forms.Button();
			this.fiveButton = new System.Windows.Forms.Button();
			this.sqrtButton = new System.Windows.Forms.Button();
			this.sixButton = new System.Windows.Forms.Button();
			this.oneButton = new System.Windows.Forms.Button();
			this.twoButton = new System.Windows.Forms.Button();
			this.equalsButton = new System.Windows.Forms.Button();
			this.threeButton = new System.Windows.Forms.Button();
			this.zeroButton = new System.Windows.Forms.Button();
			this.decimalButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox
			// 
			this.textBox.Location = new System.Drawing.Point(2, 11);
			this.textBox.Name = "textBox";
			this.textBox.Size = new System.Drawing.Size(280, 20);
			this.textBox.TabIndex = 0;
			this.textBox.Text = "0";
			this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
			// 
			// clearButton
			// 
			this.clearButton.Location = new System.Drawing.Point(149, 44);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(67, 51);
			this.clearButton.TabIndex = 1;
			this.clearButton.Text = "C";
			this.clearButton.UseVisualStyleBackColor = true;
			this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
			// 
			// clearEntryButton
			// 
			this.clearEntryButton.Location = new System.Drawing.Point(222, 44);
			this.clearEntryButton.Name = "clearEntryButton";
			this.clearEntryButton.Size = new System.Drawing.Size(60, 50);
			this.clearEntryButton.TabIndex = 2;
			this.clearEntryButton.Text = "CE";
			this.clearEntryButton.UseVisualStyleBackColor = true;
			this.clearEntryButton.Click += new System.EventHandler(this.clearEntryButton_Click);
			// 
			// multiplyButton
			// 
			this.multiplyButton.Location = new System.Drawing.Point(149, 101);
			this.multiplyButton.Name = "multiplyButton";
			this.multiplyButton.Size = new System.Drawing.Size(67, 48);
			this.multiplyButton.TabIndex = 3;
			this.multiplyButton.Text = "*";
			this.multiplyButton.UseVisualStyleBackColor = true;
			this.multiplyButton.Click += new System.EventHandler(this.operatorButton_Click);
			// 
			// divideButton
			// 
			this.divideButton.Location = new System.Drawing.Point(222, 101);
			this.divideButton.Name = "divideButton";
			this.divideButton.Size = new System.Drawing.Size(60, 48);
			this.divideButton.TabIndex = 4;
			this.divideButton.Text = "/";
			this.divideButton.UseVisualStyleBackColor = true;
			this.divideButton.Click += new System.EventHandler(this.operatorButton_Click);
			// 
			// subtractButton
			// 
			this.subtractButton.Location = new System.Drawing.Point(72, 101);
			this.subtractButton.Name = "subtractButton";
			this.subtractButton.Size = new System.Drawing.Size(71, 47);
			this.subtractButton.TabIndex = 5;
			this.subtractButton.Text = "-";
			this.subtractButton.UseVisualStyleBackColor = true;
			this.subtractButton.Click += new System.EventHandler(this.operatorButton_Click);
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(2, 101);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(64, 48);
			this.addButton.TabIndex = 6;
			this.addButton.Text = "+";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.operatorButton_Click);
			// 
			// sevenButton
			// 
			this.sevenButton.Location = new System.Drawing.Point(2, 155);
			this.sevenButton.Name = "sevenButton";
			this.sevenButton.Size = new System.Drawing.Size(64, 48);
			this.sevenButton.TabIndex = 10;
			this.sevenButton.Text = "7";
			this.sevenButton.UseVisualStyleBackColor = true;
			this.sevenButton.Click += new System.EventHandler(this.numberButton_Click);
			// 
			// eightButton
			// 
			this.eightButton.Location = new System.Drawing.Point(72, 155);
			this.eightButton.Name = "eightButton";
			this.eightButton.Size = new System.Drawing.Size(71, 47);
			this.eightButton.TabIndex = 9;
			this.eightButton.Text = "8";
			this.eightButton.UseVisualStyleBackColor = true;
			this.eightButton.Click += new System.EventHandler(this.numberButton_Click);
			// 
			// moduloButton
			// 
			this.moduloButton.Location = new System.Drawing.Point(222, 155);
			this.moduloButton.Name = "moduloButton";
			this.moduloButton.Size = new System.Drawing.Size(60, 48);
			this.moduloButton.TabIndex = 8;
			this.moduloButton.Text = "%";
			this.moduloButton.UseVisualStyleBackColor = true;
			this.moduloButton.Click += new System.EventHandler(this.operatorButton_Click);
			// 
			// nineButton
			// 
			this.nineButton.Location = new System.Drawing.Point(149, 155);
			this.nineButton.Name = "nineButton";
			this.nineButton.Size = new System.Drawing.Size(67, 48);
			this.nineButton.TabIndex = 7;
			this.nineButton.Text = "9";
			this.nineButton.UseVisualStyleBackColor = true;
			this.nineButton.Click += new System.EventHandler(this.numberButton_Click);
			// 
			// fourButton
			// 
			this.fourButton.Location = new System.Drawing.Point(2, 209);
			this.fourButton.Name = "fourButton";
			this.fourButton.Size = new System.Drawing.Size(64, 48);
			this.fourButton.TabIndex = 14;
			this.fourButton.Text = "4";
			this.fourButton.UseVisualStyleBackColor = true;
			this.fourButton.Click += new System.EventHandler(this.numberButton_Click);
			// 
			// fiveButton
			// 
			this.fiveButton.Location = new System.Drawing.Point(72, 209);
			this.fiveButton.Name = "fiveButton";
			this.fiveButton.Size = new System.Drawing.Size(71, 47);
			this.fiveButton.TabIndex = 13;
			this.fiveButton.Text = "5";
			this.fiveButton.UseVisualStyleBackColor = true;
			this.fiveButton.Click += new System.EventHandler(this.numberButton_Click);
			// 
			// sqrtButton
			// 
			this.sqrtButton.Location = new System.Drawing.Point(222, 209);
			this.sqrtButton.Name = "sqrtButton";
			this.sqrtButton.Size = new System.Drawing.Size(60, 48);
			this.sqrtButton.TabIndex = 12;
			this.sqrtButton.Text = "sqrt";
			this.sqrtButton.UseVisualStyleBackColor = true;
			this.sqrtButton.Click += new System.EventHandler(this.sqrtButton_Click);
			// 
			// sixButton
			// 
			this.sixButton.Location = new System.Drawing.Point(149, 209);
			this.sixButton.Name = "sixButton";
			this.sixButton.Size = new System.Drawing.Size(67, 48);
			this.sixButton.TabIndex = 11;
			this.sixButton.Text = "6";
			this.sixButton.UseVisualStyleBackColor = true;
			this.sixButton.Click += new System.EventHandler(this.numberButton_Click);
			// 
			// oneButton
			// 
			this.oneButton.Location = new System.Drawing.Point(2, 263);
			this.oneButton.Name = "oneButton";
			this.oneButton.Size = new System.Drawing.Size(64, 48);
			this.oneButton.TabIndex = 18;
			this.oneButton.Text = "1";
			this.oneButton.UseVisualStyleBackColor = true;
			this.oneButton.Click += new System.EventHandler(this.numberButton_Click);
			// 
			// twoButton
			// 
			this.twoButton.Location = new System.Drawing.Point(72, 263);
			this.twoButton.Name = "twoButton";
			this.twoButton.Size = new System.Drawing.Size(71, 47);
			this.twoButton.TabIndex = 17;
			this.twoButton.Text = "2";
			this.twoButton.UseVisualStyleBackColor = true;
			this.twoButton.Click += new System.EventHandler(this.numberButton_Click);
			// 
			// equalsButton
			// 
			this.equalsButton.Location = new System.Drawing.Point(222, 263);
			this.equalsButton.Name = "equalsButton";
			this.equalsButton.Size = new System.Drawing.Size(60, 102);
			this.equalsButton.TabIndex = 16;
			this.equalsButton.Text = "=";
			this.equalsButton.UseVisualStyleBackColor = true;
			this.equalsButton.Click += new System.EventHandler(this.equalsButton_Click);
			// 
			// threeButton
			// 
			this.threeButton.Location = new System.Drawing.Point(149, 263);
			this.threeButton.Name = "threeButton";
			this.threeButton.Size = new System.Drawing.Size(67, 48);
			this.threeButton.TabIndex = 15;
			this.threeButton.Text = "3";
			this.threeButton.UseVisualStyleBackColor = true;
			this.threeButton.Click += new System.EventHandler(this.numberButton_Click);
			// 
			// zeroButton
			// 
			this.zeroButton.Location = new System.Drawing.Point(2, 317);
			this.zeroButton.Name = "zeroButton";
			this.zeroButton.Size = new System.Drawing.Size(141, 48);
			this.zeroButton.TabIndex = 20;
			this.zeroButton.Text = "0";
			this.zeroButton.UseVisualStyleBackColor = true;
			this.zeroButton.Click += new System.EventHandler(this.numberButton_Click);
			// 
			// decimalButton
			// 
			this.decimalButton.Location = new System.Drawing.Point(149, 317);
			this.decimalButton.Name = "decimalButton";
			this.decimalButton.Size = new System.Drawing.Size(67, 48);
			this.decimalButton.TabIndex = 19;
			this.decimalButton.Text = ".";
			this.decimalButton.UseVisualStyleBackColor = true;
			this.decimalButton.Click += new System.EventHandler(this.decimalButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 369);
			this.Controls.Add(this.zeroButton);
			this.Controls.Add(this.decimalButton);
			this.Controls.Add(this.oneButton);
			this.Controls.Add(this.twoButton);
			this.Controls.Add(this.equalsButton);
			this.Controls.Add(this.threeButton);
			this.Controls.Add(this.fourButton);
			this.Controls.Add(this.fiveButton);
			this.Controls.Add(this.sqrtButton);
			this.Controls.Add(this.sixButton);
			this.Controls.Add(this.sevenButton);
			this.Controls.Add(this.eightButton);
			this.Controls.Add(this.moduloButton);
			this.Controls.Add(this.nineButton);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.subtractButton);
			this.Controls.Add(this.divideButton);
			this.Controls.Add(this.multiplyButton);
			this.Controls.Add(this.clearEntryButton);
			this.Controls.Add(this.clearButton);
			this.Controls.Add(this.textBox);
			this.Name = "Form1";
			this.Text = "Form1";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox;
		private System.Windows.Forms.Button clearButton;
		private System.Windows.Forms.Button clearEntryButton;
		private System.Windows.Forms.Button multiplyButton;
		private System.Windows.Forms.Button divideButton;
		private System.Windows.Forms.Button subtractButton;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.Button sevenButton;
		private System.Windows.Forms.Button eightButton;
		private System.Windows.Forms.Button moduloButton;
		private System.Windows.Forms.Button nineButton;
		private System.Windows.Forms.Button fourButton;
		private System.Windows.Forms.Button fiveButton;
		private System.Windows.Forms.Button sqrtButton;
		private System.Windows.Forms.Button sixButton;
		private System.Windows.Forms.Button oneButton;
		private System.Windows.Forms.Button twoButton;
		private System.Windows.Forms.Button equalsButton;
		private System.Windows.Forms.Button threeButton;
		private System.Windows.Forms.Button zeroButton;
		private System.Windows.Forms.Button decimalButton;
	}
}

