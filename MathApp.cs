using System;

static class MathApp
{
    static void Main()
    {
		Console.WriteLine();
		Console.WriteLine("MATHAPP: Fun Way to Practice Math!");
		bool exit = false;
		do
		{
			Console.WriteLine();
			Console.WriteLine("           MAIN MENU");
			Console.WriteLine("------------------------------");
			Console.WriteLine("1. Math Test");
			Console.WriteLine("2. Instructions");
			Console.WriteLine("3. About");
			Console.WriteLine("4. Exit");
			Console.WriteLine("------------------------------");
			Console.WriteLine();
			Console.Write("Choose an Option: ");
			
			string choice = Console.ReadLine();
			
			switch (choice)
			{
				case "1":
					Console.WriteLine();
					Console.WriteLine("           MATH TEST");
					Console.WriteLine();
					int numQ = 0;
					do
					{
						Console.Write("Choose the number of questions(25/50/100): ");
						try
							{numQ = int.Parse(Console.ReadLine());}
						catch(Exception e)
							{Console.WriteLine("You must ENTER a valid number!");
							Console.WriteLine("Press ENTER to continue...");
							Console.ReadLine();}
					}
					while(numQ == 0);
					
					MathTest(numQ);
					break;
				case "2":
					Console.WriteLine("");
					Console.WriteLine("           INSTRUCTIONS");
					Console.WriteLine("");
					Console.WriteLine("Welcome to the fun math program, MathApp!");
					Console.WriteLine("The Math Test in this program allows you");
					Console.WriteLine(" to practice your basic math skills.");
					Console.WriteLine("");
					Console.WriteLine("* First you must provide the number of questions");
					Console.WriteLine("* Questions involve the operations +, -, *, /");
					Console.WriteLine("  addition, subtraction, multiplication, and division.");
					Console.WriteLine("* After answering the questions, your results will be displayed.");
					Console.WriteLine("* Have fun!");
					Console.WriteLine("");
					Console.WriteLine("Press ENTER to continue...");
					Console.ReadLine();
					
					break;
				case "3":
					Console.WriteLine("");
					Console.WriteLine("             ABOUT");
					Console.WriteLine("");
					Console.WriteLine("MATHAPP: Fun Way to Practice Math!");
					Console.WriteLine("      Version 1.0.0");
					Console.WriteLine("  Developer:  Shayonta Chowdhury");
					Console.WriteLine();
					Console.WriteLine("Press ENTER to continue...");
					Console.ReadLine();
					break;
				case "4":
					exit = true;
					Console.WriteLine("Exit");
					break;
				default:
					Console.WriteLine("You must ENTER a number from 1-4!");
					Console.WriteLine("Press ENTER to continue...");
					Console.ReadLine();
					break;
			}
		}
		while (!exit);
    }
    static void MathTest(int numQ)
    {
		Random r = new Random();
		int operation;
		int num1;
		int num2;
		int answer;
		bool correct;
		int trial;
		
		int right = 0;
		
		Console.WriteLine();
		Console.WriteLine("Press ENTER to start!");
		Console.ReadLine();
		Console.WriteLine();
		
		for (int i = 0; i < numQ; i++)
		{		
			answer = -1;
			correct = false;
			trial = 0;
			operation = r.Next(4);
			switch (operation)
			{
				case 0:	//+
					num1 = r.Next(1,21);
					num2 = r.Next(1,21);
					
					Console.Write("{0}.", i+1);
					do
					{
						do
						{
							Console.Write(" {0} + {1} = ",num1,num2);
							try 
								{answer = int.Parse(Console.ReadLine());}
							catch (Exception e)
								{Console.WriteLine("     You must ENTER a valid number!");}
						}
						while(answer == -1);
						
						if (answer == (num1+num2))
						{	
							correct = true;
							Console.WriteLine("     Correct!");
							right++;
						}
						else
						{
							Console.WriteLine("     Incorrect...");
							trial++;
						}
					}
					while((trial != 3) && (!correct));
					
					break;
				case 1:	//-
					num1 = r.Next(3,21);
					do
					{
						num2 = r.Next(0,21);
					}
					while(num2 > num1);
					
					Console.Write("{0}.", i+1);
					do
					{
						do
						{
							Console.Write(" {0} - {1} = ",num1,num2);
							try 
								{answer = int.Parse(Console.ReadLine());}
							catch (Exception e)
								{Console.WriteLine("     You must ENTER a valid number!");}
						}
						while(answer == -1);
						
						if (answer == (num1-num2))
						{	
							correct = true;
							Console.WriteLine("     Correct!");
							right++;
						}
						else
						{
							Console.WriteLine("     Incorrect...");
							trial++;
						}
					}
					while((trial != 3) && (!correct));
					
					break;
			    case 2:	//*
					num1 = r.Next(11);
					num2 = r.Next(11);
					
					Console.Write("{0}.", i+1);
					do
					{
						do
						{
							Console.Write(" {0} * {1} = ",num1,num2);
							try 
								{answer = int.Parse(Console.ReadLine());}
							catch (Exception e)
								{Console.WriteLine("     You must ENTER a valid number!");}
						}
						while(answer == -1);
						
						if (answer == (num1*num2))
						{	
							correct = true;
							Console.WriteLine("     Correct!");
							right++;
						}
						else
						{
							Console.WriteLine("     Incorrect...");
							trial++;
						}
					}
					while((trial != 3) && (!correct));
					
					break;
			    case 3:	///
					num1 = r.Next(4,21);
					int[] a = new int[num1];
					
					int j = 0;
					for (int k = 1; k <= (num1/2); k++)
					{
						if (num1 % k == 0)
						{
							a[j] = k;
							j++;
						}
					}
					a[j] = num1;
					
					num2 = r.Next(j+1);
					num2 = a[num2];
					
					Console.Write("{0}.", i+1);
					do
					{
						do
						{
							Console.Write(" {0} / {1} = ",num1,num2);
							try 
								{answer = int.Parse(Console.ReadLine());}
							catch (Exception e)
								{Console.WriteLine("     You must ENTER a valid number!");}
						}
						while(answer == -1);
						
						if (answer == (num1/num2))
						{	
							correct = true;
							Console.WriteLine("     Correct!");
							right++;
						}
						else
						{
							Console.WriteLine("     Incorrect...");
							trial++;
						}
					}
					while((trial != 3) && (!correct));
					
					break;
			}
			Console.WriteLine();
		}
		Console.WriteLine("Press ENTER to view results...");
		Console.ReadLine();
		
		Console.WriteLine("Number of correct answers:   {0}", right);
		Console.WriteLine("Number of incorrect answers: {0}", numQ - right);
		Console.WriteLine("Mark: {0}%  ( {1}/{2} )", right/numQ * 100, right, numQ);
		if (right/numQ >= 0.80) 
			Console.WriteLine("Good job! Keep it up!");
		else
			Console.WriteLine("Nice try! Keep practising to get better!");
		Console.WriteLine("Press ENTER to continue...");
		Console.ReadLine();
    }
}