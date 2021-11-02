using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Calculation.Method1(100);
            int result2 = Calculation.MySum(100);
            Console.WriteLine(result);
            Console.WriteLine(result2);
            Calculation.Hnoi(3, "A", "B", "C");
            Console.WriteLine(Calculation.fabo(0));       
            Form form = new Form();
            form.ShowDialog();
        }
    }

    class Calculation
    {
        public static int Method1(int sum)
        {
            int s = 0;
            for (int i = 1; i <= sum; i++)
            {
                s += i;
            }
            return s;
        }

        public static int MySum(int x)
        {
            if (x == 1)
            {
                return 1;
            }
            else
            {
                int result = x + MySum(x - 1);
                return result;
            }
        }
        public static void Hnoi(int s, String from, String mid, String to)
        {
            if(s == 1)
            {
                Console.WriteLine(from +" move to "+ to);
            }
            else
            {
                Hnoi(s-1,from,to,mid);
                Console.WriteLine(from+" move to "+to);
                Hnoi(s - 1, mid, from, to);
            }
        }
        public static int fabo(int n)
        {
            if (n==1||n==2)
            {
                return 1;
            }
            else if(n>2)
            {
                return fabo(n - 1) + fabo(n - 2);
            }
            return -1;
        } 
    }
}
