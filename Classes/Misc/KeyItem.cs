using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

class KeyItem
{
    public static IReadOnlyList<KeyItem> List { get; } = CreateList();

    private static IReadOnlyList<KeyItem> CreateList()
    {
        String[] names = Enum.GetNames(typeof(System.Windows.Forms.Keys));
        Key[] values = (Key[])Enum.GetValues(typeof(System.Windows.Forms.Keys));

        return Enumerable
            .Range(0, names.Length)
            .Select(i => new KeyItem(values[i], names[i]))
            .ToList();
    }

    private KeyItem(Key key, String name)
    {
        this.KeyCode = key;
        this.Name = name ?? throw new ArgumentNullException(nameof(name));
    }

    public Key KeyCode { get; }
    public String Name { get; }
}