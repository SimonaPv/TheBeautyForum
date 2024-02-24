using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

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
