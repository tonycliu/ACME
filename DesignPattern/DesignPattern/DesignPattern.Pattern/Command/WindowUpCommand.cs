using DesignPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Pattern.Command
{
    public class WindowUpCommand : IVoiceCommand
    {
        private ElectricWindow window;

        public WindowUpCommand(ElectricWindow window)
        {
            this.window = window;
        }

        public virtual void Execute()
        {
            window.CloseWindow();
        }
    }
}
