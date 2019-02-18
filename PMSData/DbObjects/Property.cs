namespace PMSData.DbObjects
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Property")]
    public partial class Property
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Property()
        {
            Photos = new HashSet<Photo>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(128)]
        public string AgentID { get; set; }

        public int AddressID { get; set; }

        public int OfTypeID { get; set; }

        public int OfSubType { get; set; }

        [Required]
        [StringLength(120)]
        public string Title { get; set; }

        [Required]
        [StringLength(120)]
        public string Seller { get; set; }

        [Required]
        [StringLength(120)]
        public string Locality { get; set; }

        public double? CoveredAreaMeasurement { get; set; }

        public int? CoveredAreaUnits { get; set; }

        public int? Condition { get; set; }

        public int? Furnished { get; set; }

        public int? Stories { get; set; }

        public int? FloorNo { get; set; }

        public int? Flooring { get; set; }

        public int? Baths { get; set; }

        public int? Kitchens { get; set; }

        public int? DrawingRooms { get; set; }

        public int? DiningRooms { get; set; }

        public int? LivingRooms { get; set; }

        public int? NumberOfRooms { get; set; }

        public int? StoreRooms { get; set; }

        public int? ServantQuarters { get; set; }

        public int? Lawn { get; set; }

        public int? CarSpaces { get; set; }

        public DateTime? Build { get; set; }

        public double AreaMeasurement { get; set; }

        public int AreaUnits { get; set; }

        public double AreaDiLength { get; set; }

        public double AreaDiWidth { get; set; }

        public int Price { get; set; }

        public int For { get; set; }

        public int AllowBidding { get; set; }

        public int Availability { get; set; }

        public int? Views { get; set; }

        public int? Status { get; set; }

        public int? Discount { get; set; }

        public int? Featured { get; set; }

        public int? Flags { get; set; }

        public DateTime PublishOn { get; set; }

        public DateTime? LastEdit { get; set; }

        public virtual Address Address { get; set; }

        public virtual PropertyType OfType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Photo> Photos { get; set; }
    }
}
