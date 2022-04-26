using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void startGame()
        {
            List<Color> pattern = new List<Color>();
            List<Color> userPattern = new List<Color>();
            Color[] colors = new Color[]
                {Functions.greenColor, Functions.redColor, Functions.yellowColor, Functions.blueColor};


            bool gameEnd = false;
            while (!gameEnd)
            {
                
            }
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
