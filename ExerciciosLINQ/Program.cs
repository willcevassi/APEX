
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            ApexDB2 apexDB2Context = new ApexDB2();

            List<ALUNO> alunos = apexDB2Context.ALUNO.ToList();

            var alunosCSHARP = (from aluno in apexDB2Context.ALUNO
                                    join cursoAluno in apexDB2Context.CURSO_ALUNO
                                    on aluno.idAluno equals cursoAluno.idAluno
                                where cursoAluno.CURSO.idCurso.Equals(1)
                                select aluno).ToList();

         var alunosAndroid = (from aluno in apexDB2Context.ALUNO
                              join cursoAluno in apexDB2Context.CURSO_ALUNO
                              on aluno.idAluno equals cursoAluno.idAluno
                              where cursoAluno.CURSO.idCurso.Equals(4)
                              select aluno).ToList();

            var cursosProfUM = (from c in apexDB2Context.CURSO
                                where c.PROFESSOR.idProfessor.Equals(1)
                                select c).ToList();

            var cursosOrdenados = (from c in apexDB2Context.CURSO
                                   orderby c.nomeCurso
                                   select c).ToList();

            var alunosOrdenadosPeloCargo = (from a in apexDB2Context.ALUNO
                                            orderby a.cargo
                                            select a).ToList();


            //var query =
            //    from post in database.Posts
            //    join meta in database.Post_Metas on post.ID equals meta.Post_ID
            //    where post.ID == id


            var alunosComCertificado =
                (from aluno in apexDB2Context.ALUNO
                 join certificado in apexDB2Context.CERTIFICADO on aluno.idAluno equals certificado.idAluno
                 join curso in apexDB2Context.CURSO on certificado.idCurso equals curso.idCurso
                 select new {
                     aluno = aluno.PESSOA.nomePessoa,
                     data = certificado.dataConclusao,
                     curso = curso.nomeCurso                     
                 }).ToList();


            CURSO curso2 = new CURSO();
            curso2.PROFESSOR.idProfessor = 2;
            curso2.cargaHoraria = 48;
            apexDB2Context.CURSO.Add(curso2);
            apexDB2Context.SaveChanges();

            ALUNO novoAluno = new ALUNO();
            novoAluno.cargo = "Teste de Inclusão";
            novoAluno.PESSOA = new PESSOA {
                nomePessoa = "Willian Cevassi",
                endereco = "R. Delminda Silveira",
                dataNascimento = new DateTime(1982, 06, 15)
            };

            apexDB2Context.ALUNO.Add(novoAluno);
            apexDB2Context.SaveChanges();

        }
    }
}
