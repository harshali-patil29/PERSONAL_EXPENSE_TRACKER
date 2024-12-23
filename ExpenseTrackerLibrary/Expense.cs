namespace ExpenseTrackerLibrary{

public class Expense
{
    
    public int Id { get; set; }
    public string Description { get; set; }
    public string Category { get; set; }
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }

    public Expense(int Id,string Description,string Category,decimal Amount,DateTime Date)
    {
        this.Id = Id;
        this.Description = Description;
        this.Category = Category;
        this.Amount = Amount;
        this.Date = Date;
    }
    

    public override string ToString(){
        return $"Id: {Id}, Descripton: {Description}, Category: {Category}, Amount: {Amount}, Date: {Date}";
    }



}
}
