using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotehdas_Abstrakti_AUTE19SA
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto a = new Auto();
            a.KokoaAuto();
            a.LaskePaino();

            Console.ReadKey();
        }
    }
}
