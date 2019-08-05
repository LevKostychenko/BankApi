using System;
using System.Collections.Generic;
using System.Text;
using BankApi.Logic.ApiLogic.NationalBank.Models;

namespace BankApi.Logic.ApiLogic.NationalBank.DataProviders
{
    public class ApiDataProvider : DataProviderBase, IApiDataProvider
    {
        public IEnumerable<CurrencyModel> GetAllCurrenciesForNationalBank()
        {
            string response = ApiAccess.GetDataFromApi(ApiRequestUrlModel.GetAllCurrenciesUrl);

            return ApiConverter.ToCurrencyListConverter(response);
        }
    }
}
