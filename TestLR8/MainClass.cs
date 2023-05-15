using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLR8
{
    public class MainClass
    {
        public double task1_1(double x)
        {
            if (x > 0)
                return 2 * x - 10;
            else if (x == 0)
                return 0;
            else
                return 2 * Math.Abs(x) - 1;
        }
        public double[] task1_2(double a, double b)
        {
            double[] c = {b, a };
            return c;
        }
        public int task2_1(int a, int b, int c)
        {
            if (a > b)
                if (a > c)
                    return a;
                else return c;
            else if (b > c)
                return b;
            else return c;
        }
        public int[] task2_2(int a)
        {
            int sum = 0;
            int proz = 1;
            while (a > 0)
            {
                sum += a % 10;
                proz *= a % 10;
                a = a / 10;
            }
            int[] answer = { sum, proz };
            return answer;
        }
        public int task3_1(int a)
        {
            int b = 1;
            while (a > 1)
            {
                b *= a;
                a--;
            }
            return b;
        }
        public int task3_2(Int64 a)
        {
            int max = 0;
            while (a > 0)
            {
                if (a % 10 > max)
                {
                    max=Convert.ToInt32(a % 10);
                }
                a = a / 10;
            }
            return max;
        }
    }
}
