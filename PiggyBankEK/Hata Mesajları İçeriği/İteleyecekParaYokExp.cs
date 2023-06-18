using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBankEK.Exception_Library
{
    public class AtilacakParaSecilmediException : Exception
    {
        public AtilacakParaSecilmediException() : base("Lütfen atılacak parayı seçiniz!")
        {

        }
    }
}
