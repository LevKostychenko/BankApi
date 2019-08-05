using System;
using System.Collections.Generic;
using System.Text;
using BankApi.Logic.ApiLogic.NationalBank.Models;

namespace BankApi.Logic.ApiLogic.NationalBank
{
    public interface INationalBankApi
    {
        IEnumerable<CurrencyModel> GetAllCurrenciesForNationalBank();

        CurrencyModel GetConcreteCurrencyByIdForNationalBank(int id);


    }
}
