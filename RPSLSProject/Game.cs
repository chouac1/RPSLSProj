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

        //will need to turn RPSLS into a list per USER STORY, possibly even put inside the Human class

        Random rng;
        public string playerInput;
        int playerOneScore;
        int playerTwoScore;
        int computerScore;
        public Player playerOne;
        public Computer computerPlayer;

        public List<string> gestures;

        //This class is where the battle will take place

        //CONSTRUCTOR (SPAWNS)
        public Game()
        {

            playerOneScore = 0;
            playerTwoScore = 0;
            computerScore = 0;
            rng = new Random();
            playerOne = new Human();
            playerTwo = 
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

        public void DisplayRules()
        {
            // display the rules of the game
        }
        public void ChooseOpponentType() 
        {
            // if-else/if statement to decide opponent
            // grab user input
            // instantiate playerTwo as a human or computer

            Console.WriteLine("Do you want 1 player or 2 players?");
            string input = Console.ReadLine();
            if (input == "1")
            {
                playerTwo = new Computer();
            }
            else if(input == "2")
            {
                playerTwo = new Human();
            }
        }

        public void RunGame()
        {
            // Welcome/Setup --- MVP (Minimal Viable Project) 
            // 1. Display rules to user 
            // 2. Prompt the user to choose 1 or 2 players
            // 3. Ask players for their names (optional)

            // A round of play ---
            // 4. Display the options
            // 5. Prompt user to choose a gesture
            // 6. display gesture options for p2
            // 7. have player 2 choose gestures
            // 8. compare the gestures of the players
            // 9. give a point to winner of the round
            // 10. Check to see if anyone has enough points to win (do-while loop??)

            // 11. Loop back on round 4-9

            // Conclusion
            // 12. display the winner

            DisplayRules();
            ChooseOpponentType();
            // put the loop method at the end
        }


    }
}
