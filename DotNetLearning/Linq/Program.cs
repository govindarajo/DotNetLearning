using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linq
{
    internal class Program
    {
        static void Main()
        {
            ExtensionMethod();
           
        }

        private static void LinqQueries()
        {
            using (var form = new Form1())
            {
                form.ShowDialog();
            }
        }
        private static void ExtensionMethod()
        {
            string name = "govind";
            //var updatedName = StringExtensionMethod.ChangeFirstChar(name);

            var updatedName = name.ChangeFirstChar();
            MessageBox.Show(updatedName);
        }
    }
}
