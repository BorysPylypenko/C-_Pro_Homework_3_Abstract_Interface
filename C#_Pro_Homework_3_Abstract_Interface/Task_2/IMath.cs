using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Pro_Homework_3_Abstract_Interface.Task_2
{
    public interface IMath
    {
        int Max();
        int Min();
        float Avg();
        bool Search(int searchNumber);
    }
}
