using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSProj
{
    public abstract class Player
    {
        //MEMBER VARIABLES (HAS A)

        //Parent class of human and computer

        public string name;
        public int score;
        public string chosenGesture;

        public List<string> gestures;

        //CONSTRUCTOR
        public Player()
        {
            gestures = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };
            score = 0;
        }

        //MEMBER METHODS (CAN DO)

        public abstract void ChooseGesture();

    }
}
