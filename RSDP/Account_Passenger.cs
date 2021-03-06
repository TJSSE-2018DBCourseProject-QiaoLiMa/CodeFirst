﻿using System;
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
    
    [Table("Account_PassengerTable")]
    public class Account_Passenger
    {
        [Key]
        
        [Column(TypeName = "VARCHAR2")]
        [StringLength(30)]
        public string AccountID { get; set; }

        
        [Column(TypeName = "CHAR")]
        [StringLength(18)]
        public string PassengerID { get; set; }

        [ForeignKey("AccountID")]
        public AccountList AccountList { get; set; }

        [ForeignKey("PassengerID")]
        public Passenger Passenger { get; set; }
    }
    
}
