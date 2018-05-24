using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Common.Entities
{
    public class CaseFlowCase
    {
        public int AICaseId { get; set; }
        public int CaseFlowId { get; set; }
        public int CaseNo { get; set; }
        public int? DebtorNo { get; set; }
        public int? ClientNo { get; set; }
        public string CaseStepNo { get; set; }
        public string CaseHistoryStep { get; set; }
        public int? niAcnTdoActionNo { get; set; }
        public bool HasEmail { get; set; }
        public bool HasTlf { get; set; }
        public bool HasAddress { get; set; }
        public bool IsDone { get; set; }
        public DateTime? DoneDate { get; set; }
        public string Result { get; set; }
    }
}
