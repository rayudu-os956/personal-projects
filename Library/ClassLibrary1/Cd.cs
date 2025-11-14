public class Cd : ILoanable,IPrintable
{
    public string Artist{get;set;}
    public string  Title {get;set;}
    public int NumberOfTracks{get;set;}
    public int  LoanPeriod{get{return 14;}}

    public string Borrower{get;set;}

    public void Borrow (string borrower)
    {
        if(Borrower == null)
        {
            Borrower = borrower;
            Console.WriteLine($"{Title} by {Artist} has been borrowed by {Borrower}");
        }
        else
        {
            Console.WriteLine($"{Title} by {Artist} iis already borrowed by {Borrower}");
        }
    }

  public void Return()
  {
   Console.WriteLine($"CD {Title} by {Artist} has been returned.");
   Borrower = null;
  }

  public void Print()
  {
   Console.WriteLine($"CD: {Title} by {Artist} ({(Borrower == null ? "available" : "borrowed by " + Borrower)})");
  }
}