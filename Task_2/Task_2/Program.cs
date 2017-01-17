using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxComputing;

namespace Task_2
{    
    class Program
    {
        static public float CalculateNeededMinMoneyForSalary(float employeeSalary, short percent)
        {
            float tax_money = employeeSalary / 100 * percent;
            return tax_money + employeeSalary;
        }
        static public float CalculateNeededMinMoneyForSalary(float employeeSalary, short percent, short additionalPercent)
        {
            float tax_money = employeeSalary / 100 * (percent+additionalPercent);
            return tax_money + employeeSalary;          
        }
        static void Main(string[] args)
        {
            Tax tax = new Tax();
            
            short additionalPercent;            

            short percent = tax.PerсentByCountry(Tax.Country.Ukraine, out additionalPercent);
            float necessaryMoney = CalculateNeededMinMoneyForSalary(2000, percent, additionalPercent);
            Console.WriteLine("Necessary money for {0} - {1} company", Tax.Country.Ukraine, necessaryMoney);

            percent = tax.PerсentByCountry(Tax.Country.USA, out additionalPercent);
            necessaryMoney = CalculateNeededMinMoneyForSalary(2000, percent);
            Console.WriteLine("Necessary money for {0} - {1} company", Tax.Country.USA, necessaryMoney);

            percent = tax.PerсentByCountry(Tax.Country.Norway, out additionalPercent);
            necessaryMoney = CalculateNeededMinMoneyForSalary(2000, percent);
            Console.WriteLine("Necessary money for {0} - {1} company", Tax.Country.Norway, necessaryMoney);

            Console.ReadKey();
        }

        //public static class ExtensionMethod
        //{
            //public static void PerсentByCountry(this Tax tax, Tax.Country country, out short additionalTax)
            //{
            //    additionalTax = 0;
            //    switch (country)
            //    {
            //        case Tax.Country.Norway:
            //            {  }
            //            break;
            //        case Tax.Country.USA:
            //            {  }
            //            break;
            //        case Tax.Country.Ukraine:
            //            { additionalTax = 3; }
            //            break;
            //        default: additionalTax = 0;
            //            break;
            //    }            
            //}
        }
    }
