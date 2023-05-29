using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppAprendizado
{
    internal class PessoaAluno
    {
        public Pessoa Pessoa { get; set; }
        public Aluno Aluno { get; set; }

        public PessoaAluno(Pessoa pessoa)
        {
            Pessoa = pessoa;
        }
    }
}
