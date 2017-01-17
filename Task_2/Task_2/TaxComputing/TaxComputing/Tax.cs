using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxComputing
{
    public class Tax
    {
        public enum Country
        {
            USA,
            Ukraine,
            Norway
        }
        //public short PerсentByCountry(Country country)
        //{
        //    short percent = 0;
        //    switch (country)
        //    {
        //        case Country.Norway:
        //            { percent = 30; }
        //            break;
        //        case Country.USA:
        //            { percent = 10; }
        //            break;
        //        case Country.Ukraine:
        //            { percent = 15; }
        //            break;
        //    }
        //    return percent;
        //}

        public short PerсentByCountry(Country country, out short additionalPersent)
        {
            additionalPersent = 0;
            short percent = 0;
            switch (country)
            {
                case Country.Norway:
                    { percent = 30; }
                    break;
                case Country.USA:
                    { percent = 10; }
                    break;
                case Country.Ukraine:
                    {
                        percent = 15;
                        additionalPersent = 3;
                    }
                    break;
                default:
                    additionalPersent = 0;
                    break;
            }
            return percent;
        }
    }
}
