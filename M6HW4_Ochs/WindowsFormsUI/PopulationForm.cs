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
    public partial class PopulationForm : Form
    {
        public PopulationForm()
        {
            InitializeComponent();
        }

        private void EmployeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'populationDBDataSet.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.populationDBDataSet.City);
            // TODO: This line of code loads data into the 'personnelDataSet.Employee' table. You can move, or remove it, as needed.

        }

        private void ASCButton_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.ASCButton(this.populationDBDataSet.City);
        }

        private void DESCButton_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.DESCButton(this.populationDBDataSet.City);
        }

        private void CityName_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.cityName(this.populationDBDataSet.City);
        }

        private void TotalPop_Click(object sender, EventArgs e)
        {
            int totalPopulation;
            totalPopulation = (int) cityTableAdapter.totalPop();
            MessageBox.Show($"Total population of all cities is : {totalPopulation.ToString()}");
        }

        private void AveragePop_Click(object sender, EventArgs e)
        {
            int averagePopulation;
            averagePopulation = (int)cityTableAdapter.averagePop();
            MessageBox.Show($"Average population of all cities is : {averagePopulation.ToString()}");
        }

        private void HighestPop_Click(object sender, EventArgs e)
        {
            int highestPopulation;
            highestPopulation = (int)cityTableAdapter.highestPop();
            MessageBox.Show($"Highest population of all cities is : {highestPopulation.ToString()}");
        }

        private void LowestPop_Click(object sender, EventArgs e)
        {
            int lowestPopulation;
            lowestPopulation = (int)cityTableAdapter.lowestPop();
            MessageBox.Show($"Lowest population of all cities is : {lowestPopulation.ToString()}");
        }
    }
}
