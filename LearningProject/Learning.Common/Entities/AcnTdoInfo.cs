using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Common.Entities
{
    public class niAcnTdo
    {
        public int ActionNo { get; set; }
        public string BookedFor { get; set; }
        public DateTime? Date { get; set; }
        public int? Priority { get; set; }
        public byte? TodoType { get; set; }
        public string Action { get; set; }
        public string Argument { get; set; }
        public string BookedBy { get; set; }
        public DateTime? BookedDate { get; set; }
        public byte? ObjectType { get; set; }
        public int? ObjectNo { get; set; }
        public int? SubNo { get; set; }
        public int? CreditorNo { get; set; }
        public int? Flags { get; set; }
        public string AutoCode { get; set; }
        public string NextCode { get; set; }
        public byte? Executed { get; set; }
        public string ResponseTime { get; set; }
        public string DateAdjusted { get; set; }
        public string Stack { get; set; }
        public byte[] ExtData { get; set; }
        public int Status { get; set; }
        public int? ExtRef { get; set; }
    }
}
