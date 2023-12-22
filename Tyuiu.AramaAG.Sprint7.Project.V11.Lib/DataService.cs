using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.AramaAG.Sprint7.Project.V11.Lib
{
    public class DataService
    {
        public int CountStaff(string path)
        {
            string[,] array = GetMatrix(path);
            int row = array.GetUpperBound(0) + 1;
            return row;
        }

        public int MaxExperienceStaff(string path)
        {
            string[,] array = GetMatrix(path);
            int row = array.GetUpperBound(0) + 1;
            int column = array.Length / row;
            int maxExp = int.MaxValue;
            for (int i = 0; i < row; i++)
            {
                for (int j = 7; j < column; j++)
                {
                    if(Convert.ToInt32(array[i, j]) <= maxExp)
                    {
                        maxExp = Convert.ToInt32(array[i, j]);
                    }
                }
            }
            return maxExp;
        }

        static int rows;
        static int columns;
        public string[,] GetMatrix(string path)
        {
            string fileDta = File.ReadAllText(path, Encoding.UTF8);
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
    }
}
