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
    public static void KeyPress(string Key)
    {
        SendKeys.Send(Key);
    }

}

