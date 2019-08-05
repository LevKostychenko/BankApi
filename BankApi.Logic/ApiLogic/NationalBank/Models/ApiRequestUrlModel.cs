using System;
using System.Collections.Generic;
using System.Text;

namespace BankApi.Logic.ApiLogic.NationalBank.Models
{
    public static class ApiRequestUrlModel
    {
        public static string GetAllCurrenciesUrl { get { return "http://www.nbrb.by/API/ExRates/Currencies"; } }

        public static string GetConcreteCurrencyUrl { get { return "http://www.nbrb.by/API/ExRates/Currencies/"; } }

        public static string GetAllRatesUrl { get { return "http://www.nbrb.by/API/ExRates/Rates"; } }

        public static string GetConcreteRateUrl { get { return "http://www.nbrb.by/API/ExRates/Rates/"; } }

        public static string GetAllDynamicsUrl { get { return "http://www.nbrb.by/API/ExRates/Rates/Dynamics"; } }

        public static string GetConcreteDynamicUrl { get { return "http://www.nbrb.by/API/ExRates/Rates/Dynamics/"; } }
    }
}
