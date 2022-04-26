using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MemoryGame
{
    public partial class GameScreen : Form
    {
        public GameScreen()
        {
            InitializeComponent();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            // Anchor buttons to appropriate side
            redBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            yelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            blueBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            updateBtns();
        }

        private List<Color> pattern = new List<Color>();
        private List<Color> userPattern = new List<Color>();
        private readonly Color[] colors =
            {Functions.greenColor, Functions.redColor, Functions.yellowColor, Functions.blueColor};

        public void startGame()
        {
            // Choose random color
            Color color = new Color();
            Random rdm = new Random();
            for (int i = 0; i < 10; i++)
            {
                switch (rdm.Next(1, 4))
                {
                    case 1:
                        color = colors[0];
                        pattern.Add(color);
                        break;
                    case 2:
                        color = colors[1];
                        pattern.Add(color);
                        break;
                    case 3:
                        color = colors[2];
                        pattern.Add(color);
                        break;
                    case 4:
                        color = colors[3];
                        pattern.Add(color);
                        break;
                }
            }

            // Change color to white
            foreach (Button btn in new[] { greenBtn, redBtn, yelBtn, blueBtn })
            {
                btn.BackColor = Color.White;
                btn.Update();
            }

            // Display the color pattern to the user
            foreach (Color col in pattern)
            {
                if (col == colors[0])
                {
                    greenBtn.BackColor = colors[0];
                    Thread.Sleep(1000);
                    greenBtn.BackColor = Color.White;
                }
                else if (col == colors[1])
                {
                    redBtn.BackColor = colors[1];
                    Thread.Sleep(1000);
                    greenBtn.BackColor = Color.White;
                }
                else if (col == colors[2])
                {
                    yelBtn.BackColor = colors[2];
                    Thread.Sleep(1000);
                    yelBtn.BackColor = Color.White;
                }
                else if (col == colors[3])
                {
                    blueBtn.BackColor = colors[3];
                    Thread.Sleep(1000);
                    blueBtn.BackColor = Color.White;
                }
                Thread.Sleep(1000);
            }

            // Restore Color


        }
        /*
        public void startGame()
        {
            


            bool gameEnd = false;
            while (!gameEnd)
            {
                // Choose random color
                Color color;
                switch (new Random().Next(1, 4))
                {
                    case 1:
                        color = colors[0];
                        pattern.Append(color);
                        break;
                    case 2:
                        color = colors[1];
                        pattern.Append(color);
                        break;
                    case 3:
                        color = colors[2];
                        pattern.Append(color);
                        break;
                    case 4:
                        color = colors[3];
                        pattern.Append(color);
                        break;
                    default:
                        break;
                }

                // Disable button input
                foreach (Button btn in new[] {greenBtn, redBtn, yelBtn, blueBtn})
                {
                    btn.BackColor = Color.White;
                    btn.Update();
                }
                
                // Display the color pattern to the user
                foreach (Color col in pattern)
                {
                    if (col.Equals(colors[0])) greenBtn.BackColor = colors[0];
                    else if (col.Equals(colors[1])) redBtn.BackColor = colors[1];
                    else if (col.Equals(colors[2])) yelBtn.BackColor = colors[2];
                    else if (col.Equals(colors[3])) blueBtn.BackColor = colors[3];

                    Thread.Sleep(500);
                }
            }
        }
        */






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
            MainApp app = new MainApp();

            // If game is still running, prompt the user
            if (!app.GameInProgress) return;
            // Check to see if the user wants to continue the game
            if (MessageBox.Show(
                    "A game is still in progress!\nDo you wish to leave the game and lose unsaved progress?",
                    "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) != DialogResult.No) return;
            e.Cancel = true;
        }
    }
}
