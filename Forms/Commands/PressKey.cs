using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatedRoutine.Controls
{
    public partial class PressKey : UserControl
    {
        public PressKey()
        {
            InitializeComponent();
            this.Text = "Press Key";
        }

        private void AssignKey(object sender, KeyPressEventArgs e)
        {

           ((TextBox)sender).Text = e.KeyChar.ToString(); ;
            
        }
    }
}
