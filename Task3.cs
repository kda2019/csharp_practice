using System;
using System.Linq;

namespace pr_1
{
    public class Task3 : ITask {
        private int[] array;

        public Task3(int[] array)
        {
            this.array = array;
        }

        public void ExecuteTask() {
            int minVal = array.Min();
            int maxVal = array.Max();

            Console.WriteLine("Task 3:");
            Console.WriteLine($"Array: {string.Join(", ", array)}");
            Console.WriteLine($"Min value is {minVal}");
            Console.WriteLine($"Max value is {maxVal}\n");
        }
    }
}
