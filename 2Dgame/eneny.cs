using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _2Dgame
{
    internal class eneny
    {
        public int size = 13;
        public int xSpeed, ySpeed;
        public int x, y;

        // enemy 
        public eneny(int _x, int _y, int _xSpeed, int _ySpeed)
        {
            x = _x;
            y = _y;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
        }


        // move method of enemies 
        public void Move(Size ss)
        {
            x += xSpeed;
            y += ySpeed;

            if (y < 100 || y > 300)
            {
                ySpeed *= -1;
            }
            if (x < 144 || x > 420)
            {
                xSpeed *= -1;
            }
        }


        // check if player collieds with enemy 
        public bool Collision(Player p)
        {
            Rectangle ballRec = new Rectangle(x, y, size, size);
            Rectangle playerRec = new Rectangle(p.x, p.y, p.width, p.height);

            if (ballRec.IntersectsWith(playerRec))
            {

                return true;

            }
            return false;
        }
    }
}
