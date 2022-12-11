using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class Auto
    {
        private string znacka;
        private double spotreba;
        private int ujetoCelkem;
        private DateTime okamzikRozjezdu;
        private int dobaJizdyCelkem;
        private bool jede;
        public bool Jede
        {
            get 
            {
                return jede;
            }
        }
        public Auto(string znacka,double spotreba)
        {
            this.znacka = znacka;
            this.spotreba = spotreba;
            ujetoCelkem = 0;
            dobaJizdyCelkem = 0;
            jede = false;
        }
        public int VratUjeteKm()
        {
            return ujetoCelkem;
        }
        public void Rozjed()
        {
            jede = true;
            okamzikRozjezdu = DateTime.Now;
        }
        public void Zastav(int celkoveKm)
        {
            jede = false;
            ujetoCelkem = ujetoCelkem + celkoveKm;
            TimeSpan cas = DateTime.Now - okamzikRozjezdu;
            dobaJizdyCelkem = Convert.ToInt32(cas.TotalSeconds);
        }
        public double CelkovaSpotreba()
        {
            double spotreba100km = ((double)ujetoCelkem / 100) * (double)spotreba;
            return Math.Round(spotreba100km, 3);
        }
        public override string ToString()
        {
            if(jede == true)
            {
                return "Auto značky " + this.znacka + " ujelo celkem " + this.ujetoCelkem.ToString() + "km" + " se spotřebou " + this.spotreba.ToString() + " litrů na 100km " + " za " + this.dobaJizdyCelkem.ToString() + " hodin." + "Auto je stále v pohybu.";
            }
            else
            {
                return "Auto značky " + this.znacka + " ujelo celkem " + this.ujetoCelkem.ToString() + "km" + " se spotřebou " + this.spotreba.ToString() + " litrů na 100km " + " za " + this.dobaJizdyCelkem.ToString() + " hodin." + "Auto už není v pohybu.";
            }
        }
    }
}
