namespace week_10;

public class Event
{
    public int NumberOfMove { get; set; }
    public string DescriptionOfEvent { get; set; }
    public string TypeOfEvent { get; set; }
    public string ChangeCharachteristics { get; set; }

    public Event(int numberOfMove, string descriptionOfEvent, string typeOfEvent, string changeCharachteristics)
    {
        NumberOfMove = numberOfMove;
        DescriptionOfEvent = descriptionOfEvent;
        TypeOfEvent = typeOfEvent;
        ChangeCharachteristics = changeCharachteristics;
    }
}