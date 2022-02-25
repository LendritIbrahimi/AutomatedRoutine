using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

public struct KeyItem
{

    private const String alphanumerics = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    public static List<KeyItem> AllKeys = CreateKeys();
    public static List<KeyItem> CreateKeys()
    {
        List<KeyItem> keys = new List<KeyItem>();

        keys.Add(new KeyItem("NONE", ""));
        keys.Add(new KeyItem("SHIFT", "+"));
        keys.Add(new KeyItem("CTRL", "^"));
        keys.Add(new KeyItem("ALT", "%"));
        keys.Add(new KeyItem("BACKSPACE", "{BACKSPACE}"));
        keys.Add(new KeyItem("BREAK", "{BREAK}"));
        keys.Add(new KeyItem("CAPS LOCK", "{CAPSLOCK}"));
        keys.Add(new KeyItem("DELETE", "{DELETE}"));
        keys.Add(new KeyItem("DOWN ARROW", "{DOWN}"));
        keys.Add(new KeyItem("UP ARROW", "{UP}"));
        keys.Add(new KeyItem("LEFT ARROW", "{LEFT}"));
        keys.Add(new KeyItem("RIGHT ARROW", "{RIGHT}"));
        keys.Add(new KeyItem("END", "{END}"));
        keys.Add(new KeyItem("ENTER", "{ENTER}"));
        keys.Add(new KeyItem("ESC", "{ESC}"));
        keys.Add(new KeyItem("HELP", "{HELP}"));
        keys.Add(new KeyItem("HOME", "{HOME}"));
        keys.Add(new KeyItem("INSERT", "{INSERT}"));
        keys.Add(new KeyItem("NUM LOCK", "{NUMLOCK}"));
        keys.Add(new KeyItem("PAGE DOWN", "{PGDN}"));
        keys.Add(new KeyItem("PAGE UP", "{PGUP}"));
        keys.Add(new KeyItem("PRINT SCREEN", "{PRTSC}"));
        keys.Add(new KeyItem("SCROLL LOCK", "{SCROLLLOCK}"));
        keys.Add(new KeyItem("TAB", "{TAB}"));
        keys.Add(new KeyItem("F1", "{F1}"));
        keys.Add(new KeyItem("F2", "{F2}"));
        keys.Add(new KeyItem("F3", "{F3}"));
        keys.Add(new KeyItem("F4", "{F4}"));
        keys.Add(new KeyItem("F5", "{F5}"));
        keys.Add(new KeyItem("F6", "{F6}"));
        keys.Add(new KeyItem("F7", "{F7}"));
        keys.Add(new KeyItem("F8", "{F8}"));
        keys.Add(new KeyItem("F9", "{F9}"));
        keys.Add(new KeyItem("F10", "{F10}"));
        keys.Add(new KeyItem("F11", "{F11}"));
        keys.Add(new KeyItem("F12", "{F12}"));
        keys.Add(new KeyItem("F13", "{F13}"));
        keys.Add(new KeyItem("F14", "{F14}"));
        keys.Add(new KeyItem("F15", "{F15}"));
        keys.Add(new KeyItem("F16", "{F16}"));
        keys.Add(new KeyItem("ADD", "{ADD}"));
        keys.Add(new KeyItem("SUBTRACT", "{SUBTRACT}"));
        keys.Add(new KeyItem("MULTIPLY", "{MULTIPLY}"));
        keys.Add(new KeyItem("DIVIDE", "{DIVIDE}"));

        foreach (char c in alphanumerics)
        {
            keys.Add(new KeyItem(c.ToString().ToUpper(), "{" + c.ToString().ToUpper() + "}"));
        }
        return keys;
    }
    public KeyItem(string name, string value)
    {
        FullName = name;
        ValueName = value;
    }
    public string ValueName { get; }
    public string FullName { get; }
}