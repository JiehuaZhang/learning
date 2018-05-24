using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Common.Entities
{
    public class CaseFlowStep
    {
        public int AIStepId { get; set; }
        public int StepId { get; set; }
        public int ActionId { get; set; }
        public string Name { get; set; }
        public DateTime? ExpectRunDateTime { get; set; }
        public string TemplateId { get; set; }
        public bool IsDone { get; set; }
        public DateTime? RunDateTime { get; set; }
        public int CaseFlowId { get; set; }
        public int? Duration { get; set; }
        public bool SendToSME { get; set; }
    }
}
