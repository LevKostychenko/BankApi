using System;
using System.Collections.Generic;
using System.Text;
using BankApi.Logic.ApiLogic.NationalBank.Models;

namespace BankApi.Logic.ApiLogic.NationalBank.ResponseConverters
{
    public interface IApiResponseConverter
    {
        IEnumerable<CurrencyModel> ToCurrencyListConverter(string response);

        CurrencyModel ToCurrencyConverter(string response);

        RateModel ToRateConverter(string response);

        IEnumerable<RateModel> ToRateListConverter(string response);

        RateShortModel ToRateShortConverter(string responce);
    }
}
