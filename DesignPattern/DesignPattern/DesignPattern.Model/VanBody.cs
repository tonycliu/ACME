using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Model
{
    public class VanBody : IBody
    {
        public string BodyParts
        {
            get { return "Body shell parts for a van."; }
        }
    }
}
