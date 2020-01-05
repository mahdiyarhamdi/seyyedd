namespace BDP.Model
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using System.Configuration;
    using Microsoft.Extensions.Configuration;

    public class Context : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["Context"].ConnectionString);
        }

        public virtual DbSet<ErrorLog> ErrorLogs { get; set; }
        public virtual DbSet<Glaser> Glasers { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<RequestLog> RequestLogs { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<State> States { get; set; }
       
    }
}
