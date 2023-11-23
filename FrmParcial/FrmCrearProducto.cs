using BibliotecaDeClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmParcial
{
    public partial class FrmCrearProducto : Form
    {
        public int m, mx, my; //Variables para mover la ventana sin bordes.


        public FrmCrearProducto()
        {
            InitializeComponent();
        }

        private void FrmCrearProducto_Load(object sender, EventArgs e)
        {
            cmbTipoDeProducto.SelectedIndex = 0;
        }

        private void cmbTipoDeProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbTipoDeProducto.SelectedIndex)
            {
                case 1:
                    grpMemoriaRam.Visible = true;
                    grpNotebook.Visible = false;
                    grpVideo.Visible = false;
                    grpProcesador.Visible = false;
                    break;
                case 2:
                    grpMemoriaRam.Visible = false;
                    grpNotebook.Visible = true;
                    grpVideo.Visible = false;
                    grpProcesador.Visible = false;
                    break;
                case 3:
                    grpMemoriaRam.Visible = false;
                    grpNotebook.Visible = false;
                    grpVideo.Visible = true;
                    grpProcesador.Visible = false;
                    break;
                case 4:
                    grpMemoriaRam.Visible = false;
                    grpNotebook.Visible = false;
                    grpVideo.Visible = false;
                    grpProcesador.Visible = true;
                    break;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Producto CrearProducto()
        {
            Producto nuevoProducto = null;
            double auxPrecio;
            int auxStock;
            int auxMemoriaRam;
            int auxRamVelocidad;
            int auxNotebookRam;
            int auxNotebookAlmacenamiento;
            int auxVideoMemoria;
            int auxVideoEnergia;
            int auxProcesadorNucleos;
            double auxProcesadorFrecuencia;



            if (cmbTipoDeProducto.Text != "Tipo De Producto" &&
            !(string.IsNullOrEmpty(txtMarca.Text)) &&
            !(string.IsNullOrEmpty(txtModelo.Text)) &&
            !(string.IsNullOrEmpty(txtCategoria.Text)) &&
            double.TryParse(txtPrecio.Text, out auxPrecio) &&
            int.TryParse(txtStock.Text, out auxStock) &&
            auxPrecio > 0 && auxStock > 0)
            {
                switch (cmbTipoDeProducto.SelectedIndex)
                {
                    case 1:
                        if (!(string.IsNullOrEmpty(txtRamTecnologia.Text)) && int.TryParse(txtRamMemoria.Text, out auxMemoriaRam) && int.TryParse(txtRamVelocidad.Text, out auxRamVelocidad) && auxMemoriaRam > 0 && auxRamVelocidad > 0)
                            nuevoProducto = new MemoriaRam(cmbTipoDeProducto.Text, txtMarca.Text, txtModelo.Text, auxPrecio, txtCategoria.Text, auxStock, auxMemoriaRam, txtRamTecnologia.Text, auxRamVelocidad);
                        break;
                    case 2:
                        if (int.TryParse(txtNotebookRam.Text, out auxNotebookRam) && int.TryParse(txtNotebookAlmacenamiento.Text, out auxNotebookAlmacenamiento) && !(string.IsNullOrEmpty(txtNotebookProcesador.Text)) && auxNotebookAlmacenamiento > 0 && auxNotebookRam > 0)
                            nuevoProducto = new Notebook(cmbTipoDeProducto.Text, txtMarca.Text, txtModelo.Text, auxPrecio, txtCategoria.Text, auxStock, auxNotebookRam, auxNotebookAlmacenamiento, txtNotebookProcesador.Text);
                        break;
                    case 3:
                        if (!(string.IsNullOrEmpty(txtVideoChipset.Text)) && int.TryParse(txtVideoMemoria.Text, out auxVideoMemoria) && int.TryParse(txtVideoEnergia.Text, out auxVideoEnergia) && auxVideoEnergia > 0 && auxVideoMemoria > 0)
                            nuevoProducto = new PlacaDeVideo(cmbTipoDeProducto.Text, txtMarca.Text, txtModelo.Text, auxPrecio, txtCategoria.Text, auxStock, txtVideoChipset.Text, auxVideoMemoria, auxVideoEnergia);
                        break;
                    case 4:
                        if (int.TryParse(txtProcesadorNucleos.Text, out auxProcesadorNucleos) && double.TryParse(txtProcesadorFrecuencia.Text, out auxProcesadorFrecuencia) && !(string.IsNullOrEmpty(txtProcesadorSocket.Text)) && auxProcesadorFrecuencia > 0 && auxProcesadorNucleos > 0)
                            nuevoProducto = new Procesador(cmbTipoDeProducto.Text, txtMarca.Text, txtModelo.Text, auxPrecio, txtCategoria.Text, auxStock, auxProcesadorNucleos, auxProcesadorFrecuencia, txtProcesadorSocket.Text);
                        break;

                }

            }
            else
            {
                MessageBox.Show("Revise los datos ingresados.");
            }


            return nuevoProducto;
        }


        private void btnCrear_Click(object sender, EventArgs e)
        {
            List<Producto> lista = Negocio.RetornarProductos();
            Producto nuevoProducto = CrearProducto();

            if (nuevoProducto != null)
            {
                lista.Add(nuevoProducto);
                this.Close();

            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


//Tipo De Producto
//Memoria Ram
//Notebook
//Placa de Video
//Procesador