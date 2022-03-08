using CustomersInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxesByMonth
{
    internal class TaxesByMonth
    {
        CustomersInfo.CustomerInfo customersInfo;
        public TaxesByMonth()
        {
            customersInfo = new CustomersInfo.CustomerInfo();
            customersInfo.Init();
        }

        public List<TaxesByMonthL> CalculateTaxesByMonth()
        {
            return customersInfo.GetCustomers().GroupBy(x => x.Value.Day.Month).Select(x => new TaxesByMonthL
            {
                NumberMonth = x.Key,
                TotalSales = x.Sum(a => a.Value.Sale),
                Taxes = x.Sum(a => a.Value.Sale) * 0.08625
            }).OrderBy(x => x.NumberMonth)
            .ToList();
        }

        public class TaxesByMonthL
        {
            public int NumberMonth;
            public int TotalSales;
            public double Taxes;
        }
    }
}
