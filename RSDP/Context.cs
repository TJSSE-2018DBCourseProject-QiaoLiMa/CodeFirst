using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Migrations;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations.History;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace RSDP
{

    public class OracleDbContext : DbContext
    {
        public DbSet<Account_Passenger> Account_Passenger { get; set; }
        public DbSet<Passenger> Passenger { get; set; }
        public DbSet<AccountList> AccountList { get; set; }
        public DbSet<CostTable> CostTable { get; set; }
        public DbSet<PassengerOrder> PassengerOrder { get; set; }
        public DbSet<ConstructionAndOverhaulInformation> ConstructionAndOverhaulInformation { get; set; }
        //public DbSet<FreightOrder> FreightOrder { get; set; }
        public DbSet<Loco> Loco { get; set; }
        //public DbSet<Packge> Packge { get; set; }
        //public DbSet<Price> Price { get; set; }
   
        public DbSet<Route> Route { get; set; }
        public DbSet<Station> Station { get; set; }
        public DbSet<Track> Track
       { get; set; }
        public DbSet<Train> Train{ get; set; }
        public DbSet<TrainNumber> TrainNumberTable { get; set; }
        public DbSet<Crew> Crew { get; set; }
        public DbSet<Train_TrainNumberTable> Train_TrainNumberTable { get; set; }
        public DbSet<Staff> Staff { get; set; }
        
      
        public DbSet<RealTimeTable> RealTime
        { get; set; }
        public DbSet<TimeTable> TimeTable { get; set; }
        //public DbSet<Transfer> Transfer { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.HasDefaultSchema("C##TESTUSER");
            //modelBuilder.Entity<Passenger>()
            //modelBuilder.Entity<Price>().Property(t => t.BasePriceOne)
                                          //.HasColumnName("BasePriceOne")
                                          //.HasPrecision(5, 2);

            //modelBuilder.Entity<Price>().Property(t => t.BasePriceTwo)
                                          //.HasColumnName("BasePriceTwo")
                                          //.HasPrecision(6, 2);
            //modelBuilder.Entity<Price>().Property(t => t.BasePriceOne).HasPrecision(5, 2);

            //modelBuilder.Entity<Price>().Property(t => t.BasePriceTwo).HasPrecision(6, 2);

            //modelBuilder.Entity<FreightOrder>().Property(t => t.OrderBill).HasPrecision(10, 2);

            //modelBuilder.Entity<Packge>().Property(t => t.Weight).HasPrecision(10, 3);

            //modelBuilder.Entity<Transfer>().HasKey(t => new { t.PackgeID, t.TrainID, t.TransferID, t.OrderID });//货运复合主键的

            //modelBuilder.Entity<Packge>().HasMany(x => x.Carriage).WithRequired(y => y.Packge);//这边是一对多的外码设定//货运



        }
    }
}