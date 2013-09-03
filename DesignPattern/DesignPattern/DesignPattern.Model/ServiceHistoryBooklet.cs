using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Model
{
    public class ServiceHistoryBooklet : AbstractBookletPrinter
    {
        protected internal override int PageCount
        {
            get { return 12; }
        }

        protected internal override void PrintFrontCover()
        {
            Console.WriteLine("Print front cover for Service History booklet");
        }

        protected internal override void PrintTableOfContent()
        {
            Console.WriteLine("Print table of content for Service History booklet");
        }

        protected internal override void PrintPage(int pageNum)
        {
            Console.WriteLine("Print page " + pageNum + " for Service History booklet");
        }

        protected internal override void PrintIndex()
        {
            Console.WriteLine("Print index for Service History booklet");
        }

        protected internal override void PrintBackCover()
        {
            Console.WriteLine("Print back cover for Service History booklet");
        }
    }
}
