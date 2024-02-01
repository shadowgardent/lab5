using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
   public class Student

    {
        private string studentName;
        private double gpa;
        public Student(string name , double gpa) 
        {
            this.studentName = name;    
            this.gpa = gpa;
        }

        

        public double getGPA() { return gpa; }
    }
}
    

