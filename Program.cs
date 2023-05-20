using System;
namespace homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int N = int.Parse(input[0]);
            int K = int.Parse(input[1]);

            if ((1 <= N && N <= 10000) && (1 <= K && K <= 100))
            {
                input = Console.ReadLine().Split(' ');
                int[] people = new int[N];
                for (int i = 0; i < N; i++)
                {
                    people[i] = int.Parse(input[i]);
                }

                int total = TotalPeople(people, K);
                Console.WriteLine(total);
            }
        }
        static int TotalPeople(int[] array, int K)
        {
            int maxSum = 0;

            for (int i = 0; i <= (K * 2); i++)
            {
                maxSum += array[i];
            }

            int currentSum = maxSum;

            for (int i = (K * 2) + 1; i < array.Length; i++)
            {
                currentSum += array[i] - array[i - ((K * 2) + 1)];
                maxSum = Math.Max(maxSum, currentSum);
            }

            return maxSum;
        }
    }
}