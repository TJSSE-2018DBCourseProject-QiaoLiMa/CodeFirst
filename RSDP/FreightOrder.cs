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
/// <summary>
/// 货运
/// </summary>
namespace RSDP
{
    [Table("FreightOrderTable")]
    public class FreightOrder
    {

        /// <summary>
        ///  [Key]
        /// [Column(TypeName = "VARCHAR2")]
        ///  [Column(TypeName = "int")]
        ///   [Required]
        /// </summary>
        /// 
        [Key]
        [Column(TypeName = "VARCHAR2")]
        [StringLength(20)]
        public string OrderID { get; set; }

        [Required, Column(TypeName = "VARCHAR2")]
        [StringLength(20)]
        public string OrderName { get; set; }

        [Required, Column(TypeName = "CHAR")]
        public string SenderName { get; set; }

        [Required, Column(TypeName = "VARCHAR2")]
        [StringLength(20)]
        public string SenderID { get; set; }

        [Required, Column(TypeName = "VARCHAR2")]
        [StringLength(20)]
        public string SenderPhoneNumber { get; set; }

        [Required, Column(TypeName = "VARCHAR2")]
        [StringLength(20)]
        public string ReceiverName { get; set; }

        [Required, Column(TypeName = "VARCHAR2")]
        [StringLength(20)]
        public string ReceiverPhoneNumber { get; set; }

        [Required, Column(TypeName = "VARCHAR2")]
        [StringLength(20)]
        public string StartStation { get; set; }

        [Required, Column(TypeName = "VARCHAR2")]
        [StringLength(20)]
        public string EndStation { get; set; }

        [Required, Column(TypeName = "DATE")]
        public DateTime CreateDate { get; set; }//日期 可能需要操作

        [Column(TypeName = "DATE")]
        public DateTime DueDate { get; set; }

        [ForeignKey("Transfer")]
        [Column(TypeName = "VARCHAR2")]
        [StringLength(20)]
        public string TransferID { get; set; }//外码

        [ForeignKey("Packge")]
        [Column(TypeName = "VARCHAR2")]
        [StringLength(20)]
        public string PackgeID { get; set; }//外码



        [Column(TypeName = "number")]
        public decimal OrderBill { get; set; }

        [Required, Column(TypeName = "INT")]
        public int OrderCapacity { get; set; }

        [Required, Column(TypeName = "INT")]
        public int CarriageNumber { get; set; }


    }
}
