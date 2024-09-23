class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        // Prompt the user to enter a list of numbers
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            // Check if the input is 0 to terminate the loop
            if (number == 0)
                break;

            numbers.Add(number);
        }

        // Core Requirements
        // 1. Compute the sum
        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");

        // 2. Compute the average
        double average = numbers.Average();
        Console.WriteLine($"The average is: {average}");

        // 3. Find the maximum number
        int maxNumber = numbers.Max();
        Console.WriteLine($"The largest number is: {maxNumber}");

        // Stretch Challenges
        // 1. Find the smallest positive number
        int smallestPositive = numbers.Where(n => n > 0).DefaultIfEmpty(0).Min();
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        // 2. Sort the numbers and display the sorted list
        List<int> sortedNumbers = numbers.OrderBy(n => n).ToList();
        Console.WriteLine("The sorted list is:");
        foreach (int n in sortedNumbers)
        {
            Console.WriteLine(n);
        }
    }
}