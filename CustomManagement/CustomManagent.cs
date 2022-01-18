
using TurboCollections;

bool AppRunning = true;
var customerManager = new TurboList<string>();
while (AppRunning)
{

	Console.WriteLine("----Choose an option----");
	Console.WriteLine("1) Add a Customer");
	Console.WriteLine("2) Remove Customer by name");
	Console.WriteLine("3) Remove Customer by index");
	Console.WriteLine("4) Display All Customers");
	Console.WriteLine("5) Exit Application");

	Console.Write("<<<  ");
	int selection = Convert.ToInt32(Console.ReadLine());

	switch (selection)
	{
		case 1:
			AddACustomer();

			break;
		case 2:
			RemoveCustomerByName();

			break;
		case 3:
			RemoveCustomerByIndex();

			break;
		case 4:
			DisplayALlCustomers();

			break;
		case 5:
			Console.WriteLine("Exiting Application...");
			AppRunning = false;

			break;
	}


}

void AddACustomer()
{
	Console.WriteLine("What is the customers name?");
	string name = Console.ReadLine();
	customerManager.Add(name);

}

void RemoveCustomerByName()
{
	Console.WriteLine("What name do you want to remove?");
	string name = Console.ReadLine();
	customerManager.Remove(name);
}

void RemoveCustomerByIndex()
{
	Console.WriteLine("What index do you want to remove?");
	int index = Convert.ToInt32(Console.ReadLine());
	customerManager.RemoveAt(index);
}

void DisplayALlCustomers()
{
	Console.WriteLine("Customers:");

	for (int i = 0; i < customerManager.Count; i++)
	{
		Console.WriteLine(customerManager.Get(i));
	}
}