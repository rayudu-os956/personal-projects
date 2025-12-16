public  class Car
{
    private string make;
    private string model;
    private decimal rentalPrice;
    private bool rented;

     public int Id { get; }

     public Car(int id, string make, string model, decimal rentalPrice)
    {
        Id = id;
        this.make = make;
        this.model = model;
        this.rentalPrice = rentalPrice;
        this.rented = false;

    }
        public bool Rent()
        {
            if (rented)
            {
                Console.WriteLine("Sorry, this car is already rented.");
                return false;
            }
            rented = true;
            return true;
        }

        public bool Return()
        {
            if (!rented)
            {
                Console.WriteLine("This car is not currently rented.");
                return false;
            }
            rented = false;
            return true;
        }

        public void PrintInfo()
        {
                      string status = rented ? "Rented" : "Available";
            Console.WriteLine($"{Id}. {make} {model} (Rental price: ${rentalPrice}/day) - {status}");
        }


    
}