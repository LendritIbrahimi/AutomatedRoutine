using AutomatedRoutine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

static class Serialize
{
    public static string UserControlToXML(List<UserControl> commandControls)
    {
        string output = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n" +
            "<AutomatedRoutine>\n";
        foreach (UserControl content in commandControls)
        {
            output += "\t" + ((ICommand)content).Serialize();
        }
        output += "</AutomatedRoutine>";
        return output;
    }

    public static List<CommandContainer> XMLToUserControl(string XML)
    {
        List<CommandContainer> output = new List<CommandContainer>();
        XmlDocument doc = new XmlDocument();
        try
        {
            doc.LoadXml(XML);
        }catch(XmlException e)
        {
            MessageBox.Show("Something is wrong\n" + e.Message);
            return null;
        }
        foreach (XmlNode node in doc.DocumentElement.ChildNodes)
        {
            string commandName = node.Name;
            CommandContainer commandObject = new CommandContainer();

            ComboBox selector = (commandObject.Controls.Find("cmbMain", true).First() as ComboBox);
            selector.SelectedValue = commandName;

            UserControl content = commandObject
                                  .Controls.Find("pnlContent", true).First()
                                  .Controls.OfType<UserControl>().First();

            (content as ICommand).Deserialize(node.OuterXml);
            output.Add(commandObject);
        }

        return output;
    }
}

