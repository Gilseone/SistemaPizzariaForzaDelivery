using Entidades.InfraestruturaBD;

namespace Entidades.Entidades
{
    public class Entidade : IEntidade
    {       
        public Entidade()
        {
        
        }
        
        public Entidade(int codigo, string descricao)
        {
            Codigo = codigo;
            Descricao = descricao;
        }

        public int Codigo { get; set; }

        public string Descricao { get; set; }
    }
}
