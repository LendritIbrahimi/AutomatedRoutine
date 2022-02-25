using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CommandUserControl
{
    public partial class MouseClick : UserControl, ICommand
    {
        public string XMLName { get; } = "MouseClick";
        public string FullName { get; } = "Mouse Click";
        public void Run()
        {
            if (rbLeft.Checked)
                Mouse.LeftClick();
            else
                Mouse.RightClick();
        }
        public string Serialize()
        {
            string output = "<" + XMLName + ">\n";
            output += "<right>" + rbRight.Checked + " </right>";

            output += "</" + XMLName + ">\n";
            return output;

        }
        public ICommand Deserialize(string content)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(content);
            bool right = true;
            if (bool.TryParse(doc.SelectSingleNode(XMLName + "/right").InnerText, out right))
            {
                rbRight.Checked = right;
                rbLeft.Checked = !right;
            }
            else
            {
                rbLeft.Checked = true;
            }
            return this;
        }
        public MouseClick()
        {
            InitializeComponent();
        }
    }
}
