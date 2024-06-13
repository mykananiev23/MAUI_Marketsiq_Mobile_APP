using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketsIQ.Services.Quantower.API.Client.Models.ScreenerOperands
{
    public class QScreenerSelectorItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("displayText")]
        public string DisplayValue { get; set; }
    }
}
