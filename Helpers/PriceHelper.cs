using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSMCSharp.Helpers
{
    public class PriceHelper
    {
        public static string ReturnGoldValue(long value)
        {
            long valueDivided = value / 10000;

            string output = String.Empty;

            if (valueDivided >= 0 && valueDivided < 10000)
                output = valueDivided.ToString() + "g";
            if (valueDivided >= 10000 && valueDivided <= 100000)
                output = valueDivided.ToString("##,###") + "g";
            if (valueDivided >= 100000 && valueDivided < 1000000)
                output = valueDivided.ToString("###,###") + "g";
            if (valueDivided >= 1000000 && valueDivided < 10000000)
                output = valueDivided.ToString("#,###,###") + "g";
            if (valueDivided == 10000000)
                output = valueDivided.ToString("##,###,###") + "g";

            if (valueDivided > 10000000)
                output = "ERROR Parsing Value";

            return output;
        }
    }
}
