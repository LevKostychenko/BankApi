using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace BankApi.Logic.ApiLogic.NationalBank.Models
{
    public sealed class CurrencyModel
    {
        [JsonProperty("Cur_ID")]
        public int Cur_ID { get; set; }

        [JsonProperty("Cur_ParentID")]
        public Nullable<int> Cur_ParentID { get; set; }

        [JsonProperty("Cur_Code")]
        public string Cur_Code { get; set; }

        [JsonProperty("Cur_Abbreviation")]
        public string Cur_Abbreviation { get; set; }

        [JsonProperty("Cur_Name")]
        public string Cur_Name { get; set; }

        [JsonProperty("Cur_Name_Bel")]
        public string Cur_Name_Bel { get; set; }

        [JsonProperty("Cur_Name_Eng")]
        public string Cur_Name_Eng { get; set; }

        [JsonProperty("Cur_QuotName")]
        public string Cur_QuotName { get; set; }

        [JsonProperty("Cur_QuotName_Bel")]
        public string Cur_QuotName_Bel { get; set; }

        [JsonProperty("Cur_QuotName_Eng")]
        public string Cur_QuotName_Eng { get; set; }

        [JsonProperty("Cur_NameMulti")]
        public string Cur_NameMulti { get; set; }

        [JsonProperty("Cur_Name_BelMulti")]
        public string Cur_Name_BelMulti { get; set; }

        [JsonProperty("Cur_Name_EngMulti")]
        public string Cur_Name_EngMulti { get; set; }

        [JsonProperty("Cur_Scale")]
        public int Cur_Scale { get; set; }

        [JsonProperty("Cur_Periodicity")]
        public int Cur_Periodicity { get; set; }

        [JsonProperty("Cur_DateStart")]
        public System.DateTime Cur_DateStart { get; set; }

        [JsonProperty("Cur_DateEnd")]
        public System.DateTime Cur_DateEnd { get; set; }
    }
}
