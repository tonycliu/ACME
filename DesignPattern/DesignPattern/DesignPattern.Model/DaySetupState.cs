using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Model
{
    public class DaySetupState : IClockSetupState
    {
        private ClockSetup clockSetup;
        private int day;

        public DaySetupState(ClockSetup clockSetup)
        {
            this.clockSetup = clockSetup;
            day = DateTime.Now.Day;
        }
        public void PreviousValue()
        {
            if (this.day > 1)
                this.day--;
        }

        public void NextValue()
        {
            if (this.day < DateTime.DaysInMonth(clockSetup.YearSetupState.SelectedValue, clockSetup.MonthSetupState.SelectedValue))
                this.day++;
        }

        public void SelectValue()
        {
            Console.WriteLine("Select day: " + this.day);
            Console.WriteLine("Done -- " + this.clockSetup.SelectedDate.ToShortDateString());
        }

        public int SelectedValue
        {
            get { return this.day; }
        }

        public string Instruction
        {
            get { return "Please setup day..."; }
        }
    }
}
