using ChallengeTest.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeTest.Infrastructure.Context
{
    public class ChallengeTestContext : DbContext
    {
        public ChallengeTestContext(DbContextOptions<ChallengeTestContext> options)
            : base(options)
        { }

        public virtual DbSet<Employee> Persons { get; set; }
        public virtual DbSet<TimeSheet> TimeSheets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        //    DateTime currentDateTime = DateTime.Now;
        //    List<Employee> employees = new List<Employee>()
        //    {
        //         new Employee()
        //            {
        //                EmployeeId = 1,
        //                FirstName = "Kevin",
        //                LastName = "Sejin",
        //                Age = 28,
        //                Email = "kevinricar24@test.com"
        //            },
        //            new Employee()
        //            {
        //                EmployeeId = 2,
        //                FirstName = "Dario",
        //                LastName = "Ricardo",
        //                Age = 3,
        //                Email = "kevinricar241@test.com"
        //            }
        //    };
        //    modelBuilder.Entity<Employee>().HasData(employees);
        //    modelBuilder.Entity<TimeSheet>().HasData(
        //            new TimeSheet()
        //            {
        //                TimesheetId = 1,
        //                DateWorked = currentDateTime,
        //                HoursWorked = 10,
        //                Employee = employees[0]
        //            },
        //            new TimeSheet()
        //            {
        //                TimesheetId = 2,
        //                DateWorked = currentDateTime,
        //                HoursWorked = 6,
        //                Employee = employees[1]
        //            }
        //        );
        }
    }
}
