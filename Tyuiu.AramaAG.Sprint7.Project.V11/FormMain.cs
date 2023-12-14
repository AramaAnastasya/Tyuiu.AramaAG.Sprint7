using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.AramaAG.Sprint7.Project.V11.Lib;

namespace Tyuiu.AramaAG.Sprint7.Project.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewStaff_AAG.ColumnCount = 7;
            dataGridViewStaff_AAG.RowCount = 10;

            for (int i = 0; i < 7; i++)
            {
                dataGridViewStaff_AAG.Columns[i].Width = 75;
            }
        }
    }
}
