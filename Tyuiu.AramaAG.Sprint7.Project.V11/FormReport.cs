using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.AramaAG.Sprint7.Project.V11
{
    public partial class FormReport : Form
    {
        private string[,] numsMass;
        public FormReport(string[,] Mass)
        {
            InitializeComponent();
            this.numsMass = Mass;
            radioButtonDiagram_AAG.Checked = true;
        }

        private void BackClick_AAG(object sender, EventArgs e)
        {
            this.Close();
        }

        public void output(string[,] numsMass)
        {
            try
            {
                //dataGridViewResult_AAG.ColumnCount = 2;
                //dataGridViewResult_AAG.Columns[0].Width = 20;
                //dataGridViewResult_AAG.Columns[1].Width = 50;

                //this.chartResult_AAG.ChartAreas[0].AxisX.Title = "Ось X";
                //this.chartResult_AAG.ChartAreas[0].AxisY.Title = "Ось Y";

                //chartResult_AAG.Series[0].Points.Clear();
                //dataGridViewResult_AAG.Rows.Clear();
                //double[] numsMass = new double[ds.len];

                //numsMass = ds.LoadFromDataFile(path);

                this.chartResult_AAG.Titles.Add("Диаграмма стажа работников");
                List<int> StazList = new List<int>();
                for (int i = 0; i < numsMass.GetUpperBound(0); i++)
                {
                    //dataGridViewResult_AAG.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                    for (int j = 6; j < numsMass.Length / (numsMass.GetUpperBound(0) + 1); j++)
                    {
                        MessageBox.Show(numsMass[i, j].ToString());
                        StazList.Add(Convert.ToInt32(numsMass[i, j]));
                        //chartResult_AAG.Series[0].Points.AddXY(i, numsMass[i, 6]);
                    }
                }
                var unique = StazList.GroupBy(x => x)
                            .Select(i => new { Number = i.Key, Count = i.Count() })
                            .ToList();

                foreach (var count in unique)
                {
                    //Console.WriteLine($"Number: {count.Number}, Count: {count.Count}");
                    chartResult_AAG.Series[0].Points.AddXY(count.Number, count.Count);
                }


            }
            catch
            {
                MessageBox.Show("Ошибка чтения файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDaneChartSalary_AAG_Click(object sender, EventArgs e)
        {
            try
            {
                //    dataGridViewResult_AAG.ColumnCount = 2;
                //    dataGridViewResult_AAG.Columns[0].Width = 20;
                //    dataGridViewResult_AAG.Columns[1].Width = 50;

                //    this.chartResult_AAG.ChartAreas[0].AxisX.Title = "Ось X";
                //    this.chartResult_AAG.ChartAreas[0].AxisY.Title = "Ось Y";

                //    chartResult_AAG.Series[0].Points.Clear();
                //    dataGridViewResult_AAG.Rows.Clear();
                //    double[] numsMass = new double[ds.len];

                //    numsMass = ds.LoadFromDataFile(path);

                //    for (int i = 0; i < numsMass.Length; i++)
                //    {
                //        dataGridViewResult_AAG.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                //        chartResult_AAG.Series[0].Points.AddXY(i, numsMass[i]);
                //    }
            }
            catch
            {
                MessageBox.Show("Ошибка чтения файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBuildDiag1_AAG_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> StazList = new List<int>();
                if (radioButtonDiagram_AAG.Checked)
                {
                    this.chartResult_AAG.Series.Clear();
                    //Добавление нового набора данных
                    this.chartResult_AAG.Series.Add("Pie");
                    //Тип графика для данного набора данных
                    this.chartResult_AAG.Series["Pie"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                    this.chartResult_AAG.Titles.Clear();
                    this.chartResult_AAG.Titles.Add("Диаграмма стажа работников");
                }
                else
                {
                    this.chartResult_AAG.Series.Clear();
                    //Добавление нового набора данных
                    this.chartResult_AAG.Series.Add("Column");
                    //Тип графика для данного набора данных
                    this.chartResult_AAG.Series["Column"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    this.chartResult_AAG.Titles.Clear();
                    this.chartResult_AAG.Titles.Add("Диаграмма стажа работников");
                }


                for (int i = 0; i < numsMass.GetUpperBound(0); i++)
                {
                    for (int j = 6; j < numsMass.Length / (numsMass.GetUpperBound(0) + 1); j++)
                    {
                        //MessageBox.Show(numsMass[i, j].ToString());
                        StazList.Add(Convert.ToInt32(numsMass[i, j]));
                    }
                }
                var unique = StazList.GroupBy(x => x)
                            .Select(i => new { Number = i.Key, Count = i.Count() })
                            .ToList();

                foreach (var count in unique)
                {
                    chartResult_AAG.Series[0].Points.AddXY(count.Number, count.Count);
                }


            }
            catch
            {
                MessageBox.Show("Ошибка чтения файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBuildDgraph_AAG_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonDiagram_AAG.Checked)
                {
                    this.chartResult_AAG.Series.Clear();
                    //Добавление нового набора данных
                    this.chartResult_AAG.Series.Add("Pie");
                    //Тип графика для данного набора данных
                    this.chartResult_AAG.Series["Pie"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                    this.chartResult_AAG.Titles.Clear();
                    this.chartResult_AAG.Titles.Add("График соотношение должности и зарплаты");
                    // Создаем словарь для хранения количества каждого товара
                    Dictionary<string, List<int>> staffSalary = new Dictionary<string, List<int>>();

                    // Проходим по двумерному массиву и добавляем количество каждого товара в список
                    for (int i = 0; i < numsMass.GetLength(0) - 1; i++)
                    {
                        string product = numsMass[i, 5];
                        int count = int.Parse(numsMass[i, 4]);

                        if (staffSalary.ContainsKey(product))
                        {
                            // Если товар уже есть в словаре, то добавляем новое значение в список
                            staffSalary[product].Add(count);
                        }
                        else
                        {
                            // Если товара еще нет в словаре, то добавляем его с новым списком
                            staffSalary.Add(product, new List<int> { count });
                        }
                    }
                    double average;
                    // Вычисляем среднее значение количества для каждого товара
                    foreach (KeyValuePair<string, List<int>> productCount in staffSalary)
                    {
                        int sum = 0;
                        foreach (int count in productCount.Value)
                        {
                            sum += count;
                        }
                        average = (double)sum / productCount.Value.Count;

                        chartResult_AAG.Series[0].Points.AddXY(productCount.Key, average);
                    }
                }
                else
                {
                    this.chartResult_AAG.Series.Clear();
                    //Добавление нового набора данных
                    this.chartResult_AAG.Series.Add("Column");
                    //Тип графика для данного набора данных
                    this.chartResult_AAG.Series["Column"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    this.chartResult_AAG.Titles.Clear();
                    this.chartResult_AAG.Titles.Add("График соотношение должности и зарплаты");
                    for (int i = 0; i < numsMass.GetUpperBound(0); i++)
                    {
                        for (int j = 6; j < numsMass.Length / (numsMass.GetUpperBound(0) + 1); j++)
                        {
                            chartResult_AAG.Series[0].Points.AddXY(numsMass[i, j - 1], numsMass[i, j - 2]);
                        }
                    }
                }




            }
            catch
            {
                MessageBox.Show("Ошибка чтения файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
