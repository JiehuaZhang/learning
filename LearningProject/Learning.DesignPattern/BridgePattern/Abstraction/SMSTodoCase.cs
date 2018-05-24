using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Learning.Common.Entities;

namespace Learning.DesignPattern.BridgePattern.Abstraction
{
    /// <summary>
    /// The 'RefinedAbstraction' class
    /// </summary>
    public class SMSTodoCase : TodoCase
    {
        public override void Send()
        {
            var dicCaseList = new Dictionary<string, List<ActionCase>>();
            foreach (var stepAndCase in NiAcnTdoList)
            {
                var callTodoList =
                 new ActionCase { Step = stepAndCase.Step, Cases = stepAndCase.Cases.Where(x => x.HasTlf && x.DebtorNo != null).Select(x => x).ToList() };
               
                if (!dicCaseList.ContainsKey(stepAndCase.Step.TemplateId))
                {
                    dicCaseList.Add(stepAndCase.Step.TemplateId, new List<ActionCase>());
                }

                dicCaseList[stepAndCase.Step.TemplateId].Add(callTodoList);
            }
            var TempalteIDThisTime = dicCaseList.Keys.FirstOrDefault();
            if (!string.IsNullOrEmpty(TempalteIDThisTime))
            {
                ActionOperator.ActionOperation(dicCaseList[TempalteIDThisTime]);
            }
        }
    }
}
