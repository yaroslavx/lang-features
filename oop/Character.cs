namespace oop;

public class Point2D
{
    private int x;
    private int y;

    public Point2D(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}

public class Character
{
    private readonly int Speed;
    
    public int Health { get; private set; } = 100;
    
    public string Race { get; private set; }
    public int Armor { get; private set; }

    public Character(string race)
    {
        Race = race;
        Armor = 30;
    }
    
    public Character(string race, int armor, int speed)
    {
        Race = race;
        Armor = armor;
        Speed = speed;
    }
    
    public void Hit(int damage)
    {
        if (damage > Health)
        {
            damage = Health;
        }
        Health -= damage;
    }
}