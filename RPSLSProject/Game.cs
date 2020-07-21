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

        //public List<string> gestures;

        //This class is where the battle will take place

        //CONSTRUCTOR (SPAWNS)
        public Game()
        {
            playerOne = new Human();

        }

        //METHODS (CAN DO)

        public void DisplayRules()

        //how to reloop so the player can reinput their choices? Will need to revist loops slideshows and ask instructor.

        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, and Spock... A classic game with a twist! This game will be a best of 3.");
        }
        public void ChooseOpponentType()
        {

            Console.WriteLine("Do you want 1 player or 2 players?");
            string input = Console.ReadLine();

            if (input == "1")
            {
                playerTwo = new Computer();
            }
            else if (input == "2")
            {
                playerTwo = new Human();
            }
            else
            {
                Console.WriteLine("Try again. Choose between 1 or 2 players to start the game.");
                ChooseOpponentType();
            }


        }

        public void PlayRound()

        {

            Console.WriteLine("Player 1:");
            playerOne.ChooseGesture();
            Console.WriteLine("Player 2:");
            playerTwo.ChooseGesture();


            // ------------------------------- ROCK VS. GESTURES
            if (playerOne.chosenGesture == "rock" && playerTwo.chosenGesture == "scissors")
            {
                Console.WriteLine("Great choice! Rock crushes scissors! You win a point.\n");
                playerOne.score++;
                DisplayScores();
            }

            else if (playerOne.chosenGesture == "rock" && playerTwo.chosenGesture == "lizard")
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
                DisplayScores();
            }

            // ------------------------------- PAPER VS. GESTURES

            if (playerOne.chosenGesture == "paper" && playerTwo.chosenGesture == "rock")
            {
                Console.WriteLine("Great choice! paper covers rock! You win a point.\n");
                playerOne.score++;
                DisplayScores();
            }

            else if (playerOne.chosenGesture == "paper" && playerTwo.chosenGesture == "spock")
            {
                Console.WriteLine("Great choice! paper disproves spock! You win a point.\n");
                playerOne.score++;
                DisplayScores();
            }

            else if (playerOne.chosenGesture == "paper" && playerTwo.chosenGesture == "scissors")
            {
                Console.WriteLine("Bummer! scissors cuts paper! Player 2 wins a point.\n");
                playerTwo.score++;
                DisplayScores();
            }

            else if (playerOne.chosenGesture == "paper" && playerTwo.chosenGesture == "Lizard")
            {
                Console.WriteLine("Bummer! lizard eats paper! Player 2 wins a point.\n");
                playerTwo.score++;
                DisplayScores();
            }

            else if (playerOne.chosenGesture == "paper" && playerTwo.chosenGesture == "paper")
            {
                Console.WriteLine("It's a TIE! Try again!.\n");
                DisplayScores();

            }

            // ------------------------------- SCISSORS VS. GESTURES

            else if (playerOne.chosenGesture == "scissors" && playerTwo.chosenGesture == "paper")
            {
                Console.WriteLine("Great choice! scissors cuts paper! You win a point.\n");
                playerOne.score++;
                DisplayScores();
            }

            else if (playerOne.chosenGesture == "scissors" && playerTwo.chosenGesture == "lizard")
            {
                Console.WriteLine("Great choice! scissors decapitates lizard! You win a point.\n");
                playerOne.score++;
                DisplayScores();
            }

            else if (playerOne.chosenGesture == "scissors" && playerTwo.chosenGesture == "spock")
            {
                Console.WriteLine("Bummer! spock smashes scissors! Player 2 wins a point.\n");
                playerTwo.score++;
                DisplayScores();
            }

            else if (playerOne.chosenGesture == "scissors" && playerTwo.chosenGesture == "rock")
            {
                Console.WriteLine("Bummer! rock smashes scissors! Player 2 wins a point.\n");
                playerTwo.score++;
                DisplayScores();
            }

            else if (playerOne.chosenGesture == "scissors" && playerTwo.chosenGesture == "scissors")
            {
                Console.WriteLine("It's a TIE! Try again!\n");
                DisplayScores();
            }
            // ------------------------------- LIZARD VS. GESTURES

            else if (playerOne.chosenGesture == "lizard" && playerTwo.chosenGesture == "paper")
            {
                Console.WriteLine("Great choice! lizard eats paper! You win a point.\n");
                playerOne.score++;
                DisplayScores();
            }

            else if (playerOne.chosenGesture == "lizard" && playerTwo.chosenGesture == "lizard")
            {
                Console.WriteLine("It's a TIE! Try again! \n");
                DisplayScores();
            }

            else if (playerOne.chosenGesture == "lizard" && playerTwo.chosenGesture == "spock")
            {
                Console.WriteLine("Great choice! lizard poisons spock! You win a point.\n");
                playerOne.score++;
                DisplayScores();
            }

            else if (playerOne.chosenGesture == "lizard" && playerTwo.chosenGesture == "rock")
            {
                Console.WriteLine("Bummer! rock crushes lizard! Player 2 wins a point.\n");
                playerTwo.score++;
                DisplayScores();
            }

            else if (playerOne.chosenGesture == "lizard" && playerTwo.chosenGesture == "scissors")
            {
                Console.WriteLine("Bummer! scissors decapitates lizard. Player 2 wins a point.\n");
                playerTwo.score++;
                DisplayScores();
            }

                // ------------------------------- SPOCK VS. GESTURES

            if (playerOne.chosenGesture == "spock" && playerTwo.chosenGesture == "paper")
            {
                Console.WriteLine("Bummer! paper disproves spock! Player 2 wins a point.\n");
                playerTwo.score++;
                DisplayScores();
            }

            else if (playerOne.chosenGesture == "spock" && playerTwo.chosenGesture == "lizard")
            {
                Console.WriteLine("Bummer! lizard poisons spock! Player 2 wins a point.\n");
                playerTwo.score++;
                DisplayScores();
            }

            else if (playerOne.chosenGesture == "spock" && playerTwo.chosenGesture == "spock")
            {
                Console.WriteLine("It's a TIE! Try again.\n");
                DisplayScores();
            }

            else if (playerOne.chosenGesture == "spock" && playerTwo.chosenGesture == "rock")
            {
                Console.WriteLine("Great choice! spock vaporizes rock! You win a point!\n");
                playerOne.score++;
                DisplayScores();
            }

            else if (playerOne.chosenGesture == "spock" && playerTwo.chosenGesture == "scissors")
            {
                Console.WriteLine("Great choice! spock smashes scissors! You win a point!\n");
                playerOne.score++;
                DisplayScores();
            }


        }
        

        public void PlayGame()
        {
            //this is the while loop that will check for scores to see if the game can continue

           
            while (true)
            {
                if (playerOne.score == 3 || playerTwo.score == 3)
                {
                  
                    break;

                }

                PlayRound();
                            
            }

        }

    public void DisplayScores()
        {
            Console.WriteLine("CURRENT SCORES\n" + "Player 1:  " + playerOne.score + " || " + "Player 2:  " + playerTwo.score + "\n");

        }

        public void DeclareAChampion()
        {
            if (playerOne.score == 3)
            {
                Console.WriteLine("Player 1 is the victor!");
            }
            else if (playerTwo.score == 3)
            {
                Console.WriteLine("Player 2 is the victor!");
            }

            Console.ReadLine();
        }


        public void RunGame()
        {
            DisplayRules();
            ChooseOpponentType();
            PlayGame();
            DeclareAChampion();

        }


    }
}

