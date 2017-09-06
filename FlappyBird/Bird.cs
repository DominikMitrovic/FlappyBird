using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    class Bird
    {
        public Bird()
        {
            score = 0;
            jump = 110;
            gravity = 12;
        }
        public int score;
        public int jump;
        public int gravity;
    }

}
