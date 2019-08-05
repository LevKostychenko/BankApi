using BankApi.Logic.ApiLogic.NationalBank.ResponseConverters;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankApi.Logic.ApiLogic.NationalBank.DataProviders
{
    public abstract class DataProviderBase
    {
        internal ApiDataAccess ApiAccess => new ApiDataAccess();

        internal ApiResponseConverter ApiConverter => new ApiResponseConverter();
    }
}
