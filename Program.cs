namespace Average_Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<int> averages = new List<int>();

            const int sampleSize = 100;
            const int expectedMean = 50;

            for (int i = 0; i < 100; i++)
            {
                int total = 0;

                for (int j = 0; j < sampleSize; j++)
                {
                    int randVal = rnd.Next(100);
                    total += randVal;
                }
                int average = total / sampleSize;
                total = 0;

                averages.Add(average);
                Console.WriteLine($"The Average is {average}");
            }

            Console.WriteLine();

            int furthest = averages.OrderByDescending(x => Math.Abs(x - expectedMean)).First();

            Console.WriteLine($"Max: {averages.Max()}, Min: {averages.Min()}, Actual Mean: {averages.Average():F2}");
        }
    }
}