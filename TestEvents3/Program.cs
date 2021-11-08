using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestEvents3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyForm form = new MyForm();
            form.Click += form.FormClicked;
        }
    }

    class MyForm : Form
    {
        internal void FormClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
