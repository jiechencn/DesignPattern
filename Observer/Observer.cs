namespace Observer;

public class Subscriber
{
    public string Name { get; set; }

    public void Subscribe(Subject subject)
    {
        subject.Attach(this);
    }

    public void Unsubscribe(Subject subject)
    {
        subject.Dettach(this);
    }

    public void Update(Subject subject)
    {
        Console.WriteLine($"{Name} is notified that {subject.Name} comes");
    }
}
