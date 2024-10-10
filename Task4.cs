using System;
using System.Linq;


namespace pr_1
{
    public class Task4 : ITask {

        private int[] arr;
        private int m;

        public Task4(int[] array, int modulus) {

            arr = array;
            m = modulus;
        }

        public void ExecuteTask() {

            int[] newArray = RearrangeArray(arr, m); 
            PrintDetails(arr, m, newArray);
        }

        private int[] RearrangeArray(int[] arr, int modulus) {

            int[] result = new int[arr.Length];
            int count = 0;

            foreach (int num in arr)
                if (Math.Abs(num) > modulus)
                    result[count++] = num;
            return result;
        }

        private void PrintDetails(int[] arr, int modulus, int[] newArray) {

            Console.WriteLine("Task 4:");
            Console.WriteLine($"Given array: ");
            PrintArray(arr);  

            Console.WriteLine($"Modulus M: {modulus}");
            Console.WriteLine("New array Y:");
            PrintArray(newArray);
            Console.WriteLine();
        }

        private void PrintArray(int[] array) {

            foreach (var num in array)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
        }
    }
}
