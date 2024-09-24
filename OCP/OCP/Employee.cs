using System.Collections.Generic;

namespace OCP
{
    abstract class Employee
    {
       public string Email { get; set;  }
        public abstract IEnumerable<PayItem> GetPayItems();
    }
}
