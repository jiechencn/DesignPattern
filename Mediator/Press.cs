namespace Mediator;

public interface IPress
{
    void ReleaseNews(string news, AbstractMedia media);
    void Register(AbstractMedia media);
}

public class CentralPress : IPress
{

    private List<AbstractMedia> medias = new List<AbstractMedia>();
    public void Register(AbstractMedia media)
    {
        medias.Add(media);
    }

    public void ReleaseNews(string news, AbstractMedia media)
    {
        news = news.Replace("bad", "good");

        foreach (var m in medias)
        {
            m.Receive(news);
        }
    }
}