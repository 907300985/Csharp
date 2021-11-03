using System;
using System.Collections;
using System.Collections.Generic;

namespace trycatch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(new Cal().Add("99999999999999", "123")); 

            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            /*            foreach (int l in list)
                        {
                            Console.WriteLine(l);
                        }*/
            IEnumerator e = list.GetEnumerator();
            while (e.MoveNext())
            {
                Console.WriteLine(e.Current);
            }


          

        }

    }
    class Cal
    {
        public int Add(String arg1, String arg2)
        {
            int a = 0, b = 0;
            
            try
            {
                a = int.Parse(arg1);
                b = int.Parse(arg2);
            }
            catch(ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch(FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
            catch(OverflowException oe)
            {
                Console.WriteLine(oe.Message);
       
            }
            return a + b;
        }
    }
}
