namespace udemy_2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of days to simulate:");
        int days = int.Parse(Console.ReadLine() ?? "0");

        int[] temperatures = new int[days];
        string[] conditions = {"Sunny", "Cloudy", "Rainy", "Windy"};
        string[] weatherConditions = new string[days];

        Random random = new Random();
        for (int i = 0; i < days; i++)
        {
            temperatures[i] = random.Next(18, 37);
            weatherConditions[i] = conditions[random.Next(conditions.Length)];
        }

        double averageTemperature = CalculateAverageTemperature(temperatures);
        Console.WriteLine($"Average Temperature: {averageTemperature:F2}°C");
    }

    static double CalculateAverageTemperature(int[] temperatures)
    {
        int sum = 0;
        foreach (int temp in temperatures)
        {
            sum += temp;
        }
        return (double)sum / temperatures.Length;
    }
}
