using System;
using System.Collections.Generic;
using System.Text;

namespace Acelera.OO.Examples.Inheritance
{
    public class Employee
    {
        public Employee(decimal wage)
        {
            this.Wage = wage;

            Bonus = 0.1M;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime BithDate { get; set; }
        public DateTime HireDate { get; set; }
        public decimal Wage { get; set; }
        public decimal Bonus { get; set; }

        public decimal GetBonus()
        {
            return Wage * Bonus;
        }
    }

    public class Manager
    {
        public Manager(decimal wage)
        {
            this.Wage = wage;

            Bonus = 0.2M;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime BithDate { get; set; }
        public DateTime HireDate { get; set; }
        public decimal Wage { get; set; }
        public decimal Bonus { get; set; }

        public decimal GetBonus()
        {
            return Wage * Bonus;
        }
    }

    public class CEO
    {
        public CEO(decimal wage)
        {
            this.Wage = wage;

            Bonus = 0.3M;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime BithDate { get; set; }
        public DateTime HireDate { get; set; }
        public decimal Wage { get; set; }
        public decimal Bonus { get; set; }

        public decimal GetBonus()
        {
            return Wage * Bonus;
        }
    }
}
