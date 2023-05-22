using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_8.Employee
{
    //Inheritance
    abstract class Bonus
    {
        public virtual decimal CalculateBonus(decimal salary)
        {
            return salary * 0.9M;
        }
    }
    internal class PermenantEmployee : Bonus
    {
        public override decimal CalculateBonus(decimal salary)
        {
            return salary * 0.1M;
        }
    }
    internal class TemporaryEmployee : Bonus
    {
        public override decimal CalculateBonus(decimal salary)
        {
            return salary * 0.5M;
        }
    }
}
