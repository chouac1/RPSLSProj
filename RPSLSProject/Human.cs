using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSProj
{
    class Human : Player
    {
        //MEMBER VARIABLES (HAS A)

        //CONSTRUCTOR (SPAWNS)
        public Human()
        {

        }

        //METHODS (CAN DO)

        public override void ChooseGesture()
        {

            Console.WriteLine("Choose between rock, paper, scissors, lizard, or spock.");
            chosenGesture = Console.ReadLine();

            while (true)
            {
                if (chosenGesture == "rock")
                {

                    break;

                }
                else if (chosenGesture == "paper")
                {

                    break;

                }
                else if (chosenGesture == "scissors")
                {

                    break;

                }
                else if(chosenGesture == "lizard")
                {

                    break;

                }
                else if(chosenGesture == "spock")
                {

                    break;

                }
                else
                {
                    Console.WriteLine("Invalid choice! Please only pick between rock, paper, scissors, lizard, or spock (lower cases)\n");
                    ChooseGesture();
                }
            }

        }


    }
}
