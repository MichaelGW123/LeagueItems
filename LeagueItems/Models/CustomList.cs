using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeagueItems.Models
{
    public partial class CustomList
    {
        [Key]
        [Column("listId")]
        public int ListId { get; set; }
        [Required]
        [Column("name")]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [Column("userId")]
        [StringLength(50)]
        public string UserId { get; set; }
        [Column("championId")]
        public int ChampionId { get; set; }
        [Column("equipmentId1")]
        public int? EquipmentId1 { get; set; }
        [Column("equipmentId2")]
        public int? EquipmentId2 { get; set; }
        [Column("equipmentId3")]
        public int? EquipmentId3 { get; set; }
        [Column("equipmentId4")]
        public int? EquipmentId4 { get; set; }
        [Column("equipmentId5")]
        public int? EquipmentId5 { get; set; }
        [Column("equipmentId6")]
        public int? EquipmentId6 { get; set; }

        [ForeignKey(nameof(ChampionId))]
        [InverseProperty("CustomList")]
        public virtual Champion Champion { get; set; }
        [ForeignKey(nameof(EquipmentId1))]
        [InverseProperty(nameof(Equipment.CustomListEquipmentId1Navigation))]
        public virtual Equipment EquipmentId1Navigation { get; set; }
        [ForeignKey(nameof(EquipmentId2))]
        [InverseProperty(nameof(Equipment.CustomListEquipmentId2Navigation))]
        public virtual Equipment EquipmentId2Navigation { get; set; }
        [ForeignKey(nameof(EquipmentId3))]
        [InverseProperty(nameof(Equipment.CustomListEquipmentId3Navigation))]
        public virtual Equipment EquipmentId3Navigation { get; set; }
        [ForeignKey(nameof(EquipmentId4))]
        [InverseProperty(nameof(Equipment.CustomListEquipmentId4Navigation))]
        public virtual Equipment EquipmentId4Navigation { get; set; }
        [ForeignKey(nameof(EquipmentId5))]
        [InverseProperty(nameof(Equipment.CustomListEquipmentId5Navigation))]
        public virtual Equipment EquipmentId5Navigation { get; set; }
        [ForeignKey(nameof(EquipmentId6))]
        [InverseProperty(nameof(Equipment.CustomListEquipmentId6Navigation))]
        public virtual Equipment EquipmentId6Navigation { get; set; }
    }
}
