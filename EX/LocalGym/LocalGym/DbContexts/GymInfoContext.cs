using LocalGym.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace LocalGym.DbContexts
{
    public class GymInfoContext : DbContext
    {
        public DbSet<Member> Members { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Session> Sessions { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=WSAMZN-FK6DHHFM;Database=LocalGym;ConnectRetryCount=0;User Id=sa;Password=Password@123;Encrypt=False;");
        //}

        public GymInfoContext(DbContextOptions<GymInfoContext> options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Member>()
                .HasData(
                new Member { Id = 1, FirstName = "Alice", LastName = "Johnson", Email = "alice.johnson@example.com", JoinDate = new DateOnly(2023, 1, 15) },
                new Member { Id = 2, FirstName = "Bob", LastName = "Smith", Email = "bob.smith@example.com", JoinDate = new DateOnly(2023, 2, 22) },
                new Member { Id = 3, FirstName = "Carol", LastName = "Davis", Email = "carol.davis@example.com", JoinDate = new DateOnly(2023, 3, 10) },
                new Member { Id = 4, FirstName = "Dave", LastName = "Wilson", Email = "dave.wilson@example.com", JoinDate = new DateOnly(2023, 4, 5) },
                new Member { Id = 5, FirstName = "Eve", LastName = "Brown", Email = "eve.brown@example.com", JoinDate = new DateOnly(2023, 5, 20) }
                );

            modelBuilder.Entity<Trainer>().HasData(
            new Trainer { TrainerId = 1, FirstName = "John", LastName = "Carter", Speciality = "Strength Training", FeePer30Minutes = 30, HireDate = new DateOnly(2022, 11, 1) },
            new Trainer { TrainerId = 2, FirstName = "Emma", LastName = "Green", Speciality = "Yoga", FeePer30Minutes = 25, HireDate = new DateOnly(2023, 1, 15) },
            new Trainer { TrainerId = 3, FirstName = "Michael", LastName = "Lee", Speciality = "Cardio", FeePer30Minutes = 35, HireDate = new DateOnly(2023, 3, 10) },
            new Trainer { TrainerId = 4, FirstName = "Sarah", LastName = "Martinez", Speciality = "Pilates", FeePer30Minutes = 28, HireDate = new DateOnly(2023, 4, 20) },
            new Trainer { TrainerId = 5, FirstName = "Chris", LastName = "Clark", Speciality = "Weightlifting", FeePer30Minutes = 32, HireDate = new DateOnly(2023, 6, 1) }
            );

            // Seeding data for Session table
            modelBuilder.Entity<Session>().HasData(
                new Session { SessionId = 1, CustomerId = 1, TrainerId = 2, SessionDate = new DateOnly(2024, 7, 15), Duration = new TimeOnly(45) },
                new Session { SessionId = 2, CustomerId = 2, TrainerId = 3, SessionDate = new DateOnly(2024, 7, 16), Duration = new TimeOnly(60) },
                new Session { SessionId = 3, CustomerId = 3, TrainerId = 1, SessionDate = new DateOnly(2024, 7, 17), Duration = new TimeOnly(30) },
                new Session { SessionId = 4, CustomerId = 4, TrainerId = 4, SessionDate = new DateOnly(2024, 7, 18), Duration = new TimeOnly(50) },
                new Session { SessionId = 5, CustomerId = 5, TrainerId = 5, SessionDate = new DateOnly(2024, 7, 19), Duration = new TimeOnly(40) }
            );
            base.OnModelCreating(modelBuilder);
        }
    }
}
