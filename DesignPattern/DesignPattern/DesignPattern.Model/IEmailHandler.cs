using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Model
{
    public interface IEmailHandler
    {
        IEmailHandler NextHandler { set; }
        void ProcessHandler(string email);
    }
}
