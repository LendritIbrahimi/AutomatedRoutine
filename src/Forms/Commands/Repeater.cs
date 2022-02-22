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
    public partial class Loop : UserControl, ICommand
    {
        private int input = 0;
        public Loop()
        {
            InitializeComponent();
            this.Text = "Repetition";
        }
        public string Serialize()
        {
            string output =
                "<loop>" + input + "</loop>\n";

            return output;
        }
        public void Run()
        {

            if (!int.TryParse(txtRepeat.Text, out input) || Repeater.Repetitions > 1)
                return;

            Repeater.Repetitions += input;
        }
    }
}
