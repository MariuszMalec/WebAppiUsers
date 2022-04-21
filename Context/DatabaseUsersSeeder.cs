using Microsoft.EntityFrameworkCore;
using WebAppiUsers.Models;

namespace WebAppiUsers.Context
{
    public static class DatabaseUsersSeeder
    {
        private static List<User> Users = new List<User>()//TODO insert startowe dane do bazy
        {
            new User {Id = 1, FirstName = "Patryk", LastName="Szwermer", Sso = 222222221},
            new User {Id = 2, FirstName = "Przemyslaw", LastName="Sawicki", Sso = 222222222},
            new User {Id = 3, FirstName = "Marcin", LastName="Dabrowski", Sso = 222222223},
            new User {Id = 4, FirstName = "Piotr", LastName="Katny", Sso = 222222224},
            new User {Id = 5, FirstName = "Marcin", LastName="Dudzic", Sso = 222222225},
            new User {Id = 6, FirstName = "Maciej", LastName="Krakowiak", Sso = 222222226},
            new User {Id = 7, FirstName = "Mateusz", LastName="Cebula", Sso = 222222227},
            new User {Id = 8, FirstName = "Jakub", LastName="Nowikowski", Sso = 222222228},
            new User {Id = 9, FirstName = "Jan", LastName="Choma", Sso = 222222229},
            new User {Id = 10, FirstName = "Marcin", LastName="Przypek", Sso = 322222221},
            new User {Id = 11, FirstName = "Michal", LastName="Sosnowski", Sso = 422222221},
            new User {Id = 12, FirstName = "Maciej", LastName="Tyszka", Sso = 522222221}
        };

        public static List<User> GetAll()
        {
            return Users;
        }
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                GetAll()
                );
        }

    }
}
