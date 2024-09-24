using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var salariedEmployee = new SalariedEmployee
            {
                BasicSalary = 5000,
                Transportation = 500,
                Housing = 1000
            };

            var calculator = new SalariedEmployeeSalaryCalc(salariedEmployee);
            decimal salary = calculator.CalcSalary();
            Console.WriteLine($"Total Salary: {salary}");

            Console.ReadKey();
        }
    }

    class SalariedEmployee : Employee {
        public decimal BasicSalary { get; set; }    
        public decimal Transportation { get; set; }
        public decimal Housing { get; set; }

        public override IEnumerable<PayItem> GetPayItems()
        {
            return new[] {
            new PayItem("Basic Salary", BasicSalary),
            new PayItem("Transportation", Transportation),
            new PayItem("Housing", Housing)
        };
        }
    }
    class SalariedEmployeeSalaryCalc : SalaryCalc
    {
        public SalariedEmployeeSalaryCalc(SalariedEmployee employee) : base(employee)
        {
        }

        public override decimal CalcSalary()
        {
            var salariedEmployee = (SalariedEmployee)Employee;
            return salariedEmployee.BasicSalary + salariedEmployee.Transportation + salariedEmployee.Housing;
        }
    }

    class FreelanceEmployee : Employee
    {
        public decimal ProjectFee { get; set; }

        public override IEnumerable<PayItem> GetPayItems()
        {
            return new[]
            {
            new PayItem("Project Fee", ProjectFee)
        };
        }
    }

    class FreelanceEmployeeSalaryCalc : SalaryCalc
    {
        public FreelanceEmployeeSalaryCalc(FreelanceEmployee employee) : base(employee)
        {
        }

        public override decimal CalcSalary()
        {
            var freelanceEmployee = (FreelanceEmployee)Employee;
            return freelanceEmployee.ProjectFee;
        }
    }


    class BonusEmployee : Employee
    {
        public decimal BaseSalary { get; set; }
        public decimal Bonus { get; set; }

        public override IEnumerable<PayItem> GetPayItems()
        {
            return new[]
            {
            new PayItem("Base Salary", BaseSalary),
            new PayItem("Bonus", Bonus)
        };
        }
    }

    class BonusEmployeeSalaryCalc : SalaryCalc
    {
        public BonusEmployeeSalaryCalc(BonusEmployee employee) : base(employee)
        {
        }

        public override decimal CalcSalary()
        {
            var bonusEmployee = (BonusEmployee)Employee;
            return bonusEmployee.BaseSalary + bonusEmployee.Bonus;
        }
    }
}
