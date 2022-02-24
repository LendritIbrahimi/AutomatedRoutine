using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CommandUserControl
{
    public partial class MoveMouse : UserControl, ICommand
    {
        private int posX = -1, posY = -1, time = 0;
        public string XMLName { get; } = "MoveMouse";
        public string FullName { get; } = "Move Mouse";
        private void GiveValues()
        {
            int.TryParse(mtxXCord.Text, out posX);
            int.TryParse(mtxYCord.Text, out posY);
            int.TryParse(mtxTime.Text, out time);
        }

        public string Serialize()
        {
            GiveValues();
            string output = "<" + XMLName + ">\n";

            output += "\t<X>" + posX + "</X>\n";
            output += "\t<Y>" + posY + "</Y>\n";
            output += "\t<time>" + time + "</time>\n";
            output += "\t<incremental>" + chbIncrement.Checked + "</incremental>\n";

            output += "</" + XMLName + ">\n";
            return output;
        }
        public ICommand Deserialize(string content)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(content);
            mtxXCord.Text = doc.SelectSingleNode(XMLName + "/X").InnerText;
            mtxYCord.Text = doc.SelectSingleNode(XMLName + "/Y").InnerText;
            mtxTime.Text = doc.SelectSingleNode(XMLName + "/time").InnerText;
            bool check = false;
            if (bool.TryParse(doc.SelectSingleNode(XMLName + "/incremental").InnerText, out check))
            {
                chbIncrement.Checked = check;
            }

            return this;
        }

        public void Run()
        {
            GiveValues();
            Mouse.Move(posX, posY, time, chbIncrement.Checked);
        }

        public MoveMouse()
        {
            InitializeComponent();
        }

        private void ClearNotEmpty(object sender, EventArgs e)
        {
            (sender as MaskedTextBox).Select(0, 0);
        }
    }
}
