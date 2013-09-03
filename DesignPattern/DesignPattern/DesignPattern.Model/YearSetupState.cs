using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Model
{
    public class YearSetupState : IClockSetupState
    {
        private ClockSetup clockSetup;
        private int year;

        public YearSetupState(ClockSetup clockSetup)
        {
            this.clockSetup = clockSetup;
            year = DateTime.Now.Year;
        }
        public void PreviousValue()
        {
            year--;
        }

        public void NextValue()
        {
            year++;
        }

        public void SelectValue()
        {
            Console.WriteLine("Select year: " + this.year);
            this.clockSetup.State = clockSetup.MonthSetupState;
        }

        public int SelectedValue
        {
            get { return year; }
        }

        public string Instruction
        {
            get { return "Please setup year..."; }
        }
    }
}
