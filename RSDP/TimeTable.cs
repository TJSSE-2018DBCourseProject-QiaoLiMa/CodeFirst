
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

    public enum Condition
    {
        OnRoad = 1,
        Arrived = 2,
        Error = 3,
    }

    [Table("TimeTable")]
    public class TimeTable
    {
        [Required]
        [Column(TypeName = "DATE")]
        public DateTime Date { get; set; }



        [Required]
        [Key, Column(Order = 1, TypeName = "VARCHAR2")]
        [StringLength(10)]
        [ForeignKey("trainNumber")]
        public string TrainNumber { get; set; }      //外码
        public TrainNumber trainNumber { get; set; }

        [Column(TypeName = "int")]
        [Required]
        public int StationOrder { get; set; }


        [Required]
        [Key, Column(Order = 2, TypeName = "DATE")]
        public DateTime DepartuerDate { get; set; }

        [Required]
        [Key, Column(Order = 3, TypeName = "VARCHAR2")]
        [StringLength(5)]
        [ForeignKey("Station")]
        public string StationID { get; set; }      //外码
        public Station Station { get; set; }



        [Column(TypeName = "int")]
        [Required]
        public int PlatformNum { get; set; }

        [Column(TypeName = "date")]
        public DateTime ArriveTime { get; set; }

        [Column(TypeName = "date")]
        public DateTime LeaveTime { get; set; }

        [Column(TypeName = "date")]
        public DateTime Duration { get; set; }

      
        [Column(TypeName = "int")]
        [Required]
        public Condition condition { get; set; }

        [Column(TypeName = "int")]
        [Required]
        public int RemainingSeatsNumber { get; set; }


        [Required]
        [Column(TypeName = "VARCHAR2")]
        [StringLength(20)]
        public string CrewID { get; set; }      //外码
        public Crew Crew { get; set; }
        
    }
}
