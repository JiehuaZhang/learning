using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Learning.Common.Entities;

namespace Learning.DesignPattern.AdapterPattern
{
    /// <summary>
    /// ITarget
    /// </summary>
    public interface IAction
    {
        List<ActionCase> GetTodoCaseList();
    }
}
