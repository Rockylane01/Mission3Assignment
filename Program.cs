/*
 * Author: Rocky Lane
 * This Program creates a list of FoodItems that keep track of information for the inventory of a food bank.
 */

using Mission3Assignment;

List<FoodItem> foodItems = new List<FoodItem>();

Console.WriteLine("Welcome to the Food Inventory System!");
bool running = true;
while (running)
{
    Console.WriteLine("Please choose an option:");
    Console.WriteLine("1. Add Food Item");
    Console.WriteLine("2. View Food Items");
    Console.WriteLine("3. Remove Food Item");
    Console.WriteLine("4. Exit");
    string choice = Console.ReadLine();

    // Depending on user choice, perform actions
    switch (choice)
    {
        case "1":
            Console.Write("Enter food name: ");
            string name = Console.ReadLine();

            Console.Write("Enter food category: ");
            string category = Console.ReadLine();

            Console.Write("Enter quantity: ");
            string sQuantity = Console.ReadLine();
            if (!int.TryParse(sQuantity, out int quantity))
            {
                Console.WriteLine("Invalid quantity. Please enter a valid number.");
                Console.WriteLine();
                break;
            }

            Console.Write("Enter expiration date (yyyy-mm-dd): ");
            string sDate = Console.ReadLine();
            if (!DateTime.TryParse(sDate, out DateTime expDate))
            {
                Console.WriteLine("Invalid date. Please enter a valid date (yyyy-mm-dd).");
                Console.WriteLine();
                break;
            }

            FoodItem newItem = new FoodItem(name, category, quantity, expDate);
            foodItems.Add(newItem);

            Console.WriteLine("Food item added successfully!");
            Console.WriteLine();
            break;

        case "2":
            Console.WriteLine();
            Console.WriteLine("Current Food Items:");

            if (foodItems.Count < 1)
            {
                Console.WriteLine("No food items have been added.");
            }

            foreach (var item in foodItems)
            {
                Console.WriteLine($"Name: {item.getName()}");
                Console.WriteLine($"Category: {item.getCategory()}");
                Console.WriteLine($"Quantity: {item.getQuantity()}");
                Console.WriteLine($"Expiration Date: {item.getExpirationDate().ToShortDateString()}");
                Console.WriteLine();
            }
            Console.WriteLine();
            break;

        case "3":
            Console.WriteLine("Enter the name of the food item to remove: ");
            string removeName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(removeName))
            {
                Console.WriteLine("Invalid input. Please enter a valid food name.");
                Console.WriteLine();
                break;
            }

            FoodItem itemToRemove = foodItems.Find(item => item.getName().Equals(removeName, StringComparison.OrdinalIgnoreCase));

            if (itemToRemove != null)
            {
                foodItems.Remove(itemToRemove);
                Console.WriteLine("Food item removed successfully!");
            }
            else
            {
                Console.WriteLine("Food item not found.");
            }
            Console.WriteLine();
            break;

        case "4":
            running = false;
            Console.WriteLine("Exiting the system. Goodbye!");
            Console.WriteLine();
            break;

        default:
            Console.WriteLine("Invalid choice. Please try again and make sure you entered a valid number (1-4).");
            Console.WriteLine();
            break;
    }
}