using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeagueItems.Models
{
    public partial class Champion
    {
        public Champion()
        {
            CustomList = new HashSet<CustomList>();
        }

        [Key]
        [Column("championId")]
        public int ChampionId { get; set; }
        [Required]
        [Column("name")]
        [StringLength(20)]
        public string Name { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("attacktype")]
        [StringLength(10)]
        public string Attacktype { get; set; }
        [Column("damagetype")]
        [StringLength(10)]
        public string Damagetype { get; set; }

        [InverseProperty("Champion")]
        public virtual ICollection<CustomList> CustomList { get; set; }
    }
}
