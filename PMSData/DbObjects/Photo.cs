namespace PMSData.DbObjects
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Photo")]
    public partial class Photo
    {
        public int ID { get; set; }

        public int PropertyID { get; set; }

        [Required]
        [StringLength(50)]
        public string PhotoTitle { get; set; }

        public string AltText { get; set; }

        public string Caption { get; set; }

        [Required]
        public string UploadedFrom { get; set; }

        public string UploadedTo { get; set; }

        public double? Size { get; set; }

        public string Extension { get; set; }

        public DateTime UploadedOn { get; set; }

        public DateTime? LastEdit { get; set; }

        public virtual Property Property { get; set; }
    }
}
