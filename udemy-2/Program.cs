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
        Console.WriteLine($"The Max Temperature: {temperatures.Max()}°C");
        Console.WriteLine($"The Min Temperature: {temperatures.Min()}°C");
        Console.WriteLine($"The Most Common Temprature: {MostCommonWeatherCondition(weatherConditions)}");
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

    static string MostCommonWeatherCondition(string[] weatherConditions)
    {
        int count = 0;
        string mostCommon = weatherConditions[0];

        for (int i = 0; i < weatherConditions.Length; i++)
        {
            int tempCount = 0;
            for (int j = 0; j < weatherConditions.Length; j++)
            {
                if (weatherConditions[j] == weatherConditions[i])
                {
                    tempCount++;
                }
                if (tempCount > count)
                {
                    count = tempCount;
                    mostCommon = weatherConditions[i];
                }
            }
        }
        return mostCommon;
    }
}
