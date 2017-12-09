using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Micropower.Models.Entities
{
    public class Column
    {
        public enum State
        {
            Waiting,
            Heating,
            Stabilizing,
            GettingFirstFraction,
            GettingMainAndFirstFraction,
            GettingOnlyMainFraction,
            GettingLastFraction,
            PompingWastes
        }
        public string Temperature1 { get; set; }
        public string Temperature2 { get; set; }
        public string Temperature3 { get; set; }
        public string Temperature4 { get; set; }
        public bool OverflowSensor1 { get; set; }
        public bool OverflowSensor2 { get; set; }
        public bool Heating1 { get; set; }
        public bool Heating2 { get; set; }
        public bool Heating3 { get; set; }
        public bool Heating4 { get; set; }
        public State ColumnState { get; set; }
        public SetColumnParams ColumnWorkingParams { get; set; }
        public string TemperatureAlarm1 { get; set; }
        public string TemperatureAlarm2 { get; set; }
        public string TemperatureAlarm3 { get; set; }
        public string TemperatureAlarm4 { get; set; }
        public bool CheckOverflowSensors { get; set; }
    }
}