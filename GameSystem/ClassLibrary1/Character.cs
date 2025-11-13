using System.Runtime.CompilerServices;
using System.Security.Cryptography;

public class Character
{
    public string _name;
    public int _health;
    public   int _attack;
    public   int _defence ;

    public Character(string name ,int health , int attck, int defence)
    {
        this._name = name;
        this._health = health;
        this._attack = attck;
        this._defence = defence;
    }

    public virtual void Attack(Character target)
    {
        int damage = _attack -target._defence;
        if (damage > 0)
        {
            target._health -= damage; 
            Console.WriteLine($"{_name} attacks {target._name} for {damage} damage!");
        }
        if(damage <= 0)
        {
            Console.WriteLine($"{_name}'s attack has no effect on {target._name}.");
        }
    }
    public virtual void Defend()
    {
         Console.WriteLine($"{_name} defends.");
    }
    
}