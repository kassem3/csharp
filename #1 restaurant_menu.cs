/* Create a menu for a restaurant, show 3 options. */

string choice;

System.Console.WriteLine("Please choose from the following menu:");
System.Console.WriteLine("1- Pizza");
System.Console.WriteLine("2- Sandwich");
System.Console.WriteLine("3- Chicken");

choice = System.Console.ReadLine();

switch (choice)
{
    case "Pizza":
        System.Console.WriteLine("You chose Pizza!");
        break;

    case "Sandwich":
        System.Console.WriteLine("You chose Sandwich!");
        break;

    case "Chicken":
        System.Console.WriteLine("You chose Chicken!");
        break;

    default:
        System.Console.WriteLine("Invalid Choice!");
        break;
}
