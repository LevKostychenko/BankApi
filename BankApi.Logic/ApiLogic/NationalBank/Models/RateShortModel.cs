using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace BankApi.Logic.ApiLogic.NationalBank.Models
{
    public class RateShortModel
    {
        [JsonProperty("Cur_ID")]
        public int Cur_ID { get; set; }

        [JsonProperty("Date")]
        public System.DateTime Date { get; set; }

        [JsonProperty("Cur_OfficialRate")]
        public decimal? Cur_OfficialRate { get; set; }
    }
}
