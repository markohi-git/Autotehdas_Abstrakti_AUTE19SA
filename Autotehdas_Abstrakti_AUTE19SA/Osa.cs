using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Autotehdas_Abstrakti_AUTE19SA
{
    public abstract class Osa
    {
        public abstract string Materiaali { get; }
        public abstract double Paino { get; }
        public abstract void Asenna();
    }
}