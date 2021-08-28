namespace DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Estudientes
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Apellido { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Seccion { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string Encargado { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string Padre_o_Madre { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string Falta { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string Promocion { get; set; }
    }
}
