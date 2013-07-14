using DesignPattern.Model;
using DesignPattern.Pattern.ChainOfResponsibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Client
{
    public class ChainsOfResponsibilityDriver
    {
        public static void Run()
        {
            IEmailHandler handler = ChainsOfResponsibility.HandlerSetup();
            string spam = "You need viagra! You need this!";
            string service = "Please repair this hard drive!";

            handler.ProcessHandler(spam);
            handler.ProcessHandler(service);

        }
    }
}
