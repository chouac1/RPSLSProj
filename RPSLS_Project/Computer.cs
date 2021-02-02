using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_Project
{
    class Computer : Player
    {
        Random random;
        public Computer()
        {
            random = new Random();
        }
        public override void ChosenGesture()
        {
            var randomNumber = random.Next(0, gestures.Count);
            chosenGesture = gestures[randomNumber];
            Console.WriteLine("Player two has chosen: " + chosenGesture);
        }

    }
}
