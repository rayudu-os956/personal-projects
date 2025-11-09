class Program
{
    static void Main()
    {
        //Implicit Typcasting 
        byte a = 10;
        short e = a;
        System.Console.WriteLine(e);

        //Explicit Casting
        int b = 10;
        short f = (short)b;
        System.Console.WriteLine(f);

        //Parse 
        string c = "10.34";
        double g = double.Parse(c);
        System.Console.WriteLine(g);

        //tryparse 

        bool t = decimal.TryParse(c, out decimal h);
        {
            if (t)
            {
                System.Console.WriteLine(h);
            }
            else
            {
                System.Console.WriteLine("Not converted");
            }
        }
        decimal d = 11.56M; //decimal type
        string i = System.Convert.ToString(d);
         System.Console.WriteLine(i);

    }
}