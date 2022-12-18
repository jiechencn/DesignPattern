using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Visitor
{
    public interface INodeVisitor
    {
        public void Visit(FolderNode folder);

        public void Visit(FileNode file);
    }


    public class NodeVisitor : INodeVisitor
    {
        public void Visit(FolderNode folder)
        {
            Console.WriteLine($"{folder.Name} : {folder.Size}");
            foreach (var node in folder.Iterator())
            {
                node.Accept(this);
            }
        }

        public void Visit(FileNode file)
        {
            Console.WriteLine($"{file.Name} : {file.Size}");
        }
    }
}
