public class Player
{
    public string Name;
    public int Health;
    public int CurrentHitPoints;
    public int MaximumHitPoints;
    public Weapon CurrentWeapon;
    public Location CurrentLocation;

    public Player(string name, int currenthitpoints, int maximumhitpoints)
    {
        Name = name;
        CurrentHitPoints = currenthitpoints;
        MaximumHitPoints = maximumhitpoints;
        CurrentWeapon = null;
        CurrentLocation = null;
    }

    public bool IfAlive()
    {
        if (CurrentHitPoints != 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static void Heal(int amount)
    {
        CurrentHitPoints += amount;
    }


}