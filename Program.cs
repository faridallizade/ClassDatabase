using GroupDatabase.Models;
using GroupDatabase.Services;

namespace GroupDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group()
            {
                Name = "TK_91"
            };
            Group group1 = new Group()
            {
                Name = "TK_92"
            };
            GroupService gservice = new GroupService();
            gservice.Add(group);
            gservice.Add(group1);

            Student student = new Student()
            {
                Name = "Farid",
                GroupId = 1
            };
            Student student1 = new Student()
            {
                Name = "Ceyhun",
                GroupId = 2
            };
            StudentService sservice = new StudentService();
            sservice.Add(student);
            sservice.Add(student1);


        }
    }
}