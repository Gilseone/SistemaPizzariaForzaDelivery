using Libs;
using System;

namespace Entidades.Tipos
{
    [Serializable]
    public enum OrdemValidacaoDatas : int
    {
        [StringValue("Data Inicial")]
        DataInicial = 1,

        [StringValue("Data Final")]
        DataFinal = 2,
    }
}
