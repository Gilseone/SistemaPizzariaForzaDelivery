using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class InfoCadastro
    {
        public InfoCadastro()
        {
            this.UsrInsercao = new Entidade();
            this.UsrAlteracao = new Entidade();
            this.UsrExclusao = new Entidade();
        }

        public DateTime DtInsercao { get; set; }
        public Entidade UsrInsercao { get; set; }
        public DateTime DtAlteracao { get; set; }
        public Entidade UsrAlteracao { get; set; }
        public DateTime DtExclusao { get; set; }
        public Entidade UsrExclusao { get; set; }
    }
}
