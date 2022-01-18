using TurboCollections;

var stack = new TurboStack<string>();
var appIsRunning = true;
var previousState = "";
stack.Push("Main Menu");

while (appIsRunning)
{
	Console.WriteLine();

	if (stack.Peek() == "Main Menu")
	{
		MainMenu();
	}
	else if (stack.Peek() == "Settings")
	{
		SettingsMenu();
	}
	else if (stack.Peek().Contains("Level"))
	{
		LevelMenu();
	}
}

void MainMenuSelection(int selection)
{
	if (selection == 1)
	{
		previousState = stack.Peek();
		stack.Push("Settings");
	}
	else if (selection == 2)
	{
		Console.WriteLine("Exiting application...");
		appIsRunning = false;
	}
	else if (selection == 0)
	{
		previousState = stack.Peek();
		stack.Push($"Level {stack.GetCount()}");
	}
}

void MainMenu()
{
	Console.WriteLine("You are here: " + stack.Peek());
	Console.WriteLine("What do you want to do?");
	Console.WriteLine($"0) Go to level {stack.GetCount()}");
	Console.WriteLine("1) Go to settings");
	Console.WriteLine("2) Quit");
	var selection = Convert.ToInt32(Console.ReadLine());
	MainMenuSelection(selection);
}

void SettingsMenu()
{
	Console.WriteLine("You are here: " + stack.Peek());
	Console.WriteLine("What do you want to do?");
	Console.WriteLine("Any key) Go back to main menu");
	var selection = Console.ReadKey();
	stack.Pop();
}

void LevelMenuSelection(int selection)
{
	if (selection == 0)
	{
		previousState = stack.Peek();
		stack.Push($"Level {stack.GetCount()}");
	}
	else if (selection == 1)
	{
		while (stack.Peek() != "Main Menu")
		{
			stack.Pop();
		}
	}
	else if (selection == 3)
	{
		stack.Pop();
		previousState = stack.Peek();
	}
}

void LevelMenu()
{
	Console.WriteLine("You are here: " + stack.Peek());
	Console.WriteLine("What do you want to do?");
	Console.WriteLine($"0) Go to Level {stack.GetCount()}");
	Console.WriteLine("1) Go to Main Menu");
	Console.WriteLine($"3) Go backwards to {previousState}");
	var selection = Convert.ToInt32(Console.ReadLine());
	LevelMenuSelection(selection);
}
