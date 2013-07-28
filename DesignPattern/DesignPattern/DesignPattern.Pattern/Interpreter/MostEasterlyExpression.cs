using DesignPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Pattern.Interpreter
{
    public class MostEasterlyExpression : IExpression
    {
        private IEnumerable<IExpression> expressions;

        public MostEasterlyExpression(IEnumerable<IExpression> expressions)
        {
            this.expressions = expressions;
        }

        public virtual City Interpret()
        {
            City resultCity = new City("NoWhere", -999.9, -999.9);

            foreach (IExpression expression in this.expressions)
            {
                City currentCity = expression.Interpret();

                if (currentCity.Longtitude > resultCity.Longtitude)
                {
                    resultCity = currentCity;
                }
            }

            return resultCity;
        }
    }
}
