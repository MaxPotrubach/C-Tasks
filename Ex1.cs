using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ex1
    {
        private bool Compare(int N, int Number)
        {
            if (Number >= 1 && Number <= N)
                return true;
            else
                return false;
        }
        public void Exercise(int N)
        {
            int[] Numbers = {6, 90, 12};

            foreach (int i in Numbers)
            {
                if (Compare(N, i))
                    Console.WriteLine($"{i} is in diapazone");
                else
                    Console.WriteLine($"{i} is out of diapazone");
            }
        }
    }
}
