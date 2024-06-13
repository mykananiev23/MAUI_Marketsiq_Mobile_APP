using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketsIQ.Services.Quantower.Utilities.ResponseWaiter
{
    public interface IResponse<TKey>
    {
        TKey Key { get; }
    }
}
