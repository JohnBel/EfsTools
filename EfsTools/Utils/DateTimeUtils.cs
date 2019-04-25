using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfsTools.Utils
{
    internal static class DateTimeUtils
    {
        public static DateTime DateTimeFromQualcommTs(long ts)
        {
            var time = ts >> 16;
            time *= 5;
            time /= 4;
            var timeSpan = new TimeSpan(time * 10000);
            var dateTime = QualcommEpoch + timeSpan;
            return dateTime;            
        }

        private static readonly DateTime QualcommEpoch = new DateTime(1980, 1, 6, 0, 0, 0, DateTimeKind.Utc);
    }
}
