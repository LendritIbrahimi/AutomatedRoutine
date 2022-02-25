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

    private static string CommandContainerToXML(List<CommandContainer> container)
    {
        string output = "\t<instructions>\n";

        List<UserControl> userControls = container
               .Select(control => control
               .Controls.Find("pnlContent", true).First()
               .Controls.OfType<UserControl>().First()).ToList();


        foreach (UserControl content in userControls)
            output += "\t" + ((ICommand)content).Serialize();

        output += "</instructions>\n";
        return output;
    }

    private static string SettingToXML(XMLContainer container)
    {
        string output = "<settings>\n";

        output += "\t<repetitions>" + container.Repetitions + "</repetitions>\n";
        output += "\t<repetitionindex>" + container.RepetitionComboboxIndex + "</repetitionindex>\n";
        output += "\t<stepsize>" + container.StepSize + "</stepsize>\n";
        output += "\t<finishedindex>" + container.FinishedIndex + "</finishedindex>\n";

        output += "</settings>\n";

        return output;
    }

    public static string ContainerToXML(XMLContainer container)
    {
        string output = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n" +
            "<AutomatedRoutine>\n";

        output += CommandContainerToXML(container.Commands);

        output += SettingToXML(container);

        output += "</AutomatedRoutine>";
        return output;
    }

    public static List<CommandContainer> XMLToCommandContainer(string XML)
    {
        List<CommandContainer> output = new List<CommandContainer>();
        XmlDocument doc = new XmlDocument();
        try
        {
            doc.LoadXml(XML);
        }
        catch (XmlException e)
        {
            MessageBox.Show("Something is wrong\n" + e.Message);
            return null;
        }
        foreach (XmlNode node in doc.SelectSingleNode("AutomatedRoutine/instructions").ChildNodes)
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
    public static XMLContainer XMLToSettings(string XML)
    {
        XMLContainer container = new XMLContainer();

        XmlDocument doc = new XmlDocument();
        try
        {
            doc.LoadXml(XML);

            container.Repetitions = int.Parse(doc.SelectSingleNode("AutomatedRoutine/settings/repetitions").InnerText);
            container.RepetitionComboboxIndex = int.Parse(doc.SelectSingleNode("AutomatedRoutine/settings/repetitionindex").InnerText);
            container.StepSize = int.Parse(doc.SelectSingleNode("AutomatedRoutine/settings/stepsize").InnerText);
            container.FinishedIndex = int.Parse(doc.SelectSingleNode("AutomatedRoutine/settings/finishedindex").InnerText);
        }
        catch (XmlException e)
        {
            MessageBox.Show("Something is wrong\n" + e.Message);
            return null;
        }

        return container;
    }
}

