using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace MySecondApplication.Exercises.Six
{
    public class Workflow
    {
        private readonly IList<IActivity> Activities;

        public Workflow()
        {
            this.Activities = new List<IActivity>();
        }

        public List<IActivity> getActivities()
        {
            return (List<IActivity>)this.Activities;
        }

        public void AddActitivity(IActivity activity)
        {
            if (activity == null)
            {
                throw new ArgumentNullException("The activity to add can't be null");
            }

            this.Activities.Add(activity);
        }
        public void ClearActivities()
        {
            if (this.Activities.Count == 0)
            {
                Console.WriteLine("The activities are already empty");
            }
            else
            {
                this.Activities.Clear();
                Console.WriteLine("The activitities were cleared sucessfully");
            }
        }

    }
}

