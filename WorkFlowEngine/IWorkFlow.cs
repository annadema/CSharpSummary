﻿using System.Collections.Generic;

namespace WorkFlowEngine
{
    public interface IWorkFlow
    {
        void Add(IActivity activity);
        void Remove(IActivity activity);
        IEnumerable<IActivity> GetActivities();

    }
}