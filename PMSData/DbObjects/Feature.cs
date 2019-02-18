namespace PMSData.DbObjects
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Feature")]
    public partial class Feature
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        public string ImageIcon { get; set; }

        public double? ImageSize { get; set; }

        [Required]
        [StringLength(250)]
        public string Description { get; set; }

        public DateTime? LastEdit { get; set; }
    }
}
