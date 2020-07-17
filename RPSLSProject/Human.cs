using System;
using System.Collections.Generic;
using System.Linq;
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
            Console.WriteLine("Choose between rock, paper, scissors, lizard, or spock." ); 
            chosenGesture = Console.ReadLine();

        }


    }
}
