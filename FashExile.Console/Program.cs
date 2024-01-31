using FashExile.Data;

namespace FashExile.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var db = new ShoppingDbContext();
            db.Database.EnsureCreated();
        }
    }
}