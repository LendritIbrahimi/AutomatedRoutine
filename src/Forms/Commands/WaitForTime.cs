using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CommandUserControl
{
    public partial class WaitForTime : UserControl, ICommand
    {

        private int time = 0;
        public void Run()
        {
            if (!int.TryParse(txtTime.Text, out time))
                time = 1000;
            Thread.Sleep(time);
        }
        public string Serialize()
        {
            string output = "<WaitForTime>\n";

            output += "\t<time>" + time + "</time>\n";
            output += "</WaitForTime>\n";
            return output;
        }

        public WaitForTime()
        {
            InitializeComponent();
            this.Text = "Wait";
        }
    }
}
