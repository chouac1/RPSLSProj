using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSProj
{
    class Program
    {
        static void Main(string[] args)
        {

            //PLANNING: Create different classes (human--maybe inherit to AI and player2 class, game==to battlefield from RVD), if statements
            //to achieve which variable (RPS) beats the other, 

            Game game = new Game();
            game.PlayRounds();

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

            //Classes
            //Player (parent class, maybe putting gestures inside this class??)
            //Computer (subclass of player)
            //human (subclass of player)
            //Game

          


        }
    }
}
