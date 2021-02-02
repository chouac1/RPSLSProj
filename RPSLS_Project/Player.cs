using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_Project
{
    public abstract class Player
    {
        //member variables

        public string name;
        public int score;
        public string chosenGesture;
        public List<string> gestures;
        //constructor
        public Player()
        {
            gestures = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };
            score = 0;
        }

        //member methods
        public abstract void ChosenGesture();
    }
}
