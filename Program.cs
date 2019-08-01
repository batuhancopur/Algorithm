using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lockers
{
    class Program
    {
        static void Main(string[] args)
        {
            int w=3;
            int h=5;
            int i;
            int j;

            var lockers = new int[3, 2] { { 1, 4 }, { 2, 2 }, { 1, 3 } };
            var points = new int[h, w];

            for (i = 0; i < h; i++)
            {
                for (j = 0; j < w; j++)
                {
                    int x = Math.Abs(j - lockers[0, 0]);
                    int y = Math.Abs(i - lockers[0, 1]);
                    int min = x + y;
                    int k = 0;
                    do
                    {
                        x = Math.Abs(j - lockers[k, 0]);
                        y = Math.Abs(i - lockers[k, 1]);
                        if (x + y <= min)
                        {
                            min = x + y;
                        }
                        k++;

                    } while (k < 3);

                    points[i, j] = min;

                }
            }


            for (i = 0; i < h; i++)
            {
                for (j = 0; j < w; j++)
                {

                    Console.Write(points[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("done");
            Console.ReadLine();
        }
    }
}
