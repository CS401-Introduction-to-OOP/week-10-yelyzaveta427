namespace week_10;

public class Character
{
    public string Name { get; set; }
    public string Role { get; set; }
    public string Level { get; set; }
    public int Health { get; set; }
    public int GoldAmount { get; set; }
    public string StateCharacter { get; set; }
    public bool IsActive { get; set; }

    public Character(string name, string role, string level, int health, int goldAmount, string stateCharacter)
    {
        Name = name;
        Role = role;
        Level = level;
        Health = health;
        GoldAmount = goldAmount;
        StateCharacter = stateCharacter;
        
    }
}