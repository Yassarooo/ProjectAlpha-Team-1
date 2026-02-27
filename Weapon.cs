class Weapon
{
    public string Name;
    public int Damage;
    public int ID;

    public Weapon(string name, int damage, int id)
    {
        ID = id;
        Name = name;
        Damage = damage;
    }

    public void Attack(Player p)
    {
        p.HP -= this.Damage;
    }
    public void Attack(Monster p)
    {
        p.HP -= this.Damage;
    }
}
