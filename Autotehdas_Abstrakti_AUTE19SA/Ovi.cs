using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Autotehdas_Abstrakti_AUTE19SA
{
    public class Ovi:Osa
    {
        public override string Materiaali => "Teräspelti";
        public override double Paino => 28;
        public override void Asenna()
        {
            Console.WriteLine("ovi asennettu");
        }
    }
}