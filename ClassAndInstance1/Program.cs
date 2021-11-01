using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassAndInstance1
{
    class Program
    {
        static void Main(string[] args)
        {
            Form myform = new Form();
          
            //Form myform2;
            //myform2 = myform;
            //Console.WriteLine(myform2 == myform);
            myform.Text = "啥也不是";
            myform.ShowDialog();
       }
    }

}