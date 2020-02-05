using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pesele
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            int m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11;
            int suma;

            string ile = Console.ReadLine();
            
            for(var k =0; k <= int.Parse(ile); k++)
            { 
            
                string pesel = Console.ReadLine();
            
            
                int[] tab = new int[11];
                
                 for (int i = 0; i < pesel.Length; i++)
                     tab[i] = int.Parse(pesel.Substring(i, 1));
                 {
                   m1 = tab[0] * 1;
                   m2 = tab[1] * 3;
                   m3 = tab[2] * 7;
                   m4 = tab[3] * 9;
                   m5 = tab[4] * 1;
                   m6 = tab[5] * 3;
                   m7 = tab[6] * 7;
                   m8 = tab[7] * 9;
                   m9 = tab[8] * 1;
                   m10 = tab[9] * 3;
                   m11 = tab[10] * 1;

                  suma = m1 + m2 + m3 + m4 + m5 + m6 + m7 + m8 + m9 + m10 + m11;
                 }



                string c1 = suma.ToString().Substring(0,1);
                string c2 = suma.ToString().Substring(1, 1);
                string c3 = suma.ToString().Substring(2, 1);

                if(c3 =="0")
                {
                    Console.WriteLine("D");
                }
                else
                {
                    Console.WriteLine("N");
                }
             }

        }
    }
}
