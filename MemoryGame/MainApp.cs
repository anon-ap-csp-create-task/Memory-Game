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
    public partial class MainApp : Form
    {
        public MainApp()
        {
            InitializeComponent();
        }

        private void MainApp_Load(object sender, EventArgs e)
        {
            // Set appropriate size for form
            this.Size = new Size(500, 500);

            this.MaximumSize = new Size(1000, 1000);
            this.MinimumSize = new Size(200, 200);

            // Anchor buttons to appropriate side
            redBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            yelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            blueBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            updateBtns();
        }

        private void MainApp_SizeChanged(object sender, EventArgs e)
        {
            updateBtns();
        }

        private void updateBtns()
        {
            // Resize green button
            greenBtn.Location = new Point(0, 0);
            greenBtn.Width = this.Width / 2;
            greenBtn.Height = this.Height / 2 - 10; // Compensate for some unidentical buttons (unspecified reason)

            redBtn.Location = new Point(this.Width / 2, 0);
            redBtn.Width = this.Width / 2;
            redBtn.Height = this.Height / 2 - 10;

            yelBtn.Location = new Point(0, this.Height / 2 - 10);
            yelBtn.Width = this.Width / 2;
            yelBtn.Height = this.Height / 2 - 10;
                
            blueBtn.Location = new Point(this.Width / 2, this.Height / 2 - 10);
            blueBtn.Width = this.Width / 2;
            blueBtn.Height = this.Height / 2 - 10;
        }
    }
}
