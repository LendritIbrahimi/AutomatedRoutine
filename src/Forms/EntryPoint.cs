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
    public int posX = -1, posY = -1;
    public EntryPoint()
    {
        InitializeComponent();
    }

    private void InstantiateContainter(int size)
    {
        int checkValue = size - pnlContainer.Controls.Count;

        if (pnlContainer.Controls.Count < size)
            for (int i = 0; i < checkValue; i++)
                pnlContainer.Controls.Add(new CommandContainer());
        else
            for (int i = 1; i <= -checkValue; i++)
                pnlContainer.Controls.RemoveAt(pnlContainer.Controls.Count - i);
    }

    private void BtnStart_Click(object sender, EventArgs e)
    {
        List<CommandContainer> comControl = GetCommandFromPanel();
        List<Command> copyLCommand;

        if (comControl.Count > 0)
        {
            copyLCommand = comControl[0].GetData();
        }

        int loopNumber = 0;
        //int.TryParse(mtxNum.Text, out loopNumber);
        int increase = 1;

        if (loopNumber == 0)
        {
            increase = -1;
            loopNumber = 1;
        }

        for (int j = 0; j < loopNumber; j += increase)
        {
            for (int i = 0; i < comControl.Count; i++)
            {
                Panel mainPanel = comControl[i].Controls.OfType<Panel>().First();
                switch (comControl[i].cmbIndex)
                {

                    case 0:
                        MoveMouse mm = mainPanel.Controls.OfType<MoveMouse>().First();
                        if (posX == -1)
                            posX = mm.x;
                        if (posY == -1)
                            posY = mm.y;

                        Mouse.Move(posX, posY, mm.time);
                        posX = -1; posY = -1;
                        break;
                    case 1:
                        Mouse.Click();
                        break;
                    case 2:
                        WaitForTime wft = mainPanel.Controls.OfType<WaitForTime>().First();
                        Thread.WaitForTime(wft.time);
                        break;
                    case 3:
                        Color CheckColor = mainPanel.Controls.OfType<ColorSelect>().First().GetColor;
                        int skipLoop = mainPanel.Controls.OfType<ColorSelect>().First().SkipLoop;
                        if (mainPanel.Controls.OfType<ColorSelect>().First().giveXValue)
                            posX = Cursor.Position.X;
                        if (mainPanel.Controls.OfType<ColorSelect>().First().giveXValue)
                            posY = Cursor.Position.Y;

                        if (Screen.CheckColorAtPosition(Cursor.Position, CheckColor))
                            if (skipLoop == 0)
                                i += comControl.Count;
                            else
                                i += skipLoop;
                        break;
                    case 4:
                        int y = mainPanel.Controls.OfType<ScrollWheel>().First().y;

                        Mouse.ScrollWheel((uint)y);
                        break;
                    case 5:
                        i += comControl.Count;
                        break;

                };

            }
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