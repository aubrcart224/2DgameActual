using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2Dgame
{
    public partial class gameScreen : UserControl
    {
        int deaths = 0;
        Player hero;

        // lists 
        List<eneny> enemies = new List<eneny>();
        List<string> walls = new List<string>();
        

        Size screenSize;

        //keys 
        bool leftArrowDown = false;
        bool rightArrowDown = false;
        bool upArrowDown = false;
        bool downArrowDown = false;


        public gameScreen()
        {
            InitializeComponent();
            InitialzeGame();
        }

        public void InitialzeGame()
        {

            screenSize = new Size(this.Width, this.Height);
            int x = 50;
            int y = 50;
            
            hero = new Player(x, y);

            
            deathLable.Text =$"Deaths: {deaths}";

            eneny enemy1= new eneny (150, 200, 0,-6);
            eneny enemy2 = new eneny(180, 200, 0,6);
            eneny enemy3 = new eneny(210, 200, 0, -6);
            eneny enemy4 = new eneny(240, 200, 0, 6); 
            eneny enemy5 = new eneny(270, 200, 0, -6);
            eneny enemy6 = new eneny(300, 200, 0, 6);
            eneny enemy7 = new eneny(330, 200, 0, -6);
            eneny enemy8 = new eneny(360, 200, 0, 6);
            eneny enemy9 = new eneny(390, 200, 0, -6);
            eneny enemy10 = new eneny(420,200, 0, 6);

            enemies.Add(enemy1);
            enemies.Add(enemy2);
            enemies.Add(enemy3);
            enemies.Add(enemy4); 
            enemies.Add(enemy5);
            enemies.Add(enemy6);
            enemies.Add(enemy7);
            enemies.Add(enemy8);
            enemies.Add(enemy9);
            enemies.Add(enemy10);

        }


        private void gameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {


                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
            }
        }

        private void gameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;

            }
        }

        private void gameScreen_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Red, hero.x, hero.y, hero.width, hero.height);

            foreach (eneny b in enemies)
            {
                e.Graphics.FillEllipse(Brushes.Blue, b.x, b.y, b.size, b.size);

                //outlines 

                

                //List<Graphics> walls = new List<Graphics>();
                //Graphics wall1 =  new e.Graphics.DrawLine(Pens.Black, 140, 100, 440, 100);
                //Graphics wall2 = new DrawLine(Pens.Black, 140, 100, 140, 180);

                //walls.Add("wall1") =  e.Graphics.DrawLine(Pens.Black, 140, 100, 440, 100);

                e.Graphics.DrawLine(Pens.Black, 140, 100, 440, 100);
                e.Graphics.DrawLine(Pens.Black, 140, 100, 140, 180);
                e.Graphics.DrawLine(Pens.Black, 140, 220, 140, 310);
                e.Graphics.DrawLine(Pens.Black, 140, 310, 440, 310);
                e.Graphics.DrawLine(Pens.Black, 440, 100, 440, 180);
                e.Graphics.DrawLine(Pens.Black, 440, 220, 440, 310);

                //start and end zones 
                e.Graphics.FillRectangle(Brushes.LightGreen, 90, 100,50,211);
                e.Graphics.FillRectangle(Brushes.LightGreen, 441, 100, 50, 211);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {



            foreach (eneny b in enemies)
            {
                b.Move(screenSize);
            }


            //key intputs 
            if (leftArrowDown == true)
            {
                hero.Move("left", screenSize);
            }
            if (rightArrowDown == true)
            {
                hero.Move("right", screenSize);
            }
            if (upArrowDown == true)
            {
                hero.Move("up", screenSize);
            }
            if (downArrowDown == true)
            {
                hero.Move("down", screenSize);
            }

            foreach (eneny b in enemies)
            {
                if (b.Collision(hero))
                {

                    hero.x = 100;
                    hero.y = 100;
                    deaths++;
                    deathLable.Text = $"Deaths: {deaths}";

                }


            }

            Refresh();
        }

       
    }
}
