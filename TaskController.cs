using System;

namespace pr_1
{
    public class TaskController
    {
        private ITask[] tasks;

        public TaskController(ITask[] tasks)
        {
            this.tasks = tasks;
        }

        public void RunAllTasks()
        {
            foreach (var task in tasks)
            {
                task.ExecuteTask();
            }
        }
    }
}
