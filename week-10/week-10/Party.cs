using System.Collections;

namespace week_10;

public class Party : IEnumerable <Character>
{
    public List<Character> characters = new List<Character>();
    public IEnumerator<Character> GetEnumerator()
    {
        foreach (var character in characters)
        {
            yield return character;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerable GetActiveMembers()
    {
        foreach (var c in characters )
        {
            if (c.IsActive)
            {
                yield return c;
            }
        }
    }

    public void Add(Character c) => characters.Add(c);

    public IEnumerable GetWounded(int attack)
    {
        foreach (var c in characters)
        {
            if (c.Health < attack)
            {
                yield return c;
            }
        }
    }
}