using System.Diagnostics.CodeAnalysis;

public class Player
{
    public string Name;
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
}