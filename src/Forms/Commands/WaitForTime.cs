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
    public partial class WaitForTime : UserControl
    {
        public int time = 0;

        private void GiveValues(object sender, EventArgs e)
        {
            int.TryParse(mtxTime.Text, out time);
        }

        public WaitForTime()
        {
            InitializeComponent();
            this.Text = "Wait";
        }

        private void ClearNotEmpty(object sender, EventArgs e)
        {
            (sender as MaskedTextBox).Select(0, 0);
        }
    }
}
