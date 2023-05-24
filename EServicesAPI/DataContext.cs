using EServicesAPI.Models;
using Microsoft.EntityFrameworkCore;
using Shared;

namespace EServicesAPI
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EServicesDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var users = new List<User>()
            {
                new User
                {
                    UserId = 1,
                    Username = "Ahmed_50",
                    Name = "Ahmed Ali Omer Yassir",
                    PasswordHash = Base64Converter.Base64Encode("Ahmed@123"),
                    Email = "ahmed@email.com",
                    PhoneNumber = "+971112345667",
                    UserType = UserType.Customer
                },
                new User
                {
                    UserId = 2,
                    Username = "Ali_51",
                    Name = "Ali Omer Yassir Ahmed",
                    PasswordHash = Base64Converter.Base64Encode("Ali@123"),
                    Email = "ali@email.com",
                    PhoneNumber = "+971112345667",
                    UserType = UserType.Customer
                },
                new User
                {
                    UserId = 3,
                    Username = "Omer_52",
                    Name = "Omer Yassir Ahmed Ali",
                    PasswordHash = Base64Converter.Base64Encode("Omer@123"),
                    Email = "omer@email.com",
                    PhoneNumber = "+971112345667",
                    UserType = UserType.Customer
                },
                new User
                {
                    UserId = 4,
                    Username = "Yassir_53",
                    Name = "Yassir Ahmed Ali Omer",
                    PasswordHash = Base64Converter.Base64Encode("Yassir@123"),
                    Email = "yassir@email.com",
                    PhoneNumber = "+971112345667",
                    UserType = UserType.Customer
                },
                new User
                {
                    UserId = 5,
                    Username = "Rami_90",
                    Name = "Rami Ali Ammar",
                    PasswordHash = Base64Converter.Base64Encode("Rami@123"),
                    Email = "rami@email.com",
                    PhoneNumber = "+971112345667",
                    UserType = UserType.Admin
                },
                new User
                {
                    UserId = 6,
                    Username = "Hussam_91",
                    Name = "Hussam Ali Ammar",
                    PasswordHash = Base64Converter.Base64Encode("Hussam@123"),
                    Email = "hussam@email.com",
                    PhoneNumber = "+971112345667",
                    UserType = UserType.Admin
                },
            };

            modelBuilder.Entity<User>().HasData(users);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }
    }
}
