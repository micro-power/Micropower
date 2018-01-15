using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static Micropower.Models.Entities.Column;

namespace Micropower.Models.DTO
{
    public class ColumnBindingModel
    {
        public int T1 { get; set; }
        public int T2 { get; set; }
        public int T3 { get; set; }
        public int T4 { get; set; }
        public int OS1 { get; set; }
        public int OS2 { get; set; }
        public int CmdOk { get; set; }
        public State CS { get; set; }
    }
}