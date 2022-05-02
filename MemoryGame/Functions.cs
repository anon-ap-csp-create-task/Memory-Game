using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace MemoryGame
{
    public class Functions
    {

        // Starts the game
        public void startGame()
        {
            Data.GameInProgress = true;
            Data.pattern.Clear();
            Data.userPattern.Clear();

            MainApp.panel.Invoke(new MethodInvoker(delegate()
            {
                MainApp.panel.updateScoreDisplay();
                MainApp.panel.startGame();
            }));

            MainApp.gs.Invoke(new MethodInvoker(delegate ()
            {
                MainApp.gs.generateColor(ref Data.pattern, ref Data.userPattern);
            }));
        }

        
        private List<Color> tempColors = new List<Color>(); // Temporarily stores user input
        // Function to handle button inputs
        public void handleInput(Color btnColor)
        {
            // If there is no game in progress, return and execute nothing
            if (!Data.GameInProgress) return;


            tempColors.Add(btnColor);
            if (Data.pattern.Count != tempColors.Count) return; // If the user has not entered enough inputs, return.

            // Add last user input to list
            Data.userPattern.Add(btnColor); 
            // Continue to verify if user entered correct sequence
            if (Data.pattern.SequenceEqual(Data.userPattern))
            {
                Data.GameInProgress = true;
                tempColors.Clear();

                // Update scores
                Data.score = Data.userPattern.Count;
                MainApp.panel.Invoke(new MethodInvoker(delegate()
                {
                    MainApp.panel.updateScoreDisplay();
                }));


                // Continue the game
                MainApp.gs.Invoke(new MethodInvoker(delegate()
                {
                    MainApp.gs.generateColor(ref Data.pattern, ref Data.userPattern);
                }));
            }
            else
            {
                Data.GameInProgress = false;
                tempColors.Clear();

                endGame();
            }
        }

        public void endGame()
        {
            // If score is greater than best score, update best score to score
            if (Data.score > Data.bestScore) Data.bestScore = Data.score;
            MainApp.panel.Invoke(new MethodInvoker(delegate ()
            {
                MainApp.panel.updateScoreDisplay();
                MainApp.panel.endGame();
            }));

            Data.pattern.Clear();
            Data.score = 0;
        }

    }
}
