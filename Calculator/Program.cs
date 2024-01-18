using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Program 
    {
        static void Main(string[] args)
        {
            Calculator calculate = new Calculator();

            calculate.Start();

            int choice = int.Parse(Console.ReadLine());

            Calculate(choice, calculate);          
        }

        public static void Calculate(int choice, Calculator calculate) 
        
        {
            calculate.Chice();

            switch (choice)
            {
                case 1:
                    calculate.Add();
                    break;
                case 2:                   
                    calculate.Subtract();                    
                    break;
                case 3:
                    calculate.Divide();
                    break;
                case 4:
                    calculate.MultiPly();
                    break;
                default:
                    break;
            }

               calculate.End();
        }
        
    }
}
