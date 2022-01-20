using AutomatedRoutine;
using AutomatedRoutine.Controls;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

static class CommandInstances
{
    public static List<Command> Get()
    {
        List<Command> dataSource = new List<Command>();
        dataSource.Add(new Command(new MoveMouse(), 1));
        dataSource.Add(new Command(new PressKey(), 2));
        dataSource.Add(new Command(new WaitForTime(), 3));
        dataSource.Add(new Command(new ColorSelect(), 4));
        dataSource.Add(new Command(new ScrollWheel(), 5));
        dataSource.Add(new Command(null, 6, "Break"));
        return dataSource;
    }
}
