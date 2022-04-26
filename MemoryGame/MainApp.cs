using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace MemoryGame
{
    public partial class MainApp : Form
    {
        public MainApp()
        {
            InitializeComponent();
        }

        // https://www.c-sharpcorner.com/article/developing-mdi-applications-in-C-Sharp/

        private readonly GameScreen gs = new GameScreen();
        public bool GameInProgress = true;

        private void MainApp_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

            gs.MdiParent = this;
            gs.Size = new Size(this.Width / 2, this.Height / 2);
            gs.Show();
        }

        private void MainApp_SizeChanged(object sender, EventArgs e)
        {

        }
    }
}
