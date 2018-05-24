using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Learning.DesignPattern.BridgePattern.Abstraction;
using Learning.DesignPattern.BridgePattern.Implementor;
using Learning.DesignPattern.FactoryMethodPattern.ActionFactory;

namespace Learning.DesignPattern.AdapterPattern
{

    //    1. Target interface: IAction
    //    2. Adapter Class: CaseAdapter
    //    3. Adaptee Class: CaseSystem
    //    4. Client: ActionProvider
    
    /// <summary>
    /// Client
    /// </summary>
    public class ActionProvider
    {
        private readonly IAction _action;

        public ActionProvider(IAction action)
        {
            _action = action;
        }
        
        public void RunCaseStep()
        {
            var cases = _action.GetTodoCaseList();//call Adapter，同时实现两步，从一个system提取数据以及处理后再传到client。
            var actionIDList = cases.Select(x => x.Step.ActionId).Distinct().ToList();

            Console.WriteLine(string.Join(", ", actionIDList));

            ActionFactory  factory = new ConcreteActionFactory();
            foreach (var actionID in actionIDList)
            {
                var todoCase = factory.CreateAction(actionID, cases);
                todoCase.Send();
            }

            //IActionOperator email = new EmailSender();
            //IActionOperator sms = new SMSSender();
            //IActionOperator letter = new LetterSender();
            //IActionOperator call = new CallSender();


            //TodoCase smsCases = new SMSTodoCase
            //{
            //    NiAcnTdoList = cases.Where(x => x.Step.ActionId == 1).ToList(),
            //    ActionOperator = sms
            //};
            //smsCases.Send();

            //TodoCase emailCases = new CommonTodoCase
            //{
            //    NiAcnTdoList = cases.Where(x => x.Step.ActionId == 2).ToList(),
            //    ActionOperator = email
            //};
            //emailCases.Send();

            //TodoCase letterCases = new CommonTodoCase
            //{
            //    NiAcnTdoList = cases.Where(x=>x.Step.ActionId == 3).ToList(),
            //    ActionOperator = letter
            //};
            //letterCases.Send();

            //TodoCase callCases = new CommonTodoCase
            //{
            //    NiAcnTdoList = cases.Where(x=>x.Step.ActionId == 4).ToList(),
            //    ActionOperator = call
            //};
            //callCases.Send();

        }

    }
}
