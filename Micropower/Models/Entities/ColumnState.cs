using static Micropower.Models.Entities.Column;

namespace Micropower.Models.Entities
{
    public class ColumnState
    {
        public Temperature Temperature1 { get; set; } = new Temperature();
        public Temperature Temperature2 { get; set; } = new Temperature();
        public Temperature Temperature3 { get; set; } = new Temperature();
        public Temperature Temperature4 { get; set; } = new Temperature();
        public bool OverflowSensor1 { get; set; } = false;
        public bool OverflowSensor2 { get; set; } = false;
        public State ColumnStep { get; set; } = State.Waiting;
    }
}