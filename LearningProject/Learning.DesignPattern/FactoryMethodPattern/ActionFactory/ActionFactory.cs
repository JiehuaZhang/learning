using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Learning.Common.Entities;
using Learning.DesignPattern.BridgePattern.Abstraction;

namespace Learning.DesignPattern.FactoryMethodPattern.ActionFactory
{
    public abstract class ActionFactory
    {
        public abstract TodoCase CreateAction(int actionID, List<ActionCase> cases);

    }
}
