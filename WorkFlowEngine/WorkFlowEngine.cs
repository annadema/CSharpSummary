using System;
using System.Collections.Generic;

namespace WorkFlowEngine
{
    class WorkFlowEngine
    {

        public void Run(IWorkFlow workFlow)
        {
            foreach (var step in workFlow.GetActivities())
            {
                try
                {
                    step.Execute();
                }
                catch (Exception e)
                {
                    //Logging
                    //Terminate and persist the state of workflow
                    Console.WriteLine(e);
                    throw;
                }
                
            }
        }


    }
}