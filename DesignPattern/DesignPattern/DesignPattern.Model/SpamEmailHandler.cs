using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Model
{
    public class SpamEmailHandler : AbstractEmailHandler
    {
        protected internal override string[] MatchingWords()
        {
            return new string[] { "viagra", "pills", "medicines" };
        }

        protected internal override void ProcessHere(string email)
        {
            Console.WriteLine("Email handled by spam software.");
        }
    }
}
