using System;
using System.Collections.Generic;
using System.Text;

namespace BankApi.Logic
{
    public interface IApiDataAccess
    {
        string GetDataFromApi(string apiUrl);
    }
}
