using DesignPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Client
{
    public class TemplateMethodDriver
    {
        public static void Run()
        {
            AbstractBookletPrinter saloonBooklet = new SaloonBooklet();
            saloonBooklet.Print();

            AbstractBookletPrinter serviceHistoryBooklet = new ServiceHistoryBooklet();
            serviceHistoryBooklet.Print();
        }
    }
}
