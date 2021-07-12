using System;
using System.Collections.Generic;
using System.Linq;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int nStudents = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> gradeByStudents = new Dictionary<string, List<double>>();
                


            for (int i = 0; i < nStudents; i++)
            {
                string nameOfStudent = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!gradeByStudents.ContainsKey(nameOfStudent))
                {
                    gradeByStudents.Add(nameOfStudent, new List<double>() { grade });
                }
                else
                {
                    gradeByStudents[nameOfStudent].Add(grade);
                }

            }

            Dictionary<string, List<double>> resultFilter = gradeByStudents
                .Where(x => x.Value.Average(x => x) >= 4.50)
                .OrderByDescending(y => y.Value.Average(z => z))
                .ToDictionary(k => k.Key, v => v.Value);

            foreach (var item in resultFilter)
            {
                Console.WriteLine($"{item.Key} -> {(item.Value.Average(x => x)):f2}");
            }


            

            
                
        }
    }
}
