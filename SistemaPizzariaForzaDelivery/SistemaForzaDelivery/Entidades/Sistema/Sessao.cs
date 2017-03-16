using Entidades.Entidades;

namespace Entidades.Sistema
{
    public sealed class Sessao
    {
        private static Sessao Instance;

        public static Sessao GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new Sessao();
                }
                return Instance;
            }
        }

        public static Entidade Usuario { get; set; }
        public static string Grupo { get; set; }        
        public static string NomeMaquina { get; set; }
    }
}