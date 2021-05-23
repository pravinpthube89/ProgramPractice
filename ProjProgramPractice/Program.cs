using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjProgramPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Program objProgram = new Program();
            objProgram.Display("Addition", objProgram.Add(10, 20));
            objProgram.Display("Subtraction", objProgram.sub(10, 20));
        }
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int sub(int a, int b)
        {
            return a - b;
        }
        public int Mul(int a, int b)
        {
            return a * b;
        }
        public int Div(int a, int b)
        {
            return a / b;
        }
        public void Display(string calculation,double result)
        {
            Console.WriteLine(calculation +" = "+ result);
        }
    }
}
