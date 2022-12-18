using Visitor;

class Program
{
    public static void Main(string[] args)
    {

        FolderNode dir = new FolderNode("dir");
        FolderNode dir1 = new FolderNode("dir1");
        dir1.Add(new FileNode("file1", 111));
        FolderNode dir2 = new FolderNode("dir2");
        dir2.Add(new FileNode("file2", 222));
        FileNode file3 = new FileNode ("file3", 300);
        dir.Add(dir1);
        dir.Add(dir2);
        dir.Add(file3);

        INodeVisitor visitor = new NodeVisitor();

        dir.Accept(visitor);
        Console.WriteLine();

        dir1.Accept(visitor);
        Console.WriteLine();

        dir2.Accept(visitor);
        Console.WriteLine();

        file3.Accept(visitor);
    }
}