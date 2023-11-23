using BibliotecaDeClases;
using FrmParcial;
using System.Windows.Forms.VisualStyles;
using System.Media;

namespace FrmParcial
{
    public partial class FrmLogin : Form
    {
        public int m, mx, my; //Variables para mover la ventana sin bordes.
        public int contadorDeTiempo = 0; //Variable para mostrar gif de inicio de sesión.
        public int duracionGif;
        SoundPlayer reproductorSonido = new SoundPlayer();
        Usuario aux;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            if (Negocio.ValidarCamposIngresados(txtEmail.Text, txtContraseña.Text)) 
            {
                aux = Negocio.LogearUsuario(txtEmail.Text, txtContraseña.Text); //Doble verificación.

                if (aux != null)
                {
                    if(aux.TipoDeUsuario == Usuario.eTipoDeUsuario.Contador)
                    {
                        FrmEstadistica frmEstadistica = new FrmEstadistica();
                        frmEstadistica.Show();
                        this.Hide();
                    }

                    if (aux.TipoDeUsuario == Usuario.eTipoDeUsuario.Dueño)
                    {
                        if (chkAnimaciones.Checked)
                        {
                            FrmMenuPrincipal menuPrincipal = new FrmMenuPrincipal(aux);//desactivar == false
                            this.Hide();
                            menuPrincipal.Show();
                        }
                        else
                        {
                            duracionGif = 84;
                            picInicioDueño.Visible = true;
                            tmrContadorTiempo.Start();
                            reproductorSonido.Stream = Properties.Resources.SonidoChallenger;
                            reproductorSonido.Play();
                        }
                    }
                    else
                    {
                        if (chkAnimaciones.Checked)
                        {
                            this.Hide();
                            FrmVentas frmVentas = new FrmVentas(aux);
                            frmVentas.Show();
                        }
                        else
                        {
                            duracionGif = 44;
                            picInicioVendedor.Visible = true;
                            tmrContadorTiempo.Start();
                            reproductorSonido.Stream = Properties.Resources.SonidoHierro;
                            reproductorSonido.Play();
                        }
                    }
                }
                else
                {
                    lblErrorIngreso.Text = "Email y/o contraseña incorrectos. Reingrese.";
                }
            }
            else
            {
                lblErrorIngreso.Text = "Error. No puede haber campos vacíos.";
            }
        }
        private void tmrContadorTiempo_Tick(object sender, EventArgs e)
        {
            contadorDeTiempo += 1;

            if (contadorDeTiempo == duracionGif && duracionGif == 44)
            {
                tmrContadorTiempo.Stop();
                this.Hide();
                picInicioVendedor.Visible = false;
            }

            if (contadorDeTiempo == duracionGif && duracionGif == 84)
            {
                tmrContadorTiempo.Stop();
                FrmMenuPrincipal menuPrincipal = new FrmMenuPrincipal(aux);
                this.Hide();
                menuPrincipal.Show();
                picInicioDueño.Visible = false;
            }
        }

        #region Logica TextBox
        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if(txtEmail.Text == "EMAIL")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.LightGray;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if(txtEmail.Text == "")
            {
                txtEmail.Text = "EMAIL";
                txtEmail.ForeColor = Color.DimGray;
            }
        }              
   


        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if(txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.LightGray;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if(txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }
        #endregion

        #region Funciones MinimizarCerrar

        protected void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Autocompletado de Datos
        private void btnAutocompletarVendedor_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "fadon@vendedor.com";
            txtContraseña.Text = "contraseña";
            txtEmail.ForeColor = Color.LightGray;
            txtContraseña.ForeColor = Color.LightGray;
            txtContraseña.UseSystemPasswordChar = true;
        }
        private void btnAutocompletarDueño_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "peralta@peralta.com";
            txtContraseña.Text = "contraseña";
            txtEmail.ForeColor = Color.LightGray;
            txtContraseña.ForeColor = Color.LightGray;
            txtContraseña.UseSystemPasswordChar = true;
        }
        #endregion

        #region Logica Mover Ventana
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void btnContador_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "contador@contador.com";
            txtContraseña.Text = "contraseña";
            txtEmail.ForeColor = Color.LightGray;
            txtContraseña.ForeColor = Color.LightGray;
            txtContraseña.UseSystemPasswordChar = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0; 
        }
        #endregion
    }
}