using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppAprendizado
{
    internal class Aluno//criando classe aluno
    {
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public string CodigoCurso { get; set; }
        public string NomeCurso { get; set; }

        public Aluno(string nome, string cpf, string cidade, string rg, string telfone, string matricula, string codigoCurso, string nomeCurso)
        {
            Nome = nome;
            Matricula = matricula;
            CodigoCurso = codigoCurso;
            NomeCurso = nomeCurso;
        }
    }
}
