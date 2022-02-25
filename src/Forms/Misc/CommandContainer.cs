using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace AutomatedRoutine
{
    public partial class CommandContainer : UserControl
    {
        private List<Command> dataSource = new List<Command>();
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
            dataSource = CommandInstances.Get();
            // setup data binding
            cmbMain.DataSource = this.dataSource;
            cmbMain.DisplayMember = "Name";
            cmbMain.ValueMember = "xMLName";

            // make it read-only
            cmbMain.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cmbMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeCommand(cmbMain.SelectedIndex);
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
