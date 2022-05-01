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
    public partial class GamePanel : Form
    {
        public GamePanel()
        {
            InitializeComponent();
        }

        private void GamePanel_Load(object sender, EventArgs e)
        {
            updateLocation();
        }


        public void updateScoreDisplay()
        {
            this.score_number.Text = Data.score.ToString();
            this.bestScore_number.Text = Data.bestScore.ToString();
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
        }
    }
}
