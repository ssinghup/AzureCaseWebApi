using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebApi.Models
{
    public partial class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext()
            : base("name=ApplicationDBContext")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<BOOKED_TICKET> BOOKED_TICKET { get; set; }
        public virtual DbSet<CITY> CITies { get; set; }
        public virtual DbSet<Class1> Class1 { get; set; }
        public virtual DbSet<FLIGHT> FLIGHTs { get; set; }
        public virtual DbSet<FLIGHT_COMPANY> FLIGHT_COMPANY { get; set; }
        public virtual DbSet<FLIGHT_TIME> FLIGHT_TIME { get; set; }
        public virtual DbSet<LOGIN_USER> LOGIN_USER { get; set; }
        public virtual DbSet<USER_ROLE> USER_ROLE { get; set; }
        public virtual DbSet<VW_FLIGHT_TIMESLOT> VW_FLIGHT_TIMESLOT { get; set; }
        public virtual DbSet<VW_TICKET_BOOKED> VW_TICKET_BOOKED { get; set; }
        public virtual DbSet<database_firewall_rules> database_firewall_rules { get; set; }
        public virtual DbSet<ipv6_database_firewall_rules> ipv6_database_firewall_rules { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BOOKED_TICKET>()
                .Property(e => e.PERSON_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<BOOKED_TICKET>()
                .Property(e => e.PERSON_EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<BOOKED_TICKET>()
                .Property(e => e.PERSON_MOBILE)
                .IsUnicode(false);

            modelBuilder.Entity<CITY>()
                .Property(e => e.CITYCODE)
                .IsUnicode(false);

            modelBuilder.Entity<CITY>()
                .Property(e => e.CITY_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<FLIGHT>()
                .Property(e => e.FLIGHT_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<FLIGHT>()
                .Property(e => e.FLIGHT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<FLIGHT_COMPANY>()
                .Property(e => e.COMPANY_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<FLIGHT_COMPANY>()
                .HasMany(e => e.FLIGHTs)
                .WithOptional(e => e.FLIGHT_COMPANY)
                .HasForeignKey(e => e.COMPANY_ID);

            modelBuilder.Entity<FLIGHT_TIME>()
                .Property(e => e.Departure)
                .IsUnicode(false);

            modelBuilder.Entity<FLIGHT_TIME>()
                .Property(e => e.Arrival)
                .IsUnicode(false);

            modelBuilder.Entity<FLIGHT_TIME>()
                .Property(e => e.Duration)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_USER>()
                .Property(e => e.USERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_USER>()
                .Property(e => e.USER_PASSWORD)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_USER>()
                .Property(e => e.FNAME)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_USER>()
                .Property(e => e.LNAME)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_USER>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_USER>()
                .HasMany(e => e.USER_ROLE)
                .WithRequired(e => e.LOGIN_USER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<USER_ROLE>()
                .Property(e => e.ROLE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<VW_FLIGHT_TIMESLOT>()
                .Property(e => e.FLIGHT_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<VW_FLIGHT_TIMESLOT>()
                .Property(e => e.FLIGHT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<VW_FLIGHT_TIMESLOT>()
                .Property(e => e.COMPANY_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<VW_FLIGHT_TIMESLOT>()
                .Property(e => e.Departure)
                .IsUnicode(false);

            modelBuilder.Entity<VW_FLIGHT_TIMESLOT>()
                .Property(e => e.Arrival)
                .IsUnicode(false);

            modelBuilder.Entity<VW_FLIGHT_TIMESLOT>()
                .Property(e => e.Duration)
                .IsUnicode(false);

            modelBuilder.Entity<VW_FLIGHT_TIMESLOT>()
                .Property(e => e.FROM_CITYNAME)
                .IsUnicode(false);

            modelBuilder.Entity<VW_FLIGHT_TIMESLOT>()
                .Property(e => e.TO_CITYNAME)
                .IsUnicode(false);

            modelBuilder.Entity<VW_TICKET_BOOKED>()
                .Property(e => e.FLIGHT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<VW_TICKET_BOOKED>()
                .Property(e => e.FLIGHT_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<VW_TICKET_BOOKED>()
                .Property(e => e.COMPANY_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<VW_TICKET_BOOKED>()
                .Property(e => e.BOOKING_DATE)
                .IsUnicode(false);

            modelBuilder.Entity<VW_TICKET_BOOKED>()
                .Property(e => e.PERSON_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<VW_TICKET_BOOKED>()
                .Property(e => e.PERSON_EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<VW_TICKET_BOOKED>()
                .Property(e => e.PERSON_MOBILE)
                .IsUnicode(false);

            modelBuilder.Entity<VW_TICKET_BOOKED>()
                .Property(e => e.FROM_CITYNAME)
                .IsUnicode(false);

            modelBuilder.Entity<VW_TICKET_BOOKED>()
                .Property(e => e.TO_CITYNAME)
                .IsUnicode(false);

            modelBuilder.Entity<VW_TICKET_BOOKED>()
                .Property(e => e.Departure)
                .IsUnicode(false);

            modelBuilder.Entity<VW_TICKET_BOOKED>()
                .Property(e => e.Arrival)
                .IsUnicode(false);

            modelBuilder.Entity<VW_TICKET_BOOKED>()
                .Property(e => e.Duration)
                .IsUnicode(false);

            modelBuilder.Entity<database_firewall_rules>()
                .Property(e => e.start_ip_address)
                .IsUnicode(false);

            modelBuilder.Entity<database_firewall_rules>()
                .Property(e => e.end_ip_address)
                .IsUnicode(false);

            modelBuilder.Entity<ipv6_database_firewall_rules>()
                .Property(e => e.start_ipv6_address)
                .IsUnicode(false);

            modelBuilder.Entity<ipv6_database_firewall_rules>()
                .Property(e => e.end_ipv6_address)
                .IsUnicode(false);
        }
    }
}
