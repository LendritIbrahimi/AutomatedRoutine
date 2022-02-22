using System.Windows.Forms;

public struct Command
{
    public string Name { get; }
    public UserControl Control { get; }

    public Command(UserControl control, string name = "") : this()
    {
        Control = control;
        if (name == "")
            Name = control.Text;
        else
            Name = name;

    }
}