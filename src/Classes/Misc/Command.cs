using System.Windows.Forms;

public struct Command
{
    public string Name { get; }
    public string XMLName { get; }
    public UserControl Control { get; }

    public Command(UserControl control) : this()
    {
        Control = control;
        Name = (control as ICommand).FullName;
        XMLName = (control as ICommand).XMLName;

    }
}