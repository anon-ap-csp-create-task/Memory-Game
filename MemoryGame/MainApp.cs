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

        // https://www.c-sharpcorner.com/article/developing-mdi-applications-in-C-Sharp/

        private void MainApp_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

            helpScreen hs = new helpScreen();
            hs.MdiParent = this;
            hs.Size = new Size(this.Width / 2, this.Height / 2);
            hs.Show();

            gameScreen gs = new gameScreen();
            gs.MdiParent = this;
            gs.Size = this.Size;
            //gs.Show();
        }

        private void MainApp_SizeChanged(object sender, EventArgs e)
        {
            
        }
    }
}
