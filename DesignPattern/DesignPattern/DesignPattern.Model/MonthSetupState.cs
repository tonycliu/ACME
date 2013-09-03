using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Model
{
    public class MonthSetupState : IClockSetupState
    {
        private ClockSetup clockSetup;
        private int month;

        public MonthSetupState(ClockSetup clockSetup)
        {
            this.clockSetup = clockSetup;
            month = DateTime.Now.Month;
        }

        public void PreviousValue()
        {
            if (this.month > 1)
                month--;
        }

        public void NextValue()
        {
            if (this.month < 12)
                month++;
        }

        public void SelectValue()
        {
            Console.WriteLine("Select month: " + this.month);
            this.clockSetup.State = this.clockSetup.DaySetupState;
        }

        public int SelectedValue
        {
            get { return this.month; }
        }

        public string Instruction
        {
            get { return "Please setup month..."; }
        }
    }
}
