using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Autotehdas_Abstrakti_AUTE19SA
{
    public class Auto
    {
        List<Osa> autonosat =new List<Osa>();
        public void KokoaAuto()
        {
            Moottori m = new Moottori();
            autonosat.Add(m);
            m.Asenna();

            for(int i = 0; i < 4; i++) {
                Ovi o = new Ovi();
                autonosat.Add(o);
                o.Asenna();
            }

            
            Puskuri etupuskuri = new Puskuri();
            autonosat.Add(etupuskuri);
            etupuskuri.Asenna();

            Puskuri takapuskuri = new Puskuri();
            autonosat.Add(takapuskuri);
            takapuskuri.Asenna();

        }
        public void LaskePaino()
        {
            Console.WriteLine("Auton paino on ..");
        }
    }
}