namespace StatePattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            DocumentContext doc = new DocumentContext();
            doc.Next(); // to reviewing
            doc.Next(); // to approved
            doc.Next(); // to published
            doc.Edit(); // try to edit
            doc.Review(); // try to review
            doc.Approve(); // try to approve
            doc.Publish(); // try to publish
        }
    }
}