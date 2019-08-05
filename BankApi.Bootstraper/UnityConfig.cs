using System;
using System.Collections.Generic;
using System.Text;
using BankApi.Logic.ApiLogic.NationalBank;
using BankApi.Logic.ApiLogic.NationalBank.DataProviders;
using Unity;

namespace BankApi.Bootstraper
{
    public static class UnityConfig
    {
        public static UnityContainer Container { get; set; }

        public static void Initialize()
        {
            Container = new UnityContainer();

            UnityConfig.Container.RegisterType<INationalBankApi, NationalBankApi>();
            UnityConfig.Container.RegisterType<IApiDataProvider, ApiDataProvider>();
        }
    }
}
