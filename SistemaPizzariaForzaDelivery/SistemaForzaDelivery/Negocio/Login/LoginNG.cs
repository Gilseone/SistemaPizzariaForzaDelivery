using BaseDados.Login;
using Entidades.Entidades;

namespace Negocio.Login
{
    public class LoginNG
    {
        public bool VerificarLoginValido(Usuario usr)
        {
            return new LoginBD().VerificarLoginValido(usr);
        }
    }
}
