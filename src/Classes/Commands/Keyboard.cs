using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Runtime.InteropServices;


class Keyboard
{
    [DllImport("User32.dll")]
    static extern int SetForegroundWindow(IntPtr point);
    public static void KeyPress(string key)
    {
        SendKeys.Send(key);

    }
    public static string FormatKeyStringArray(List<string> keys)
    {
        string output = "";
        if (keys.Count == 0)
            return output;

        foreach (string key in keys)
        {
            if (key.Equals("None"))
                continue;
            output += key.ToUpper();
        }

        return output;
    }

}

