namespace oop;

public class Character
{
    private static int Speed = 10;
    
    public int Health { get; private set; } = 100;
    
    public void Hit(int damage)
    {
        if (damage > Health)
        {
            damage = Health;
        }
        Health -= damage;
    }

    public void PrintSpeed()
    {
        Console.WriteLine($"Speed = {Speed}");
    }

    public void IncreaseSpeed()
    {
        Speed++;
    }
}