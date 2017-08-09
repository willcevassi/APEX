namespace ExerciciosLINQ
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CURSO")]
    public partial class CURSO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CURSO()
        {
            CURSO_ALUNO = new HashSet<CURSO_ALUNO>();
        }

        [Key]
        public int idCurso { get; set; }

        public int idProfessor { get; set; }

        [Required]
        [StringLength(30)]
        public string nomeCurso { get; set; }

        public int cargaHoraria { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CURSO_ALUNO> CURSO_ALUNO { get; set; }

        public virtual PROFESSOR PROFESSOR { get; set; }
    }
}
