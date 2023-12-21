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
            output();
        }

        public BindingList<Staffs> staffList;
        private BindingSource bindingSource;

        public class Staffs
        {
            public string Familia { get; set; }
            public string Name { get; set; }
            public string LastName { get; set; }
            public string BirhtDay { get; set; }
            public int Salary { get; set; }
            public string Staff1 { get; set; }
            public int Staz { get; set; }



            public Staffs()
            {

            }

            public Staffs(string familia, string name, string lastName, string birhtDay, int salary, string staff, int staz)
            {
                Familia = familia;
                Name = name;
                LastName = lastName;
                BirhtDay = birhtDay;
                Salary = salary;
                Staff1 = staff;
                Staz = staz;
            }
        }

        public void output()
        {
            saveFileDialogData_AAG.Filter = "Значения, разделенные запятыми(* .csv)|*.csv|Все фалы(*.*)|*.*";
            OpenFileDialogData_AAG.Filter = "Значения, разделенные запятыми(* .csv)|*.csv|Все фалы(*.*)|*.*";

            staffList = new BindingList<Staffs>();
            bindingSource = new BindingSource(staffList, null);
            dataGridViewStaff_AAG.DataSource = bindingSource;
            for (int i = 0; i < dataGridViewStaff_AAG.ColumnCount; i++)
            {
                dataGridViewStaff_AAG.Columns[i].ReadOnly = true;
            }
            buttonSaveEdit_AGG.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

                for (int j = 0; j < columns; j++)
                {
                    string[] line_r = lines[i].Split(';');
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
            try
            {
                //string filePath = OpenFileDialogData_AAG.FileName;
                string[] lines = File.ReadAllLines(OpenFilePath);

                staffList.Clear();
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] values = lines[i].Split(';');
                string po = values[0];
                    staffList.Add(new Staffs
                    {
                        Familia = values[0],
                        Name = values[1],
                        LastName = values[2],
                        BirhtDay = values[3],
                        Salary = Convert.ToInt32(values[4]),
                        Staff1 = values[5],
                        Staz = Convert.ToInt32(values[6])
                    });
                }


                //string[,] arrayValues = LoadFromFileDta(OpenFilePath);
                //dataGridViewStaff_AAG.ColumnCount = columns;
                //dataGridViewStaff_AAG.RowCount = rows;
                //for (int i = 0; i < rows; i++)
                //{
                //    for (int j = 0; j < columns; j++)
                //    {
                //        dataGridViewStaff_AAG.Rows[i].Cells[j].Value = arrayValues[i, j];
                //    }


                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ввода: " + ex.Message, "Ошибка");
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
                    dataGridViewStaff_AAG.Columns[k].ReadOnly = true;
                }
                buttonSaveEdit_AGG.Enabled = false;
            }
        }

        private void buttonAboutMe_AAG_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonHelp_AAG_Click(object sender, EventArgs e)
        {

        }

        private void buttonADDData_AAG_Click(object sender, EventArgs e)
        {
            labelFamilia_AAG.Visible = true;
            labelName_AAG.Visible = true;
            labelLastName_AAG.Visible = true;
            labelBirhtDay_AAG.Visible = true;
            labelSalary_AAG.Visible = true;
            labelStaff_AAG.Visible = true;
            labelStaz_AAG.Visible = true;
            buttonSavePeople_AAG.Visible = true;
            textBoxFamilia_AAG.Visible = true;
            textBoxName_AAG.Visible = true;
            textBoxLastName_AAG.Visible = true;
            textBoxBirhtDay_AAG.Visible = true;
            textBoxSalary_AAG.Visible = true;
            textBoxStaff_AAG.Visible = true;
            textBoxStaz_AAG.Visible = true;

        }

        private void buttonSavePeople_AAG_Click(object sender, EventArgs e)
        {
            {
                labelFamilia_AAG.Visible = false;
                labelName_AAG.Visible = false;
                labelLastName_AAG.Visible = false;
                labelBirhtDay_AAG.Visible = false;
                labelSalary_AAG.Visible = false;
                labelStaff_AAG.Visible = false;
                labelStaz_AAG.Visible = false;
                buttonSavePeople_AAG.Visible = false;
                textBoxFamilia_AAG.Visible = false;
                textBoxName_AAG.Visible = false;
                textBoxLastName_AAG.Visible = false;
                textBoxBirhtDay_AAG.Visible = false;
                textBoxSalary_AAG.Visible = false;
                textBoxStaff_AAG.Visible = false;
                textBoxStaz_AAG.Visible = false;
            }

            //string[,] array = new string[dataGridViewStaff_AAG.Rows.Count + 1, columns];
            //MessageBox.Show(dataGridViewStaff_AAG.Rows.Count.ToString());
            //for (int i = 0; i <= dataGridViewStaff_AAG.Rows.Count; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        if (i == dataGridViewStaff_AAG.Rows.Count)
            //        {
            //            if(j == 0)
            //                array[i, j] = textBoxFamilia_AAG.Text;
            //            if (j == 1)
            //                array[i, j] = textBoxName_AAG.Text;
            //            if (j == 2)
            //                array[i, j] = textBoxLastName_AAG.Text;
            //            if (j == 3)
            //                array[i, j] = textBoxBirhtDay_AAG.Text;
            //            if (j == 4)
            //                array[i, j] = textBoxSalary_AAG.Text;
            //            if (j == 5)
            //                array[i, j] = textBoxStaff_AAG.Text;
            //            if (j == 6)
            //                array[i, j] = textBoxStaz_AAG.Text;
            //        }
            //        else
            //        {
                        
            //            array[i, j] = dataGridViewStaff_AAG.Rows[i].Cells[j].Value.ToString();
            //        }
            //    }
            //}
            //dataGridViewStaff_AAG.ColumnCount = columns;
            //dataGridViewStaff_AAG.RowCount = dataGridViewStaff_AAG.Rows.Count + 1;
            //for (int i = 0; i < dataGridViewStaff_AAG.Rows.Count; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        dataGridViewStaff_AAG.Rows[i].Cells[j].Value = array[i, j];
            //    }
            //}

            DialogResult result = MessageBox.Show("Рекомендуем пересохранить данные в файле!\nСохранить?","Сообщение",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                SaveData();
            }
            textBoxFamilia_AAG.Text = "";
            textBoxName_AAG.Text = "";
            textBoxLastName_AAG.Text = "";
            textBoxBirhtDay_AAG.Text = "";
            textBoxSalary_AAG.Text = "";
            textBoxStaff_AAG.Text = "";
            textBoxStaz_AAG.Text = "";
        }

        public void SaveData()
        {
            saveFileDialogData_AAG.FileName = "Данные.csv";
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
                for (int k = 0; k < dataGridViewStaff_AAG.ColumnCount; k++)
                {
                    dataGridViewStaff_AAG.Columns[k].ReadOnly = true;
                }
            }
        }

        private void textBoxSearch_AAG_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
