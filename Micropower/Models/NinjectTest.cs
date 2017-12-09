using Micropower.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Micropower.Models
{
    public class NinjectTest
    {
        IDateTimeProvider time;

        public NinjectTest(IDateTimeProvider dateTimeProvider)
        {
            time = dateTimeProvider ?? throw new ArgumentNullException(nameof(dateTimeProvider));
        }
        public string Value()
        {
            return time.GetDateTime().ToString();
        }
    }
}