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

        public string XMLName { get; } = "PressKey";
        public string FullName { get; } = "Press Key";
        public PressKey()
        {
            InitializeComponent();
            foreach(ComboBox cmbKey in this.Controls.OfType<ComboBox>())
            {
                KeySelected.Add(cmbKey);
            }
            InitializeKeyList(KeySelected);
        }
        public void Run()
        {
            MessageBox.Show(KeyPressString);
            if (KeyPressString.Equals(""))
                return;
            Keyboard.KeyPress(KeyPressString);
        }

        public string Serialize()
        {
            string output = "<" + XMLName + ">\n";
            foreach (ComboBox key in KeySelected)
            {
                output += "\t<" + key.Name + ">" + key.Text + "</" + key.Name + ">\n";
            }
            output += "</" + XMLName + ">\n";
            return output;
        }
        public ICommand Deserialize(string content)
        {
            return this;
        }
        private void InitializeKeyList(HashSet<ComboBox> keycmb)
        {
            foreach (ComboBox key in keycmb)
            {
                key.TextChanged -= new EventHandler(UpdateKeys);

                key.DropDownStyle = ComboBoxStyle.DropDownList;
                key.BindingContext = new BindingContext();
                key.DataSource = KeyItem.AllKeys;
                key.DisplayMember = nameof(KeyItem.FullName);
                key.ValueMember = nameof(KeyItem.ValueName);
                key.SelectedIndex = 0;

                key.TextChanged += new EventHandler(UpdateKeys);
            }
        }
        private void UpdateKeys(object sender, EventArgs e)
        {
            ComboBox cmbSender = (sender as ComboBox);
            KeySelected.Add(cmbSender);

            KeyPressString = Keyboard.FormatKeyStringArray(KeySelected.Select(cmb => cmb.SelectedValue.ToString()).ToList());
        }
    }
}
