namespace WindowsFormsApp3.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Zakaz")]
    public partial class Zakaz
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Zakaz()
        {
            GeneralTable = new HashSet<GeneralTable>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDZakaza { get; set; }

        [StringLength(50)]
        public string TitlePostavshika { get; set; }

        [StringLength(10)]
        public string Nakladnaya { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataOfDelivery { get; set; }

        [StringLength(10)]
        public string Price { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        [StringLength(50)]
        public string PhoneCourier { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GeneralTable> GeneralTable { get; set; }
    }
}
