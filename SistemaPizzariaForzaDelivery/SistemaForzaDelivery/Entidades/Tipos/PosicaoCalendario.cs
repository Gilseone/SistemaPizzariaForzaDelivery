using Libs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades.Tipos
{
    [Serializable]
    public enum PosicaoCalendario : int
    {
        [StringValue("Acima")]
        Acima = 0,

        [StringValue("Abaixo")]
        Abaixo = 1,
    }
}
