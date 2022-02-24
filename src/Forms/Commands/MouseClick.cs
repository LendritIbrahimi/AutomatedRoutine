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
        public string XMLName { get; } = "MouseClick";
        public string FullName { get; } = "Mouse Click";
        public void Run()
        {
            Mouse.Click();
        }
        public string Serialize()
        {
            return "<"+ XMLName + ">\n" +
                "</" + XMLName + ">\n";
        }
        public ICommand Deserialize(string content)
        {
            return this;
        }
        public MouseClick()
        {
            InitializeComponent();
        }
    }
}
