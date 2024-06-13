using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketsIQ.Services.Google.Protobuf
{
    public static class ProtoPreconditions
    {
        public static T CheckNotNull<T>(T value, string name) where T : class
        {
            if (value == null)
            {
                throw new ArgumentNullException(name);
            }

            return value;
        }

        internal static T CheckNotNullUnconstrained<T>(T value, string name)
        {
            if (value == null)
            {
                throw new ArgumentNullException(name);
            }

            return value;
        }
    }
}
