using Libs;
using System;

namespace Entidades.Tipos
{
    [Serializable]
    public enum TipoSituacao : int
    {
        [StringValue("Inativo")]
        Inativo = 0,

        [StringValue("Ativo")]
        Ativo = 1,

        [StringValue("Todos")]
        Todos = 2,
    }
}
