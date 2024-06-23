using System;

namespace WorkFlowEngine
{
    public class ChangeStatus : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Changing Status");
        }
    }
}