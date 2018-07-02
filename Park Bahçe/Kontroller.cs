using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Park_Bahçe
{
    class Kontroller
    {

        static public bool KimlikNoKontrol(string Deger)
        {
            string deger = Deger.Trim();
            if (deger.Length!=11)
            {
                return false;
            }

            foreach (char item in deger)
            {
                if (!Char.IsDigit(item))
                {
                    return false;
                }
            }

            return true;
        }

        static public bool MetinKontrol(string deger)
        {
            string cumle = deger.Trim();
            if (cumle.Length==0)
            {
                return false;
            }

            foreach (char item in cumle)
            {
                if (!Char.IsLetter(item) && !Char.IsWhiteSpace(item))
                {
                    return false;
                }
            }

            return true;
        }

        static public bool SayiKontrol(string deger)
        {
            int i;

            return Int32.TryParse(deger, out i);
        }

        
    }
}
