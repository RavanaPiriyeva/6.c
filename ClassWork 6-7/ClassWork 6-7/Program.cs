using System;

namespace ClassWork_6_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Revane";
            string surname = "Piriyeva";
            byte age = 12;
            double salary = 15;
            int workhour = 30;

            Worker worker = new Worker(name, surname, age, salary);
            if (worker.CalcSalary(salary, age, workhour) != -1)
            {
                Console.WriteLine(worker.CalcSalary(salary, age, workhour));
            }
            else
            {
                Console.WriteLine("ishleye bilmez");
            }
        }
    }
}
