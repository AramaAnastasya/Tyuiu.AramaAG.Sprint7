using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            saveFileDialogData_AAG.Filter = "Значения, разделенные запятыми(* .csv)|*.csv|Все фалы(*.*)|*.*";
            OpenFileDialogData_AAG.Filter = "Значения, разделенные запятыми(* .csv)|*.csv|Все фалы(*.*)|*.*";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        DataService ds = new DataService();
        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewStaff_AAG.ColumnCount = 10;
            dataGridViewStaff_AAG.RowCount = 10;
            dataGridViewStaff_AAG.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            
            for (int i = 0; i < 10; i++)
            {
                dataGridViewStaff_AAG.Columns[i].Width = 75;
            }

        }


        static string OpenFilePath = "C:/Users/Lenovo/Downloads/Данные — копия2.0.csv";
        static int rows;
        static int columns;
        public static string[,] LoadFromFileDta(string FilePath)
        {
            string fileDta = File.ReadAllText(FilePath, Encoding.UTF8);
            fileDta = fileDta.Replace('\n', '\r');
            string[] lines = fileDta.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;
            string[,] arrayValues = new string[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    arrayValues[i, j] = line_r[j];

                }
            }
            return arrayValues;
        }

        private void CreateReportClick_AAG(object sender, EventArgs e)
        {
            FormReport formReport = new FormReport();
            formReport.Show();

        }

        private void OpenFileClick(object sender, EventArgs e)
        {
            OpenFileDialogData_AAG.ShowDialog();
            OpenFilePath = OpenFileDialogData_AAG.FileName;

            string[,] arrayValues = LoadFromFileDta(OpenFilePath);
            dataGridViewStaff_AAG.ColumnCount = columns;
            dataGridViewStaff_AAG.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridViewStaff_AAG.Columns[i].Width = 75;
                dataGridViewStaff_AAG.Columns[i].Width = 75;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewStaff_AAG.Rows[i].Cells[j].Value = arrayValues[i, j];
                }


            }
        }

        private void EditDataClick(object sender, EventArgs e)
        {
            for (int i = 0; i <= dataGridViewStaff_AAG.ColumnCount - 1; i++)
            {
                dataGridViewStaff_AAG.Columns[i].ReadOnly = false;
            }
            buttonSaveEdit_AGG.Enabled = true;
        }

        private void ClickSaveData(object sender, EventArgs e)
        {
            saveFileDialogData_AAG.FileName = "Данные1.csv";
            saveFileDialogData_AAG.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogData_AAG.ShowDialog();
            string path = saveFileDialogData_AAG.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewStaff_AAG.RowCount;
            int columns = dataGridViewStaff_AAG.ColumnCount;
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewStaff_AAG.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewStaff_AAG.Rows[i].Cells[j].Value;
                    }
                }

                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
                for (int k = 0; k <= dataGridViewStaff_AAG.ColumnCount - 1; k++)
                {
                    dataGridViewStaff_AAG.Columns[i].ReadOnly = true;
                }
                buttonSaveEdit_AGG.Enabled = false;
            }
        }
    }
}
