using Libs;
using System;

namespace Entidades.Tipos
{
    [Serializable]
    public enum TipoMensagem : int
    {
        [StringValue("Você deverá inserir o título do registro!")]
        ErroTituloNaoPreenchido = 0,

        [StringValue("Registro cadastrado com sucesso!")]
        SucessoRegistroCadastrado = 1,

        [StringValue("Não foi possível cadastrar este registro. Tente Novamente!")]
        ErroRegistroNaoCadastrado = 2,

        [StringValue("Registro alterado com sucesso!")]
        SucessoRegistroAlterado = 3,

        [StringValue("Não foi possível alterar este registro. Tente Novamente!")]
        ErroRegistroNaoAlterado = 4,

        [StringValue("Sem dados para serem exibidos!")]
        ErroSemDadosParaExibir = 5,

        [StringValue("Registro excluído com sucesso!")]
        SucessoRegistroExcluido = 6,

        [StringValue("Não foi possível excluir este registro. Tente Novamente!")]
        ErroRegistroExcluido = 7,
    }
}
