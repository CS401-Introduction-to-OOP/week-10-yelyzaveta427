using week_10;

public class Program
{
    public static void Main()
    {
        Character c1 = new Character("Ben", "warrior", 2, 3, 5, true);
        Character c2 = new Character("Bob", "thief", 10, 5, 10, true);
        Character c3 = new Character("Silvia", "Seller", 15, 10, 30, true);
        Party party = new Party();
        
        party. Add(c1);
        party.Add(c2);
        party.Add(c3);


        EventLog log = new EventLog();
        Event e1 = new Event(1, "robbery", "conflict", "0" );
        Event e2 = new Event(2, "gold purchasing", "exchange of gold", "5" );
        
        log.Add(e1);
        log.Add(e2);

        foreach (var m in party)
        {
            Console.WriteLine($"{m.Name} - {m.Role}");
        }
        
        foreach (Character member in party.GetActiveMembers())
        {
            Console.WriteLine($"Active member - {member.Name}");
        }

        foreach (Character m in party.GetWounded(1))
        {
            Console.WriteLine($"{m.Name} has been wounded");
        }

        var richCharacters = party.Where(c => c.GoldAmount > 30);
        foreach (var m in richCharacters)
        {
            Console.WriteLine($"{m.Name}: {m.GoldAmount} amount of gold");
        }

        var byLevel = party.OrderBy(c => c.Level);
        foreach (var c in byLevel)
        {
            Console.WriteLine($"{c.Name} level - {c.Level}");
        }
        
        var avgLevel = party.Average(c => c.Level);
        Console.WriteLine($"Average Level of members: {avgLevel}");

        foreach (var e in log.GetRecentEvents(2))
        {
            Console.WriteLine($"Event {e.DescriptionOfEvent} has number of move {e.NumberOfMove}");
        }
    }
}