namespace Visitor
{
    public interface IBehavior
    {
        public void Accept(INodeVisitor visitor);
        public IList<AbstractNode> Iterator();
    }
    public abstract class AbstractNode: IBehavior
    {
        public string Name { get; protected set; } = string.Empty;
        public int Size { get; protected set; } = default;

        public virtual void Add(AbstractNode node)
        {
        }

        public virtual void Remove(AbstractNode node)
        {
        }

        public abstract void Accept(INodeVisitor visitor);
        public abstract IList<AbstractNode> Iterator();
    }

    public class FileNode : AbstractNode
    {
        public FileNode(string name, int size)
        {
            Name = name;
            Size = size;
        }

        public override void Accept(INodeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override IList<AbstractNode> Iterator()
        {
            throw new NotImplementedException();
        }
    }

    public class FolderNode : AbstractNode
    {
        private IList<AbstractNode> children = new List<AbstractNode>();

        public FolderNode(string name)
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

        public override void Accept(INodeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override IList<AbstractNode> Iterator()
        {
            return children.ToList();
        }
    }
}
