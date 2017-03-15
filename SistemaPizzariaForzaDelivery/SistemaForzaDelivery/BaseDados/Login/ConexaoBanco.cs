using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BaseDados.Login
{
   public class ConexaoBanco
    {
        String dbConnection;

        public ConexaoBanco()
        {
            dbConnection = "Data Source=UnityBD.s3db";
        }

    }
}
