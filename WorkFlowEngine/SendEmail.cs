using System;

namespace WorkFlowEngine
{
    public class SendEmail : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Sending an email");
        }
    }
}