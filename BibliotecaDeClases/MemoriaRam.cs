using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace BibliotecaDeClases
{
    public class MemoriaRam : Producto
    {
        #region Atributos
        private int cantidadDeMemoria;
        private string tecnologia;
        private int velocidad;
        #endregion

        #region    Constructores
        public MemoriaRam(int id,string tipoDeProducto, string marcaProducto, string modelo, double precio, string categoria, int stock, int cantidadDeMemoria, string tecnologia, int velocidad) : base(id,tipoDeProducto, marcaProducto, modelo, precio, categoria, stock)
        {
            this.cantidadDeMemoria = cantidadDeMemoria;
            this.tecnologia = tecnologia;
            this.velocidad = velocidad;
        }
        #endregion

        public override string MostrarDetallesDeProducto()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.MostrarDetallesDeProducto());
            sb.AppendLine($"Cantidad de memoria: {this.cantidadDeMemoria}GB");
            sb.AppendLine($"Tecnología: {this.tecnologia}");
            sb.AppendLine($"Velocidad: {this.velocidad}Mhz");

            return sb.ToString();
        }
        public string CantidadMemoria
        {
            get { return Convert.ToString(this.cantidadDeMemoria); }
        }
        public string Tecnologia
        {
            get { return this.tecnologia; }
        }
        public string Velocidad
        {
            get { return Convert.ToString(this.velocidad); }
        }


    }
}
