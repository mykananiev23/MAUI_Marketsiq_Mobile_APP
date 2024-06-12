using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketsIQ.Models.Full
{
    public class LMEDataModel
    {
        public string Symbol { get; set; }
        public string Net { get; set; }
        public string Bid { get; set; }
        public string Ask { get; set; }
        public string ClosingStock { get; set; }
        public string OpeningStock { get; set; }
        public string In { get; set; }
        public string Out { get; set; }
        public string Warrants { get; set; }
        public string CWarrants { get; set; }
        public string CWRation { get; set; }
    }
}
