namespace Mediator;

public abstract class AbstractMedia
{
    protected IPress press;
    protected string name;
    public AbstractMedia(IPress press, string name)
    {
        this.press = press;
        this.name = name;
        this.press.Register(this);
    }

    public abstract void Send(string news);
    public abstract void Receive(string news);
}

public class Media : AbstractMedia
{
    public Media(IPress press, string name) : base(press, name)
    {
    }

    public override void Receive(string news)
    {
        Console.WriteLine(this.name + ": received news:" + news);
    }

    public override void Send(string news)
    {
        Console.WriteLine(this.name + ": Sending news=" + news + "\n");
        press.ReleaseNews(news, this);
    }
}