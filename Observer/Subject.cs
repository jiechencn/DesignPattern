namespace Observer;

public class Subject
{
    private List<Subscriber> observers = new List<Subscriber>();
    private int state;

    public string Name { get; set; }

    public void Attach(Subscriber observer)
    {
        observers.Add(observer);
    }

    public void Dettach(Subscriber observer)
    {
        observers.Remove(observer);
    }

    public void SetState(int state)
    {
        this.state = state;
        NotifyObservers();
    }

    private void NotifyObservers()
    {
        foreach(var observer in observers)
        {
            if (state == 1)
            {
                observer.Update(this);
            }
        }
    }
}
