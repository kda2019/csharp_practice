using System;

namespace pr_1
{
    class Program
    {
        static void Main()
        {

            ITask task1 = new Task1(8, 20, 3);

            ITask task2 = new Task2(6, 7, 9);

            int[] arrTask3 = { 5, 12, 23, 7, 19, 34, 55, 67, 78, 1, 45, 90, 11, 21, 33, 56, 72 };
            ITask task3 = new Task3(arrTask3);

            int[] arrTask4 = { -15, 24, -3, 0, 19, -7, 33, -42, 56, 0, 12, -18, 7, -23, 9, -4, 27 };
            ITask task4 = new Task4(arrTask4, 7);
        
            TaskController controller = new TaskController(new ITask[] { task1, task2, task3, task4 });
            controller.RunAllTasks();
        
        }
    }
}

