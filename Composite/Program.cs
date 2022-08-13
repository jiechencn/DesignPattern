namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             folder3
                folder1
                    file1 ： size = 111
                folder2
                    file21 : size = 222
                    file22 : size = 555
             */
            AbstractNode file1 = new File(nameof(file1), 111);
            AbstractNode folder1 = new Folder(nameof(folder1));
            folder1.Add(file1);
            Console.WriteLine($"folder1=" + folder1.Size);


            AbstractNode file21 = new File(nameof(file21), 222);
            AbstractNode file22 = new File(nameof(file22), 555);
            AbstractNode folder2 = new Folder(nameof(folder2));
            folder2.Add(file21);
            folder2.Add(file22);
            Console.WriteLine($"folder2=" + folder2.Size);

            AbstractNode folder3 = new Folder(nameof(folder3));
            folder3.Add(folder1);
            folder3.Add(folder2);
            Console.WriteLine($"folder3=" + folder3.Size);
        }
    }
}
