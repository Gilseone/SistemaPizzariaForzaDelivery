using Libs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades.Tipos
{
    [Serializable]
    public enum ComparadorString : int
    {
        //Separador de Datas
        [StringValue("//")]
        SeparadorDatas = 0,

        //Separador de Referências
        [StringValue("/")]
        SeparadorReferencias = 1,

        //Espaço
        [StringValue(" ")]
        Espaco = 2,

        //Vazio
        [StringValue("")]
        Vazio = 3,

        //Zero
        [StringValue("0")]
        Zero = 4,

        //Traço
        [StringValue("-")]
        Traco = 5,

        //Substrituto Número na Formatação do Endereço
        [StringValue("#@#@")]
        SubstitutoNumeroEndereco = 6,
    }
}
