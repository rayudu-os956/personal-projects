using System.Security.Principal;

public class Mage : Character
{
     public Mage(string name, int health, int attack, int defense) : base(name, health, attack, defense)
    {
        
    }

    public void CastSpell(Character target)
    {
        int damage = _attack*3-target._defence;
        if (damage > 0)
        {
            target._health  -= damage;
            Console.WriteLine($"{_name} casts  a spell om {target._name} for {damage} damage!!");
        }
        else
        {
            Console.WriteLine($"{_name}'s spell has no effect on {target._name}.");
        }
    }
        // Sealed method for the Mage class
    public sealed override void Defend()
    {
        Console.WriteLine($"{_name} cannot defend!");
    }

}