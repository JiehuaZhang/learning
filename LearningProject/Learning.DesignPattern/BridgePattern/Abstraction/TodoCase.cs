using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Learning.Common.Entities;
using Learning.DesignPattern.BridgePattern.Implementor;

namespace Learning.DesignPattern.BridgePattern.Abstraction
{
    /// <summary>
    /// The 'Abstraction' class
    /// </summary>
    public abstract class TodoCase
    {
        public IActionOperator ActionOperator { get; set; }
        public List<ActionCase> NiAcnTdoList { get; set; }
        public abstract void Send();
    }
}
