namespace WindowsFormsApp3.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GeneralTable")]
    public partial class GeneralTable
    {
        [Key]
        [StringLength(50)]
        public string Login { get; set; }

        public int IDPostavshika { get; set; }

        public int IDZakaza { get; set; }

        public int ID_Tovara { get; set; }

        public virtual Auth Auth { get; set; }

        public virtual Postavshiki Postavshiki { get; set; }

        public virtual Sklad Sklad { get; set; }

        public virtual Zakaz Zakaz { get; set; }
    }
}
