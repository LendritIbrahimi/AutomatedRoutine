using AutomatedRoutine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

static class Serialize
{
    public static string UserControlToXML(List<UserControl> commandControls)
    {
        string output = "<AutomatedRoutine>\n";
        foreach (UserControl content in commandControls)
        {
            output += "\t" + ((ICommand)content).Serialize();
        }
        output += "</AutomatedRoutine>";
        return output;
    }
}

