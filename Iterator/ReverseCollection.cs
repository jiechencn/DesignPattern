namespace Iterator;
public class ReverseCollection: AbstractCollection
{
    private Dictionary<int, object> datas = new Dictionary<int, object>();

    public override AbstractIterator CreateIterator()
    {
        return new ReverseIterator(this);
    }

    public override void Add(object data)
    {
        datas.Add(datas.Count, data);
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