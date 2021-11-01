using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = CPU.Instance.Add(2, 3);
            Console.WriteLine($"Result: {result}, CPU instruction count: {CPU.Instance.InstructionCount}");
            new Calculator().Start();
        }
    }
}
