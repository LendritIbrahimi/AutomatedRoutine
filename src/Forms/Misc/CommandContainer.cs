using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatedRoutine
{
    public partial class CommandContainer : UserControl
    {
        private List<Command> dataSource = new List<Command>();
        public int cmbIndex = 1;
        public CommandContainer()
        {
            InitializeComponent();
            AddToComboBox();
        }
        public List<Command> GetData()
        {
            return dataSource;
        }

        private void AddToComboBox()
        {
            this.dataSource = CommandInstances.Get();
            // setup data binding
            this.cmbMain.DataSource = this.dataSource;
            this.cmbMain.DisplayMember = "Name";
            this.cmbMain.ValueMember = "Value";

            // make it read-only
            this.cmbMain.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cmbMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeCommand(cmbMain.SelectedIndex);
            cmbIndex = cmbMain.SelectedIndex;
        }

        private void ChangeCommand(int index)
        {
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(dataSource[index].Control);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
