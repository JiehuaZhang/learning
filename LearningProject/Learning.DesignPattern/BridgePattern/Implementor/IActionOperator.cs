using System.Collections.Generic;
using Learning.Common.Entities;

namespace Learning.DesignPattern.BridgePattern.Implementor
{
    /// <summary>
    /// The 'Bridge/Implementor' interface
    /// </summary>
    public interface IActionOperator
    {
        void ActionOperation(List<ActionCase> niAcnTdos);
    }
}
