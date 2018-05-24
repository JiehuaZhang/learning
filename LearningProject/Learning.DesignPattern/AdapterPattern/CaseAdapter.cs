using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Learning.Common.Entities;
using Learning.Common.Mapper;

namespace Learning.DesignPattern.AdapterPattern
{
    /// <summary>
    /// Adapter
    /// </summary>
    public class CaseAdapter : CaseSystem,IAction
    {
        public List<ActionCase> GetTodoCaseList()
        {
            var list = GetActionStepsAndCases();
            return list;
        }
    }
}
