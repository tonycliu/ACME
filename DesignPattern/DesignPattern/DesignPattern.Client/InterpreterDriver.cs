using DesignPattern.Pattern.Interpreter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Client
{
    public class InterpreterDriver
    {
        public static void Run()
        {
            DirectionalEvaluator evaluator = new DirectionalEvaluator();
            string route = "london edinburgh manchester south";
            Console.WriteLine(evaluator.Evaluate(route));

            route = "london edinburgh manchester south aberdeen west";
            Console.WriteLine(evaluator.Evaluate(route));
        }
    }
}
