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

            foreach (Panel pnlKey in this.Controls.OfType<Panel>())
            {
                ComboBox cmb = pnlKey.Controls.OfType<ComboBox>().First();
                if (cmb != null)
                    KeySelected.Add(cmb);
            }
            InitializeKeyList(KeySelected);
        }
        public void Run()
        {
            UpdateKeys();
            if (KeyPressString.Equals(""))
                return;
            Keyboard.KeyPress(KeyPressString);
        }

        public string Serialize()
        {
            string output = "<" + XMLName + ">\n";
            foreach (ComboBox key in KeySelected)
            {
                if (key.Visible)
                    output += "\t<" + key.Name + ">" + key.Text + "</" + key.Name + ">\n";
            }
            output += "</" + XMLName + ">\n";
            return output;
        }
        public ICommand Deserialize(string content)
        {

            return this;
        }
        private void InitializeKeyList(HashSet<ComboBox> cmbKeys)
        {

            foreach (ComboBox key in cmbKeys)
            {
                key.DropDownStyle = ComboBoxStyle.DropDownList;
                key.BindingContext = new BindingContext();
                key.DataSource = KeyItem.AllKeys;
                key.DisplayMember = nameof(KeyItem.FullName);
                key.ValueMember = nameof(KeyItem.ValueName);
                key.SelectedIndex = 0;
            }
        }
        private void UpdateKeys()
        {
            KeyPressString = Keyboard.FormatKeyStringArray(KeySelected
                .Where(a => a.Visible)
                .Select(cmb => cmb.SelectedValue.ToString())
                .ToList());
            MessageBox.Show(KeyPressString);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (Panel pnlKey in this.Controls.OfType<Panel>())
            {
                if (!pnlKey.Visible && pnlKey.Controls.OfType<ComboBox>().Any())
                {
                    pnlKey.Visible = true;
                    break;
                }
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (Panel pnlKey in this.Controls.OfType<Panel>().Reverse())
            {
                if (pnlKey.Visible && pnlKey.Controls.OfType<ComboBox>().Any() && pnlKey.Controls.OfType<ComboBox>().First().Name != "cmbKey1")
                {
                    pnlKey.Visible = false;
                    break;
                }
            }
        }
    }
}
