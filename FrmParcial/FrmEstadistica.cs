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
    public partial class FrmEstadistica : Form
    {
        public FrmEstadistica()
        {
            InitializeComponent();
        }

        private void FrmEstadistica_Load(object sender, EventArgs e)
        {
            List<String> categorias = Negocio.DevuelveCategorias();

            foreach(string item in categorias)
            {

                dgvEstadistica.Rows.Add(Negocio.ContadorCategoriasVendidas(item), item, (Negocio.GananciaPorTag(item) / Negocio.ContadorCategoriasVendidas(item)));

            }

            dgvEstadistica.Rows.Add();

            lblGananciaTotal.Text = Negocio.GananciaTotal().ToString();
            lblCantidadVentas.Text = Negocio.RetornarCantidadVentas().ToString();

        }
    }
}
