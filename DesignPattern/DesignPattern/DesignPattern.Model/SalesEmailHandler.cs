﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Model
{
    public class SalesEmailHandler : AbstractEmailHandler
    {
        protected internal override string[] MatchingWords()
        {
            return new string[] { "buy", "purchase" };
        }

        protected internal override void ProcessHere(string email)
        {
            Console.WriteLine("Email handled by sales department.");
        }
    }
}
