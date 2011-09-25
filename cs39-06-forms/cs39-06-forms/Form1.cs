using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cs39_06_forms
{
	public partial class Form1 : Form
	{
		private enum op { equals, add, subtract, multiply, divide, modulo }
		private int mode = (int)op.equals;
		private bool shouldOverwrite = true;		// clear the textbox when entering a new operand
		private double operand = 0.0;

		public Form1()
		{
			InitializeComponent();
		}

		private void ClearButton_Click(object sender, EventArgs e)
		{
			textBox.Text = "0";
			mode = (int)op.equals;
			operand = 0.0;
			shouldOverwrite = true;
		}

		private void decimalButton_Click(object sender, EventArgs e)
		{
			if (!textBox.Text.Contains('.'))
				textBox.Text += '.';
		}

		private void textBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void numberButton_Click(object sender, EventArgs e)
		{
			Button clickedButton = (Button)sender;
			string number = clickedButton.Text;

			inputNumber(number);
		}

		private void inputNumber(string number)
		{
			if (shouldOverwrite)
				textBox.Text = number;
			else
				textBox.Text += number;
			shouldOverwrite = false;
		}

		private void operatorButton_Click(object sender, EventArgs e)
		{
			// evaluate the expression before reading in a new operand
			if (mode != (int)op.equals)
				evaluate();
			double.TryParse(textBox.Text, out operand);

			Button buttonClicked = (Button)sender;
			setMode(buttonClicked.Text);

			shouldOverwrite = true;
		}

		private void setMode(string newMode)
		{
			switch (newMode)
			{
				case "+":
					mode = (int)op.add;
					break;
				case "-":
					mode = (int)op.subtract;
					break;
				case "*":
					mode = (int)op.multiply;
					break;
				case "/":
					mode = (int)op.divide;
					break;
				case "%":
					mode = (int)op.modulo;
					break;
			}
		}

		// sqrt gets its own event function because it only takes 1 operand
		private void sqrtButton_Click(object sender, EventArgs e)
		{
			double.TryParse(textBox.Text, out operand);
			textBox.Text = Math.Sqrt(operand).ToString();
		}

		private void equalsButton_Click(object sender, EventArgs e)
		{
			evaluate();
		}

		private void evaluate()
		{
			double otherOperand;
			double.TryParse(textBox.Text, out otherOperand);

			switch (mode)
			{
				case (int)op.add:
					textBox.Text = (operand + otherOperand).ToString();
					break;
				case (int)op.subtract:
					textBox.Text = (operand - otherOperand).ToString();
					break;
				case (int)op.multiply:
					textBox.Text = (operand * otherOperand).ToString();
					break;
				case (int)op.divide:
					textBox.Text = (operand / otherOperand).ToString();
					break;
				case (int)op.modulo:
					textBox.Text = (operand % otherOperand).ToString();
					break;
				case (int)op.equals:
					textBox.Text = operand.ToString();
					break;
			}

			mode = (int)op.equals;
		}

		private void clearEntryButton_Click(object sender, EventArgs e)
		{
			textBox.Text = "0";
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			Keys key = (Keys)sender;
			switch (key.ToString()) {
				case "k":
					evaluate();
					break;
			}
		}
	}
}
