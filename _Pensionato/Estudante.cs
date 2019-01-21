using System;

namespace _Pensionato
{
    class Estudante
    {
        public string nome { get; set; }
        public string email { get; set; }
        public int quarto { get; set; }

        public Estudante(string nome, string email, int quarto)
        {
            this.nome = nome;
            this.email = email;
            this.quarto = quarto;
        }

        public override string ToString()
        {
            return quarto + ": " +
                nome + ", " + email;
        }


    }
}
