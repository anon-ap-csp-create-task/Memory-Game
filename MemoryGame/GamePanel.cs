using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class GamePanel : Form
    {
        public GamePanel()
        {
            InitializeComponent();
        }

        private void GamePanel_Load(object sender, EventArgs e)
        {
            this.replayBtn.Hide();
            updateLocation();
        }

        
        // Update score display
        public void updateScoreDisplay()
        {
            this.score_number.Text = Data.score.ToString();
            this.bestScore_number.Text = Data.bestScore.ToString();
        }

        // Initialize components to start the game
        public void startGame()
        {
            this.BackColor = Color.PaleGreen;

            this.title.ForeColor = Color.MidnightBlue;
            this.title.Text = "Memory";

            this.functionBtn.Hide();
            this.replayBtn.Hide();
        }
        // Initialize components to end the game
        public void endGame()
        {
            this.BackColor = Color.LightCoral;

            this.title.ForeColor = Color.Red;
            this.title.Text = "Game Over!";

            this.functionBtn.Text = "Play Again";
            this.functionBtn.Show();
            this.replayBtn.Show();
        }


        // Prevent form from moving outside the boundaries of the parent window
        private void GamePanel_Move(object sender, EventArgs e)
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

        // Resize form components when necessary
        private void GamePanel_Resize(object sender, EventArgs e)
        {
            updateLocation();
        }
        private void updateLocation()
        {
            score.Location = new Point(this.Width / 2 - 60, this.Height / 2 - 70);
            score_number.Location = new Point(this.Width / 2 + 20, this.Height / 2 - 70);

            bestScore.Location = new Point(this.Width / 2 - 90, this.Height / 2);
            bestScore_number.Location = new Point(this.Width / 2 + 35, this.Height / 2);


            this.title.Location = new Point(this.Width / 2 - 90, this.Height / 2 - 110);
            this.functionBtn.Location = new Point(this.Width / 2 - 80, this.Height / 2 + 50);
            this.replayBtn.Location = new Point(this.Width / 2 - 50, this.Height / 2 + 110);
        }

        private void FunctionBtn_Click(object sender, EventArgs e)
        {
            Functions func = new Functions();
            func.startGame();
            
        }
        private void ReplayBtn_Click(object sender, EventArgs e)
        {
            MainApp.gs.Invoke(new MethodInvoker(delegate ()
            {
                MainApp.gs.showReplay(Data.pattern, Data.userPattern);
            }));
        }
    }
}
