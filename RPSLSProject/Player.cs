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

        public int rock;
        public int paper;
        public int scissors;
        public int lizard;
        public int spock;

        public string name;
        public string score;
        public string chooseGesture;

        //CONSTRUCTOR
        public Player()
        {
            rock = 1;
            paper = 2;
            scissors = 3;
            lizard = 4;
            spock = 5;
        }

        //MEMBER METHODS (CAN DO)

        public abstract void ChooseGesture();

    }
}
