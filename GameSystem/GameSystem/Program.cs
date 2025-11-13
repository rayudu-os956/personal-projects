class Program
{
    public static void Main()
    {
        Warrior warrior = new Warrior("Rayudu",100,20,30);
        Mage mage = new Mage ("Mook",80 ,15,5);
        Drageon drageon = new Drageon("Dory ",200,30,20);
        warrior.Attack(mage);
        mage.Defend();
        drageon.BreatheFire(warrior);
        drageon.Defend();
        warrior.Defend();

        Game game = new Game();
        game.Battle(warrior,mage);
        game.Battle(mage,drageon);
        game.Battle(warrior,drageon);   
    }
}