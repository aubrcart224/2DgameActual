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
    public partial class gameOverScreen : UserControl
    {
        public gameOverScreen()
        {
            InitializeComponent();

            gameOverLable.Text = $"Game Over.\nYou Win.\nYou Died: {gameScreen.deaths} Times.\nClick The Button To Return To The Menu Screen";
        }

        private void gameOverScreen_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            // go back to menu 
            Form1.ChangeScreen(this, new menuScreen());
        }

        
    }
}
