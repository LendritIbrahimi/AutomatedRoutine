using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatedRoutine
{
    public partial class MoveMouse : UserControl, ICommand
    {
        private int posX = -1, posY = -1, time = 0;

        private void GiveValues(object sender, EventArgs e)
        {
            int.TryParse(mtxXCord.Text, out posX);
            int.TryParse(mtxYCord.Text, out posY);
            int.TryParse(mtxTime.Text, out time);
        }

        public void RunCommand()
        {
            Mouse.Move(posX, posY, time);
        }

        public MoveMouse()
        {
            InitializeComponent();
            this.Text = "Move Mouse";
        }

        private void ClearNotEmpty(object sender, EventArgs e)
        {
            (sender as MaskedTextBox).Select(0, 0);
        }
    }
}
