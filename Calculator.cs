using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Calculator
    {
        public void Start()
        {
            CPU.Instance.Div(10, 5);
            CPU.Instance.Mul(1111, 1111);
            Console.WriteLine($"CPU instruction count: {CPU.Instance.InstructionCount}");

        }
    }
}
