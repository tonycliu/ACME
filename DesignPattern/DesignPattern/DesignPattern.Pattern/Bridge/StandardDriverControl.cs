using DesignPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Pattern.Bridge
{
    public class StandardDriverControl : AbstractDriverControl
    {
        public StandardDriverControl(IEngine engine) : base(engine)
        {

        }
    }
}
