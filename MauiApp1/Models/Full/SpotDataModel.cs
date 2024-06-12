using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketsIQ.Models.Full
{
    public class SpotDataModel
    {
        public string Symbol { get; set; }
        public string Time { get; set; }
        public string Net { get; set; }
        public string Bid { get; set; }
        public string Ask { get; set; }
    }
}
