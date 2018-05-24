using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Learning.Common.Entities;
using Learning.Common.Enum;
using Learning.Common.Mapper;

namespace Learning.DesignPattern.BridgePattern.Implementor
{
    /// <summary>
    /// The 'ConcreteImplementor' class
    /// </summary>
    public class EmailSender : IActionOperator
    {
        private const int actionStatus = 2;
        public void ActionOperation(List<ActionCase> actionCases)
        {
            var niAcnList = new List<niAcnTdo>();
            foreach (var actionCase in actionCases)
            {
                niAcnList.AddRange(actionCase.ToNiAcnTdo(AcnTodoType.Email, actionStatus));
            }
            foreach (var acnTdo in niAcnList)
            {
                Console.WriteLine("Email: "+acnTdo.GetObjectString());
            }
        }
    }
}
