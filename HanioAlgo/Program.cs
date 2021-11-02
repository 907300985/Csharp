using System;

namespace HanioAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyHano(2, "A", "B", "C");
        }

        public static void MyHano(int s, String left, String mid, String right)
        {
            if(s == 1)
            {
                Console.WriteLine(left+" 移到 "+right);
            }
            else
            {
                MyHano(s-1,left, right, mid);
                Console.WriteLine(left+" 移到 "+right);
                MyHano(s - 1, mid, left, right);
            }
        }

    }
}
