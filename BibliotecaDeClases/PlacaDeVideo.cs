using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BibliotecaDeClases
{ 
    public class PlacaDeVideo : Producto
    {
        #region Atributos
        private string chipset;
        private int capacidadDeMemorioa;
        private int consumoDeEnergia;
        #endregion
        
        #region Constructores
        public PlacaDeVideo(int id,string tipoDeProducto, string marcaProducto, string modelo, double precio, string categoria, int stock, string chipset, int capacidadDeMemoria, int consumoDeEnergia) : base (id, tipoDeProducto, marcaProducto, modelo, precio, categoria, stock)
        {
            this.chipset = chipset;
            this.capacidadDeMemorioa = capacidadDeMemoria;
            this.consumoDeEnergia = consumoDeEnergia;
        }
        #endregion

        public override string MostrarDetallesDeProducto()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.MostrarDetallesDeProducto());
            sb.AppendLine($"Chipset: {this.chipset}");
            sb.AppendLine($"Capacidad de Memoria: {this.capacidadDeMemorioa}");
            sb.AppendLine($"Consumo de Energía: {this.consumoDeEnergia}");

            return sb.ToString();
        }
        public string Chipset
        {
            get { return this.chipset; }
        }
        public string CapacidadMemoria
        {
            get { return Convert.ToString(this.capacidadDeMemorioa); }
        }
        public string ConsumoEnergia
        {
            get { return Convert.ToString(this.consumoDeEnergia); }
        }

    }
}
