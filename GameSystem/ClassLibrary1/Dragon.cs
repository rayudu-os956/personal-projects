public class Drageon : Character
{
    public Drageon (string name, int health , int attack, int defence) : base( name,  health ,  attack, defence)
    {
    }

    public override void Attack(Character target)
    {
        int damage = _attack * 2 - target._defence;
        if (damage > 0)
        {
            target._health -= damage;
            Console.WriteLine($"{_name} attacks {target._name} for {damage} damage!");
        }
        else
        {
            Console.WriteLine($"{_name}'s attack has no effect on {target._name}.");
        }
    }
    public void BreatheFire(Character target)
    {
        int damage = _attack * 4 - target._defence;
        if (damage > 0)
        {
            target._health -= damage;
            Console.WriteLine($"{_name} breathes fire on {target._name} for {damage} damage!");
        }
        else
        {
            Console.WriteLine($"{_name}'s fire has no effect on {target._name}.");
        }
    }
        public override void Defend()
    {
        Console.WriteLine($"{_name} defends and gains 10 defense.");
        _defence += 10;
    }
}
    