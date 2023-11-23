using BibliotecaDeClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace FrmParcial
{
    public partial class FrmEditarProducto : Form
    {
        Producto producto;
        public FrmEditarProducto(Producto producto)
        {
            InitializeComponent();
            this.producto = producto;
        }

        private void FrmEditarProducto_Load(object sender, EventArgs e)
        {
            txtCategoria.Text= producto.Categoria;
            txtPrecio.Text = producto.Precio.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            double auxNuevoPrecio;

            if(double.TryParse(txtPrecio.Text, out auxNuevoPrecio) && auxNuevoPrecio > 0)
            {
                producto.Precio = auxNuevoPrecio;
                producto.Categoria = txtCategoria.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("El precio debe ser mayor a 0.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
    }
}
