 public class DVD : ILoanable, IPrintable
 {
  public string Director { get; set; }
  public string Title { get; set; }
  public int LengthInMinutes { get; set; }
  public int LoanPeriod { get { return 7; } }
  public string Borrower { get; set; }

  public void Borrow(string borrower)
  {
   if (Borrower == null)
   {
    Borrower = borrower;
    Console.WriteLine($"{Title} directed by {Director} has been borrowed by {Borrower}");
   }
   else
   {
    Console.WriteLine($"{Title} directed by {Director} is already borrowed by {Borrower}");
   }
  }

  public void Return()
  {
   if (Borrower != null)
   {
    Console.WriteLine($"{Title} directed by {Director} has been returned");
    Borrower = null;
   }
   else
   {
    Console.WriteLine($"{Title} directed by {Director} is not borrowed");
   }
  }

  public void Print()
  {
   Console.WriteLine($"DVD: {Title} directed by {Director} ({LengthInMinutes} min)");
  }
 }