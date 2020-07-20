using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSProj
{
    class Computer : Player
    {
        //MEMBER VARIABLES (HAS A)

        Random rand;


        //CONSTRUCTOR
        public Computer()
        {
            rand = new Random();
        }

        //MEMBER METHODS (CAN DO)

        public override void ChooseGesture()
        {
            int randomNumber = rand.Next(0, gestures.Count);

            chosenGesture = gestures[randomNumber];

            Console.WriteLine("The computer has chosen: " + chosenGesture);


        }
    }
}
