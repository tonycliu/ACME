using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Model
{
    public abstract class AbstractEmailHandler : IEmailHandler
    {
        private IEmailHandler nextHandler;

        protected internal abstract string[] MatchingWords();
        protected internal abstract void ProcessHere(string email);

        public IEmailHandler NextHandler
        {
            set { nextHandler = value; }
        }

        public void ProcessHandler(string email)
        {
            bool canProcess = false;

            if (this.MatchingWords().Length == 0)
                canProcess = true;
            else
            {
                foreach (string word in this.MatchingWords())
                {
                    if (email.IndexOf(word) >= 0)
                    {
                        canProcess = true;
                        break;
                    }
                }
            }

            if (canProcess)
            {
                this.ProcessHere(email);
            }
            else
            {
                nextHandler.ProcessHandler(email);
            }
        }
    }
}
