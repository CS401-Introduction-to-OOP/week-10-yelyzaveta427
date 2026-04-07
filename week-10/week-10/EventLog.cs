using System.Collections;

namespace week_10;

public class EventLog : IEnumerable <Event>
{
    public List<Event> events = new List<Event>();
    
    public IEnumerator<Event> GetEnumerator()
    {
        foreach (var e in events)
        {
            yield return e;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    
    public IEnumerable<Event> GetRecentEvents(int n)
    {
        int count = events.Count;
        for (int i = Math.Max(0, count - n); i < count; i++)
        {
            yield return events[i];
        }
    }
}