using BibliotecaDeClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmParcial
{
    public partial class FrmFacturaDeVenta : Form
    {
        Cliente cliente;
        Producto producto;
        Usuario usuarioActivo;

        public FrmFacturaDeVenta(Cliente cliente, Producto producto, Usuario usuarioActivo)
        {
            InitializeComponent();
            this.cliente = cliente;
            this.producto = producto;
            this.usuarioActivo = usuarioActivo;
        }

        private void FrmFacturaDeVenta_Load(object sender, EventArgs e)
        {
            lblEmisor.Text = usuarioActivo.NombreCompleto;
            lblNombreComprador.Text = cliente.NombreCompleto;
            lblProductoVendido.Text = producto.TipoDeProducto + producto.MarcaDeProducto + producto.Modelo;
            lblTotalAPagar.Text = producto.Precio.ToString();
        }
    }
}
