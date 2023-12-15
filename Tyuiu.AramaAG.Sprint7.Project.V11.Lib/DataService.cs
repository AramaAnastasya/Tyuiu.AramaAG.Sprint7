using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.AramaAG.Sprint7.Project.V11.Lib
{
    public class DataService
    {
        public int CountStaff(int[,] array)
        {
            int row = array.GetUpperBound(0);
            //int column = array.GetUpperBound(1) + 1;
            //int count = 0;
            //for(int i = 0; i < row; i++)
            //{
            //    for (int j = 0; j  < column; j ++)
            //    {
            //        summ = array[i, 4];
            //    }
            //}
            return row;
        }
    }
}
