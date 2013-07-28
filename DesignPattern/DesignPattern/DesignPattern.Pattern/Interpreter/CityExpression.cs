using DesignPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Pattern.Interpreter
{
    public class CityExpression : IExpression
    {
        private City city;

        public CityExpression(City city)
        {
            this.city = city;
        }

        public City Interpret()
        {
            return city;
        }
    }
}
