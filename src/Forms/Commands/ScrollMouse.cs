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
    public partial class ScrollMouse : UserControl, ICommand
    {
        public string XMLName { get; } = "ScrollMouse";
        public string FullName { get; } = "Scroll Wheel";

        private int distance = 0;
        public ScrollMouse()
        {
            InitializeComponent();
        }
        public void Run()
        {
            if (!int.TryParse(txtDistance.Text, out distance))
                distance = 0;
            Mouse.ScrollWheel((uint)distance);
        }
        public string Serialize()
        {
            int.TryParse(txtDistance.Text, out distance);
            string output = "<" + XMLName + ">\n";

            output += "\t<distance>" + distance + "</distance>\n";
            output += "</" + XMLName + ">\n";
            return output;
        }
        public ICommand Deserialize(string content)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(content);
            txtDistance.Text = doc.SelectSingleNode(XMLName + "/distance").InnerText;
            return this;
        }
    }
}
