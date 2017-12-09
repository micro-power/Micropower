using Micropower.Interfaces;
using System;

namespace Micropower.Models
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime GetDateTime()
        {
            return DateTime.Now;
        }
    }
}