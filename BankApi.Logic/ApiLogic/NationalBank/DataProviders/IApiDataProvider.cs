using System;
using System.Collections.Generic;
using System.Text;
using BankApi.Logic.ApiLogic.NationalBank.Models;

namespace BankApi.Logic.ApiLogic.NationalBank.DataProviders
{
    public interface IApiDataProvider
    {
        IEnumerable<CurrencyModel> GetAllCurrenciesForNationalBank();
    }
}
