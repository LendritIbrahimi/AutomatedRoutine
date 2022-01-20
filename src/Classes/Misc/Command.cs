using System.Windows.Forms;

public struct Command
{
    public string Name { get; }
    public int Value { get; }
    public UserControl Control { get; }

    public Command(UserControl control, int value, string name = "") : this()
    {
        Control = control;
        Value = value;
        if (name == "")
            Name = control.Text;
        else
            Name = name;

    }
}