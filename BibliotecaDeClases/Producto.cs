using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BibliotecaDeClases
{
    public abstract class Producto
    {
        #region Atributos
        protected int id;
        protected string tipoDeProducto;
        protected string marcaProducto;
        protected string modelo;
        protected double precio;
        protected string categoria;
        protected int stock;
        #endregion

        #region Constructores

        protected Producto(int id, string tipoDeProducto, string marcaProducto, string modelo, double precio, string categoria, int stock) 
        {
            this.id = id;
            this.tipoDeProducto = tipoDeProducto;
            this.marcaProducto = marcaProducto;
            this.modelo = modelo;
            this.precio = precio;
            this.categoria = categoria;
            this.stock = stock;
        }

        #endregion

        #region Propiedades
        public int Id
        {
            get { return id; }  
        }
        public string TipoDeProducto
        {
            get { return this.tipoDeProducto;}
        }
        public string MarcaDeProducto
        {
            get { return this.marcaProducto;}
        }
        public string Modelo
        {
            get { return this.modelo;}
        }
        public double Precio
        {
            get { return this.precio;}
            set { this.precio = value; }
        }
        public string Categoria
        {
            get { return this.categoria;}
            set { this.categoria = value; }
        }
        public int Stock
        {
            get { return this.stock;}
            set { this.stock = value; }
        }

        #endregion

        public virtual string MostrarDetallesDeProducto()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Tipo de producto: {this.tipoDeProducto}");
            sb.AppendLine($"Marca de producto: {marcaProducto}");
            sb.AppendLine($"Modelo: {this.modelo}");
            sb.AppendLine($"Precio: ${this.precio}");
            sb.AppendLine($"Categoria: {this.categoria}");
            sb.AppendLine($"Stock: {this.stock}");

            return sb.ToString();
        }

        #region Enumerados
        public enum eColores
        {
            Rosa,
            Negro,
            Rojo,
            Blanco,
            Amarillo,
            Marron,
            Verde,
            Violeta,
            Azul,
            Celeste
        }
        #endregion

        public static Producto operator+(Producto p1, int cantidadASumar)
        {
            p1.Stock = p1.Stock + cantidadASumar;

            return p1;
        }
        public static Producto operator++(Producto p1)
        {
            p1.Stock++;

            return p1;
        }

        public static Producto operator --(Producto p1)
        {
            p1.Stock--;

            return p1;
        }

    }
}
