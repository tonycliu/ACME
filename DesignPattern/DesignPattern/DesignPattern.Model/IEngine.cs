using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Model
{
    public interface IEngine
    {
        int Size { get; }
        bool Turbo { get; }

        void Start();
        void Stop();
        void IncreasePower();
        void DescresePower();
    }
}
