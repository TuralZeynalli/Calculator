using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    abstract class  MathematicFonction : IConsoleWriteline, IConsoleWriteline2, IConsoleWriteline3
    {
        protected decimal num1;
        protected decimal num2;
        
        public void GetNumbers()         
        {
            num1 = decimal.Parse(Console.ReadLine());
            num2 = decimal.Parse(Console.ReadLine());
        }
       
        public abstract void MultiPly();

        public abstract void Divide();

        public abstract void Subtract();

        public abstract void Add();

        public void End()
        {
            Console.WriteLine("Thanks for your operating");
        }

        public void Chice()
        {
            Console.WriteLine("Get numbers");
        }

        public void Start()
        {
            Console.WriteLine("Choice operation \n Button 1 - Add, \n Button 2 - Subtract, \n Button 3 - Divide, \n Button 4 - Multiply");
        }
    }
}
