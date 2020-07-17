using Microsoft.Win32;
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

        public Player playerOne;
        public Player playerTwo;

        public List<string> gestures;

        //This class is where the battle will take place

        //CONSTRUCTOR (SPAWNS)
        public Game()
        {
            playerOne = new Human();

        }

        //METHODS (CAN DO)

        public void CheckScores()
        {
            //this is the while loop that will check for scores

            while (playerOne.score < 3 && playerTwo.score < 3)
            {
                PlayRounds();
            }
        }

        public void DisplayRules()
        {
            Console.WriteLine("Welcome to Rock, Paper, and Scissos, Lizard and Spock... A classic game with a twist!");
        }
        public void ChooseOpponentType() 
        {

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
            else
            {
                Console.WriteLine("Try again. Choose between 1 or 2 players to start the game.");
            }
        }

        public void PlayRounds()
        {

            playerOne.ChooseGesture();
            playerTwo.ChooseGesture();

            if (playerOne.chosenGesture == "rock" && playerTwo.chosenGesture == "scissors")
            {
                Console.WriteLine("Great choice! Rock crushes scissors! You win a point.\n");
                playerOne.score++;
                DisplayScores();
            }

            else if(playerOne.chosenGesture == "rock" && playerTwo.chosenGesture == "lizard")
            {
                Console.WriteLine("Great choice! Rock crushes lizard! You win a point.\n");
                playerOne.score++;
                DisplayScores();
            }

            else if (playerOne.chosenGesture == "rock" && playerTwo.chosenGesture == "paper")
            {
                Console.WriteLine("Bummer! You loose. Paper covers rock! Player 2 wins a point.\n");
                playerTwo.score++;
                DisplayScores();
            }

            else if (playerOne.chosenGesture == "rock" && playerTwo.chosenGesture == "spock")
            {
                Console.WriteLine("Bummer! You loose. Spock vaporizes rock! Player 2 wins a point.\n");
                playerTwo.score++;
                DisplayScores();
            }

            else if (playerOne.chosenGesture == "rock" && playerTwo.chosenGesture == "rock")
            {
                Console.WriteLine("This is a tie! Try again!\n");
                PlayRounds();
                DisplayScores();
            }

            
        }

        public void DisplayScores()
        {
            Console.WriteLine("CURRENT SCORES ARE" + "Player 1: " + playerOne.score + " || " + playerTwo.score);

        }


        public void RunGame()
        {
            DisplayRules();
            ChooseOpponentType();
            PlayRounds();
            CheckScores();

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

            // put the loop method at the end
        }


    }
}
