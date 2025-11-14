public class book : ILoanable, IPrintable
{
  public string Author { get; set; }
  public string Title { get; set; }
  public string ISBN { get; set; }
  public int LoanPeriod { get { return 21; } }
  public string Borrower { get; set; }

    public void Borrow(string borrower)
  {
   if (Borrower == null)
   {
    Borrower = borrower;
    Console.WriteLine($"{Title} by {Author} has been borrowed by {Borrower}");
   }
   else
   {
    Console.WriteLine($"{Title} by {Author} is already borrowed by {Borrower}");
   }
  }

  public void Return()
  {
   if (Borrower != null)
   {
    Console.WriteLine($"{Title} by {Author} has been returned");
    Borrower = null;
   }
   else
   {
    Console.WriteLine($"{Title} by {Author} is not borrowed");
   }
  }

    public void Print()
  {
    Console.WriteLine($"Book: {Title} by {Author} (ISBN: {ISBN}) ({(Borrower == null ? "available" : "borrowed by " + Borrower)})");
  }
 

}