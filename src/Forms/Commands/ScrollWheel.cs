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
    public partial class ScrollWheel : UserControl, ICommand
    {
        private int y = 0;
        public ScrollWheel()
        {
            InitializeComponent();
            this.Text = "Scroll Mouse";
        }
        public void Run()
        {
            Mouse.ScrollWheel((uint)y);
        }
        private void MtxYCord_Leave(object sender, EventArgs e)
        {
            int.TryParse(mtxYCord.Text, out y);
        }
    }
}
