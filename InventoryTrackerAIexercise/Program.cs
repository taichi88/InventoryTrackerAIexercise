using System.Data;
using System.Diagnostics.CodeAnalysis;

namespace InventoryTrackerAIexercise
{
    internal class Program
    {
        static void Main(string[] args)

        {


            Console.WriteLine("how many days you want to simulate ");
            int days = int.Parse(Console.ReadLine());

            int[] rainFall = new int[days];


            string[] weatherCondition = new string[days];

            string[] weatherDescription = ["rainy", "dry"];


            Random random = new Random();

            for (int i = 0; i < days; i++)
            {
                rainFall[i] = random.Next(0, 50);
                weatherCondition[i] = weatherDescription[random.Next(weatherDescription.Length)];
                Console.WriteLine($"the rainfall amount  of the day " + (i + 1) + " is " + rainFall[i] + "\n and the condition is " + weatherCondition[i]);

            }

            Console.WriteLine("the average rainfall is " + calculateAverageRainfall(rainFall));
            Console.WriteLine("the Total rainfall is " + totalrainfall(rainFall));
            Console.WriteLine("the Total rainy days is " + totalnumberofRainydays(weatherCondition));



        }


        static double calculateAverageRainfall(int[] rainFall)
        {
            double sum = 0;

            foreach (int rain in rainFall)

                sum += rain;

            return sum / rainFall.Length;

        }
        static double totalrainfall(int[] rainFall)
        {
            double sum = 0;

            foreach (int rain in rainFall)

                sum += rain;

            return sum / rainFall.Length;

        }
        static int totalnumberofRainydays(string[] weatherCondition) 
        { 

        int rainyDays = 0;
            foreach (string day in weatherCondition)
                if (day == "rainy")
                    {
                    rainyDays++;
                }
            return rainyDays;


             }

        /*
        Console.WriteLine("Enter the number of days to simulate");
        int days = int.Parse(Console.ReadLine());

        int[] temperature = new int[days];

        string[] conditions = ["Sunny", "Snowy"];

        string[] weatherCondition = new string[days];

        Random random = new Random();

        for (int i = 0; i < days; i++)
        { 
            temperature[i] = random.Next(-10, 40);
            Console.WriteLine("The temperature is " + temperature[i]);
            weatherCondition[i] = conditions[random.Next(conditions.Length)];
            Console.WriteLine("the conditions is " + weatherCondition[i]);
        }



        Console.WriteLine($"Average temperature is {CalculateAverage(temperature)}");
        Console.ReadKey();
    }

    static double CalculateAverage(int[] temperature)
    {
        double sum = 0;

        foreach(int number in temperature)
            sum += number;
        return sum / temperature.Length;
        */


    }
}


/*
            int sum = 0;

            int quantioftemp = 0;
            for (int i = 0; i < temperature.Length; i++)
            {
                sum += temperature[i];
            }

            double average = sum / temperature.Length;

            return average;*/
