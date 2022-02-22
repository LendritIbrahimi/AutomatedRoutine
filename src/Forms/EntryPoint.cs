using AutomatedRoutine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

public partial class EntryPoint : Form
{
    private static bool isRunning = false;
    private static Thread runningThread;
    public EntryPoint()
    {
        InitializeComponent();

    }

    public void ExecuteCommands()
    {
        List<UserControl> comControl = GetCommandFromPanel();

        foreach (UserControl content in comControl)
        {
            if (!isRunning)
                return;
            content.Padding = new Padding(3);

            ((ICommand)content).Run();
            Thread.Sleep(1000);

            content.Padding = new Padding(0);
        }
    }

    private void BtnStart_Click(object sender, EventArgs e)
    {
        //functionality
        isRunning = true;
        runningThread = new Thread(ExecuteCommands);
        runningThread.IsBackground = true;
        runningThread.Start();


        // design & event triggering
        Button btn = (sender as Button);

        btn.Click -= BtnStart_Click;
        btn.Click += BtnStop_Click;

        btn.Text = "Stop";
        btn.BackColor = Color.IndianRed;

    }
    private void BtnStop_Click(object sender, EventArgs e)
    {
        // functionality
        isRunning = false;
        if (runningThread.IsAlive)
            runningThread.Abort(); ;

        // not safe


        // design & event triggering
        Button btn = (sender as Button);

        btn.Click -= BtnStop_Click;
        btn.Click += BtnStart_Click;

        btn.Text = "Start";
        btn.BackColor = Color.SeaGreen;
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        pnlContainer.Controls.Add(new CommandContainer());
    }

    private List<UserControl> GetCommandFromPanel()
    {
        List<UserControl> comControl = new List<UserControl>();
        foreach (CommandContainer cmdControl in this.pnlContainer.Controls.OfType<CommandContainer>())
        {
            UserControl content = cmdControl
               .Controls.Find("pnlContent", true).First()
               .Controls.OfType<UserControl>().First();
            comControl.Add(content);
        }
        return comControl;
    }

    private void tsSave_Click(object sender, EventArgs e)
    {
        SaveFileDialog saveXML = new SaveFileDialog();
        saveXML.Filter = "XML Files (*.xml)|*.xml|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
        saveXML.Title = "Save File As";

        if (saveXML.ShowDialog() == DialogResult.OK)
        {
            File.WriteAllText(saveXML.FileName, Serialize.UserControlToXML(GetCommandFromPanel()));
        }
    }
}