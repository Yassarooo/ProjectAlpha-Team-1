using System.ComponentModel;
using System.Data.Common;
using System.Diagnostics.Contracts;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

public class Location
{
    public int ID;
    public string Name;
    public string Description;
    public Quest QuestAvailableHere;
    public Monster MonsterLivingHere;
    public Location LocationToNorth;
    public Location LocationToEast;
    public Location LocationToWest;
    public Location LocationToSouth;

    public Location(int id, string name, string description, Quest questAvailableHere = null, Monster monsterLivingHere = null)
    {
        ID = id;
        Name = name;
        Description = description;
        QuestAvailableHere = questAvailableHere;
        MonsterLivingHere = monsterLivingHere;
    }

    public List<Location> GetAvailableLocations()
    {
        List<Location> availableLocations = new List<Location>();

        if (LocationToNorth != null)
        {
            availableLocations.Add(LocationToNorth);
        }

        if (LocationToEast != null)
        {
            availableLocations.Add(LocationToEast);
        }

        if (LocationToWest != null)
        {
            availableLocations.Add(LocationToWest);
        }

        if (LocationToSouth != null)
        {
            availableLocations.Add(LocationToSouth);
        }

        return availableLocations;
    }
}