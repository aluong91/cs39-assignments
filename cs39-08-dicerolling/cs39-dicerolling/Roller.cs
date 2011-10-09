using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cs39_dicerolling
{
    class Roller
    {
        public Roller(int lower, int upper)
        {
            Lower = lower;
            Upper = upper;
        }

        public void Roll()
        {
            Value = rand.Next(Upper - Lower) + Lower;
        }

        public int Lower { get; set; }
        public int Upper { get; set; }
        public int Value { get; private set; }

        private Random rand = new Random();
    }
}