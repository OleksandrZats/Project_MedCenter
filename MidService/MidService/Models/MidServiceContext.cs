using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MidService.Models
{
	public class MidServiceContext : DbContext
	{
		public DbSet<User> Users { get; set; }
		public DbSet<Service> Services { get; set; }
		public DbSet<Specialty> Specialties { get; set; }
		public DbSet<Doctor> Doctors { get; set; }
		public DbSet<Order> Orders { get; set; }

		public MidServiceContext()
		{
			Database.EnsureCreated();
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=newdb;Trusted_Connection=True;");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<User>().HasData(
				new User[]
				{
					new User() { UserId = 1,FIO = "Петров Петр Петрович", TNumber = "0501234567", Email = "user1@user.com", Password = "admin", Gender="Male", Role = 0 }
				});
			modelBuilder.Entity<Service>().HasData(
				new Service[]
				{
					new Service() {SeviceId = 1, Name = "Осмотр", Description = "Будет сделан осмотр", Price = 100 },
					new Service() {SeviceId = 2, Name = "Масаж", Description = "Будет сделан масаж", Price = 200},
					new Service() {SeviceId = 3, Name = "Укол", Description = "Будет сделан укол", Price = 150 }
				});
			modelBuilder.Entity<Specialty>().HasData(
				new Specialty[] 
				{
					new Specialty() {SpecialtyId = 1, Name = "Невропатолог", Description = "Невропатолог" },
					new Specialty() {SpecialtyId = 2, Name = "Офтальмолог", Description = "Офтальмолог" }
				});
			modelBuilder.Entity<Doctor>().HasData(
				new Doctor[] 
				{
					new Doctor() {DoctorId = 1, FIO = "Дашкевич Александр Юрьевич", TNumber = "0967156979", Status = "PHD", SpecialtyId = 2 },
					new Doctor() {DoctorId = 2, FIO = "Удзумаки Наруто Минатович", TNumber = "0507027600", Status = "Hokage", SpecialtyId = 1 }
				});
		}
	}
}
