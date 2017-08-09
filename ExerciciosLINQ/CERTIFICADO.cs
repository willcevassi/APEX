namespace ExerciciosLINQ
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CERTIFICADO")]
    public partial class CERTIFICADO
    {
        public int id { get; set; }

        public int idAluno { get; set; }

        public int idCurso { get; set; }

        public DateTime dataConclusao { get; set; }
    }
}
