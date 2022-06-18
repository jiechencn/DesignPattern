namespace Iterator;

public class ReverseIterator : AbstractIterator
{
    public ReverseIterator(ReverseCollection collection)
        :base(collection)
    {
        index = collection.Length() - 1;
    }

    public override bool HasNext()
    {
        return index > 0;
    }

    public override object Next()
    {
        object data = collection.Get(index);
        index--;
        return data;
    }
}