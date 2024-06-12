using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketsIQ.Models.Full
{
    public class ForwardsDataModel
    {
        public string SymbolName { get; set; }
        public string ValueDate { get; set; }
        public string Bid { get; set; }
        public string Ask { get; set; }
    }
}
