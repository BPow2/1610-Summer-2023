using System;
					
public class Program
{
	public Hero heroOne;
	public Hero heroTwo;
	
	public void Main()
	{
		heroOne = new Hero();
		heroTwo = new Hero();

		Console.WriteLine(heroOne.health);
		Console.WriteLine(heroOne.powerLevel);
		
		Console.WriteLine(heroTwo.health);
		Console.WriteLine(heroTwo.powerLevel);
	}
}

public class Hero {
	public int health = 100;
	public int powerLevel = 9001;
}