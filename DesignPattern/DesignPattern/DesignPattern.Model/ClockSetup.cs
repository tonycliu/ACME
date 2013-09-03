using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Model
{
    public class ClockSetup
    {
        private YearSetupState yearState;
        private MonthSetupState monthState;
        private DaySetupState dayState;

        private IClockSetupState currentState;

        public ClockSetup()
        {
            this.yearState = new YearSetupState(this);
            this.monthState = new MonthSetupState(this);
            this.dayState = new DaySetupState(this);
            this.State = yearState;
        }

        public virtual IClockSetupState State { 
            get { return this.currentState; }
            set 
            {
                this.currentState = value;
                Console.WriteLine(this.currentState.Instruction);
            }
        }

        public virtual void RotateRight()
        {
            this.currentState.NextValue();
        }
        public virtual void RotateLeft()
        {
            this.currentState.PreviousValue();
        }
        public virtual void Push()
        {
            this.currentState.SelectValue();
        }

        public virtual DateTime SelectedDate
        {
            get { return new DateTime(yearState.SelectedValue, monthState.SelectedValue, dayState.SelectedValue); }
        }

        public virtual IClockSetupState YearSetupState
        {
            get { return yearState; }
        }

        public virtual IClockSetupState MonthSetupState
        {
            get { return monthState; }
        }

        public virtual IClockSetupState DaySetupState
        {
            get { return dayState; }
        }
    }
}
