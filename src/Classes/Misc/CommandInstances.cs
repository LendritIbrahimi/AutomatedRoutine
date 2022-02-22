using AutomatedRoutine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using CommandUserControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

static class CommandInstances
{
    public static List<Command> Get()
    {
        List<Command> dataSource = new List<Command>();


        List<Type> controls = ControlsFinder.FindControls(Assembly.GetExecutingAssembly(), "CommandUserControl");
        foreach (Type type in controls)
        {
            dataSource.Add(new Command((UserControl)Activator.CreateInstance(type)));
        }
        return dataSource;
    }
}
