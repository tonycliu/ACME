using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Model
{
    public class SaloonBooklet : AbstractBookletPrinter
    {
        protected internal override int PageCount
        {
            get { return 100; }
        }

        protected internal override void PrintFrontCover()
        {
            Console.WriteLine("Print front cover for Saloon booklet");
        }

        protected internal override void PrintTableOfContent()
        {
            Console.WriteLine("Print table of content for Saloon booklet");
        }

        protected internal override void PrintPage(int pageNum)
        {
            Console.WriteLine("Print page " + pageNum + " for Saloon booklet");
        }

        protected internal override void PrintIndex()
        {
            Console.WriteLine("Print index for Saloon booklet");
        }

        protected internal override void PrintBackCover()
        {
            Console.WriteLine("Print back cover for Saloon booklet");
        }
    }
}
