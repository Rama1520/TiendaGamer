using BibliotecaDeClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmParcial
{
    public partial class FrmInventario : Form
    {
        public int m, mx, my; //Variables para mover la ventana sin bordes.
        List<Producto> listaDeProductos;
        Producto productoSeleccioando;
        Usuario usuario;

        public FrmInventario(Usuario usuario)
        {
            InitializeComponent();
            this.listaDeProductos = Negocio.RetornarProductos();
            this.usuario = usuario;
        }




        public void CargarDataGridView(List<Producto> listaDeProductos)
        {
            foreach (Producto producto in listaDeProductos)
            {
                dgvProductos.Rows.Add(producto.TipoDeProducto, producto.MarcaDeProducto, producto.Modelo, producto.Precio, producto.Categoria, producto.Stock);
            }
        }

        private void FrmInventario_Load(object sender, EventArgs e)
        {
            CargarDataGridView(Negocio.RetornarProductos());
        }


        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            double auxMin;
            double auxMax;

            if (double.TryParse(txtMin.Text, out auxMin) && double.TryParse(txtMax.Text, out auxMax))
            {
                List<Producto> listaDeProductos = Negocio.BuscarPorPrecio(auxMin, auxMax);
                dgvProductos.Rows.Clear();
                CargarDataGridView(listaDeProductos);
            }
        }


        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             int n = e.RowIndex;

            if(n != -1)
            {
                foreach(Producto item in listaDeProductos)
                {
                    if(item.TipoDeProducto == dgvProductos.Rows[n].Cells[0].Value.ToString() &&
                        item.MarcaDeProducto == dgvProductos.Rows[n].Cells[1].Value.ToString() &&
                        item.Modelo == dgvProductos.Rows[n].Cells[2].Value.ToString() &&
                        item.Precio == (double)dgvProductos.Rows[n].Cells[3].Value &&
                        item.Categoria == dgvProductos.Rows[n].Cells[4].Value.ToString() && 
                        item.Stock == (int)dgvProductos.Rows[n].Cells[5].Value)
                    {
                        productoSeleccioando = item;
                        break;
                    }
                }
            }

        }

        private void btnAgregarStock_Click(object sender, EventArgs e)
        {
            if(productoSeleccioando != null)
            {
                FrmSumarStock frmSumarStock = new FrmSumarStock(productoSeleccioando);
                frmSumarStock.ShowDialog();
                dgvProductos.Rows.Clear();
                CargarDataGridView(Negocio.RetornarProductos());
            }
            else
            {
                MessageBox.Show("Primero seleccione un producto.");
            }
        }

        private void btnVerDetalles_Click(object sender, EventArgs e)
        {
            MessageBox.Show(productoSeleccioando.MostrarDetallesDeProducto());
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            FrmCrearProducto frmCrearProducto = new FrmCrearProducto();
            frmCrearProducto.ShowDialog();
            dgvProductos.Rows.Clear();
            CargarDataGridView(Negocio.RetornarProductos());
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(productoSeleccioando != null)
            {
                FrmEditarProducto frmEditarProducto = new FrmEditarProducto(productoSeleccioando);
                frmEditarProducto.ShowDialog();
                dgvProductos.Rows.Clear();
                CargarDataGridView(Negocio.RetornarProductos());
            }
        }


        private void txtCategorias_TextChanged(object sender, EventArgs e)
        {
            dgvProductos.Rows.Clear();
            CargarDataGridView(Negocio.BuscarPorCategoria(txtCategorias.Text));
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal(usuario);
            this.Hide();
            frmMenuPrincipal.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
