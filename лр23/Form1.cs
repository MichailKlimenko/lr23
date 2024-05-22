using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace лр23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "BikeRentalDBDataSet.Rentals". При необходимости она может быть перемещена или удалена.
            this.RentalsTableAdapter.Fill(this.BikeRentalDBDataSet.Rentals);

            this.reportViewer1.RefreshReport();
        }

        private void прокатToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadReport(@"C:\работа\Практика КПиЯП\лр23\лр23\Report1.rdlc");
        }

        private void велосипедToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadReport(@"C:\работа\Практика КПиЯП\лр23\лр23\Report2.rdlc");
        }

        private void клиентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadReport(@"C:\работа\Практика КПиЯП\лр23\лр23\Report3.rdlc");
        }
        private void LoadReport(string reportPath)
        {
            this.reportViewer1.LocalReport.ReportPath = reportPath;
            this.reportViewer1.RefreshReport();
        }
    }
}
