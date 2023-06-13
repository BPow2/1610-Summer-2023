using System;
					
public class Program
{
	public void Main()
	{
		//Generates a random number 1-10.
		Random rand = new Random();
		int chosenNumber;
		chosenNumber = rand.Next(1, 11);
		Console.WriteLine(chosenNumber);
		
		//Asks user to guess the number
		Console.WriteLine("Guess a number between 1 and 10.");
		int guess;
		guess = Convert.ToInt32(Console.ReadLine());
		
		//Loop to give user multiple guesses
		while (guess != chosenNumber){
			if (guess > chosenNumber){
				Console.WriteLine("Your number was too high. Try again: ");
				guess = Convert.ToInt32(Console.ReadLine());
			} else if (guess < chosenNumber) {
				Console.WriteLine("Your number was too low. Try agian: ");
				guess = Convert.ToInt32(Console.ReadLine());
			}
			
		}
		Console.WriteLine("Correct!");
	}
}