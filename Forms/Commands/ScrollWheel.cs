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
    public partial class ScrollWheel : UserControl
    {
        public int y = 0;
        public ScrollWheel()
        {
            InitializeComponent();
            this.Text = "Scroll Mouse";
        }

        private void MtxYCord_Leave(object sender, EventArgs e)
        {
            int.TryParse(mtxYCord.Text,out y);
        }
    }
}
