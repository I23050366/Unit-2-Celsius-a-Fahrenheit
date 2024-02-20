



class PhysicsConverter
{
    static void Main()
    {
        // Get user input for temperature in Celsius
        Console.Write("Enter temperature in Celsius: ");
        double celsiusTemperature = Convert.ToDouble(Console.ReadLine());

        // Convert temperature to Fahrenheit using the formula: fahrenheit = (celsius * 9/5) + 32
        double fahrenheitTemperature = ConvertCelsiusToFahrenheit(celsiusTemperature);

        // Display the converted temperature
        Console.WriteLine($"The temperature in Fahrenheit is: {fahrenheitTemperature} °F");
    }

    // Method to convert Celsius to Fahrenheit
    // Formula: fahrenheit = (celsius * 9/5) + 32
    static double ConvertCelsiusToFahrenheit(double celsiusTemperature)
    {
        return (celsiusTemperature * 9 / 5) + 32;
    }
}