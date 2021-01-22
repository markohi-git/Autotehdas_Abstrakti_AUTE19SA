using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Autotehdas_Abstrakti_AUTE19SA
{
    public class Moottori:Osa
    {
        public override string Materiaali => "Alumiini";
        public override double Paino => 85;
        public override void Asenna()
        {
            Console.WriteLine("moottori asennettu");
        }
    }
}