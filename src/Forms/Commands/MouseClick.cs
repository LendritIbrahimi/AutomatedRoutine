using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandUserControl
{
    public partial class MouseClick : UserControl, ICommand
    {
        public void Run()
        {
            Mouse.Click();
        }
        public string Serialize()
        {
            return "<MouseClick>\n" +
                "</MouseClick>\n";
        }
        public MouseClick()
        {
            InitializeComponent();
            this.Text = "Mouse Click";
        }
    }
}
