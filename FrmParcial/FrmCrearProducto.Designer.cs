namespace FrmParcial
{
    partial class FrmCrearProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            txtModelo = new TextBox();
            txtCategoria = new TextBox();
            txtMarca = new TextBox();
            cmbTipoDeProducto = new ComboBox();
            grpMemoriaRam = new GroupBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtRamMemoria = new TextBox();
            txtRamVelocidad = new TextBox();
            txtRamTecnologia = new TextBox();
            grpVideo = new GroupBox();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            txtVideoEnergia = new TextBox();
            txtVideoChipset = new TextBox();
            txtVideoMemoria = new TextBox();
            grpNotebook = new GroupBox();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            txtNotebookProcesador = new TextBox();
            txtNotebookAlmacenamiento = new TextBox();
            txtNotebookRam = new TextBox();
            txtProcesadorSocket = new TextBox();
            txtProcesadorNucleos = new TextBox();
            txtProcesadorFrecuencia = new TextBox();
            btnSalir = new Button();
            btnCrear = new Button();
            btnMinimizar = new Button();
            btnCerrar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            grpProcesador = new GroupBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            grpMemoriaRam.SuspendLayout();
            grpVideo.SuspendLayout();
            grpNotebook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grpProcesador.SuspendLayout();
            SuspendLayout();
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(138, 146);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 23);
            txtPrecio.TabIndex = 0;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(138, 204);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(125, 23);
            txtStock.TabIndex = 1;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(138, 88);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(125, 23);
            txtModelo.TabIndex = 3;
            txtModelo.TextChanged += txtModelo_TextChanged;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(138, 175);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(125, 23);
            txtCategoria.TabIndex = 7;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(138, 117);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(125, 23);
            txtMarca.TabIndex = 6;
            // 
            // cmbTipoDeProducto
            // 
            cmbTipoDeProducto.FormattingEnabled = true;
            cmbTipoDeProducto.Items.AddRange(new object[] { "Tipo De Producto", "Memoria Ram", "Notebook", "Placa de Video", "Procesador" });
            cmbTipoDeProducto.Location = new Point(138, 59);
            cmbTipoDeProducto.Name = "cmbTipoDeProducto";
            cmbTipoDeProducto.Size = new Size(125, 23);
            cmbTipoDeProducto.TabIndex = 8;
            cmbTipoDeProducto.SelectedIndexChanged += cmbTipoDeProducto_SelectedIndexChanged;
            // 
            // grpMemoriaRam
            // 
            grpMemoriaRam.Controls.Add(label7);
            grpMemoriaRam.Controls.Add(label8);
            grpMemoriaRam.Controls.Add(label9);
            grpMemoriaRam.Controls.Add(txtRamMemoria);
            grpMemoriaRam.Controls.Add(txtRamVelocidad);
            grpMemoriaRam.Controls.Add(txtRamTecnologia);
            grpMemoriaRam.Location = new Point(563, 63);
            grpMemoriaRam.Name = "grpMemoriaRam";
            grpMemoriaRam.Size = new Size(252, 129);
            grpMemoriaRam.TabIndex = 9;
            grpMemoriaRam.TabStop = false;
            grpMemoriaRam.Text = "Memoria Ram";
            grpMemoriaRam.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Subheading", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(6, 89);
            label7.Name = "label7";
            label7.Size = new Size(72, 21);
            label7.TabIndex = 33;
            label7.Text = "Velocidad";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Subheading", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(6, 59);
            label8.Name = "label8";
            label8.Size = new Size(81, 21);
            label8.TabIndex = 32;
            label8.Text = "Tecnologia";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sitka Subheading", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(6, 31);
            label9.Name = "label9";
            label9.Size = new Size(69, 21);
            label9.TabIndex = 31;
            label9.Text = "Memoria";
            label9.Click += label9_Click;
            // 
            // txtRamMemoria
            // 
            txtRamMemoria.Location = new Point(129, 31);
            txtRamMemoria.Name = "txtRamMemoria";
            txtRamMemoria.Size = new Size(100, 23);
            txtRamMemoria.TabIndex = 0;
            // 
            // txtRamVelocidad
            // 
            txtRamVelocidad.Location = new Point(129, 89);
            txtRamVelocidad.Name = "txtRamVelocidad";
            txtRamVelocidad.Size = new Size(100, 23);
            txtRamVelocidad.TabIndex = 2;
            // 
            // txtRamTecnologia
            // 
            txtRamTecnologia.Location = new Point(129, 60);
            txtRamTecnologia.Name = "txtRamTecnologia";
            txtRamTecnologia.Size = new Size(100, 23);
            txtRamTecnologia.TabIndex = 1;
            // 
            // grpVideo
            // 
            grpVideo.Controls.Add(label13);
            grpVideo.Controls.Add(label14);
            grpVideo.Controls.Add(label15);
            grpVideo.Controls.Add(txtVideoEnergia);
            grpVideo.Controls.Add(txtVideoChipset);
            grpVideo.Controls.Add(txtVideoMemoria);
            grpVideo.Location = new Point(297, 214);
            grpVideo.Name = "grpVideo";
            grpVideo.Size = new Size(252, 129);
            grpVideo.TabIndex = 11;
            grpVideo.TabStop = false;
            grpVideo.Text = "Placa de Video";
            grpVideo.Visible = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Sitka Subheading", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(6, 95);
            label13.Name = "label13";
            label13.Size = new Size(61, 21);
            label13.TabIndex = 36;
            label13.Text = "Energia";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Sitka Subheading", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(6, 65);
            label14.Name = "label14";
            label14.Size = new Size(69, 21);
            label14.TabIndex = 35;
            label14.Text = "Memoria";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Sitka Subheading", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(6, 37);
            label15.Name = "label15";
            label15.Size = new Size(57, 21);
            label15.TabIndex = 34;
            label15.Text = "Chipset";
            // 
            // txtVideoEnergia
            // 
            txtVideoEnergia.Location = new Point(129, 94);
            txtVideoEnergia.Name = "txtVideoEnergia";
            txtVideoEnergia.Size = new Size(100, 23);
            txtVideoEnergia.TabIndex = 5;
            // 
            // txtVideoChipset
            // 
            txtVideoChipset.Location = new Point(129, 36);
            txtVideoChipset.Name = "txtVideoChipset";
            txtVideoChipset.Size = new Size(100, 23);
            txtVideoChipset.TabIndex = 3;
            // 
            // txtVideoMemoria
            // 
            txtVideoMemoria.Location = new Point(129, 65);
            txtVideoMemoria.Name = "txtVideoMemoria";
            txtVideoMemoria.Size = new Size(100, 23);
            txtVideoMemoria.TabIndex = 4;
            // 
            // grpNotebook
            // 
            grpNotebook.Controls.Add(label16);
            grpNotebook.Controls.Add(label17);
            grpNotebook.Controls.Add(label18);
            grpNotebook.Controls.Add(txtNotebookProcesador);
            grpNotebook.Controls.Add(txtNotebookAlmacenamiento);
            grpNotebook.Controls.Add(txtNotebookRam);
            grpNotebook.Location = new Point(563, 214);
            grpNotebook.Name = "grpNotebook";
            grpNotebook.Size = new Size(252, 129);
            grpNotebook.TabIndex = 10;
            grpNotebook.TabStop = false;
            grpNotebook.Text = "Notebook";
            grpNotebook.Visible = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Sitka Subheading", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(6, 95);
            label16.Name = "label16";
            label16.Size = new Size(82, 21);
            label16.TabIndex = 36;
            label16.Text = "Procesador";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Sitka Subheading", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(6, 65);
            label17.Name = "label17";
            label17.Size = new Size(121, 21);
            label17.TabIndex = 35;
            label17.Text = "Almacenamiento";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Sitka Subheading", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(6, 37);
            label18.Name = "label18";
            label18.Size = new Size(69, 21);
            label18.TabIndex = 34;
            label18.Text = "Memoria";
            // 
            // txtNotebookProcesador
            // 
            txtNotebookProcesador.Location = new Point(129, 93);
            txtNotebookProcesador.Name = "txtNotebookProcesador";
            txtNotebookProcesador.Size = new Size(100, 23);
            txtNotebookProcesador.TabIndex = 2;
            // 
            // txtNotebookAlmacenamiento
            // 
            txtNotebookAlmacenamiento.Location = new Point(129, 64);
            txtNotebookAlmacenamiento.Name = "txtNotebookAlmacenamiento";
            txtNotebookAlmacenamiento.Size = new Size(100, 23);
            txtNotebookAlmacenamiento.TabIndex = 1;
            // 
            // txtNotebookRam
            // 
            txtNotebookRam.Location = new Point(129, 35);
            txtNotebookRam.Name = "txtNotebookRam";
            txtNotebookRam.Size = new Size(100, 23);
            txtNotebookRam.TabIndex = 0;
            // 
            // txtProcesadorSocket
            // 
            txtProcesadorSocket.Location = new Point(129, 86);
            txtProcesadorSocket.Name = "txtProcesadorSocket";
            txtProcesadorSocket.Size = new Size(100, 23);
            txtProcesadorSocket.TabIndex = 5;
            // 
            // txtProcesadorNucleos
            // 
            txtProcesadorNucleos.Location = new Point(129, 29);
            txtProcesadorNucleos.Name = "txtProcesadorNucleos";
            txtProcesadorNucleos.Size = new Size(100, 23);
            txtProcesadorNucleos.TabIndex = 3;
            // 
            // txtProcesadorFrecuencia
            // 
            txtProcesadorFrecuencia.Location = new Point(129, 57);
            txtProcesadorFrecuencia.Name = "txtProcesadorFrecuencia";
            txtProcesadorFrecuencia.Size = new Size(100, 23);
            txtProcesadorFrecuencia.TabIndex = 4;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(167, 277);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 12;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(57, 279);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(75, 23);
            btnCrear.TabIndex = 13;
            btnCrear.Text = "CREAR";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
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
            btnMinimizar.Location = new Point(771, 0);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(25, 25);
            btnMinimizar.TabIndex = 24;
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
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
            btnCerrar.Location = new Point(802, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 25);
            btnCerrar.TabIndex = 23;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Subheading", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 57);
            label1.Name = "label1";
            label1.Size = new Size(120, 21);
            label1.TabIndex = 25;
            label1.Text = "Tipo de Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Subheading", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 87);
            label2.Name = "label2";
            label2.Size = new Size(58, 21);
            label2.TabIndex = 26;
            label2.Text = "Modelo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Subheading", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 146);
            label3.Name = "label3";
            label3.Size = new Size(50, 21);
            label3.TabIndex = 28;
            label3.Text = "Precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Subheading", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 116);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 27;
            label4.Text = "Marca";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Subheading", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 204);
            label5.Name = "label5";
            label5.Size = new Size(46, 21);
            label5.TabIndex = 30;
            label5.Text = "Stock";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Subheading", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 174);
            label6.Name = "label6";
            label6.Size = new Size(73, 21);
            label6.TabIndex = 29;
            label6.Text = "Categoria";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(25, 25, 25);
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(827, 28);
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // grpProcesador
            // 
            grpProcesador.Controls.Add(label10);
            grpProcesador.Controls.Add(label11);
            grpProcesador.Controls.Add(label12);
            grpProcesador.Controls.Add(txtProcesadorSocket);
            grpProcesador.Controls.Add(txtProcesadorNucleos);
            grpProcesador.Controls.Add(txtProcesadorFrecuencia);
            grpProcesador.Location = new Point(297, 59);
            grpProcesador.Name = "grpProcesador";
            grpProcesador.Size = new Size(252, 133);
            grpProcesador.TabIndex = 10;
            grpProcesador.TabStop = false;
            grpProcesador.Text = "Procesador";
            grpProcesador.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Sitka Subheading", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(6, 86);
            label10.Name = "label10";
            label10.Size = new Size(53, 21);
            label10.TabIndex = 39;
            label10.Text = "Socket";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Sitka Subheading", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(6, 56);
            label11.Name = "label11";
            label11.Size = new Size(81, 21);
            label11.TabIndex = 38;
            label11.Text = "Frecuencia";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Sitka Subheading", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(6, 28);
            label12.Name = "label12";
            label12.Size = new Size(55, 21);
            label12.TabIndex = 37;
            label12.Text = "Nucleo";
            // 
            // FrmCrearProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 355);
            Controls.Add(grpMemoriaRam);
            Controls.Add(grpVideo);
            Controls.Add(label5);
            Controls.Add(grpProcesador);
            Controls.Add(label6);
            Controls.Add(grpNotebook);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnMinimizar);
            Controls.Add(btnCerrar);
            Controls.Add(btnCrear);
            Controls.Add(btnSalir);
            Controls.Add(cmbTipoDeProducto);
            Controls.Add(txtCategoria);
            Controls.Add(txtMarca);
            Controls.Add(txtModelo);
            Controls.Add(txtStock);
            Controls.Add(txtPrecio);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCrearProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCrearProducto";
            Load += FrmCrearProducto_Load;
            grpMemoriaRam.ResumeLayout(false);
            grpMemoriaRam.PerformLayout();
            grpVideo.ResumeLayout(false);
            grpVideo.PerformLayout();
            grpNotebook.ResumeLayout(false);
            grpNotebook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grpProcesador.ResumeLayout(false);
            grpProcesador.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPrecio;
        private TextBox txtStock;
        private TextBox txtModelo;
        private TextBox txtCategoria;
        private TextBox txtMarca;
        private ComboBox cmbTipoDeProducto;
        private GroupBox grpMemoriaRam;
        private TextBox txtRamVelocidad;
        private TextBox txtRamTecnologia;
        private TextBox txtRamMemoria;
        private TextBox txtProcesadorSocket;
        private TextBox txtProcesadorFrecuencia;
        private TextBox txtProcesadorNucleos;
        private GroupBox grpVideo;
        private TextBox txtVideoEnergia;
        private TextBox txtVideoChipset;
        private TextBox txtVideoMemoria;
        private GroupBox grpNotebook;
        private TextBox txtNotebookProcesador;
        private TextBox txtNotebookAlmacenamiento;
        private TextBox txtNotebookRam;
        private Button btnSalir;
        private Button btnCrear;
        private Button btnMinimizar;
        private Button btnCerrar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private GroupBox grpProcesador;
        private Label label10;
        private Label label11;
        private Label label12;
    }
}