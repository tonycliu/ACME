using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Model
{
    public abstract class AbstractBookletPrinter
    {
        protected internal abstract int PageCount { get; }
        protected internal abstract void PrintFrontCover();
        protected internal abstract void PrintTableOfContent();
        protected internal abstract void PrintPage(int pageNum);
        protected internal abstract void PrintIndex();
        protected internal abstract void PrintBackCover();

        public void Print()
        {
            PrintFrontCover();
            PrintTableOfContent();
            for (int i = 1; i <= this.PageCount; i++)
            {
                PrintPage(i);
            }
            PrintIndex();
            PrintBackCover();
        }
    }
}
