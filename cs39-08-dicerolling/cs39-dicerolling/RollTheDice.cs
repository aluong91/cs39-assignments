using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cs39_dicerolling
{
	public partial class RollTheDice : Form
	{
		public RollTheDice()
		{
			InitializeComponent();
			NewGame();
		}

		private void NewGame()
		{
			Callback cb = new Callback(this.UpdateScoreboard);
			game = new Game(cb);

			DialogResult result = MessageBox.Show("Play against an AI opponent?", "Use AI", MessageBoxButtons.YesNo);
			if (result == DialogResult.Yes) {
				isFacingAI = true;
				opponent = new AI(game);
			} else
				isFacingAI = false;
			UpdateScoreboard();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			game.Roll();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			game.Stand();
		}

		private void UpdateScoreboard()
		{
			rolledValue.Text = game.Dice.Value.ToString();
			turnScore.Text = game.TurnScore.ToString();

			int Player1Score = game.Player1Score;
			int Player2Score = game.Player2Score;
			player1Score.Text = Player1Score.ToString();
			player2Score.Text = Player2Score.ToString();

			if (Player1Score >= maxScore || Player2Score >= maxScore) {
				MessageBox.Show("Player " + game.CurrentPlayer + " has won the game");
				NewGame();
			}

			currentPlayerBox.Text = "Player " + game.CurrentPlayer;
		}

		private void newGameToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			NewGame();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void currentPlayerBox_TextChanged(object sender, EventArgs e)
		{
			if (currentPlayerBox.Text == "Player 2" && isFacingAI)
				opponent.Go();
		}

		private Game game;
		private int maxScore = 100;
		private bool isFacingAI;
		private AI opponent;
	}
}
