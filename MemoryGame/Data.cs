using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    public class Data
    {
        public static List<Color> pattern = new List<Color>();
        public static List<Color> userPattern = new List<Color>();

        public static bool GameInProgress = false;

        public static readonly Color greenColor = Color.Lime;
        public static readonly Color redColor = Color.FromArgb(255, 4, 45);
        public static readonly Color yellowColor = Color.Yellow;
        public static readonly Color blueColor = Color.FromArgb(0, 150, 255);

        public static int score = 0;
        public static int bestScore = 0;
    }
}
