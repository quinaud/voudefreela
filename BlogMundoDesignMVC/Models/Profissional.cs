namespace BlogMundoDesignMVC.Models
{
    public class Profissional
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Idade { get; set; }
        public int Sexo { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public bool PossuiExperiencia { get; set; }

        //public string TipoExperiencia { get; set; }

        public bool ExperienciaGarcom { get; set; }
        public bool ExperienciaBarman { get; set; }
        public bool ExperienciaSeguranca { get; set; }
        public bool ExperienciaDj { get; set; }
        public bool ExperienciaCopeiro { get; set; }
        public bool ExperienciaFritadeira { get; set; }
        public bool ExperienciaHostness { get; set; }
        public bool ExperienciaMusico { get; set; }
        public bool ExperienciaCaixa { get; set; }
        public bool ExperienciaPromotorEventos { get; set; }
        public bool ExperienciaAnimadorFestas { get; set; }
        public bool ExperienciaManobrista { get; set; }
        public bool ExperienciaSevicosGerais { get; set; }
        public bool ExperienciaFotografo { get; set; }

        public string LocalExperiencia { get; set; }

        public bool EfetuouPagamento { get; set; }
		public bool FreeMode { get; set; }


    }
}