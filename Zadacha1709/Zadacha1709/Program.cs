using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1709
{
    class Program
    {
        static void Main(string[] args)
        {
            int Max = 0;
            int[] n = new int[10];
           
            int N = 1;
            int i = 0;
            int rang = 0;
            int maxa = 0;
          
            while (N != 0)
            {
                n[rang] = Convert.ToInt32(Console.ReadLine());
                N = n[rang];
                if (N > Max)
                {
                    Max = N;
                }

                rang++;  
             }
              int[] band= new int[Max+1];
              int[] a = new int[Max+1];
              a [0] = 0;
              a [1] = 1;
            {
                

                for (int o = 1; o <= rang ; o++)
                {
                   for (i = 2; i <= n[o]; i++)
                 {
                    if (i % 2 == 0)
                    {
                        a[i] = a[i / 2];
                          if  (a[i] > maxa)
                         band[o]  =   a[i] ;

                       
                    }
                    else
                    {
                        a[i] =a[i / 2] + a[(i / 2) + 1];
                           
                        if 
                        (a[i] > maxa)
                         band[o] =   a[i] ;

                        System.Console.WriteLine(band[o]);
                 }
              

                }
                    
            }

      
    }     }
    }
}
