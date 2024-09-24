namespace OCP
{
    abstract class SalaryCalc
    {
        public SalaryCalc( Employee employee)
        {
              Employee = employee;  
        }
        public Employee Employee { get; set; }
        public abstract decimal CalcSalary();
    }
}
