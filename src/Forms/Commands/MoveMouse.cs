using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandUserControl
{
    public partial class MoveMouse : UserControl, ICommand, IInterruptable
    {
        private int posX = -1, posY = -1, time = 0;

        private void GiveValues(object sender, EventArgs e)
        {
            int.TryParse(mtxXCord.Text, out posX);
            int.TryParse(mtxYCord.Text, out posY);
            int.TryParse(mtxTime.Text, out time);
        }

        public string Serialize()
        {
            string output = "<MoveMouse>\n";

            output += "\t<X>" + posX + "</X>\n";
            output += "\t<Y>" + posY + "</Y>\n";
            output += "\t<time>" + time + "</time>\n";

            output += "</MoveMouse>\n";
            return output;
        }

        public void Interrupt()
        {

        }

        public void Run()
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
