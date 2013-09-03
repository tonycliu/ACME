using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Model
{
    public interface IClockSetupState
    {
        void PreviousValue();
        void NextValue();
        void SelectValue();

        int SelectedValue { get; }
        string Instruction { get; }
    }
}
