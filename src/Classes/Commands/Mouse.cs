﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Runtime.InteropServices;


class Mouse
{
    #region Mouse_Click_Imporables
    [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
    public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
    //Mouse actions
    private const int MOUSEEVENTF_LEFTDOWN = 0x02;
    private const int MOUSEEVENTF_LEFTUP = 0x04;
    private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
    private const int MOUSEEVENTF_RIGHTUP = 0x10;
    private const int MOUSEEVENTF_WHEEL = 0x0800;

    public static void Click()
    {
        //Call the imported function with the cursor's current position
        uint X = (uint)Cursor.Position.X;
        uint Y = (uint)Cursor.Position.Y;
        mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
    }
    #endregion
    public static void Move(int x, int y, int t)
    {
        if (t != 0)
        {
            t = Math.Max(t, 1);
            t = Math.Min(t, 600000);
            float loopLength = t / 10;
            float moveX = Cursor.Position.X, moveY = Cursor.Position.Y;
            float moveIntX = (x - moveX) / loopLength, moveIntY = (y - moveY) / loopLength;
            for (int i = 0; i < loopLength;)
            {
                //if (Cursor.Position.X != moveX || Cursor.Position.Y != moveY)
                //{
                //    Thread.WaitForTime(4000);
                //    continue;
                //}
                moveX += moveIntX;
                moveY += moveIntY;
                Cursor.Position = new Point((int)moveX, (int)moveY);
                Thread.Sleep(10);
                i++;
            }
        }
        Cursor.Position = new Point(x, y);
    }

    public static void ScrollWheel(uint y)
    {
        mouse_event(MOUSEEVENTF_WHEEL, 0, 0, y, 0);
    }
}
