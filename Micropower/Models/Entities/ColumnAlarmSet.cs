namespace Micropower.Models.Entities
{
    public class ColumnAlarmSet
    {
        public string TemperatureAlarm1 { get; set; }
        public string TemperatureAlarm2 { get; set; }
        public string TemperatureAlarm3 { get; set; }
        public string TemperatureAlarm4 { get; set; }
        public bool CheckOverflowSensors { get; set; }
    }
}