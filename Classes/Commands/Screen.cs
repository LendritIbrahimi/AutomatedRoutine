using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Runtime.InteropServices;

class Screen
{
    #region Get_Color_Position
    [DllImport("user32.dll")]
    static extern bool GetCursorPos(ref Point lpPoint);

    [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
    public static extern int BitBlt(IntPtr hDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);

    #endregion



    static Bitmap screenPixel = new Bitmap(1, 1, PixelFormat.Format32bppArgb);
    private static Color GetColorAt(Point location)
    {
        using (Graphics gdest = Graphics.FromImage(screenPixel))
        {
            using (Graphics gsrc = Graphics.FromHwnd(IntPtr.Zero))
            {
                IntPtr hSrcDC = gsrc.GetHdc();
                IntPtr hDC = gdest.GetHdc();
                int retval = BitBlt(hDC, 0, 0, 1, 1, hSrcDC, location.X, location.Y, (int)CopyPixelOperation.SourceCopy);
                gdest.ReleaseHdc();
                gsrc.ReleaseHdc();
            }
        }

        return screenPixel.GetPixel(0, 0);
    }

    public static bool CheckColorAtPosition(Point location, Color color)
    {
        var c = GetColorAt(location);

        if (c.R == color.R && c.G == color.G && c.B == color.B)
            return true;

        return false;
    }

}
