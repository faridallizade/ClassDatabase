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
    internal class GroupService
    {
        AppDbContext Db = new AppDbContext();
        public void Add(Group group)
        {
            Db.Add(group);
            Db.SaveChanges();
        }

        public void Update(Group group)
        {
            var oldGroup = Db.Groups.Find(group.Id);
            oldGroup = group;
            Db.Groups.Update(oldGroup);
            Db.SaveChanges();
        }
        public void Delete(int Id)
        {
            var removedGroup = Db.Groups.Find(Id);
            Db.Groups.Remove(removedGroup);
            Db.SaveChanges();
        }
        public void Read()
        {
            List<Group> readGroup = new List<Group>();
            var readGroups = Db.Groups.ToList();
            foreach (var item in readGroups)
            {
                Console.WriteLine($"Id : {item.Id}  Name : {item.Name}");
            }
        }
    }
    
}
