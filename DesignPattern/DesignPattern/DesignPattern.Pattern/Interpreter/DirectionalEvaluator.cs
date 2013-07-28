using DesignPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Pattern.Interpreter
{
    public class DirectionalEvaluator
    {
        private IDictionary<string, City> cities;

        public DirectionalEvaluator()
        {
            cities = new Dictionary<string, City>();

            cities.Add("aberdeen", new City("aberdeen", 57.15, -2.15));
            cities.Add("belfast", new City("belfast", 54.62, -5.93));
            cities.Add("brimingham", new City("brimingham", 52.42, -1.92));
            cities.Add("dublin", new City("dublin", 53.33, -6.25));
            cities.Add("edinburgh", new City("edinburgh", 55.92, -3.02));
            cities.Add("glasgow", new City("glasgow", 55.83, -4.25));
            cities.Add("london", new City("london", 51.53, -0.08));
            cities.Add("liverpool", new City("liverpool", 53.42, -3.0));
            cities.Add("manchester", new City("manchester", 53.5, -2.25));
            cities.Add("southampton", new City("southampton", 50.9, -1.38));
        }

        public virtual City Evaluate(string route)
        {
            Stack<IExpression> expressionStack = new Stack<IExpression>();
            IList<string> tokens = route.ToLower().Split(new char[] { ' ' });

            foreach (string token in tokens)
            {
                if (cities.ContainsKey(token))
                {
                    expressionStack.Push(new CityExpression(cities[token]));
                }
                else if (token == "north")
                {
                    expressionStack.Push(new MostNortherlyExpression(LoadExpressions(expressionStack)));
                }
                else if (token == "south")
                {
                    expressionStack.Push(new MostSoutherlyExpression(LoadExpressions(expressionStack)));
                }
                else if (token == "east")
                {
                    expressionStack.Push(new MostEasterlyExpression(LoadExpressions(expressionStack)));
                }
                else if (token == "west")
                {
                    expressionStack.Push(new MostWesterlyExpression(LoadExpressions(expressionStack)));
                }
            }

            return expressionStack.Pop().Interpret();
        }

        private IEnumerable<IExpression> LoadExpressions(Stack<IExpression> expressionStack)
        {
            IList<IExpression> expressions = new List<IExpression>();

            while (expressionStack.Count > 0)
            {
                expressions.Add(expressionStack.Pop());
            }

            return expressions;
        }
    }
}
