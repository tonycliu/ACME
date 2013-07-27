using DesignPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Pattern.Command
{
    public class WindowDownCommand : IVoiceCommand
    {
        private ElectricWindow window;

        public WindowDownCommand(ElectricWindow window)
        {
            this.window = window;
        }

        public virtual void Execute()
        {
            window.OpenWindow();
        }
    }
}
