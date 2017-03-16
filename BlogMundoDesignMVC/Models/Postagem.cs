namespace BlogMundoDesignMVC.Models
{
    public class Postagem
    {
        public string IdPostagem { get; set; }
        public string ConteudoPrimeiroNivelPostagem { get; set; }
        public string ConteudoSegundoNivelPostagem { get; set; }
        public string DataPostagem { get; set; }
        public string ImagemPostBase64 { get; set; }
        public string NomeAutor { get; set; }
        public string SubtituloPostagem { get; set; }
        public string TituloMeioPostagem { get; set; }
        public string TituloPostagem { get; set; }
        public string FotoAutor { get; set; }


    }
}