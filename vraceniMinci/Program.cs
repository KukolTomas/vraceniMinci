using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vraceniMinci
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. argument cena, 2. argument platba
            vraceniMinci(200, 296);
            Console.ReadKey();
        }
        public static void vraceniMinci(int cena, int platba)
        {
            int startPenize = platba - cena;
            int[] penize = { 50, 20, 10,5,2,1 };

            for (int i = 0; i < penize.Length; i++)
            {
                int pocetPenez = startPenize / penize[i];
                if(pocetPenez != 0)
                {
                    Console.WriteLine("{0}Kč x {1} ", penize[i], pocetPenez);
                }
                startPenize = startPenize % penize[i];
            }
            
          
        }
    }
}
