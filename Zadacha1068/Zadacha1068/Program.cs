using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1068
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int N = Convert.ToInt32(Console.ReadLine());
            if (N > 0)
                for (int i = 0; i < N + 1; i++)
                    sum = sum + i;
            else
                sum = 1;
                for (int i = 0; i > N - 1; i--)
                    sum = sum+i;
            System.Console.WriteLine(sum);
        }
    }
}
