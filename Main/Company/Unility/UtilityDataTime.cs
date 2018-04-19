using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Unility
{
    public static class UtilityDataTime
    {
        public static int DiferentMonth(DateTime sDate, DateTime eDate)
        {
            if (sDate == null || eDate == null)
                return 0;

            var res = (sDate.Year * 12 + sDate.Month) - (eDate.Year * 12 + eDate.Month);

            res = res > 0 ? res * -1 : res;

            return res;
        }
    }
}
