namespace MoTo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Table1
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string BB { get; set; }

        [Required]
        [StringLength(20)]
        public string TB { get; set; }

        [Required]
        [StringLength(50)]
        public string BMI { get; set; }
    }
}
