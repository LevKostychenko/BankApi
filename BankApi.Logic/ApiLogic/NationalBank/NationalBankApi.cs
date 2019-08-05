using System;
using System.Collections.Generic;
using System.Text;
using BankApi.Logic.ApiLogic.NationalBank.DataProviders;
using BankApi.Logic.ApiLogic.NationalBank.Models;

namespace BankApi.Logic.ApiLogic.NationalBank
{
    public sealed class NationalBankApi : INationalBankApi
    {
        private readonly IApiDataProvider _apiDataProvider;

        public NationalBankApi(IApiDataProvider apiDataProvider)
        {
            _apiDataProvider = apiDataProvider;
        }

        public IEnumerable<CurrencyModel> GetAllCurrenciesForNationalBank()
        {
            return _apiDataProvider.GetAllCurrenciesForNationalBank();
        }

        public CurrencyModel GetConcreteCurrencyByIdForNationalBank(int id)
        {
            throw new NotImplementedException();
        }
    }
}
