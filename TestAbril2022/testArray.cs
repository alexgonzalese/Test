using System;
using System.Collections.Generic;
using System.Text;

namespace TestAbril2022
{
    public class testArray
    {

        public static string SumArray(int[] Arra1, int[] Arra2)
        {
            try
            {
                if (Arra1.Length == Arra2.Length)
                {
                    int[] ArrayResult = new int[Arra1.Length];

                    var cn = Arra1.Length;

                    for (int i = 0; i < Arra1.Length; i++)
                    {
                        cn--;

                        var ss = Arra1[i] + Arra2[cn];

                        ArrayResult[i] = ss;

                        Console.WriteLine(ArrayResult[i]);
                    }
                }
                else
                {
                    Console.WriteLine("Los valores ingresados no contienen la misma longitud");
                    return "FAILURE";
                }
                return "OK";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "FAILURE";
            }
        }
    }
}
