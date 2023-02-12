using Visitor;

class Program
{
    public static void Main(string[] args)
    {
        Student stu1 = new Student() { Name = "Tom" };
        Student stu2 = new Student() { Name = "Jerry" };
        AbstractPeople teacher1 = new Teacher() { Name = "Mr.Chen" };
        AbstractPeople teacher2 = new Teacher() { Name = "Mr.Wang" };

        School school = new School();
        school.Add(stu1);
        school.Add(stu2);
        school.Add(teacher1);
        school.Add(teacher2);

        IVisitor doctor = new Doctor();
        IVisitor examiner = new Examiner();

        school.InviteVisitor(doctor);
        school.InviteVisitor(examiner);

        Console.WriteLine($"{stu1.Name} score is {stu1.Score}");
        Console.WriteLine($"{stu2.Name} score is {stu2.Score}");

    }
}