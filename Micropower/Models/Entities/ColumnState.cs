using static Micropower.Models.Entities.Column;

namespace Micropower.Models.Entities
{
    public class ColumnState
    {
        public double Temperature1 { get; set; }
        public double Temperature2 { get; set; }
        public double Temperature3 { get; set; }
        public double Temperature4 { get; set; }
        public bool OverflowSensor1 { get; set; }
        public bool OverflowSensor2 { get; set; }
        public State ColumnStep { get; set; }
    }
}