using System;

namespace Micropower.Models
{
    public interface IDateTimeProvider
    {
        DateTime GetDateTime();
    }

    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime GetDateTime()
        {
            return DateTime.Now;
        }
    }
}