namespace BlogMundoDesignMVC.Models
{
    public class Profissional
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Idade { get; set; }
        public int Sexo { get; set; }

        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public bool PossuiExperiencia { get; set; }

        public string TipoExperiencia { get; set; }

        public string LocalExperiencia { get; set; }

        public bool EfetuouPagamento { get; set; }


    }
}