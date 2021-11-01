using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class CPU
    {
        private static CPU _instance = null;

        private CPU()
        {
            Console.WriteLine("CPU created.");
        }
        public static CPU Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CPU();
                return _instance;
            }
        }

        public int Add(int a, int b) 
        {
            InstructionCount++;
            return a + b;
        }

        public int Sub(int a, int b)
        {
            InstructionCount++;
            return a - b;
        }

        public int Mul(int a, int b)
        {
            InstructionCount++;
            return a * b;
        }

        public int Div(int a, int b)
        {
            if (b == 0) {
                throw new DivideByZeroException("Divide by 0");
            }
            InstructionCount++;
            return a / b;
        }

        public int InstructionCount { get; private set; } = 0;
    }
}
