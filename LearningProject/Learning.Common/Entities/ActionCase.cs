using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Common.Entities
{
    public class ActionCase
    {
        public ActionCase()
        {
            Cases= new List<CaseFlowCase>();
        }
        public List<CaseFlowCase> Cases { get; set; }
        public CaseFlowStep Step { get; set; }
        
    }
}
