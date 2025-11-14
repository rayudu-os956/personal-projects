 class Program
 {
  static void Main(string[] args)
  {
   // Create a CD object
   Cd cd = new Cd
   {
    Artist = "The Beatles",
    Title = "Abbey Road",
    NumberOfTracks = 11,
   };

   // Print information about the CD
   cd.Print();
   cd.Borrow("Rayudu");
   cd.Return();


   // Create a DVD object
   DVD dvd = new DVD
   {
    Title = "The Shawshank Redemption",
    Director = "Frank Darabont",
    LengthInMinutes = 143,
   };

   // Print information about the DVD
   dvd.Print();
   dvd.Borrow("Mook");
   dvd.Return();

   // Create a Book object
        book book = new book
        {
            Author = "George Orwell",
            Title = "1984",
            ISBN = "9780451524935"
        };


   // Print information about the book
        book.Print();
        book.Borrow("Diiory");
        book.Return();

  }
 }


