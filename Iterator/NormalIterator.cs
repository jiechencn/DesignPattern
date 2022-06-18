namespace Iterator;

public class NormalIterator : AbstractIterator
{
    public NormalIterator(AbstractCollection normalCollection)
        : base(normalCollection)
    {
        index = 0;
    }

    public override bool HasNext()
    {
        return index < collection.Length();
    }

    public override object Next()
    {
        object data = collection.Get(index);
        index++;
        return data;
    }
}