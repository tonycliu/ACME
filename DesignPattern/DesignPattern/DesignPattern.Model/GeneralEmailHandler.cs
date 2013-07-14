using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Model
{
    public class GeneralEmailHandler : AbstractEmailHandler
    {
        protected internal override string[] MatchingWords()
        {
            return new string[] { };
        }

        protected internal override void ProcessHere(string email)
        {
            Console.WriteLine("Email handled by general enquires.");
        }
    }
}
