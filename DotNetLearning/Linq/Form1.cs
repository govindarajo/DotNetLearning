using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            LamdaVsLinqQuery();
            //DataClasses1DataContext db = new DataClasses1DataContext();

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            ////var list = (from lis in db.Employees
            ////            select lis).ToList();

            //dataGridView1.DataSource = from number in numbers
            //            where (number % 2) == 0
            //            select number;

            //dataGridView1.Refresh();
            //dataGridView1.DataSource = list;
        }

        private void LamdaVsLinqQuery()
        {
            //Lamda
            //var stuList = Student.GetAllStudents().Where(student => student.Gender == "Female").ToList();
            //dataGridView1.DataSource = stuList;

            //Sql Like query

            var stuList = (from student in Student.GetAllStudents()
                          where student.Gender == "Female"
                          select student).ToList();

            dataGridView1.DataSource = stuList;
        }
         
    }
}
