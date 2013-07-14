using DesignPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Pattern.ChainOfResponsibility
{
    public class ChainsOfResponsibility
    {
        public static IEmailHandler HandlerSetup()
        {
            IEmailHandler spam = new SpamEmailHandler();
            IEmailHandler sales = new SalesEmailHandler();
            IEmailHandler service = new ServiceEmailHandler();
            IEmailHandler manager = new ManagerEmailHandler();
            IEmailHandler general = new GeneralEmailHandler();

            spam.NextHandler = sales;
            sales.NextHandler = service;
            service.NextHandler = manager;
            manager.NextHandler = general;

            return spam;
        }
    }
}
