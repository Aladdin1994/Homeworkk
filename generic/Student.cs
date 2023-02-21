using System;
using System.Collections.Generic;
using System.Text;

namespace generic
{
    internal class Student
    {
        public string FullName;
        public string GroupNo;
        public List<Exams> Exams = new List<Exams>();

        public override string ToString()
        {
            return FullName + "-" + GroupNo;
        }

        public List<Exams> GetExamsByPointRange(byte minPoint,byte maxPoint)
        {
            List<Exams> wantedExams=new List<Exams>();
            foreach(var item in Exams)
            {
                if(item.Point>=minPoint&&item.Point<=maxPoint)
                    wantedExams.Add(item);
            }
            return wantedExams;
        }
        public List<Exams> GetExamsByDateRange(DateTime fromDate,DateTime toDate)

        {
            List<Exams> wantedExmas=new List<Exams>();
            foreach(var item in Exams)
            {
                if(item.StartAt>=fromDate && item.FinishAt<=toDate) 
                    wantedExmas.Add(item);
            }    
            return wantedExmas;
        }

        public double GetAvgPoint()
        {
            double sum = 0;
            foreach(var item in Exams)
            {
                sum += item.Point;
            }
            return  sum/Exams.Count;
        }

        public double GetTotalExamination()
        {
            double totalMInutes = 0;
            foreach (var item in Exams)
            {
                var diff = item.FinishAt - item.StartAt;
                totalMInutes += diff.TotalMinutes;
            }
            return totalMInutes;
        }
    }
}
