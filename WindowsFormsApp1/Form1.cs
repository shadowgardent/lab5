using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
  
    public partial class Form1 : Form
    {
        private GPAcal gPAcalculator = new GPAcal();
        public Form1()
        {
            InitializeComponent();

        }




        private void button1_Click(object sender, EventArgs e)
        {
            string studentName = this.textBoxSTUDENT.Text;
            string gpa = textBoxGPA.Text;

            double dGPA = 0;
            double.TryParse(gpa , out dGPA);

            if (dGPA == 0)
                return;

            Student newStudent = new Student(studentName,dGPA);
            gPAcalculator.setStudent(newStudent);

            boxname.Text = studentName.ToString();

            hightscore.Text = gPAcalculator.getHeightScore().ToString();
            lowscore.Text = gPAcalculator.getlowtScore().ToString();
            Average.Text = gPAcalculator.averageScore().ToString();
            boxgpa.Text = gPAcalculator.getGPAX().ToString();



        }

        private void Average_TextChanged(object sender, EventArgs e)
        {
           string  Average = this.Average.Text;

             
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
