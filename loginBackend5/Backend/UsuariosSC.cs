using loginBackend5.DataAcces;
using loginBackend5.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace loginBackend5.Backend
{
    public class UsuariosSC : BaseSC
    {
        public IQueryable <UsuarioLog> GetUsuarios()
        {
            return dbContext.UsuarioLogs.AsQueryable();

        }

        public UsuarioLog GetUsuarioByID(int id)
        {    
                return GetUsuarios().Where(x => x.Iduser == id).FirstOrDefault();
        }

        public void agregarUsuario(UsuarioLoginModel newUsuario)
        {
            var nuevoUsuario = new UsuarioLog();
            nuevoUsuario.NombreUser = newUsuario.nombreUsuario;
            nuevoUsuario.EmailUser = newUsuario.emailUsuario;
            string salt = EncryptSC.crearSalt(5);
            nuevoUsuario.PasswordUser = salt + EncryptSC.GetSHA256(newUsuario.passwordUsuario);

            dbContext.UsuarioLogs.Add(nuevoUsuario);
            dbContext.SaveChanges();
        }

       public Boolean autenticacion(autenticarUsuario autenticarUser)
        {
            string value = autenticarUser.emailUsuario;
            string pass = EncryptSC.GetSHA256(autenticarUser.contraseñaUsuario);

            var aut = (from d in dbContext.UsuarioLogs
                       where d.EmailUser == value && d.PasswordUser == pass
                       select d).FirstOrDefault();

            if(aut != null)
            {
                return true;
            }
            else
            {
                return false;
            }
  
        }
        
        


    }
}
