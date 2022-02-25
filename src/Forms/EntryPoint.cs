using AutomatedRoutine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

public partial class EntryPoint : Form
{
    private static bool isRunning = false;
    private static Thread runningThread;
    private static int repetitionNumber = 1;
    private static int sleepBetweenSteps = 0;
    public static bool infinite = false;
    public EntryPoint()
    {
        InitializeComponent();
        CheckForIllegalCrossThreadCalls = false;
    }

    public void ExecuteCommands()
    {
        List<CommandContainer> comControl = GetCommandFromPanel();
        int repetitionCopy = repetitionNumber;
        while (repetitionCopy > 0 || infinite)
        {
            foreach (CommandContainer control in comControl)
            {
                if (!isRunning)
                    return;
                UserControl content = control
                    .Controls.Find("pnlContent", true).First()
                    .Controls.OfType<UserControl>().First();

                control.Padding = new Padding(4);

                ((ICommand)content).Run();

                Thread.Sleep(sleepBetweenSteps);

                control.Padding = new Padding(0);
            }
            repetitionCopy--;
            txtRepetitions.Text = repetitionCopy.ToString();
        }

        isRunning = false;
        ToggleStartButton();
    }

    private void BtnStart_Click(object sender, EventArgs e)
    {
        //functionality
        isRunning = true;

        // design & event triggering
        ToggleStartButton();

    }
    private void BtnStop_Click(object sender, EventArgs e)
    {
        // functionality
        isRunning = false;

        // design & event triggering
        ToggleStartButton();
    }

    private void ParseSettings()
    {
        int.TryParse(txtRepetitions.Text, out repetitionNumber);
        int.TryParse(txtStepTime.Text, out sleepBetweenSteps);
    }

    private void ToggleStartButton()
    {
        if (isRunning)
        {
            btnStart.Click -= BtnStart_Click;
            btnStart.Click += BtnStop_Click;

            btnStart.Text = "Stop (F11)";
            btnStart.BackColor = Color.IndianRed;

            ParseSettings();

            runningThread = new Thread(ExecuteCommands);
            runningThread.IsBackground = true;
            runningThread.Start();
        }
        else
        {
            txtRepetitions.Text = repetitionNumber.ToString();

            btnStart.Click -= BtnStop_Click;
            btnStart.Click += BtnStart_Click;

            btnStart.Text = "Start (F11)";
            btnStart.BackColor = Color.SeaGreen;

            // not safe
            if (runningThread.IsAlive)
                runningThread.Abort();
        }
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
                ParseSettings();
                XMLContainer container = new XMLContainer();
                container.Commands = GetCommandFromPanel();

                container.RepetitionComboboxIndex = chbRepetitionType.SelectedIndex;
                container.Repetitions = repetitionNumber;
                container.StepSize = sleepBetweenSteps;
                container.FinishedIndex = chbFinished.SelectedIndex;

                File.WriteAllText(saveXML.FileName, Serialize.ContainerToXML(container));
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
                SetCommandToPanel(Serialize.XMLToCommandContainer(fileContent));

                XMLContainer container = Serialize.XMLToSettings(fileContent);
                txtRepetitions.Text = container.Repetitions.ToString();
                txtStepTime.Text = container.StepSize.ToString();
                chbRepetitionType.SelectedIndex = container.RepetitionComboboxIndex;
                chbFinished.SelectedIndex = container.FinishedIndex;
            }
        }

    }

    private void EntryPoint_Load(object sender, EventArgs e)
    {
        chbRepetitionType.SelectedIndex = 0;
        chbFinished.SelectedIndex = 0;
    }

    private void EntryPoint_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.F11)
        {
            isRunning = !isRunning;
            ToggleStartButton();
        }
    }

    private void chbRepetitionType_SelectedIndexChanged(object sender, EventArgs e)
    {
        infinite = chbRepetitionType.Text.ToLower().Contains("infinite");
        txtRepetitions.Visible = !infinite;
    }
}