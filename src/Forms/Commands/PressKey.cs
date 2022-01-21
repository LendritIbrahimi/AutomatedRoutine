using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatedRoutine.Controls
{
    public partial class PressKey : UserControl
    {
        public PressKey()
        {
            InitializeComponent();
            InitializeKeyList(new ComboBox[] { cmbKey1,cmbKey2,cmbKey3 });
            this.Text = "Press Key";
        }

        private void InitializeKeyList(ComboBox[] keycmb)
        {
            foreach (ComboBox key in keycmb)
            {
                
                key.DropDownStyle = ComboBoxStyle.DropDownList;
                key.BindingContext = new BindingContext();
                key.DisplayMember = nameof(KeyItem.Name);
                key.ValueMember = nameof(KeyItem.KeyCode);
                key.DataSource = KeyItem.List;
                key.SelectedIndex = 0;
            }
        }
        private void AssignKey(object sender, KeyPressEventArgs e)
        {

            ((TextBox)sender).Text = e.KeyChar.ToString(); ;

        }
    }
}
