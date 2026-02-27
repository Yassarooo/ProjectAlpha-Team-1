public class Quest
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsCompleted { get; set; }

    public void GiveReward(Player player, Weapon reward)
    {
        if (!IsCompleted)
        {
            player.currentWeapon = reward;
            IsCompleted = true;
        }
    }
}