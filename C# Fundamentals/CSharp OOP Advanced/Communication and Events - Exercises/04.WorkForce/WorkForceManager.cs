namespace _04.WorkForce
{
    using System;

    public class WorkForceManager
    {
        public event EventHandler<EventArgs> WorkHandler;

        public void PassWeek()
        {
            this.WorkHandler?.Invoke(this, EventArgs.Empty);
        }
    }
}