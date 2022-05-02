using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
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


        public static readonly GameScreen gs = new GameScreen();
        public static readonly GamePanel panel = new GamePanel();
        private static readonly Functions func = new Functions();
        private void MainApp_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

            // Show "GameScreen.cs" and resize programmatically
            gs.MdiParent = this;
            gs.Size = new Size(this.Width / 2 + 40, this.Height / 2 + 40);
            gs.Show();
            gs.Location = new Point(this.Width / 4 + 20, 0);

            // Show "GamePanel.cs" and resize programmatically
            panel.MdiParent = this;
            panel.Size = new Size(this.Width / 4 + 20, this.Height - 45);
            panel.Show();
            panel.Location = new Point(0, 0);

        }



    }
}