using AutomatedRoutine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

public partial class EntryPoint : Form
{
    public EntryPoint()
    {
        InitializeComponent();
    }

    private void BtnStart_Click(object sender, EventArgs e)
    {
        List<CommandContainer> comControl = GetCommandFromPanel();

        for (int i = 0; i < comControl.Count; i++)
        {
            Panel mainPanel = comControl[i].Controls.Find("pnlContent", true).First() as Panel;
            UserControl content = mainPanel.Controls.OfType<UserControl>().First();
            ((ICommand)content).RunCommand();
        }
        this.Show();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        pnlContainer.Controls.Add(new CommandContainer());
    }

    private List<CommandContainer> GetCommandFromPanel()
    {
        List<CommandContainer> comControl = new List<CommandContainer>();
        foreach (var cmdControl in this.pnlContainer.Controls.OfType<CommandContainer>())
        {
            comControl.Add(cmdControl);
        }
        return comControl;
    }

}