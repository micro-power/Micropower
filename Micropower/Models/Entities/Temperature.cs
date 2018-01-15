using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Micropower.Models.Entities
{
    public class Temperature
    {
        public double Value { get; set; } = 0;
        public bool IsAvailable { get; set; } = true;
    }
}