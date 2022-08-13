namespace Composite
{
    class Folder : AbstractNode
    {
        private IList<AbstractNode> children = new List<AbstractNode>();

        public Folder(string name)
        {
            Name = name;
        }

        public override void Add(AbstractNode node)
        {
            children.Add(node);
            Size += node.Size;
        }

        public override void Remove(AbstractNode node)
        {
            children.Remove(node);
            Size -= node.Size;
        }
    }
}
