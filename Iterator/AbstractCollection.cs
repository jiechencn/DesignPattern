namespace Iterator;

public abstract class AbstractCollection
{
    public abstract AbstractIterator CreateIterator();
    public abstract void Add(object data);
    public abstract int Length();
    public abstract object Get(int index);
}
