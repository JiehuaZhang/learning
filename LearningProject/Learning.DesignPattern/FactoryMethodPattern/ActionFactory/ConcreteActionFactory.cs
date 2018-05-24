using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Learning.Common.Entities;
using Learning.DesignPattern.AdapterPattern;
using Learning.DesignPattern.BridgePattern.Abstraction;
using Learning.DesignPattern.BridgePattern.Implementor;

namespace Learning.DesignPattern.FactoryMethodPattern.ActionFactory
{
    public class ConcreteActionFactory : ActionFactory
    {
        public override TodoCase CreateAction(int actionID, List<ActionCase> cases)
        {
            switch (actionID)
            {
                case 1:
                    return new SMSTodoCase
                    {
                        NiAcnTdoList = cases.Where(x => x.Step.ActionId == actionID).ToList(),
                        ActionOperator = new SMSSender()
                    };
                case 2:
                    return new CommonTodoCase
                    {
                        NiAcnTdoList = cases.Where(x => x.Step.ActionId == actionID).ToList(),
                        ActionOperator = new EmailSender()
                    };
                case 3:
                    return new CommonTodoCase
                    {
                        NiAcnTdoList = cases.Where(x => x.Step.ActionId == actionID).ToList(),
                        ActionOperator = new LetterSender()
                    };
                case 4:
                    return new CommonTodoCase
                    {
                        NiAcnTdoList = cases.Where(x => x.Step.ActionId == actionID).ToList(),
                        ActionOperator = new CallSender()
                    };
                default:
                    return null;
                    
            }
        }
    }
}
