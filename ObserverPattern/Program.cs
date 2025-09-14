using ObserverPattern.Displays;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            // Create instances of displays 
            CurrentConditionDisplay currentDisplay = new CurrentConditionDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);

            Random rnd = new Random();

            // 3 dagen met alle displays
            for (int day = 1; day <= 3; day++)
            {
                float temp = rnd.Next(5, 35);
                float humidity = rnd.Next(40, 100);
                float pressure = 30.4f;

                Console.WriteLine($"Dag {day}:");
                weatherData.SetMeasurements(temp, humidity, pressure);
                Console.WriteLine("");
            }

            // input voor unsub
            Console.WriteLine("Druk op enter om StatisticsDisplay te unsubben");
            Console.ReadLine();

            Console.Clear();

            weatherData.RemoveObserver(statisticsDisplay);
            Console.WriteLine("StatisticsDisplay is niet meer gesubbed");
            Console.WriteLine("");

            // 3 dagen zonder sttisics display
            for (int day = 4; day <= 6; day++)
            {
                float temp = rnd.Next(5, 35);
                float humidity = rnd.Next(40, 100);
                float pressure = 30.4f;

                Console.WriteLine($"Dag {day}:");
                weatherData.SetMeasurements(temp, humidity, pressure);
                Console.WriteLine("");
            }

            //weatherData.SetMeasurements(8, 55, 30.4f);
            //Console.WriteLine("");

            //weatherData.SetMeasurements(29, 70, 29.2f);
            //Console.WriteLine("");

            //weatherData.SetMeasurements(15, 90, 29.2f);
            //Console.WriteLine("");
        }
    }
}