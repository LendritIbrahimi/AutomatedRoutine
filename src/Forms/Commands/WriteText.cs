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
    public partial class WriteText : UserControl, ICommand
    {
        public string XMLName { get; } = "WriteText";
        public string FullName { get; } = "Write Text";
        public WriteText()
        {
            InitializeComponent();
        }

        public void Run()
        {
            Keyboard.KeyPress(txtInput.Text);
        }

        public string Serialize()
        {
            string output = "<" + XMLName + ">\n";

            output += "\t<text>" + txtInput.Text + "</text>\n";

            output += "</" + XMLName + ">\n";
            return output;
        }
        public ICommand Deserialize(string content)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(content);
            txtInput.Text = doc.SelectSingleNode(XMLName + "/text").InnerText;

            return this;
        }
    }
}
