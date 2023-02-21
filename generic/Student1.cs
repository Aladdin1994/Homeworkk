using System;
using System.Collections.Generic;
using System.Text;

namespace generic
{
    internal class Student1
    {
        public string FullName;
        public string GroupNo;
        


      // public Dictionary<string, byte > Exam = new Dictionary<string, byte>();
         
         public List <Exams>Exam=new List<Exams>();

        public double GetAvgPoint()
        {
            double sum = 0;
            foreach (var item in Exam)
            {
                sum+=item.Point;
            }
            return sum / Exam.Count;
        }

        
    }
}
