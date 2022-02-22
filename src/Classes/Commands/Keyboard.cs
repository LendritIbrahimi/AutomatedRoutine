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
        System.Diagnostics.Process p = System.Diagnostics.Process.GetProcessesByName("dota2").FirstOrDefault();
        if (p != null)
        {
            IntPtr h = p.MainWindowHandle;
            SetForegroundWindow(h);
            SendKeys.SendWait(key);
        }
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
            output += "{" + key.ToUpper() + "}+";
        }

        output = output.Remove(output.Length - 1, 1);

        return output;
    }

}

