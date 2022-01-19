using TurboCollections;

var gameState = new TurboStack<string>();
var stateHistory = new TurboStack<string>();

var appIsRunning = true;
gameState.Push("Main Menu");

while (appIsRunning)
{
	Console.WriteLine();

	if (gameState.Peek() == "Main Menu")
	{
		MainMenu();
	}
	else if (gameState.Peek() == "Settings")
	{
		SettingsMenu();
	}
	else if (gameState.Peek().Contains("Level"))
	{
		LevelMenu();
	}
}

void MainMenuSelection(int selection)
{
	if (selection == 1)
	{
		stateHistory.Push(gameState.Peek());;
		gameState.Push("Settings");
	}
	else if (selection == 2)
	{
		Console.WriteLine("Exiting application...");
		appIsRunning = false;
	}
	else if (selection == 0)
	{
		stateHistory.Push(gameState.Peek());
		gameState.Push($"Level {gameState.GetCount()}");
	}
}

void MainMenu()
{
	Console.WriteLine("You are here: " + gameState.Peek());
	Console.WriteLine("What do you want to do?");
	Console.WriteLine($"0) Go to level {gameState.GetCount()}");
	Console.WriteLine("1) Go to settings");
	Console.WriteLine("2) Quit");
	var selection = Convert.ToInt32(Console.ReadLine());
	MainMenuSelection(selection);
}

void SettingsMenu()
{
	Console.WriteLine("You are here: " + gameState.Peek());
	Console.WriteLine("What do you want to do?");
	Console.WriteLine("Any key) Go back to main menu");
	var selection = Console.ReadKey();
	gameState.Yeet();
	stateHistory.Yeet();
}

void LevelMenuSelection(int selection)
{
	switch (selection)
	{
		case 0:
			stateHistory.Push(gameState.Peek());
			gameState.Push($"Level {gameState.GetCount()}");

			break;
		case 1:
		{
			while (gameState.Peek() != "Main Menu")
			{
				gameState.Yeet();
				stateHistory.Yeet();
			}

			break;
		}
		case 2:

			gameState.Yeet();
			stateHistory.Yeet();

			break;
	}
}

void LevelMenu()
{
	Console.WriteLine("You are here: " + gameState.Peek());
	Console.WriteLine("What do you want to do?");
	Console.WriteLine($"0) Go to Level {gameState.GetCount()}");
	Console.WriteLine("1) Go to Main Menu");
	Console.WriteLine($"2) Go backwards to {stateHistory.Peek()}");
	
	var selection = Convert.ToInt32(Console.ReadLine());
	LevelMenuSelection(selection);
}