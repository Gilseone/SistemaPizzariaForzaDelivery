using System;

namespace Entidades.Entidades
{
    public sealed class Usuario
    {

        private static Usuario Instance;

        public static Usuario GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new Usuario();
                }
                return Instance;
            }
        }

        public string Login { get; set; }

        public string Senha { get; set; }

        public string Nome { get; set; }

        public DateTime Nascimento { get; set; }

    }
}
