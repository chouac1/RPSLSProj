using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_Project
{
    class Game
    {
        public Player playerOne;
        public Player playerTwo;

        public Game()
        {
            playerOne = new Human();
        }
        public void DisplayRules()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, and Spock... A classic game with a twist. This will be a best of 3.");
        }

        public void ChooseOpponentType()
        {
            var input = 0;

            while (input == 0)
            {
                Console.Write("Do you want 1 or 2 players? ");
                var chosenPlayers = Convert.ToInt32(Console.ReadLine());

                if (chosenPlayers == 1)
                {
                    playerTwo = new Computer();
                    input = chosenPlayers;
                }
                else if (chosenPlayers == 2)
                {
                    playerTwo = new Human();
                    input = chosenPlayers;
                }
                else
                    Console.WriteLine("Please choose between 1 or 2 players.");
                    chosenPlayers = input;
            }

            Console.WriteLine("You chose " + input + " player(s). Good luck!");

        }

        public void DisplayScores()
        {
            Console.WriteLine("Player 1's score is: " + playerOne.score + "\nPlayer 2's score is: " + playerTwo.score);
            if (playerOne.score == 3)
                Console.WriteLine("Player 1 is the champion!");
            else if (playerTwo.score == 3)
                Console.WriteLine("Player 2 is the champion!");
        }

        public void PlayRound()
        {
            playerOne.ChosenGesture();
            playerTwo.ChosenGesture();

            if (playerOne.chosenGesture == playerTwo.chosenGesture)
                Console.WriteLine("That was a close one! It was a tie! Try again.");
            else if (playerOne.chosenGesture == "rock" && playerTwo.chosenGesture == "scissors" || playerTwo.chosenGesture == "lizard")
            {
                Console.WriteLine("Player 1 has defeated Player 2.");
                playerOne.score++;
                DisplayScores();
            }
            else if (playerOne.chosenGesture == "scissors" && playerTwo.chosenGesture == "paper" || playerTwo.chosenGesture == "lizard")
            {
                Console.WriteLine("Player 1 has defeated Player 2.");
                playerOne.score++;
                DisplayScores();
            }
            else if (playerOne.chosenGesture == "paper" && playerTwo.chosenGesture == "rock" || playerTwo.chosenGesture == "spock")
            {
                Console.WriteLine("Player 1 has defeated Player 2.");
                playerOne.score++;
                DisplayScores();
            }
            else if (playerOne.chosenGesture == "lizard" && playerTwo.chosenGesture == "spock" || playerTwo.chosenGesture == "paper")
            {
                Console.WriteLine("Player 1 has defeated Player 2.");
                playerOne.score++;
                DisplayScores();
            }
            else if (playerOne.chosenGesture == "spock" && playerTwo.chosenGesture == "scissors" || playerTwo.chosenGesture == "rock")
            {
                Console.WriteLine("Player 1 has defeated Player 2.");
                playerOne.score++;
                DisplayScores();
            }
            else
            {
                Console.WriteLine("Player 2 has defeated Player 1.");
                playerTwo.score++;
                DisplayScores();
            }
        }

        public void PlayGame()
        {
            DisplayRules();
            ChooseOpponentType();
            while (playerOne.score < 3 && playerTwo.score < 3)
            {
                PlayRound();
            }
        }

    }
}
