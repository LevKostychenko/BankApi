using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using BankApi.Bootstraper;
using BankApi.Logic.ApiLogic.NationalBank;
using BankApi.Logic.ApiLogic.NationalBank.Models;
using Unity;
using Xamarin.Forms;

namespace BankApi
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private INationalBankApi _nationalBankApi => UnityConfig.Container.Resolve<NationalBankApi>();

        public MainPage()
        { 
            InitializeComponent();
        }

        private void Btn_Clicked(object sender, EventArgs e)
        {
            List<CurrencyModel> currencies = _nationalBankApi.GetAllCurrenciesForNationalBank().ToList();

            if (string.IsNullOrEmpty(btn1.Text))
            {
                btn1.Text = "cklicked";
            }
            else
            {
                btn1.Text = string.Empty;
            }
        }
    }
}
