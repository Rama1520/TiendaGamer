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
    public partial class FrmSumarStock : Form
    {
        private Producto producto;
        private int cantidadAAgregar;

        public FrmSumarStock(Producto producto)
        {
            InitializeComponent();
            this.producto = producto;
        }

        private void txtCantidadAAgregar_TextChanged(object sender, EventArgs e)
        {
            if(txtCantidadAAgregar.Text.Length != 0 && int.TryParse(txtCantidadAAgregar.Text, out this.cantidadAAgregar) == false)
            {
                txtCantidadAAgregar.Text = txtCantidadAAgregar.Text.Remove(txtCantidadAAgregar.Text.Length - 1);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            producto += cantidadAAgregar;
            this.Close();
        }
    }
}
