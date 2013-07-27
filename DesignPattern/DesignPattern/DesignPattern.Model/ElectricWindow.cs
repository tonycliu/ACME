using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Model
{
    public class ElectricWindow
    {
        private bool open;

        public ElectricWindow()
        {
            open = false;
        }

        public virtual bool Open
        {
            get
            {
                return open;
            }
        }

        public virtual bool Closed
        {
            get
            {
                return (!open);
            }
        }

        public virtual void OpenWindow()
        {
            if (Closed)
            {
                open = true;
                Console.WriteLine("Window is now opened");
            }
        }

        public virtual void CloseWindow()
        {
            if (Open)
            {
                open = false;
                Console.WriteLine("Window is now closed");
            }
        }
    }
}
