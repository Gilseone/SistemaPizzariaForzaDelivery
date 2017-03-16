using Entidades.InfraestruturaBD;

namespace Entidades.Entidades
{
    public class Entidade : IEntidade
    {       
        public Entidade()
        {
        
        }
        
        public Entidade(int codigo, string titulo)
        {
            Codigo = codigo;
            Titulo = titulo;
        }

        public int Codigo { get; set; }

        public string Titulo { get; set; }
    }
}
