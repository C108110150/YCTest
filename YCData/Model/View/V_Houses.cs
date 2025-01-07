using PSTFrame.Data.Dapper;
using System;
//using PSTFrame.Data.Schema;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YCData.Model.View
{
    [Table("V_Houses")]
    public class V_Houses
    {
        [Key]
        [Column("SerId")]
        [DisplayName("SerId")]
        public int SerId { get; set; }

        [Column("HouseName")]
        [DisplayName("HouseName")]
        public string HouseName { get; set; }

        [Column("City")]
        [DisplayName("City")]
        public string City { get; set; }

        [Column("Area")]
        [DisplayName("Area")]
        public string Area { get; set; }

        [Column("Address")]
        [DisplayName("Address")]
        public string Address { get; set; }

        [Column("Phone")]
        [DisplayName("Phone")]
        public string Phone { get; set; }

        [Column("InsertDateTime")]
        [DisplayName("InsertDateTime")]
        public DateTime? InsertDateTime { get; set; }

        [Column("InsertUnitId")]
        [DisplayName("InsertUnitId")]
        public int InsertUnitId { get; set; }

        [Column("InsertUserId")]
        [DisplayName("InsertUserId")]
        public int InsertUserId { get; set; }

        [Column("UpdateDateTime")]
        [DisplayName("UpdateDateTime")]
        public DateTime? UpdateDateTime { get; set; }

        [Column("UpdateUnitId")]
        [DisplayName("UpdateUnitId")]
        public int UpdateUnitId { get; set; }

        [Column("UpdateUserId")]
        [DisplayName("UpdateUserId")]
        public int UpdateUserId { get; set; }

        [Column("IsDelete")]
        [DisplayName("IsDelete")]
        [Required]
        public bool IsDelete { get; set; }
    }
}
