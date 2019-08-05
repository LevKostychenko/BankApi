using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankApi.Logic.ApiLogic.NationalBank.Models;
using Newtonsoft.Json;

namespace BankApi.Logic.ApiLogic.NationalBank.ResponseConverters
{
    public class ApiResponseConverter : IApiResponseConverter
    {
        public IEnumerable<CurrencyModel> ToCurrencyListConverter(string response)
        {
            if (String.IsNullOrEmpty(response))
            {
                return new List<CurrencyModel>();
            }

            var list = new List<CurrencyModel>();

            var currencyObjects = response.Split(new char[] { '{', '}' }).ToList();
            currencyObjects = currencyObjects.Where(i => i != "[" && i != "]" && i != ",").ToList();

            foreach (var obj in currencyObjects)
            {
                list.Add(ToCurrencyConverter(obj));
            }

            return list;
        }

        public CurrencyModel ToCurrencyConverter(string response)
        {
            if (String.IsNullOrEmpty(response))
            {
                return new CurrencyModel();
            }

            return JsonConvert.DeserializeObject<CurrencyModel>("{" + response + "}");
        }


        public IEnumerable<RateModel> ToRateListConverter(string response)
        {
            if (String.IsNullOrEmpty(response))
            {
                return new List<RateModel>();
            }

            var list = new List<RateModel>();

            var rateObjects = response.Split(new char[] { '{', '}' }).ToList();
            rateObjects = rateObjects.Where(i => i != "[" && i != "]" && i != ",").ToList();

            foreach (var obj in rateObjects)
            {
                list.Add(ToRateConverter(obj));
            }

            return list;
        }

        public RateModel ToRateConverter(string response)
        {
            if (String.IsNullOrEmpty(response))
            {
                return new RateModel();
            }

            return JsonConvert.DeserializeObject<RateModel>("{" + response + "}");
        }

        public IEnumerable<RateShortModel> ToListRateShortConverter(string response)
        {
            if (String.IsNullOrEmpty(response))
            {
                return new List<RateShortModel>();
            }

            var list = new List<RateShortModel>();

            var rateShortObjects = response.Split(new char[] { '{', '}' }).ToList();
            rateShortObjects = rateShortObjects.Where(i => i != "[" && i != "]" && i != ",").ToList();

            foreach (var obj in rateShortObjects)
            {
                list.Add(ToRateShortConverter(obj));
            }

            return list;
        }

        public RateShortModel ToRateShortConverter(string response)
        {
            if (String.IsNullOrEmpty(response))
            {
                return new RateModel();
            }

            return JsonConvert.DeserializeObject<RateShortModel>("{" + response + "}");
        }
    }
}
