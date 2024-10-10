using pr_1;
using System;
using System.Linq;
using System.Xml.XPath;

namespace pr_1 {
    public class Task1 : ITask {

        private int[] nums;
        private int rangeEnd = 17;

        public Task1(int num1, int num2, int num3) {
            nums = new[] { num1, num2, num3 };
        }

        public void ExecuteTask() {

            int[] selectedNums = GetNumsInRange();
            PrintNumbers(selectedNums);
    
        }

        private int[] GetNumsInRange() {
            int[] result = new int[nums.Length];
            int count = 0;

            foreach (int num in nums)
            {
                if (num >=1 && num <= rangeEnd)
                {
                    result[count++] = num;
                }
            }
            return result;
        }

        private void PrintNumbers(int[] nums) {

            Console.WriteLine("Task 1: ");

            if (nums.Length == 0) 
            {
                Console.WriteLine($"No numbers are in the range [1, {rangeEnd}]\n");
            }
            else
            {
                Console.WriteLine($"Numbers in the range [1, {rangeEnd}]: {string.Join(", ", nums)}\n");
            }
        }
    }
}
