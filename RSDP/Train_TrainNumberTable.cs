
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


[Table("Train_TrainNumberTable")]
    public class Train_TrainNumberTable
    {


       
        [Required]
        [Key, Column(Order = 1, TypeName = "VARCHAR2")]
        [StringLength(10)]
        [ForeignKey("trainNumber")]
        public string TrainNumber { get; set; }
        public TrainNumber trainNumber { get; set; }

       
        [Column(TypeName = "VARCHAR2")]
        [Required]
        [StringLength(10)]
        [ForeignKey("Train")]
        public string physicalTrainNumber { get; set; }
        public Train Train { get; set; }


        [Key, Column(Order = 2, TypeName = "DATE")]
        [Required]
        public DateTime DATE { get; set; }


     

}
}
