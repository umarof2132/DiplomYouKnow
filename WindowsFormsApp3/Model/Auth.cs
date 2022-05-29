namespace WindowsFormsApp3.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Auth")]
    public partial class Auth
    {
        [Key]
        [StringLength(50)]
        public string Login { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string SecondName { get; set; }

        [StringLength(50)]
        public string Patronymic { get; set; }

        [Column(TypeName = "date")]
        public DateTime DataOfBirthday { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Photo { get; set; }

        [Required]
        [StringLength(50)]
        public string Role { get; set; }

        public virtual GeneralTable GeneralTable { get; set; }
    }
}
