using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface ICommand
{
    string XMLName { get; }
    string FullName { get; }
    void Run();
    string Serialize();

    ICommand Deserialize(string content);
}
