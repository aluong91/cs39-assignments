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
			SetPlayerNames();
			NewGame();
		}

		private void SetPlayerNames()
		{
			player1Name = player1NameBox.Text;
			player2Name = player2NameBox.Text;
		}

		private void NewGame()
		{
			Callback cb = new Callback(this.UpdateScoreboard);
			game = new Game(cb);
			opponent = new AI(game);
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

		// this gets called after every game move
		private void UpdateScoreboard()
		{
			rolledValue.Text = game.Dice.Value.ToString();
			turnScore.Text = game.TurnScore.ToString();

			int Player1Score = game.Player1Score;
			int Player2Score = game.Player2Score;
			player1Score.Text = Player1Score.ToString();
			player2Score.Text = Player2Score.ToString();

			if (Player1Score >= maxScore || Player2Score >= maxScore) {
				timer1.Enabled = false;
				MessageBox.Show(currentPlayerBox.Text + " has won the game");
				NewGame();
			}

			if (game.CurrentPlayer == 1)
				currentPlayerBox.Text = player1Name;
			else
				currentPlayerBox.Text = player2Name;

			if (game.CurrentPlayer == 2 && isFacingAI)
				StartAI();
			else
				StopAI();
		}

		private void StopAI()
		{
			timer1.Enabled = false;
			button1.Enabled = true;
			button2.Enabled = true;
		}

		private void StartAI()
		{
			timer1.Enabled = true;
			button1.Enabled = false;
			button2.Enabled = false;
		}

		private void newGameToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			NewGame();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			opponent.Go();
		}

		private void toolStripMenuItem2_Click(object sender, EventArgs e)
		{
			isFacingAI = true;
		}

		private void toolStripMenuItem3_Click(object sender, EventArgs e)
		{
			isFacingAI = false;
		}

		private void playerNameBox_TextChanged(object sender, EventArgs e)
		{
			player1Name = player1NameBox.Text;
			player2Name = player2NameBox.Text;
			UpdateScoreboard();
		}

		private Game game;
		private AI opponent;

		private string player1Name;
		private string player2Name;

		private bool isFacingAI = true;
		private int maxScore = 100;
	}
}
