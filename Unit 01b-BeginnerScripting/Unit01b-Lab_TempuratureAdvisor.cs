using System;
					
public class Program
{
	
	public void Main()
	{
		//asks user what the current temperature is in celsius
		Console.WriteLine("What is the current tempurature? (in Celsius)");
		int currentTemp = Convert.ToInt32(Console.ReadLine());
		int requiredTemp = 30;
		Temperature(currentTemp, requiredTemp);
		
	}
	
	public void Temperature (int currentTemp, int requiredTemp) {
		//checks to see if the current temp is less than or greater than 30
	if (currentTemp > requiredTemp) {
		Console.WriteLine("Don't forget to stay hydrated and avoid being in the sun for extended periods of time.");
	} else {
		Console.WriteLine("Enjoy the nice weather.");
	}
	}}
