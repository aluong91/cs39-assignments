using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cs39_10_blackjack
{
	public partial class MainWindow : Form
	{
		public MainWindow()
		{
			InitializeComponent();
			Deck deck = new Deck();
			textBox1.Text += deck.ToString();
			deck.Shuffle();
			textBox1.Text += Environment.NewLine + deck.ToString();
		}
	}
}
