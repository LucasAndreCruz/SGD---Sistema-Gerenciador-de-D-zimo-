using System;
using System.Collections.Generic;
using System.Text;

namespace SGD.ApplicationCore.Entity
{
   public class Pessoa
    {

        public Pessoa()
        {

        }


        public int PessoaId { get; set; }

        public string Nome { get; set; }

        public string CPF { get; set; }

        public string RG { get; set; }

        public string Email { get; set; }

    }
}
