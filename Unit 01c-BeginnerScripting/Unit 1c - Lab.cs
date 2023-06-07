using System;
					
public class Program
{
	public void Main()
	{
		Console.Write("Enter a number:");
        int rows = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(" ");
		
 		for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine("\n");
            }
		}}
		
	
