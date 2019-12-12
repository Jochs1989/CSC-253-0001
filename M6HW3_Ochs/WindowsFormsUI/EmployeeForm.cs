using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsUI
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personnelDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personnelDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.personnelDataSet.Employee);

        }

        private void ASCButton_Click(object sender, EventArgs e)
        {
            employeeDataGridView.Sort(employeeDataGridView.Columns[3], ListSortDirection.Ascending);
        }

        private void DESCButton_Click(object sender, EventArgs e)
        {
            employeeDataGridView.Sort(employeeDataGridView.Columns[3], ListSortDirection.Descending);
        }

        private void SearchDesc_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter.SearchDesc(this.personnelDataSet.Employee, searchTextBox.Text);
        }
    }
}
