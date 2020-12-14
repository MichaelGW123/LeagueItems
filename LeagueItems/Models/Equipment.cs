using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeagueItems.Models
{
    public partial class Equipment
    {
        public Equipment()
        {
            CustomListEquipmentId1Navigation = new HashSet<CustomList>();
            CustomListEquipmentId2Navigation = new HashSet<CustomList>();
            CustomListEquipmentId3Navigation = new HashSet<CustomList>();
            CustomListEquipmentId4Navigation = new HashSet<CustomList>();
            CustomListEquipmentId5Navigation = new HashSet<CustomList>();
            CustomListEquipmentId6Navigation = new HashSet<CustomList>();
        }

        [Key]
        [Column("equipmentId")]
        public int EquipmentId { get; set; }
        [Required]
        [Column("name")]
        [StringLength(50)]
        public string Name { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("stats")]
        public string Stats { get; set; }
        [Column("cost")]
        public int Cost { get; set; }

        [InverseProperty(nameof(CustomList.EquipmentId1Navigation))]
        public virtual ICollection<CustomList> CustomListEquipmentId1Navigation { get; set; }
        [InverseProperty(nameof(CustomList.EquipmentId2Navigation))]
        public virtual ICollection<CustomList> CustomListEquipmentId2Navigation { get; set; }
        [InverseProperty(nameof(CustomList.EquipmentId3Navigation))]
        public virtual ICollection<CustomList> CustomListEquipmentId3Navigation { get; set; }
        [InverseProperty(nameof(CustomList.EquipmentId4Navigation))]
        public virtual ICollection<CustomList> CustomListEquipmentId4Navigation { get; set; }
        [InverseProperty(nameof(CustomList.EquipmentId5Navigation))]
        public virtual ICollection<CustomList> CustomListEquipmentId5Navigation { get; set; }
        [InverseProperty(nameof(CustomList.EquipmentId6Navigation))]
        public virtual ICollection<CustomList> CustomListEquipmentId6Navigation { get; set; }
    }
}
