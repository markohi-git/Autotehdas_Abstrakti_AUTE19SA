using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Autotehdas_Abstrakti_AUTE19SA
{
    public class Puskuri:Osa
    {
        public override string Materiaali => "ABS-muovi";
        public override double Paino => 13;
        public override void Asenna()
        {
            Console.WriteLine("puskuri asennettu");
        }
    }
}