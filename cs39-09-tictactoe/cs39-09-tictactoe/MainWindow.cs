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
			game = new Game();
			player1Shape = 'X';
			player2Shape = 'O';
		}

		private void button_Click(object sender, EventArgs e)
		{
			Button clicked = (Button)sender;

			// the buttons have their TabIndex ordered from 1-9
			// we can use this  to determine the row and column of the button
			int targetRow = clicked.TabIndex / 3;
			int targetColumn = clicked.TabIndex % 3;

			if (game.Move(targetRow, targetColumn)) {
				if (game.CurrentPlayer == 1)
					clicked.Text = player1Shape.ToString();
				else
					clicked.Text = player2Shape.ToString();
			}
		}

		private Game game;
		private char player1Shape, player2Shape;
	}
}
