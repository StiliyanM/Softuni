namespace _04.WorkForce.Interfaces
{
    using System;

    public interface IJob
    {
        string Name { get; }
        int HoursOfWorkRequired { get; }
        bool IsFinished { get; }

        void Update(object sender, EventArgs e);
    }
}