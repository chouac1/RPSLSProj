using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_Project
{
    class Human : Player
    {
        public Human()
        {

        }
        public override void ChosenGesture()
        {
            var isRightChoice = true;

            while (isRightChoice)
            {
                Console.Write("Please choose between rock, paper, scissors, lizard, or spock: ");
                var input = Console.ReadLine().ToLower();
                foreach (var item in gestures)
                {
                    if (item == input)
                    {
                        chosenGesture = input;
                        isRightChoice = false;
                        break;
                    }
                }
            }

            Console.WriteLine("You choose: " + chosenGesture);
        }
    }
}
