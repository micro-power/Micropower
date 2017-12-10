using Micropower.Interfaces;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Micropower.Models.Entities
{
    public class Column :IBson
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

        [BsonId]
        public ObjectId Id { get; set; }

        public ColumnState ColumnCurrentState { get; set; }

        public ColumnParamsSet ColumnWorkingParams { get; set; }

        public ColumnAlarmSet ColumnAlarms { get; set; }
    }
}