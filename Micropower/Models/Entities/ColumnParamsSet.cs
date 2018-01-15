using System.Collections.Generic;

namespace Micropower.Models.Entities
{
    public class ColumnParamsSet
    {
        public bool IsCommandRecived { get; set; } = false;
        public string StartTime { get; set; } = "";
        public string StartDate { get; set; } = "";
        public List<string> Commands { get; set; } = new List<string>();
        public bool Heating1 { get; set; } = false;
        public bool Heating2 { get; set; } = false;
        public bool Heating3 { get; set; } = false;
    }
}