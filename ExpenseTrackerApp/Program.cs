using ExpenseTrackerLibrary;
using Manager;

namespace ExpenseTrackerApp
{
    class Program
    {
        static void Main()
        {
            var expenseManager = new ExpenseManager();
            while (true)
            {
                Console.WriteLine("\n----Expense Tracker Menu----\n");
                Console.WriteLine("\t1. Add an expense");
                Console.WriteLine("\t2. view all expenses");
                Console.WriteLine("\t3. View total expenses");
                Console.WriteLine("\t4. Filter expenses by category");
                Console.WriteLine("\t5. Exit");
                Console.WriteLine("Enter your choice:\t");

                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter the ID:\t");
                        var id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Description:\t");
                        var description = Console.ReadLine();
                        Console.WriteLine("Enter the Category:\t");
                        var category = Console.ReadLine();
                        Console.WriteLine("Enter the Amount:\t");
                        var amount = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Enter the Date:\t");
                        var date = Convert.ToDateTime(Console.ReadLine());
                        if (string.IsNullOrEmpty(description) || string.IsNullOrEmpty(category))
                        {
                            Console.WriteLine("Description and Category cannot be empty");
                            break;
                        }
                        var expense = new Expense(id, description, category, amount, date);
                        expenseManager.AddExpense(expense);
                        Console.WriteLine("Expense added successfully");
                        break;
                    case "2":
                        var expenses = expenseManager.GetAllExpenses();
                        if (expenses.Count == 0)
                        {
                            Console.WriteLine("No expenses found!");
                            break;
                        }
                        Console.WriteLine("List of expenses:");
                        foreach (var exp in expenses)
                        {
                            Console.WriteLine($"Id: {exp.Id}, Description: {exp.Description}, Category: {exp.Category}, Amount: {exp.Amount}, Date: {exp.Date}");
                        }
                        break;
                    case "3":
                        var totalExpenses = expenseManager.GetTotalExpenses();
                        Console.WriteLine($"Total expenses: {totalExpenses}");
                        break;
                    case "4":
                        Console.WriteLine("Enter the category");
                        var filterCategory = Console.ReadLine();
                        if(string.IsNullOrEmpty(filterCategory))
                        {
                            Console.WriteLine("Category cannot be empty");
                            break;
                        }
                        var filteredExpenses = expenseManager.FilterExpensesByCategory(filterCategory);
                        foreach (var exp in filteredExpenses)
                        {
                            Console.WriteLine($"Id: {exp.Id}, Description: {exp.Description}, Category: {exp.Category}, Amount: {exp.Amount}, Date: {exp.Date}");
                        }
                        break;
                    case "5":
                        Console.WriteLine("Exiting the application...bye");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
