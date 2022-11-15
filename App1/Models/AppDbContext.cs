using Microsoft.EntityFrameworkCore;

namespace App1.Models
{
    class AppDbContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }
        public string DbPath { get; set; }
        public AppDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "characters.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character>().HasData(
                new Character()
                {
                    ID = 1,
                    Name = "Geralt",
                    Sex = "Male",
                    Age = 112,
                    Race = "Witcher"
                },

                new Character()
                {
                    ID = 2,
                    Name = "Yennefer",
                    Sex = "Female",
                    Age = 85,
                    Race = "Human"
                },

                new Character()
                {
                    ID = 3,
                    Name = "Zoltan Chivay",
                    Sex = "Male",
                    Age = 62,
                    Race = "Dwarf"
                }
            );
        }

    }
}
