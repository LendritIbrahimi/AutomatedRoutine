using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

public struct KeyItem
{
    public static List<KeyItem> AllKeys = CreateKeys();
    public static List<KeyItem> CreateKeys()
    {
        List<KeyItem> keys = new List<KeyItem>();

        keys.Add(new KeyItem("NONE", ""));
        keys.Add(new KeyItem("BACKSPACE", "{BACKSPACE}"));
        keys.Add(new KeyItem("BREAK", "{BREAK}"));
        keys.Add(new KeyItem("CAPS LOCK", "{CAPSLOCK}"));
        keys.Add(new KeyItem("DELETE", "{DELETE}"));
        keys.Add(new KeyItem("DOWN ARROW", "{DOWN}"));

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