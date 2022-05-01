using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class GameScreen : Form
    {
        public GameScreen()
        {
            InitializeComponent();
        }

        // Game screen loading
        private void GameScreen_Load(object sender, EventArgs e)
        {
            // Anchor buttons to appropriate side
            redBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            yelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            blueBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            updateBtns();
        }

        // Callback function to update buttons
        private void GameScreen_SizeChanged(object sender, EventArgs e)
        {
            updateBtns();
        }

        // Size buttons according to the size
        private void updateBtns()
        {
            // Resize green button
            greenBtn.Location = new Point(0, 0);
            greenBtn.Width = this.Width / 2 - 10;
            greenBtn.Height = this.Height / 2 - 10; // Compensate for some unidentical buttons (unspecified reason)

            redBtn.Location = new Point(this.Width / 2 - 10, 0);
            redBtn.Width = this.Width / 2;
            redBtn.Height = this.Height / 2 - 10;

            yelBtn.Location = new Point(0, this.Height / 2 - 10);
            yelBtn.Width = this.Width / 2 - 10;
            yelBtn.Height = this.Height / 2 - 10;
                
            blueBtn.Location = new Point(this.Width / 2 - 10, this.Height / 2 - 10);
            blueBtn.Width = this.Width / 2;
            blueBtn.Height = this.Height / 2 - 10;
        }

        // Prevent form from moving outside the boundaries of the parent window
        private void gameScreen_Move(object sender, EventArgs e)
        {
            if (this.Left < 0)
            {
                this.Left = 0;
            }

            else if (this.Left > this.MdiParent.ClientRectangle.Width - this.Width)
            {
                this.Left = this.MdiParent.ClientRectangle.Width - this.Width - 5;
            }

            if (this.Top < 0)
            {
                this.Top = 0;
            }

            else if (this.Top > this.MdiParent.ClientRectangle.Height - this.Height)
            {
                this.Top = this.MdiParent.ClientRectangle.Height - this.Height - 30;
            }
        }

        // Form closing event
        private void GameScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            // If game is still running, prompt the user
            if (!Data.GameInProgress) return;
            // Check to see if the user wants to continue the game
            if (MessageBox.Show(
                    "A game is still in progress!\nDo you wish to leave the game and lose unsaved progress?",
                    "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) != DialogResult.No) return;
            e.Cancel = true;
        }



        /// <summary>
        /// Handle events for when the buttons are clicked
        /// Calls the handleInput function to confirm user entered pattern correctly.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private Functions func = new Functions();
        private void greenBtn_Click(object sender, EventArgs e)
        {
            Thread.Sleep(100);
            func.handleInput(Data.greenColor);
        }
        private void redBtn_Click(object sender, EventArgs e)
        {
            Thread.Sleep(100);
            func.handleInput(Data.redColor);
        }
        private void yelBtn_Click(object sender, EventArgs e)
        {
            Thread.Sleep(100);
            func.handleInput(Data.yellowColor);
        }
        private void blueBtn_Click(object sender, EventArgs e)
        {
            Thread.Sleep(100);
            func.handleInput(Data.blueColor);
        }

        
        /// <summary>
        /// Generate random color and append to list
        /// </summary>
        /// <param name="pattern"></param>
        /// <param name="userPattern"></param>
        public void generateColor(ref List<Color> pattern, ref List<Color> userPattern)
        {
            Color[] colors =
                {Data.greenColor, Data.redColor, Data.yellowColor, Data.blueColor};

            Random rdm = new Random();
            switch (rdm.Next(4))
            {
                case 0:
                    pattern.Add(colors[0]);
                    break;
                case 1:
                    pattern.Add(colors[1]);
                    break;
                case 2:
                    pattern.Add(colors[2]);
                    break;
                case 3:
                    pattern.Add(colors[3]);
                    break;
            }

            // Change color to white
            foreach (Button btn in new[] { greenBtn, redBtn, yelBtn, blueBtn })
            {
                btn.BackColor = Color.White;
                btn.Update();
            }


            // Disallow user input
            input_allowed(false);

            // Display the color pattern to the user
            foreach (Color col in pattern)
            {
                if (col == colors[0])  // Green button
                {
                    greenBtn.BackColor = colors[0];
                    greenBtn.Update();
                    Thread.Sleep(1000);

                    greenBtn.BackColor = Color.White;
                    greenBtn.Update();
                    Thread.Sleep(1000);
                }
                else if (col == colors[1]) // Red button
                {
                    redBtn.BackColor = colors[1];
                    redBtn.Update();
                    Thread.Sleep(1000);

                    redBtn.BackColor = Color.White;
                    redBtn.Update();
                    Thread.Sleep(1000);
                }
                else if (col == colors[2]) // Yellow button
                {
                    yelBtn.BackColor = colors[2];
                    yelBtn.Update();
                    Thread.Sleep(1000);

                    yelBtn.BackColor = Color.White;
                    yelBtn.Update();
                    Thread.Sleep(1000);
                }
                else if (col == colors[3]) // Blue button
                {
                    blueBtn.BackColor = colors[3];
                    blueBtn.Update();
                    Thread.Sleep(1000);

                    blueBtn.BackColor = Color.White;
                    blueBtn.Update();
                    Thread.Sleep(1000);
                }

            }
            
            // Allow user input
            input_allowed(true);


            // Restore Color
            greenBtn.BackColor = colors[0];
            redBtn.BackColor = colors[1];
            yelBtn.BackColor = colors[2];
            blueBtn.BackColor = colors[3];
        }

        /// <summary>
        /// Enable or disable button input
        /// </summary>
        /// <param name="isAllowed"></param>
        public void input_allowed(bool isAllowed)
        {
            Button[] buttons = {greenBtn, redBtn, yelBtn, blueBtn};
            if (isAllowed)
            {
                foreach (Button btn in buttons)
                {
                    btn.Enabled = true;
                }

            }
            else
            {
                foreach (Button btn in buttons)
                {
                    btn.Enabled = false;
                }
            }
        }
    }
}
