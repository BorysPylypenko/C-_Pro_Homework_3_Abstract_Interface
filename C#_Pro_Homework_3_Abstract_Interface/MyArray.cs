using C__Pro_Homework_3_Abstract_Interface.Task_1;
using C__Pro_Homework_3_Abstract_Interface.Task_2;
using C__Pro_Homework_3_Abstract_Interface.Task_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace C__Pro_Homework_3_Abstract_Interface
{
    public class MyArray : IOutput, IMath, ISort
    {
        public int[] Array { get; set; }
        public MyArray(int[] array)
        {
            Array = array;
        }


        public void Show()
        {
            Console.WriteLine("Array elements:");
            foreach (int element in Array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

        public void Show(string info)
        {
            Console.WriteLine($"Additional information: {info}");
            Show();
        }

        public int Max()
        {
            int max = Array[0];
            foreach (int element in Array)
            {
                if (element > max)
                {
                    max = element;
                }
            }
            return max;
        }
        
        public int Min()
        {
            int min = Array[0];
            foreach (int element in Array)
            {
                if(element < min)
                {
                    min = element;
                }
            }
            return min;
        }
        
        public float Avg ()
        {
            int sum = 0;
            foreach (int element in Array)
            {
                sum = sum + element;
            }
            return (float)sum / (float)Array.Length;
        }

        public bool Search (int searchNumber)
        {
            foreach (int element in Array)
            {
                if (element.Equals(searchNumber))
                {
                    return true;
                }
            }
            return false;
        }

        public void SortAsc()
        {
            for (int i = 0; i < Array.Length - 1; i++)
            {
                for (int j = 0; j < Array.Length - i - 1; j++)
                {
                    if (Array[j] > Array[j + 1])
                    {
                        int temp = Array[j];
                        Array[j] = Array[j + 1];
                        Array[j + 1] = temp;
                    }
                }
            }
        }

        public void SortDesc()
        {
            for (int i = 0; i < Array.Length - 1; i++)
            {
                for (int j = 0; j < Array.Length - i - 1; j++)
                {
                    if (Array[j] < Array[j + 1])
                    {
                        int temp = Array[j];
                        Array[j] = Array[j + 1];
                        Array[j + 1] = temp;
                    }
                }
            }
        }

        public void SortByParam(bool isAsc)
        {
            if (isAsc == true) { SortAsc(); }
            else { SortDesc(); }
        }
    }
}
