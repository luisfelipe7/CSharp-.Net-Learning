using System;
namespace MySecondApplication.Exercises.Six
{
    public class WorkflowEngine
    {
        private Workflow Workflow;

        public WorkflowEngine(Workflow workflow)
        {
            if (workflow == null)
            {
                throw new ArgumentNullException("The workflow to inject can't be null");
            }
            this.Workflow = workflow;
        }
        public void Run()
        {
            if (this.Workflow.getActivities().Count == 0)
            {
                Console.WriteLine("The quantity of actitivties in the workflow are 0");
            }
            else
            {
                Console.WriteLine("\n ----- Running the activities ------");
                foreach (var activity in this.Workflow.getActivities())
                {
                    activity.Execute();
                }
            }
        }
        public Workflow getWorkFlow()
        {
            return this.Workflow;
        }

    }
}

