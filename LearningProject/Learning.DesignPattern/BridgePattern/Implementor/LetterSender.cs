﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Learning.Common.Entities;
using Learning.Common.Enum;
using Learning.Common.Mapper;

namespace Learning.DesignPattern.BridgePattern.Implementor
{
    public class LetterSender :IActionOperator
    {
        private const int actionStatus = 3;
        public void ActionOperation(List<ActionCase> actionCases)
        {
            var niAcnList = new List<niAcnTdo>();
            foreach (var actionCase in actionCases)
            {
                niAcnList.AddRange(actionCase.ToNiAcnTdo(AcnTodoType.Print, actionStatus));
            }
            foreach (var acnTdo in niAcnList)
            {
                Console.WriteLine("Letter:" + acnTdo.GetObjectString());
            }
        }
    }
}
