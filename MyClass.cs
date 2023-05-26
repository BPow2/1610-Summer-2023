using System;
					
public class Program
{
	public Healer druid;
	public Healer paladin;
	
	public void Main()
	{
		druid = new Healer();
		paladin = new Healer();
		
		druid.Heal = druid.Heal + 50;
		druid.Armor = druid.Armor - 30;
		
		paladin.Heal = paladin.Heal + 10;
		paladin.Armor = paladin.Armor + 100;
		
		Console.WriteLine("Paladin heals " + paladin.Heal + " health");
		Console.WriteLine("Paladin has " + paladin.Armor + " armor");
		
		Console.WriteLine(" ");
		
		Console.WriteLine("Druid heals " + druid.Heal + " health");
		Console.WriteLine("Druid has " + druid.Armor + " armor");
	}
}

public class Healer {
	public int Heal = 50;	
	public int Armor = 50;
}