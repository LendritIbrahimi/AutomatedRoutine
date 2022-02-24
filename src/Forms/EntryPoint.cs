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
        List<CommandContainer> comControl = GetCommandFromPanel();

        foreach (CommandContainer control in comControl)
        {
            if (!isRunning)
                return;
            UserControl content = control
                .Controls.Find("pnlContent", true).First()
                .Controls.OfType<UserControl>().First();
            control.Padding = new Padding(4);

            ((ICommand)content).Run();

            control.Padding = new Padding(1);
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
        // not safe
        if (runningThread.IsAlive)
            runningThread.Abort();


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

    private List<CommandContainer> GetCommandFromPanel()
    {
        List<CommandContainer> comControl = new List<CommandContainer>();
        foreach (CommandContainer cmdControl in this.pnlContainer.Controls.OfType<CommandContainer>())
        {

            comControl.Add(cmdControl);
        }
        return comControl;
    }

    private void SetCommandToPanel(List<CommandContainer> comContainer)
    {
        this.pnlContainer.Controls.Clear();
        this.pnlContainer.Controls.AddRange(comContainer.Select(cont => (cont as Control)).ToArray());
    }

    private void tsSave_Click(object sender, EventArgs e)
    {
        using (SaveFileDialog saveXML = new SaveFileDialog())
        {
            saveXML.Filter = "XML Files (*.xml)|*.xml|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveXML.Title = "Save File As";

            if (saveXML.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveXML.FileName, Serialize.UserControlToXML(GetCommandFromPanel().Select(control => control
                .Controls.Find("pnlContent", true).First()
                .Controls.OfType<UserControl>().First()).ToList()
                    ));
            }
        }
    }

    private void tsOpen_Click(object sender, EventArgs e)
    {
        string fileContent = string.Empty;
        string filePath = string.Empty;
        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "XML Files (*.xml)|*.xml|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                Stream fileStream = openFileDialog.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                }
                SetCommandToPanel(Serialize.XMLToUserControl(fileContent));
            }
        }

    }
}