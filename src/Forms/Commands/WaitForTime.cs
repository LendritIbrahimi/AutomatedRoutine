using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace CommandUserControl
{
    public partial class WaitForTime : UserControl, ICommand
    {
        public string XMLName { get; } = "WaitForTime";
        public string FullName { get; } = "Wait for Time";

        private int time = 0;
        public void Run()
        {
            if (!int.TryParse(txtTime.Text, out time))
                time = 1000;
            Thread.Sleep(time);
        }
        public string Serialize()
        {
            int.TryParse(txtTime.Text, out time);
            string output = "<"+ XMLName + ">\n";

            output += "\t<time>" + time + "</time>\n";
            output += "</"+ XMLName + ">\n";
            return output;
        }
        public ICommand Deserialize(string content)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(content);
            txtTime.Text = doc.SelectSingleNode(XMLName + "/time").InnerText;
            return this;
        }
        public WaitForTime()
        {
            InitializeComponent();
        }
    }
}
