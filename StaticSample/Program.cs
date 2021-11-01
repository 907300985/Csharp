using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaticSample
{
    class Program

    {
        static String name = "NANDI";
        

        static void Main(string[] args)
        {
            Console.WriteLine("静态方法");
            Form form = new Form();
            form.Text = "hello";
            form.ShowDialog();
        }
        public void eat()
        {
            Console.WriteLine("eat");
        }
    }
}
