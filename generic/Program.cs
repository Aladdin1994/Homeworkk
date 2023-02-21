using System;
using System.Collections.Generic;
using System.Drawing;

namespace generic
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateTime fromDate = new DateTime(2023,2,1, 14, 30, 0);
            DateTime toDate = new DateTime(2023,2,10, 8, 0, 0);

            var diff=toDate-fromDate;

            Console.WriteLine( diff);
            Console.WriteLine(diff.Days);
            Console.WriteLine(diff.Minutes);
                Console.WriteLine(diff.Hours);

            Console.WriteLine(diff.TotalDays);


            Student std=new Student();
            std.Exams.Add{ Point=10,Subject=}

            List<int>numbers=new List<int>() 
            #region
            //   Dictionary<string, double> Products = new Dictionary<string, double>();
            Student student = new Student()
            {
                FullName = "aBBAS",
                GroupNo = "P112"
            };
          //  student.Exam.Add(new Exams { EndAt= DateTime.Now});
         
         //   student.Exam.Add("history", 34);

           // Console.WriteLine(student.GetAvgPoint());
            //string opt;
            //do
            //{

            //    Console.WriteLine("\n1. mehsul elave et");
            //    Console.WriteLine("2. Butun mehsula bax");
            //    Console.WriteLine("3.Secilmis mehsula bax");
            //    Console.WriteLine("0. cix");

            //    Console.WriteLine("\nsecim edin:");

            //    opt = Console.ReadLine();

            //    switch (opt)
            //    {
            //        case "1":
            //            string Name;
            //            do
            //            {
            //                Console.WriteLine("adi daxil edin");


            //                Name = Console.ReadLine();
            //            } while (Products.ContainsKey(Name));

            //            double price;
            //            do
            //            {
            //                Console.WriteLine("qiymet daxil et");


            //            } while (!double.TryParse(Console.ReadLine(), out price));


            //            Products.Add(Name,price);
            //            break;
            //        case "2":
            //            foreach (var item in Products)

            //                Console.WriteLine(item.Key+"-"+item.Value);

            //            break;
            //        case "3":
            //            Console.WriteLine("Product name:  ");
            //            string search = Console.ReadLine();


            //            if(!Products.ContainsKey(search))
            //            {
            //                Console.WriteLine($"{search}adli mehsul elave edilib, elave etmek isteyirsinizmi?(y/n)");
            //                string chose=Console.ReadLine();
            //                if (chose == "y")

            //                    goto case "1";
            //                break;

            //            }

            //            Console.WriteLine(search + "-" + Products[search]);
            //            break;
            //        case "0":
            //            break;
            //        default:
            //            Console.WriteLine("secim  yanlis:");
            //            break;
            //    }

            //} while (opt != "0");


            #endregion
            List<Student> students = new List<Student>();
            string opt;
            do
            {

                Console.WriteLine("\n1. telebe elave et");
                Console.WriteLine("2. Butun telebelre bax");
                Console.WriteLine("3. telebe ortalamasina bax");
                Console.WriteLine("0. cix");

                Console.WriteLine("\nsecim edin:");

                opt = Console.ReadLine();

                switch (opt)
                {
                    case "1":

                        Console.WriteLine("fullname");
                        string fullname = Console.ReadLine();
                        Console.WriteLine("Grup nomre:  ");
                        string groupNo = Console.ReadLine();

                        //byte point;
                        //string pointstr;
                        //int count = 0;
                        //bool check= false;
                        //do
                        //{
                        //    Console.Write("point");
                        //    pointstr = Console.ReadLine();

                        //    if (!byte.TryParse(pointstr, out point)) count++;
                        //    else check = true;
                        //} while (!check && count < 3);

                        //if (count == 3)
                        //    break;


                        Student std= new Student
                        {
                            FullName = fullname,
                            GroupNo = groupNo,

                           
                        };

                        students.Add(std);
                        break;
                    case "2":
                        foreach(var item in students)
                        {
                            Console.WriteLine(item);
                        }

                        break;
                    case "3":
                        //if (students.Count == 0)
                        //{
                        //    Console.WriteLine("telebe yoxdu");
                        //    break;
                        //}
                        //double sum = 0;
                        //foreach(var item in students)
                        //{
                        //    sum += item.Point;
                        //}
                        //Console.WriteLine(sum/students.Count);




                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("secim yanlis");
                        break;


                }


            } while (opt != "0");
        }

    }
}
