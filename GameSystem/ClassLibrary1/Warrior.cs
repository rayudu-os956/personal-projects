public class Warrior : Character
{
    public Warrior(string name,int health,int attack,int defence): base(name,health,attack,defence)
    {
        
    }

    public void Charge(Character target)
    {
        int damage =  _attack*2-target._defence;
        if (damage > 0)
        {
            target._health -= damage;
             Console.WriteLine($"{_name} charges {target._name} for {damage} damage!");
        }
        if (damage <= 0)
        {
            Console.WriteLine($"{_name}'s charge has np effect on {target._name}");
        }
    }

    public override void Defend()
    {
        _defence +=5 ;
        Console.WriteLine($"{_name} defends and gains 5 defense.");
    }
}