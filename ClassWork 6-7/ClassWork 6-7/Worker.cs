using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork_6_7
{
    class Worker : Person
    {
        public double salaryForHour;
        public int workHour;

        public Worker(string name, string surname, byte age, double salaryForHour, int workHour) : base(name, surname, age)
        {
            this.salaryForHour = salaryForHour;
            this.workHour = workHour;
        }
        public Worker(string name, string surname, byte age, double salaryForHour) : base(name, surname, age)
        {
            this.salaryForHour = salaryForHour;
        }
        public double CalcSalary(double salaryForHour, byte age, int workHour = 0)
        {
            if (age < 18)
            {
                return -1;
            }
            else
            {
                double salaryForMonth = salaryForHour * workHour;
                return salaryForMonth;
            }
        }
    }
}
