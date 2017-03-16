using Entidades.InfraestruturaBD;
using Entidades.Tipos;

namespace Entidades
{
    public class SaborPizza : InfoCadastro, IEntidade
    {
        public int Codigo { get; set; }
        public string Titulo { get; set; }
        public string Observacao { get; set; }
        public TipoSituacao TipoSituacao { get; set; }
        public decimal PrecoAdicional { get; set; }
        public bool IsEhExclusao { get; set; }
    }
}
