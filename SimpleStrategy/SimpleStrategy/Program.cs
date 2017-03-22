using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStrategy
{
    public interface IStrategy
    {
        double Calculate(double a, double b);
    }

    public class Context
    {
        private IStrategy strategy = null;
        
        public Context(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public double Calculate(double a, double b)
        {
            return this.strategy.Calculate(a, b); 
        }
    }

    public class OperationAddition : IStrategy
    {
        public double Calculate(double a, double b)
        {
            return a + b;
        }
    }

    public class OperationSubstraction : IStrategy
    {
        public double Calculate(double a, double b)
        {
            return a - b;
        }
    }

    public class OperationMultiply : IStrategy
    {
        public double Calculate(double a, double b)
        {
            return a * b;
        }
    }

    public class OperationDivision : IStrategy
    {
        public double Calculate(double a, double b)
        {
            return a / b;
        }
    }

    public enum Operations
    {
        Addition,
        Substraction,
        Myltiply,
        Division
    }

    class Program
    {
        static void Main(string[] args)
        {
            double a = 15;
            double b = 3;

            Operations operation = Operations.Addition;

            //OperationAddition add = new OperationAddition();
            //OperationSubstraction sub = new OperationSubstraction();
            //OperationMultiply mul = new OperationMultiply();
            //OperationDivision div = new OperationDivision();

            Context context = null;
                            
            switch(operation)
            {
                case Operations.Addition:
                {
                    context = new Context(new OperationAddition());
                    break;
                }

                case Operations.Substraction:
                {
                    context = new Context(new OperationSubstraction());
                    break;
                }

                case Operations.Myltiply:
                {
                    context = new Context(new OperationMultiply());
                    break;
                }

                case Operations.Division:
                {
                    context = new Context(new OperationDivision());
                    break;
                }
            }

            Console.WriteLine(context.Calculate(a,b));
            Console.ReadLine();
        }
    }
}
