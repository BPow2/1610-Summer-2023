using System;
					
public class Program
{
	public void Main()
	{
		Console.WriteLine("What is your exam score? (0-100) ");
		//asks the user what their score is from 0-100
		int examScore = Convert.ToInt32(Console.ReadLine());
		LetterGrade(examScore);
	}
	
	public void LetterGrade (int examScore) {
		//checks to see if exam score is over 90
		if (examScore >= 90) {
			Console.WriteLine("A");	
			//checks to see if exam score is less than 90 but great than 70
	} else if (examScore < 90
			  && examScore > 70) {
			Console.WriteLine("B");
			//checks to see if exam score is greater than 50 but also less than 70
 		} else if (examScore > 50
				  && examScore < 70) {
			Console.WriteLine("C");
		}
	
			
		}
	}
