using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BibliotecaDeClases
{
    public class Usuario
    {
        #region Atributos

        private string nombreCompleto;
        private string email;
        private string contraseña;
        private eTipoDeUsuario tipoDeUsuario;
        #endregion

        #region Constructores
        public Usuario(string nombreCompleto, string email, string contraseña, eTipoDeUsuario tipoDeUsuario) 
        {
            this.nombreCompleto = nombreCompleto; 
            this.email = email;
            this.contraseña = contraseña;
            this.tipoDeUsuario = tipoDeUsuario;
        }
        #endregion

        #region Propiedades
        public string Email
        {
            get { return this.email; }
        }
        public string Contraseña
        {
            get { return this.contraseña; }
        }
        public eTipoDeUsuario TipoDeUsuario
        {
            get { return this.tipoDeUsuario; }
        }
        public string NombreCompleto
        {
            get { return this.nombreCompleto; }
        }


        #endregion

        #region Enumerados
        public enum eTipoDeUsuario
        {
            Vendedor,
            Dueño,
            Contador
        }
        #endregion
    }
}
