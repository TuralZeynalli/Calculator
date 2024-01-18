using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Calculator : MathematicFonction
    {
        public override void Add()
        {
            GetNumbers();
            Console.WriteLine($"{num1 + num2}");
        }

        public override void Divide()
        {
            GetNumbers();
            Console.WriteLine($"{num1 / num2}");
        }

        public override void MultiPly()
        {
            GetNumbers();
            Console.WriteLine($"{num1 * num2}");
        }

        public override void Subtract()
        {
            GetNumbers();
            Console.WriteLine($"{num1 - num2}");
        }     

    }
}
