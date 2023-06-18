using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBankEK
{
    public class Kumbara : ISallanabilir
    {
        public Kumbara(int hacim)
        {
            KumbaraHacmi = hacim;
        }
        public double KumbaraHacmi { get; set; }
        public double Salla(double fazladanKaplananHacim)
        {
            Random rnd = new Random();
            return fazladanKaplananHacim = fazladanKaplananHacim * rnd.Next(25, 75) * 0.01; //0.001 mi kontrol et
        }
        public double ParaMiktari { get; set; }
        public double DolulukOrani => ParaMiktari / KumbaraHacmi;
        public void ParaEkle(double miktar)
        {
            ParaMiktari += miktar;
        }
    }
}
