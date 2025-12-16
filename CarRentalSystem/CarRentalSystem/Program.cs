using System;
using System.Collections.Generic;

namespace CarRentalSystem
{
    class Car
    {
        private bool rented;

        public int Id { get; }
        public string Make { get; }
        public string Model { get; }
        public decimal RentalPrice { get; }

        public Car(int id, string make, string model, decimal rentalPrice)
        {
            Id = id;
            Make = make;
            Model = model;
            RentalPrice = rentalPrice;
            rented = false;
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
            Console.WriteLine($"{Id}. {Make} {Model} (Rental price: ${RentalPrice}/day) - {status}");
        }
    }

    class Program
    {
        static void Main()
        {
            List<Car> cars = new()
            {
                new Car(1, "Toyota", "Corolla", 50m),
                new Car(2, "Honda", "Civic", 60m),
                new Car(3, "Ford", "Mustang", 80m)
            };

            Console.WriteLine("Welcome to the car rental system!\n");

            while (true)
            {
                PrintMenu();
                string choice = Console.ReadLine() ?? "";

                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        RentCar(cars);
                        break;

                    case "2":
                        ReturnCar(cars);
                        break;

                    case "3":
                        ShowCars(cars);
                        break;

                    case "4":
                        Console.WriteLine("Thank you for using the car rental system!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.\n");
                        break;
                }
            }
        }

        static void PrintMenu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Rent a car");
            Console.WriteLine("2. Return a car");
            Console.WriteLine("3. View available cars");
            Console.WriteLine("4. Exit");
            Console.Write("\nPlease enter your choice: ");
        }

        static void RentCar(List<Car> cars)
        {
            ShowCars(cars);

            Console.Write("Please enter the ID of the car you want to rent: ");
            if (!int.TryParse(Console.ReadLine() ?? "", out int carId))
            {
                Console.WriteLine("Invalid input.\n");
                return;
            }

            Car? selectedCar = cars.Find(c => c.Id == carId);

            if (selectedCar == null)
            {
                Console.WriteLine("Car not found.\n");
                return;
            }

            if (selectedCar.Rent())
                Console.WriteLine("Rented the car successfully.\n");
        }

        static void ReturnCar(List<Car> cars)
        {
            ShowCars(cars);

            Console.Write("Please enter the ID of the car you want to return: ");
            if (!int.TryParse(Console.ReadLine() ?? "", out int carId))
            {
                Console.WriteLine("Invalid input.\n");
                return;
            }

            Car? selectedCar = cars.Find(c => c.Id == carId);

            if (selectedCar == null)
            {
                Console.WriteLine("Car not found.\n");
                return;
            }

            if (selectedCar.Return())
                Console.WriteLine("Car returned successfully.\n");
        }

        static void ShowCars(List<Car> cars)
        {
            Console.WriteLine();
            foreach (var car in cars)
                car.PrintInfo();
            Console.WriteLine();
        }
    }
}