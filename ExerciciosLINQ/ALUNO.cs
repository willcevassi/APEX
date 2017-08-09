namespace ExerciciosLINQ
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ALUNO")]
    public partial class ALUNO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ALUNO()
        {
            CURSO_ALUNO = new HashSet<CURSO_ALUNO>();
        }

        [Key]
        public int idAluno { get; set; }

        public int idPessoa { get; set; }

        [StringLength(50)]
        public string cargo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CURSO_ALUNO> CURSO_ALUNO { get; set; }

        public virtual PESSOA PESSOA { get; set; }
    }
}
