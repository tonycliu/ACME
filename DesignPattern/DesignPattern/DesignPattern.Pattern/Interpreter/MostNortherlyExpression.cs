using DesignPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Pattern.Interpreter
{
    public class MostNortherlyExpression : IExpression
    {
        private IEnumerable<IExpression> expressions;

        public MostNortherlyExpression(IEnumerable<IExpression> expressions)
        {
            this.expressions = expressions;
        }

        public virtual City Interpret()
        {
            City resultCity = new City("NoWhere", -999.9, -999.9);

            foreach (IExpression expression in this.expressions)
            {
                City currentCity = expression.Interpret();

                if (currentCity.Latitude > resultCity.Latitude)
                {
                    resultCity = currentCity;
                }
            }

            return resultCity;
        }
    }
}
