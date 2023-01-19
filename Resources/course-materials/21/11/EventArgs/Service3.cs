using System;

namespace Events
{
    internal class Service3
    {
        // event with built in C# class
        internal event EventHandler<WorkDoneEventArgs> workDone;

        internal void DoSomeWork(int workItemId)
        {
            // Do some work
            OnWorkDone(workItemId);
        }

        private void OnWorkDone(int workItemId)
        {
            if (workDone != null)
            {
                workDone(this, new WorkDoneEventArgs(workItemId));
            }
        }
        
    }
}