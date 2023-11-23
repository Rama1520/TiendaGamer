using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BibliotecaDeClases
{
    public class Notebook : Producto
    {
        #region Atributos
        private int memoriaRam;
        private int almacenamiento;
        private string procesador;
        #endregion

        #region Contructores
        public Notebook(int id,string tipoDeProducto, string marcaProducto, string modelo, double precio, string categoria, int stock, int memoriaRam, int almacenamiento, string procesador) : base (id, tipoDeProducto, marcaProducto, modelo, precio, categoria, stock)
        {
            this.memoriaRam = memoriaRam;
            this.almacenamiento = almacenamiento;
            this.procesador = procesador;
        }
        #endregion

        public override string MostrarDetallesDeProducto()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.MostrarDetallesDeProducto());
            sb.AppendLine($"Memoria Ram: {this.memoriaRam}Gb");
            sb.AppendLine($"Almacenamiento: {this.almacenamiento}Gb");
            sb.AppendLine($"Procesador: {this.procesador}");

            return sb.ToString();
        }
        public string MemoriaRam
        {
            get { return Convert.ToString(this.memoriaRam); }
        }
        public string Almacenmaiento
        {
            get { return Convert.ToString(this.almacenamiento); }
        }
        public string Procesador
        {
            get { return this.procesador; }
        }

    }
}
