public class Game
{
    public void Battle(Character c1 , Character c2)
    {
        
        Console.WriteLine($"--- Battle between {c1._name} and {c2._name} ---");
        while(c1._health >0 && c2._health > 0)
        {
            c1.Attack(c2);
                if (c2._health > 0)
                {
                    c2.Attack(c1);
                }
            
            }

         if (c1._health <= 0)
        {
            Console.WriteLine($"{c2._name} wins!");
        }
        else
        {
            Console.WriteLine($"{c1._name} wins!");
        }
        

    }
}