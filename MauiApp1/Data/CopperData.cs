using MarketsIQ.Models.Full;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketsIQ.Data
{
    public class CopperData
    {
        public static IList<CopperModel> Datas { get; set; } = new List<CopperModel>();

        static CopperData()
        {
            Datas.Add(new CopperModel
            {
                Title = "CU"
            });
            Datas.Add(new CopperModel
            {
                Title = "AL"
            });
            Datas.Add(new CopperModel
            {
                Title = "PB"
            });
            Datas.Add(new CopperModel
            {
                Title = "INI"
            });
            Datas.Add(new CopperModel
            {
                Title = "ZN"
            });
            Datas.Add(new CopperModel
            {
                Title = "SN"
            });
            Datas.Add(new CopperModel
            {
                Title = "AA"
            });
            Datas.Add(new CopperModel
            {
                Title = "NA"
            });
        }
    }
}
