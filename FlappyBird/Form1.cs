using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using IronPython.Hosting;
using Microsoft.Scripting;
using Microsoft.Scripting.Hosting;
using IronPython.Runtime;


namespace FlappyBird
{
    public partial class Form1 : Form
    {
        Bird playerBird = new Bird();
        Pipe evilPipe = new Pipe();
        public int pipeCurrXPos = 1000;

        public ScriptEngine pyEngine = null;
        public ScriptScope pyScope = null;
        public ScriptSource pySource = null;

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;

            pyEngine = Python.CreateEngine();
            pyScope = pyEngine.CreateScope();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            pipeCurrXPos = pipeCurrXPos - evilPipe.speed;
            pbBird.Top += playerBird.gravity;

            pbPipeUp.Left = pipeCurrXPos;
            pbPipeDown.Left = pipeCurrXPos;

            if (pipeCurrXPos<-80)
            {
                playerBird.score += 1;
                lblScoreValue.Text =  playerBird.score.ToString();

                pipeCurrXPos = 1000;
                pbPipeDown.Top = -380 + evilPipe.rnd.Next(10, 340);
                pbPipeUp.Top = 330 + evilPipe.rnd.Next(10, 340);
            }
            else
            {
            }

            if (pbBird.Bounds.IntersectsWith(pbPipeDown.Bounds) || (pbBird.Bounds.IntersectsWith(pbPipeUp.Bounds)) || (pbBird.Bounds.IntersectsWith(pbGround.Bounds)))
            {
                gameOver();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                pbBird.Image = Image.FromFile(Application.StartupPath + "\\" + "frame2.png");
                pbBird.Top -= playerBird.jump;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                pbBird.Image = Image.FromFile(Application.StartupPath + "\\" + "frame1.png");
            }
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            pbPipeDown.Top= -380 + evilPipe.yPosition;
            pbPipeUp.Top = 330 + evilPipe.yPosition;
            pbPipeDown.Left = evilPipe.xPosition;
            pbPipeUp.Left = evilPipe.xPosition;
        }

        public void gameOver ()
        {
            timer.Stop();
            lblGameOver.Visible=true;
            lblGameOver.Text = ("GAME OVER\nYOUR SCORE IS: " + playerBird.score);

            lblName.Visible = true;
            tbName.Visible = true;
        }

        
        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        public void tbName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ScriptSource script = pyEngine.CreateScriptSourceFromFile("HighScores.py");
                script.Execute(pyScope);
                dynamic addToHSTable = pyScope.GetVariable("makeHSTable");
                lblHS.Visible = true;

                dynamic scores = addToHSTable(tbName.Text, playerBird.score);
                for (int i=0; i < 10; i++)
                {
                    lblHS.Text += (i+1 +")" + scores[i] + "\n");
                }

            }
            else
            {
               
            }

        }
    }
}
