using BibliotecaDeClases;
using FrmParcial;
using System.Windows.Forms.VisualStyles;
using System.Media;

namespace FrmParcial
{
    public partial class FrmLogin : Form
    {
        public int m, mx, my; //Variables para mover la ventana sin bordes.
        public int contadorDeTiempo = 0; //Variable para mostrar gif de inicio de sesi�n.
        public int duracionGif;
        SoundPlayer reproductorSonido = new SoundPlayer();
        Usuario aux;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            if (Negocio.ValidarCamposIngresados(txtEmail.Text, txtContrase�a.Text)) 
            {
                aux = Negocio.LogearUsuario(txtEmail.Text, txtContrase�a.Text); //Doble verificaci�n.

                if (aux != null)
                {
                    if(aux.TipoDeUsuario == Usuario.eTipoDeUsuario.Contador)
                    {
                        FrmEstadistica frmEstadistica = new FrmEstadistica();
                        frmEstadistica.Show();
                        this.Hide();
                    }

                    if (aux.TipoDeUsuario == Usuario.eTipoDeUsuario.Due�o)
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
                            picInicioDue�o.Visible = true;
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
                    lblErrorIngreso.Text = "Email y/o contrase�a incorrectos. Reingrese.";
                }
            }
            else
            {
                lblErrorIngreso.Text = "Error. No puede haber campos vac�os.";
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
                picInicioDue�o.Visible = false;
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
   


        private void txtContrase�a_Enter(object sender, EventArgs e)
        {
            if(txtContrase�a.Text == "CONTRASE�A")
            {
                txtContrase�a.Text = "";
                txtContrase�a.ForeColor = Color.LightGray;
                txtContrase�a.UseSystemPasswordChar = true;
            }
        }

        private void txtContrase�a_Leave(object sender, EventArgs e)
        {
            if(txtContrase�a.Text == "")
            {
                txtContrase�a.Text = "CONTRASE�A";
                txtContrase�a.ForeColor = Color.DimGray;
                txtContrase�a.UseSystemPasswordChar = false;
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
            txtContrase�a.Text = "contrase�a";
            txtEmail.ForeColor = Color.LightGray;
            txtContrase�a.ForeColor = Color.LightGray;
            txtContrase�a.UseSystemPasswordChar = true;
        }
        private void btnAutocompletarDue�o_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "peralta@peralta.com";
            txtContrase�a.Text = "contrase�a";
            txtEmail.ForeColor = Color.LightGray;
            txtContrase�a.ForeColor = Color.LightGray;
            txtContrase�a.UseSystemPasswordChar = true;
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
            txtContrase�a.Text = "contrase�a";
            txtEmail.ForeColor = Color.LightGray;
            txtContrase�a.ForeColor = Color.LightGray;
            txtContrase�a.UseSystemPasswordChar = true;
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