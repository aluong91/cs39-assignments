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
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.moduloButton = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.sqrtButton = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.equalsButton = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button0 = new System.Windows.Forms.Button();
			this.decimalButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox
			// 
			this.textBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox.Location = new System.Drawing.Point(12, 11);
			this.textBox.Name = "textBox";
			this.textBox.Size = new System.Drawing.Size(306, 26);
			this.textBox.TabIndex = 0;
			this.textBox.Text = "0";
			this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
			this.textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
			// 
			// clearButton
			// 
			this.clearButton.Location = new System.Drawing.Point(170, 44);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(74, 51);
			this.clearButton.TabIndex = 1;
			this.clearButton.Text = "C";
			this.clearButton.UseVisualStyleBackColor = true;
			this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
			// 
			// clearEntryButton
			// 
			this.clearEntryButton.Location = new System.Drawing.Point(250, 44);
			this.clearEntryButton.Name = "clearEntryButton";
			this.clearEntryButton.Size = new System.Drawing.Size(68, 50);
			this.clearEntryButton.TabIndex = 2;
			this.clearEntryButton.Text = "CE";
			this.clearEntryButton.UseVisualStyleBackColor = true;
			this.clearEntryButton.Click += new System.EventHandler(this.clearEntryButton_Click);
			// 
			// multiplyButton
			// 
			this.multiplyButton.Location = new System.Drawing.Point(170, 102);
			this.multiplyButton.Name = "multiplyButton";
			this.multiplyButton.Size = new System.Drawing.Size(74, 48);
			this.multiplyButton.TabIndex = 3;
			this.multiplyButton.Text = "*";
			this.multiplyButton.UseVisualStyleBackColor = true;
			this.multiplyButton.Click += new System.EventHandler(this.operatorButton_Click);
			// 
			// divideButton
			// 
			this.divideButton.Location = new System.Drawing.Point(250, 100);
			this.divideButton.Name = "divideButton";
			this.divideButton.Size = new System.Drawing.Size(68, 48);
			this.divideButton.TabIndex = 4;
			this.divideButton.Text = "/";
			this.divideButton.UseVisualStyleBackColor = true;
			this.divideButton.Click += new System.EventHandler(this.operatorButton_Click);
			// 
			// subtractButton
			// 
			this.subtractButton.Location = new System.Drawing.Point(93, 102);
			this.subtractButton.Name = "subtractButton";
			this.subtractButton.Size = new System.Drawing.Size(71, 47);
			this.subtractButton.TabIndex = 5;
			this.subtractButton.Text = "-";
			this.subtractButton.UseVisualStyleBackColor = true;
			this.subtractButton.Click += new System.EventHandler(this.operatorButton_Click);
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(12, 101);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(75, 48);
			this.addButton.TabIndex = 6;
			this.addButton.Text = "+";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.operatorButton_Click);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(12, 155);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(75, 48);
			this.button7.TabIndex = 10;
			this.button7.Text = "7";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.numberButton_Click);
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(93, 156);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(71, 47);
			this.button8.TabIndex = 9;
			this.button8.Text = "8";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.numberButton_Click);
			// 
			// moduloButton
			// 
			this.moduloButton.Location = new System.Drawing.Point(250, 155);
			this.moduloButton.Name = "moduloButton";
			this.moduloButton.Size = new System.Drawing.Size(68, 48);
			this.moduloButton.TabIndex = 8;
			this.moduloButton.Text = "%";
			this.moduloButton.UseVisualStyleBackColor = true;
			this.moduloButton.Click += new System.EventHandler(this.operatorButton_Click);
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(170, 155);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(74, 48);
			this.button9.TabIndex = 7;
			this.button9.Text = "9";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.numberButton_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(12, 210);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 48);
			this.button4.TabIndex = 14;
			this.button4.Text = "4";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.numberButton_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(93, 210);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(71, 47);
			this.button5.TabIndex = 13;
			this.button5.Text = "5";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.numberButton_Click);
			// 
			// sqrtButton
			// 
			this.sqrtButton.Location = new System.Drawing.Point(250, 209);
			this.sqrtButton.Name = "sqrtButton";
			this.sqrtButton.Size = new System.Drawing.Size(68, 48);
			this.sqrtButton.TabIndex = 12;
			this.sqrtButton.Text = "sqrt";
			this.sqrtButton.UseVisualStyleBackColor = true;
			this.sqrtButton.Click += new System.EventHandler(this.sqrtButton_Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(170, 209);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(74, 48);
			this.button6.TabIndex = 11;
			this.button6.Text = "6";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.numberButton_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 263);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 48);
			this.button1.TabIndex = 18;
			this.button1.Text = "1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.numberButton_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(93, 263);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(71, 47);
			this.button2.TabIndex = 17;
			this.button2.Text = "2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.numberButton_Click);
			// 
			// equalsButton
			// 
			this.equalsButton.Location = new System.Drawing.Point(250, 263);
			this.equalsButton.Name = "equalsButton";
			this.equalsButton.Size = new System.Drawing.Size(68, 102);
			this.equalsButton.TabIndex = 16;
			this.equalsButton.Text = "=";
			this.equalsButton.UseVisualStyleBackColor = true;
			this.equalsButton.Click += new System.EventHandler(this.equalsButton_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(170, 263);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(74, 48);
			this.button3.TabIndex = 15;
			this.button3.Text = "3";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.numberButton_Click);
			// 
			// button0
			// 
			this.button0.Location = new System.Drawing.Point(12, 317);
			this.button0.Name = "button0";
			this.button0.Size = new System.Drawing.Size(152, 48);
			this.button0.TabIndex = 20;
			this.button0.Text = "0";
			this.button0.UseVisualStyleBackColor = true;
			this.button0.Click += new System.EventHandler(this.numberButton_Click);
			// 
			// decimalButton
			// 
			this.decimalButton.Location = new System.Drawing.Point(170, 317);
			this.decimalButton.Name = "decimalButton";
			this.decimalButton.Size = new System.Drawing.Size(74, 48);
			this.decimalButton.TabIndex = 19;
			this.decimalButton.Text = ".";
			this.decimalButton.UseVisualStyleBackColor = true;
			this.decimalButton.Click += new System.EventHandler(this.numberButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(330, 369);
			this.Controls.Add(this.button0);
			this.Controls.Add(this.decimalButton);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.equalsButton);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.sqrtButton);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.moduloButton);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.subtractButton);
			this.Controls.Add(this.divideButton);
			this.Controls.Add(this.multiplyButton);
			this.Controls.Add(this.clearEntryButton);
			this.Controls.Add(this.clearButton);
			this.Controls.Add(this.textBox);
			this.KeyPreview = true;
			this.Name = "Form1";
			this.Text = "The World\'s Most Beautiful Calculator";
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
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
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button moduloButton;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button sqrtButton;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button equalsButton;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button0;
		private System.Windows.Forms.Button decimalButton;
	}
}

