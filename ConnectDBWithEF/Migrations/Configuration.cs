namespace ConnectDBWithEF.Migrations
{
    using ConnectDBWithEF.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ConnectDBWithEF.Models.EFContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ConnectDBWithEF.Models.EFContext context)
        {
            var Employees = new List<Employee>
            {
                new Employee{Name="Mohan",Email="Samuai@example.com", Contact="+25-258628"},
            };
            Employees.ForEach(s => context.Employees.Add(s));
            context.SaveChanges();
        }
    }
}
