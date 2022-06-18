namespace Iterator;

public abstract class AbstractIterator
{
    protected AbstractCollection collection;
    protected int index;
    public AbstractIterator(AbstractCollection collection)
    {
        this.collection = collection;
        this.index = -1;
    }

    public abstract bool HasNext();
    public abstract object Next();
}