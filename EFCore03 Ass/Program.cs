using EFCore03_Ass.Contexts;
using EFCore03_Ass.Models;

namespace EFCore03_Ass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using AppDbContext context = new AppDbContext();
            var Branch = new Branch() { Name = "Yousseg", Code = "1", Address = "El Nozha", PhoneNumber = "01111111" };
            var Manager = new Manager() { FullName = "Ali" , Email = "Alia@gmail.com" , PhoneNumber = "0222222222", Branch=Branch, HireDate = DateTime.Now };

            context.Branches.Add(Branch);
            context.Managers.Add(Manager);
            context.SaveChanges();
        }
    }
}
