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
    public partial class ColorSelect : UserControl
    {
        public Color GetColor;
        public int SkipLoop = -1;
        public bool giveXValue=false, giveYValue = false;
        public ColorSelect()
        {
            InitializeComponent();
            this.Text = "Select Color";
            GetColor = pnlShowColor.BackColor;
        }

        private void BtnShowColor_Click(object sender, EventArgs e)
        {
            colMain.ShowDialog();

            pnlShowColor.BackColor = colMain.Color;
            GetColor = pnlShowColor.BackColor;
        }

        private void CkbY_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox ck = sender as CheckBox;
            giveYValue = ck.Checked;
        }

        private void CkbX_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox ck = sender as CheckBox;
            giveXValue = ck.Checked;
        }

        private void MtxSkips_Leave(object sender, EventArgs e)
        {
            int.TryParse(mtxSkips.Text, out SkipLoop);
        }
    }
}
