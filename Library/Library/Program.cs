 class Program
 {
  static void Main(string[] args)
  {
   // Create a CD object
   Cd cd = new Cd
   {
    Artist = "The Beatles",
    Title = "Abbey Road",
    Borrower = "Rayudu"
   };

   // Print information about the CD
   cd.Print();

   // Create a DVD object
   DVD dvd = new DVD
   {
    Title = "The Shawshank Redemption",
    Director = "Frank Darabont",
    Borrower = "Mook"
   };

   // Print information about the DVD
   dvd.Print();

   // Create a Book object
   book book = new book
   {
    Author = "J.K. Rowling",
    Title = "Harry Potter and the Philosopher's Stone",
    ISBN = "9780747532743",
    Borrower = "Mook"
   };

   // Print information about the book
   book.Print();

  }
 }


