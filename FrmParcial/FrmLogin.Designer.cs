namespace FrmParcial
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnIngresar = new Button();
            btnAutocompletarVendedor = new Button();
            btnAutocompletarDueño = new Button();
            txtEmail = new TextBox();
            txtContraseña = new TextBox();
            panel1 = new Panel();
            picLogo = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            lblLogin = new Label();
            pictureBox1 = new PictureBox();
            btnCerrar = new Button();
            btnMinimizar = new Button();
            lblErrorIngreso = new Label();
            picInicioVendedor = new PictureBox();
            tmrContadorTiempo = new System.Windows.Forms.Timer(components);
            picInicioDueño = new PictureBox();
            chkAnimaciones = new CheckBox();
            btnContador = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picInicioVendedor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picInicioDueño).BeginInit();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(68, 68, 68);
            btnIngresar.Cursor = Cursors.Hand;
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnIngresar.FlatAppearance.MouseOverBackColor = Color.FromArgb(125, 125, 125);
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(444, 193);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(106, 35);
            btnIngresar.TabIndex = 2;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnAutocompletarVendedor
            // 
            btnAutocompletarVendedor.BackColor = Color.DarkRed;
            btnAutocompletarVendedor.Cursor = Cursors.Hand;
            btnAutocompletarVendedor.FlatAppearance.BorderSize = 0;
            btnAutocompletarVendedor.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnAutocompletarVendedor.FlatAppearance.MouseOverBackColor = Color.Firebrick;
            btnAutocompletarVendedor.FlatStyle = FlatStyle.Flat;
            btnAutocompletarVendedor.ForeColor = Color.White;
            btnAutocompletarVendedor.Location = new Point(518, 252);
            btnAutocompletarVendedor.Name = "btnAutocompletarVendedor";
            btnAutocompletarVendedor.Size = new Size(157, 33);
            btnAutocompletarVendedor.TabIndex = 3;
            btnAutocompletarVendedor.Text = "Autocompletar Vendedor";
            btnAutocompletarVendedor.UseVisualStyleBackColor = false;
            btnAutocompletarVendedor.Click += btnAutocompletarVendedor_Click;
            // 
            // btnAutocompletarDueño
            // 
            btnAutocompletarDueño.BackColor = Color.DarkRed;
            btnAutocompletarDueño.Cursor = Cursors.Hand;
            btnAutocompletarDueño.FlatAppearance.BorderSize = 0;
            btnAutocompletarDueño.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnAutocompletarDueño.FlatAppearance.MouseOverBackColor = Color.Firebrick;
            btnAutocompletarDueño.FlatStyle = FlatStyle.Flat;
            btnAutocompletarDueño.ForeColor = Color.White;
            btnAutocompletarDueño.Location = new Point(310, 252);
            btnAutocompletarDueño.Name = "btnAutocompletarDueño";
            btnAutocompletarDueño.Size = new Size(157, 33);
            btnAutocompletarDueño.TabIndex = 4;
            btnAutocompletarDueño.Text = "Autocompletar Dueño";
            btnAutocompletarDueño.UseVisualStyleBackColor = false;
            btnAutocompletarDueño.Click += btnAutocompletarDueño_Click;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(15, 15, 15);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Myanmar Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.ForeColor = Color.DimGray;
            txtEmail.Location = new Point(310, 81);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(365, 30);
            txtEmail.TabIndex = 5;
            txtEmail.Text = "EMAIL";
            txtEmail.Enter += txtEmail_Enter;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.FromArgb(15, 15, 15);
            txtContraseña.BorderStyle = BorderStyle.None;
            txtContraseña.Font = new Font("Myanmar Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtContraseña.ForeColor = Color.DimGray;
            txtContraseña.Location = new Point(310, 141);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(365, 30);
            txtContraseña.TabIndex = 6;
            txtContraseña.Text = "CONTRASEÑA";
            txtContraseña.Enter += txtContraseña_Enter;
            txtContraseña.Leave += txtContraseña_Leave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(227, 29, 34);
            panel1.Controls.Add(picLogo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 330);
            panel1.TabIndex = 7;
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources._545427038;
            picLogo.Location = new Point(42, 81);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(160, 160);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 8;
            picLogo.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Enabled = false;
            panel2.Location = new Point(310, 106);
            panel2.Name = "panel2";
            panel2.Size = new Size(365, 2);
            panel2.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DimGray;
            panel3.Enabled = false;
            panel3.Location = new Point(310, 166);
            panel3.Name = "panel3";
            panel3.Size = new Size(365, 2);
            panel3.TabIndex = 9;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogin.ForeColor = Color.DimGray;
            lblLogin.Location = new Point(459, 32);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(104, 31);
            lblLogin.TabIndex = 10;
            lblLogin.Text = "LOGIN";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(25, 25, 25);
            pictureBox1.Location = new Point(0, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(781, 28);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(25, 25, 25);
            btnCerrar.BackgroundImage = Properties.Resources.application_exit_icon_181084;
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(232, 0, 0);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Location = new Point(755, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 25);
            btnCerrar.TabIndex = 14;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = Color.FromArgb(25, 25, 25);
            btnMinimizar.BackgroundImage = Properties.Resources.window_minimize_icon_181229;
            btnMinimizar.BackgroundImageLayout = ImageLayout.Zoom;
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatAppearance.MouseDownBackColor = Color.FromArgb(32, 32, 32);
            btnMinimizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 56, 56);
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Location = new Point(727, 0);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(25, 25);
            btnMinimizar.TabIndex = 15;
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // lblErrorIngreso
            // 
            lblErrorIngreso.AutoSize = true;
            lblErrorIngreso.Font = new Font("Myanmar Text", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblErrorIngreso.ForeColor = Color.FromArgb(227, 29, 34);
            lblErrorIngreso.Location = new Point(310, 170);
            lblErrorIngreso.Name = "lblErrorIngreso";
            lblErrorIngreso.Size = new Size(0, 20);
            lblErrorIngreso.TabIndex = 16;
            // 
            // picInicioVendedor
            // 
            picInicioVendedor.Image = Properties.Resources.gifIngresoVendedor;
            picInicioVendedor.Location = new Point(250, 25);
            picInicioVendedor.Name = "picInicioVendedor";
            picInicioVendedor.Size = new Size(530, 305);
            picInicioVendedor.SizeMode = PictureBoxSizeMode.StretchImage;
            picInicioVendedor.TabIndex = 17;
            picInicioVendedor.TabStop = false;
            picInicioVendedor.Visible = false;
            // 
            // tmrContadorTiempo
            // 
            tmrContadorTiempo.Tick += tmrContadorTiempo_Tick;
            // 
            // picInicioDueño
            // 
            picInicioDueño.Image = Properties.Resources.gifIngresoDueño;
            picInicioDueño.Location = new Point(250, 22);
            picInicioDueño.Name = "picInicioDueño";
            picInicioDueño.Size = new Size(530, 305);
            picInicioDueño.SizeMode = PictureBoxSizeMode.StretchImage;
            picInicioDueño.TabIndex = 18;
            picInicioDueño.TabStop = false;
            picInicioDueño.Visible = false;
            // 
            // chkAnimaciones
            // 
            chkAnimaciones.AutoSize = true;
            chkAnimaciones.BackgroundImageLayout = ImageLayout.None;
            chkAnimaciones.FlatStyle = FlatStyle.Flat;
            chkAnimaciones.ForeColor = Color.Transparent;
            chkAnimaciones.Location = new Point(625, 300);
            chkAnimaciones.Name = "chkAnimaciones";
            chkAnimaciones.Size = new Size(149, 19);
            chkAnimaciones.TabIndex = 9;
            chkAnimaciones.Text = "Desactivar Animaciones";
            chkAnimaciones.UseVisualStyleBackColor = true;
            // 
            // btnContador
            // 
            btnContador.BackColor = Color.DarkRed;
            btnContador.Cursor = Cursors.Hand;
            btnContador.FlatAppearance.BorderSize = 0;
            btnContador.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnContador.FlatAppearance.MouseOverBackColor = Color.Firebrick;
            btnContador.FlatStyle = FlatStyle.Flat;
            btnContador.ForeColor = Color.White;
            btnContador.Location = new Point(423, 291);
            btnContador.Name = "btnContador";
            btnContador.Size = new Size(157, 33);
            btnContador.TabIndex = 19;
            btnContador.Text = "Autocompletar Contador";
            btnContador.UseVisualStyleBackColor = false;
            btnContador.Click += btnContador_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(780, 330);
            Controls.Add(picInicioVendedor);
            Controls.Add(picInicioDueño);
            Controls.Add(lblErrorIngreso);
            Controls.Add(btnMinimizar);
            Controls.Add(btnCerrar);
            Controls.Add(pictureBox1);
            Controls.Add(lblLogin);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txtContraseña);
            Controls.Add(txtEmail);
            Controls.Add(btnAutocompletarDueño);
            Controls.Add(btnAutocompletarVendedor);
            Controls.Add(btnIngresar);
            Controls.Add(chkAnimaciones);
            Controls.Add(btnContador);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picInicioVendedor).EndInit();
            ((System.ComponentModel.ISupportInitialize)picInicioDueño).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnIngresar;
        private Button btnAutocompletarVendedor;
        private Button btnAutocompletarDueño;
        private TextBox txtEmail;
        private TextBox txtContraseña;
        private Panel panel1;
        private PictureBox picLogo;
        private Panel panel2;
        private Panel panel3;
        private Label lblLogin;
        private PictureBox pictureBox1;
        private Button btnCerrar;
        private Button btnMinimizar;
        private Label lblErrorIngreso;
        private PictureBox picInicioVendedor;
        private System.Windows.Forms.Timer tmrContadorTiempo;
        private PictureBox picInicioDueño;
        private CheckBox chkAnimaciones;
        private Button btnContador;
    }
}