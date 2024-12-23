using ExpenseTrackerLibrary;

namespace Manager{
public class ExpenseManager{
        private readonly List<Expense> expenses = new List<Expense>();

        // Add an expense to the list
        public void AddExpense(Expense expense){
            expenses.Add(expense);
        }

        // Get all expenses
        public List<Expense> GetAllExpenses(){
            return expenses;
        }

        // Get total expenses
        public decimal GetTotalExpenses(){
            decimal totalExpense = 0;
            foreach(var expense in expenses){
                totalExpense+=expense.Amount;
            }
            return totalExpense;
        }

        // Filter expenses by category
        public List<Expense> FilterExpensesByCategory(string category){
            return expenses.Where(expense => expense.Category == category).ToList();
        }

    }

}