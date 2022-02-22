using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandUserControl
{
    public partial class PressKey : UserControl, ICommand
    {
        private string KeyPressString = "";
        private HashSet<ComboBox> KeySelected = new HashSet<ComboBox>();
        public PressKey()
        {
            InitializeComponent();
            InitializeKeyList(new ComboBox[] { cmbKey1, cmbKey2, cmbKey3 });
            this.Text = "Press Key";
        }
        public void Run()
        {
            if (KeyPressString.Equals(""))
                return;
            Keyboard.KeyPress(KeyPressString);
        }

        public string Serialize()
        {
            string output = "<PressKey>\n";
            foreach (ComboBox key in KeySelected)
            {
                output += "\t<" + key.Name + ">" + key.Text + "</" + key.Name + ">\n";
            }
            output += "</PressKey>\n";
            return output;
        }

        private void InitializeKeyList(ComboBox[] keycmb)
        {
            foreach (ComboBox key in keycmb)
            {
                key.TextChanged -= new EventHandler(UpdateKeys);

                key.DropDownStyle = ComboBoxStyle.DropDownList;
                key.BindingContext = new BindingContext();
                key.DisplayMember = nameof(KeyItem.Name);
                key.ValueMember = nameof(KeyItem.KeyCode);
                key.DataSource = KeyItem.List;
                key.SelectedIndex = 0;

                key.TextChanged += new EventHandler(UpdateKeys);
            }
        }
        private void UpdateKeys(object sender, EventArgs e)
        {
            ComboBox cmbSender = (sender as ComboBox);
            if (!KeySelected.Remove(cmbSender))
            {
                KeySelected.Add(cmbSender);
            };

            KeyPressString = Keyboard.FormatKeyStringArray(KeySelected.Select(cmb => cmb.Text).ToList());
        }
    }
}
