namespace ExerciciosLINQ
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PROFESSOR")]
    public partial class PROFESSOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROFESSOR()
        {
            CURSO = new HashSet<CURSO>();
        }

        [Key]
        public int idProfessor { get; set; }

        public int idPessoa { get; set; }

        public int tempoExperiencia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CURSO> CURSO { get; set; }

        public virtual PESSOA PESSOA { get; set; }
    }
}
