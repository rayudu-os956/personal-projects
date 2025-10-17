class Program {
    static void Main()
    {
        System.Console.WriteLine("****RayuduBank*******");
        System.Console.WriteLine("::Login Page ::");
        //declare variables to store username and password
        string userName = null, password = null;

        //read userName From keyboard

        System.Console.Write("Username: ");
        userName = System.Console.ReadLine();
        
        //read passwpprd from key board only if username is entered 
        if(userName != ""){
        System.Console.Write("Password: ");
        password = System.Console.ReadLine();
        }
        //check username and password 
    if (userName == "system"&&password == "manager")
    {
    int mainMenuChoice =-1;
     do{
            //declare variable to store menu choice 
          
            
            System.Console.WriteLine("\n::Main Menu:: ");
            System.Console.WriteLine("1.Customers");
            System.Console.WriteLine("2.Accounts");
            System.Console.WriteLine("3.Funds Transfer");
            System.Console.WriteLine("4.Funds Transfer Staement");
            System.Console.WriteLine("5.Accounts Statement");
            System.Console.WriteLine("0.Exit");


        System.Console.Write("Enetr Choice: ");
        mainMenuChoice = int.Parse(System.Console.ReadLine());

        //switch-case to check menu choice 
        switch (mainMenuChoice)
        {
            case 1: CustomersMenu();//To do :display customers meniu
            break;
            case 2: AccountsMenu();
            break;
            case 3:
            break;
            case 4: 
            break;
            case 5:
            break;
                
            
        }
     }while (mainMenuChoice!=0);
         
    }
        else
        {

            System.Console.WriteLine("Invalid username or password ");
        }
        //about to exit 

        System.Console.WriteLine("Thank you! Visit again");
        

    }
    static void CustomersMenu()
    {
        int customersMenuChoice = -1;

        do 
        {
            System.Console.WriteLine("\n:::Customers menu :::");
            System.Console.WriteLine("1.Add Customer");
            System.Console.WriteLine("2.Delete Customer");
            System.Console.WriteLine("3.Update Customer");
            System.Console.WriteLine("4.View Customers");
            System.Console.WriteLine("0.Back to main Menu");

            System.Console.Write("Enetr Choice:");
           customersMenuChoice = System.Convert.ToInt32(System.Console.ReadLine());

        }while(customersMenuChoice!=0);

    }
    static void AccountsMenu(){
        int assountsMenuchoice = -1;
        do{
            System.Console.WriteLine("\n:::Accounts  menu :::");
            System.Console.WriteLine("1.Add Account");
            System.Console.WriteLine("2.Delete account");
            System.Console.WriteLine("3.Update Account");
            System.Console.WriteLine("4.View Account");
            System.Console.WriteLine("0.Back to main Menu");

            System.Console.Write("Enetr Choice:");
           assountsMenuchoice = System.Convert.ToInt32(System.Console.ReadLine());
        }while(assountsMenuchoice!=0);

    }
}