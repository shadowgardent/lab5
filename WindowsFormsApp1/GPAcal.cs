using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class GPAcal
    {
        private List<Student> _student = new List<Student>();

        double sum;

        public void setStudent(Student student)
        {
            this._student.Add(student);

        }
        public double sumgpa()
        {
            sum = 0;
            foreach (Student student in _student)
            {
                sum += student.getGPA();
            }
            return sum;
        }



            public double getGPAX()
        {

            double sum = (sumgpa() * 3) / (3 * this._student.Count);
            return sum;

        }
        public double getHeightScore()
        {
            double height = 0;
            foreach (Student student in _student)
            {
                if (student.getGPA() > height)
                {
                    height  = student.getGPA();
                }
            }
            return height;

        }

    

        public double getlowtScore()
        {
            double  lows = this.getHeightScore();
            foreach (Student student in _student)
            {
                if (student.getGPA() < lows)
                {
                    lows = student.getGPA();
                }
            }
               return lows;

        }

        public double averageScore()
        {
            double avScore;

            avScore = this.sumgpa() / this._student.Count();
            return avScore;
        }
    }

}   