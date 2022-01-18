using TurboCollections;

var stack = new TurboStack<string>();
bool appIsRunning = true;
stack.Push("Main Menu");
while (appIsRunning)
{
	Console.WriteLine();
	if (stack.Peek() == "Main Menu")
	{
		Console.WriteLine("You are here: " +stack.Peek());
		Console.WriteLine("What do you want to do?");
		Console.WriteLine($"0) Go to level {stack.GetCount()}");
		Console.WriteLine("1) Go to settings");
		Console.WriteLine("2) Quit");
		int selection = Convert.ToInt32(Console.ReadLine());
		if (selection == 1)
		{
			stack.Push("Settings");
		} else if (selection == 2)
		{
			Console.WriteLine("Exiting application...");
			appIsRunning = false;
		} else if (selection == 0)
		{
			stack.Push($"Level {stack.GetCount()}");
		}
		
	} else if (stack.Peek() == "Settings")
	{
		Console.WriteLine("You are here: " +stack.Peek());
		Console.WriteLine("What do you want to do?");
		Console.WriteLine("Any key) Go back to main menu");
		var selection = Console.ReadKey();
		stack.Pop();
	} else if (stack.Peek().Contains("Level"))
	{
		Console.WriteLine("You are here: " +stack.Peek());
		Console.WriteLine("What do you want to do?");
		Console.WriteLine($"0) Go to Level {stack.GetCount()}");
		Console.WriteLine("1) Go to Main Menu");
		
		int selection = Convert.ToInt32(Console.ReadLine());

		if (selection == 0)
		{
			stack.Push($"Level {stack.GetCount()}");
		} else if (selection == 1)
		{
			while (stack.Peek() != "Main Menu")
			{
				stack.Pop();
			}
		}
	}
}