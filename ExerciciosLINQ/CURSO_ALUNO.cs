namespace ExerciciosLINQ
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CURSO_ALUNO
    {
        public int id { get; set; }

        public int idCurso { get; set; }

        public int idAluno { get; set; }

        public virtual ALUNO ALUNO { get; set; }

        public virtual CURSO CURSO { get; set; }
    }
}
