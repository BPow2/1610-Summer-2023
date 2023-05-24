using System;
					
public class Program
{
	public Weapon miniGun;
	public Ammo increaseAmmo;
	
	public void Main()
	{
		miniGun = new Weapon();
		increaseAmmo = new Ammo();
		
	
		miniGun.ammoCount += increaseAmmo.ammoUpgrade;
		Console.WriteLine(miniGun.weaponName + " has an ammo count of " + miniGun.ammoCount + ". ");
		
	}
}

public class Weapon {
	public int ammoCount = 10;
	public string weaponName = "Minigun";
	public float firePower = 11.5f;
}

public class Ammo {
	public int ammoUpgrade = 5;
}
