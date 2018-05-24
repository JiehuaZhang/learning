using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Learning.Common.Entities;

namespace Learning.DesignPattern.AdapterPattern
{
    /// <summary>
    /// Adaptee   
    /// </summary>
    public class CaseSystem
    {
        public List<ActionCase> GetActionStepsAndCases()
        {
            return new List<ActionCase>
            {
                new ActionCase{Cases = new List<CaseFlowCase>{ new CaseFlowCase{AICaseId = 1,CaseFlowId = 1,CaseNo = 1,ClientNo = 11,DebtorNo = 111, HasTlf = true},},Step =  new CaseFlowStep { ActionId = 1, AIStepId = 12, CaseFlowId = 1, ExpectRunDateTime = new DateTime(2018,1,3,9,30,00), IsDone = false, Name = "SMS", TemplateId ="SMS25",StepId = 1 }},
                new ActionCase{Cases = new List<CaseFlowCase>{ new CaseFlowCase{AICaseId = 2,CaseFlowId = 2,CaseNo = 2,ClientNo = 11,DebtorNo = 222, HasTlf = true },},Step =  new CaseFlowStep { ActionId = 1, AIStepId = 12, CaseFlowId = 2, ExpectRunDateTime = new DateTime(2018,1,3,9,30,00), IsDone = false, Name = "SMS", TemplateId = "SMS36",StepId = 1 }},
                new ActionCase{Cases = new List<CaseFlowCase>{ new CaseFlowCase{AICaseId = 3,CaseFlowId = 3,CaseNo = 3,ClientNo = 11,DebtorNo = 333, HasTlf = true },},Step =  new CaseFlowStep { ActionId = 2, AIStepId = 12, CaseFlowId = 3, ExpectRunDateTime = new DateTime(2018,1,3,9,30,00), IsDone = false, Name = "Email",TemplateId = "Kamp_01",StepId = 1 }},
            };
        }
    }
}
