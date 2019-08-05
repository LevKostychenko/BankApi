using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace BankApi.Logic.ApiLogic.NationalBank.Models
{
    public sealed class RateModel : RateShortModel
    {
        [JsonProperty("Cur_Abbreviation")]
        public string Cur_Abbreviation { get; set; }

        [JsonProperty("Cur_Scale")]
        public int Cur_Scale { get; set; }

        [JsonProperty("Cur_Name")]
        public string Cur_Name { get; set; }
    }
}
