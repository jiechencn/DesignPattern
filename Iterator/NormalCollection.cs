namespace Iterator;

public class NormalCollection : AbstractCollection
{
    private List<object> datas = new List<object>();

    public override AbstractIterator CreateIterator()
    {
        return new NormalIterator(this);
    }

    public override void Add(object data)
    {
        datas.Add(data);
    }

    public override int Length()
    {
        return datas.Count;
    }

    public override object Get(int index)
    {
        return datas[index];
    }
}