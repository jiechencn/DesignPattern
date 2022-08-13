namespace Composite
{
    abstract class AbstractNode
    {
        public string Name { get; protected set; } = string.Empty;
        public int Size { get; protected set; } = default;
        public virtual void Add(AbstractNode node)
        {
        }
        public virtual void Remove(AbstractNode node)
        {
        }
    }
}
