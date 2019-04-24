using System;


namespace task
{
    class Program1
    {
        static void Main(string[] args)
        {
            Group group = new Group();
            Console.WriteLine("Qrup:");
            group.Name = Console.ReadLine();
            Student student = new Student();
            student.Group = group;
            Console.WriteLine("Ad:");
            student.Name = Console.ReadLine();
            Console.WriteLine("soyad:");
            student.Surname = Console.ReadLine();
            Console.WriteLine("Salam {0} {1}  {2}", student.Name, student.Surname, student.Group.Name);
            Console.ReadKey();
        }
    }
    class Group
    {
        public string Name { get; set; }
    }
    class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Group Group { get; set; }

    }

}