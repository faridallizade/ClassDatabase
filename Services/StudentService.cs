using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using GroupDatabase.DAL;
using GroupDatabase.Models;

namespace GroupDatabase.Services
{
    internal class StudentService
    {
        AppDbContext Db = new AppDbContext();
        public void Add(Student student)
        {
            Db.Add(student);
            Db.SaveChanges();
        }
        public void Update(Student student)
        {
            var oldStudent = Db.Students.Find(student.Id);
            oldStudent = student;
            Db.Students.Update(oldStudent);
            Db.SaveChanges();
        }
        public void Delete(int Id)
        {
            var removedStudent = Db.Students.Find(Id);
            Db.Students.Remove(removedStudent);
            Db.SaveChanges();
        }
        public void Read()
        {
            List<Student> readStudents = new List<Student>();
            readStudents = Db.Students.ToList();
            foreach (var item in readStudents)
            {
                Console.WriteLine($"Id : {item.Id}  Name : {item.Name} GroupId : {item.GroupId}");
            }
        }
    }
}
