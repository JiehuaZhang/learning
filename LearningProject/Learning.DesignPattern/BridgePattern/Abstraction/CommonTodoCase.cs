namespace Learning.DesignPattern.BridgePattern.Abstraction
{
    /// <summary>
    /// The 'RefinedAbstraction' class
    /// </summary>
    public class CommonTodoCase : TodoCase
    {
        public override void Send()
        {
            ActionOperator.ActionOperation(NiAcnTdoList);
        }
    }
}
