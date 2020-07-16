using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSProj
{
    class Game
    {
        //MEMBER VARIABLES (HAS A)

        //will need to turn RPSLS into a list per USER STORY

        public int rock;
        public int paper;
        public int scissors;
        public int lizard;
        public int spock;
        Random rng;
        public string playerInput;
        int playerOneScore;
        int playerTwoScore;
        int computerScore;

        //This class is where the battle will take place

        //CONSTRUCTOR (SPAWNS)
        public Game()
        {
            rock = 1;
            paper = 2;
            scissors = 3;
            lizard = 4;
            spock = 5;
            playerOneScore = 0;
            playerTwoScore = 0;
            computerScore = 0;
            rng = new Random();
    }

        //METHODS (CAN DO)

        public int ChooseRPSLS()
        {
            Console.WriteLine("Please choose between rock, paper, scissors, lizard, or spock: ");
            return int.Parse(Console.ReadLine());
        }

        public int ChooseForCPU()
        {
            int result = rng.Next()
            return result;
        }
        
        public void PlayRounds()
        {

            while (playerOneScore < 3 && playerTwoScore < 3)
            {
                ChooseRPSLS();
                int playerInput = 

            }
        }


    }
}
