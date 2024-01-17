using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBeautyForum.Data
{
    internal class TimeOnlyToTimeSpanConverter : ValueConverter<TimeOnly, TimeSpan>
    {
        /// <summary>
        /// Initialize a new instance of the <see cref="TimeOnlyToTimeSpanConverter"/> class.
        /// </summary>
        public TimeOnlyToTimeSpanConverter() : base(
               x => x.ToTimeSpan(),
               y => TimeOnly.FromTimeSpan(y))
        {
        }
    }
}
