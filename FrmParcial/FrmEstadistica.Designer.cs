namespace FrmParcial
{
    partial class FrmEstadistica
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGananciaTotal = new System.Windows.Forms.Label();
            this.lblCantidadVentas = new System.Windows.Forms.Label();
            this.dgvEstadistica = new System.Windows.Forms.DataGridView();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPromedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadistica)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(98, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ventas Realizadas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(421, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ganancia Total";
            // 
            // lblGananciaTotal
            // 
            this.lblGananciaTotal.AutoSize = true;
            this.lblGananciaTotal.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGananciaTotal.Location = new System.Drawing.Point(421, 102);
            this.lblGananciaTotal.Name = "lblGananciaTotal";
            this.lblGananciaTotal.Size = new System.Drawing.Size(96, 20);
            this.lblGananciaTotal.TabIndex = 4;
            this.lblGananciaTotal.Text = "Ganancia Total";
            // 
            // lblCantidadVentas
            // 
            this.lblCantidadVentas.AutoSize = true;
            this.lblCantidadVentas.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCantidadVentas.Location = new System.Drawing.Point(98, 102);
            this.lblCantidadVentas.Name = "lblCantidadVentas";
            this.lblCantidadVentas.Size = new System.Drawing.Size(110, 20);
            this.lblCantidadVentas.TabIndex = 5;
            this.lblCantidadVentas.Text = "Ventas Realizadas";
            // 
            // dgvEstadistica
            // 
            this.dgvEstadistica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstadistica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCantidad,
            this.colCategoria,
            this.colPromedio});
            this.dgvEstadistica.Location = new System.Drawing.Point(125, 200);
            this.dgvEstadistica.Name = "dgvEstadistica";
            this.dgvEstadistica.RowTemplate.Height = 25;
            this.dgvEstadistica.Size = new System.Drawing.Size(343, 150);
            this.dgvEstadistica.TabIndex = 6;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad Vendidos";
            this.colCantidad.Name = "colCantidad";
            // 
            // colCategoria
            // 
            this.colCategoria.HeaderText = "Categoria";
            this.colCategoria.Name = "colCategoria";
            // 
            // colPromedio
            // 
            this.colPromedio.HeaderText = "Ganancia del Tag";
            this.colPromedio.Name = "colPromedio";
            // 
            // FrmEstadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 390);
            this.Controls.Add(this.dgvEstadistica);
            this.Controls.Add(this.lblCantidadVentas);
            this.Controls.Add(this.lblGananciaTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "FrmEstadistica";
            this.Text = "FrmEstadistica";
            this.Load += new System.EventHandler(this.FrmEstadistica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadistica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label4;
        private Label lblGananciaTotal;
        private Label lblCantidadVentas;
        private DataGridView dgvEstadistica;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colCategoria;
        private DataGridViewTextBoxColumn colPromedio;
    }
}