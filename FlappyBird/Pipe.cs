using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Resources;

namespace FlappyBird
{
    class Pipe
    {
        public Random rnd = new Random();

        public Pipe()
        {
            yPosition = rnd.Next(10, 340);
            xPosition = 1000;
            speed = 40;
        }

        public int xPosition { get; set; }
        public int yPosition { get; set; }
        public int speed { get; set; }
    }
}
