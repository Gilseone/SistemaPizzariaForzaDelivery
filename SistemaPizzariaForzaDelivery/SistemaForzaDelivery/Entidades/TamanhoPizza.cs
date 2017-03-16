using Entidades.InfraestruturaBD;
using Entidades.Tipos;

namespace Entidades
{
    public class TamanhoPizza : InfoCadastro, IEntidade
    {
        public int Codigo { get; set; }
        public string Titulo { get; set; }
        public string Observacao { get; set; }
        public TipoSituacao TipoSituacao { get; set; }
        public decimal Preco { get; set; }
        public int QtdSabores { get; set; }
        public bool IsEhExclusao { get; set; }
    }
}
