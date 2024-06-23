using System;

namespace WorkFlowEngine
{
    public class CallWebService : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Calling Web Service");
        }
    }
}