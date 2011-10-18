using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cs39_09_tictactoe
{
	public partial class MainWindow : Form
	{
		public MainWindow()
		{
			InitializeComponent();
			firstPlayer = 1;
			player1Shape = 'X';
			player2Shape = 'O';
			player1Name = toolStripTextBox1.Text;
			player2Name = toolStripTextBox2.Text;
			toolStripComboBox2.SelectedIndex = 0;
			NewGame();
		}

		private void NewGame()
		{
			game = new Game(firstPlayer);
			if (firstPlayer == 1)
				toolStripStatusLabel1.Text = player1Name + "(" + player1Shape + ") goes first";
			else
				toolStripStatusLabel1.Text = player2Name + "(" + player2Shape + ") goes first";
			foreach (Control control in this.Controls)
			{
				if (control.GetType() == typeof(Button))
				{
					Button button = (Button)control;
					button.Text = string.Empty;
				}
			}
		}

		private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			NewGame();
		}

		private void toolStripTextBox_TextChanged(object sender, EventArgs e)
		{
			player1Name = toolStripTextBox1.Text;
			player2Name = toolStripTextBox2.Text;
		}

		private void button_Click(object sender, EventArgs e)
		{
			if (game.HasWinner)
				return;

			toolStripStatusLabel1.Text = String.Empty;
			Button clicked = (Button)sender;

			// the buttons have their TabIndex ordered from 0-8
			// we can use this  to determine the row and column of the button
			int targetRow = clicked.TabIndex / 3;
			int targetColumn = clicked.TabIndex % 3;

			if (game.Move(targetRow, targetColumn)) {
				if (game.CurrentPlayer == 2)
					clicked.Text = player1Shape.ToString();
				else
					clicked.Text = player2Shape.ToString();
			}

			if (game.HasWinner)
			{
				if (game.CurrentPlayer == 2)
					toolStripStatusLabel1.Text = player1Name + "(" + player1Shape + ") has won the game!";
				else
					toolStripStatusLabel1.Text = player2Name + "(" + player2Shape + ") has won the game!";
			}
		}

		private void xToolStripMenuItem_Click(object sender, EventArgs e)
		{
			char temp = player1Shape;
			player1Shape = player2Shape;
			player2Shape = temp;

			foreach (Control control in this.Controls)
			{
				if (control.GetType() == typeof(Button))
				{
					Button button = (Button)control;
					if (button.Text == player1Shape.ToString())
						button.Text = player2Shape.ToString();
					else if (button.Text == player2Shape.ToString())
						button.Text = player1Shape.ToString();
				}
			}
		}

		private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (toolStripComboBox2.SelectedIndex == 0)
				firstPlayer = 1;
			else
				firstPlayer = 2;
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private Game game;
		private char player1Shape, player2Shape;
		private string player1Name, player2Name;
		private int firstPlayer;
	}
}
