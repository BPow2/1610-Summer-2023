using System;
					
public class Program
{
	public void Main()
	{
		Console.WriteLine("What is your exam score? (0-100) ");
		int examScore = Convert.ToInt32(Console.ReadLine());
		LetterGrade(examScore);
	}
	
	public void LetterGrade (int examScore) {
		if (examScore >= 90) {
			Console.WriteLine("A");	
	} else if (examScore < 90
			  && examScore > 70) {
			Console.WriteLine("B");
		} else if (examScore > 50
				  && examScore < 70) {
			Console.WriteLine("C");
		}
	
			
		}
	}
