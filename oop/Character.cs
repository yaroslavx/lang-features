namespace oop;

public class Character
{
    public int Health { get; private set; } = 100;
    
    public void Hit(int damage)
    {
        if (damage > Health)
        {
            damage = Health;
        }
        Health -= damage;
    }
}