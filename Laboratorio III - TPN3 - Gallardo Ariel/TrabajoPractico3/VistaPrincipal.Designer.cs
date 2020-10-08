namespace TrabajoPractico3
{
    partial class VistaPrincipal
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
            this.DGVCiudad = new System.Windows.Forms.DataGridView();
            this.DGVPais = new System.Windows.Forms.DataGridView();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.TB_C_Ciudad = new System.Windows.Forms.TextBox();
            this.TB_C_Poblacion = new System.Windows.Forms.TextBox();
            this.LabPoblacion = new System.Windows.Forms.Label();
            this.LabCiudad = new System.Windows.Forms.Label();
            this.BtnCrear = new System.Windows.Forms.Button();
            this.CB_B_Ciudad = new System.Windows.Forms.CheckBox();
            this.CB_B_Pais = new System.Windows.Forms.CheckBox();
            this.CB_B_Poblacion = new System.Windows.Forms.CheckBox();
            this.TB_B_Ciudad = new System.Windows.Forms.TextBox();
            this.TB_B_Pais = new System.Windows.Forms.TextBox();
            this.TB_B_Poblacion = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCiudad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPais)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVCiudad
            // 
            this.DGVCiudad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVCiudad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCiudad.Location = new System.Drawing.Point(13, 107);
            this.DGVCiudad.MultiSelect = false;
            this.DGVCiudad.Name = "DGVCiudad";
            this.DGVCiudad.ReadOnly = true;
            this.DGVCiudad.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGVCiudad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVCiudad.Size = new System.Drawing.Size(401, 455);
            this.DGVCiudad.TabIndex = 0;
            this.DGVCiudad.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCiudad_CellClick);
            // 
            // DGVPais
            // 
            this.DGVPais.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVPais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPais.Location = new System.Drawing.Point(431, 107);
            this.DGVPais.MultiSelect = false;
            this.DGVPais.Name = "DGVPais";
            this.DGVPais.ReadOnly = true;
            this.DGVPais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVPais.Size = new System.Drawing.Size(290, 455);
            this.DGVPais.TabIndex = 1;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(431, 20);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(76, 23);
            this.BtnActualizar.TabIndex = 2;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(431, 44);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(76, 23);
            this.BtnEliminar.TabIndex = 3;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // TB_C_Ciudad
            // 
            this.TB_C_Ciudad.Location = new System.Drawing.Point(563, 36);
            this.TB_C_Ciudad.Name = "TB_C_Ciudad";
            this.TB_C_Ciudad.Size = new System.Drawing.Size(156, 20);
            this.TB_C_Ciudad.TabIndex = 5;
            // 
            // TB_C_Poblacion
            // 
            this.TB_C_Poblacion.Location = new System.Drawing.Point(563, 81);
            this.TB_C_Poblacion.Name = "TB_C_Poblacion";
            this.TB_C_Poblacion.Size = new System.Drawing.Size(156, 20);
            this.TB_C_Poblacion.TabIndex = 6;
            // 
            // LabPoblacion
            // 
            this.LabPoblacion.AutoSize = true;
            this.LabPoblacion.Location = new System.Drawing.Point(665, 65);
            this.LabPoblacion.Name = "LabPoblacion";
            this.LabPoblacion.Size = new System.Drawing.Size(54, 13);
            this.LabPoblacion.TabIndex = 7;
            this.LabPoblacion.Text = "Poblacion";
            // 
            // LabCiudad
            // 
            this.LabCiudad.AutoSize = true;
            this.LabCiudad.Location = new System.Drawing.Point(623, 20);
            this.LabCiudad.Name = "LabCiudad";
            this.LabCiudad.Size = new System.Drawing.Size(95, 13);
            this.LabCiudad.TabIndex = 8;
            this.LabCiudad.Text = "Nombre de Ciudad";
            // 
            // BtnCrear
            // 
            this.BtnCrear.Location = new System.Drawing.Point(431, 69);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Size = new System.Drawing.Size(76, 23);
            this.BtnCrear.TabIndex = 9;
            this.BtnCrear.Text = "Crear";
            this.BtnCrear.UseVisualStyleBackColor = true;
            this.BtnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // CB_B_Ciudad
            // 
            this.CB_B_Ciudad.AutoSize = true;
            this.CB_B_Ciudad.Location = new System.Drawing.Point(149, 15);
            this.CB_B_Ciudad.Name = "CB_B_Ciudad";
            this.CB_B_Ciudad.Size = new System.Drawing.Size(59, 17);
            this.CB_B_Ciudad.TabIndex = 10;
            this.CB_B_Ciudad.Text = "Ciudad";
            this.CB_B_Ciudad.UseVisualStyleBackColor = true;
            this.CB_B_Ciudad.CheckedChanged += new System.EventHandler(this.cB_b_Ciudad_CheckedChanged);
            // 
            // CB_B_Pais
            // 
            this.CB_B_Pais.AutoSize = true;
            this.CB_B_Pais.Location = new System.Drawing.Point(149, 46);
            this.CB_B_Pais.Name = "CB_B_Pais";
            this.CB_B_Pais.Size = new System.Drawing.Size(46, 17);
            this.CB_B_Pais.TabIndex = 11;
            this.CB_B_Pais.Text = "Pais";
            this.CB_B_Pais.UseVisualStyleBackColor = true;
            this.CB_B_Pais.CheckedChanged += new System.EventHandler(this.cB_b_Pais_CheckedChanged);
            // 
            // CB_B_Poblacion
            // 
            this.CB_B_Poblacion.AutoSize = true;
            this.CB_B_Poblacion.Location = new System.Drawing.Point(149, 74);
            this.CB_B_Poblacion.Name = "CB_B_Poblacion";
            this.CB_B_Poblacion.Size = new System.Drawing.Size(73, 17);
            this.CB_B_Poblacion.TabIndex = 12;
            this.CB_B_Poblacion.Text = "Poblacion";
            this.CB_B_Poblacion.UseVisualStyleBackColor = true;
            this.CB_B_Poblacion.CheckedChanged += new System.EventHandler(this.cB_b_Poblacion_CheckedChanged);
            // 
            // TB_B_Ciudad
            // 
            this.TB_B_Ciudad.Enabled = false;
            this.TB_B_Ciudad.Location = new System.Drawing.Point(13, 13);
            this.TB_B_Ciudad.Name = "TB_B_Ciudad";
            this.TB_B_Ciudad.Size = new System.Drawing.Size(130, 20);
            this.TB_B_Ciudad.TabIndex = 13;
            // 
            // TB_B_Pais
            // 
            this.TB_B_Pais.Enabled = false;
            this.TB_B_Pais.Location = new System.Drawing.Point(13, 43);
            this.TB_B_Pais.Name = "TB_B_Pais";
            this.TB_B_Pais.Size = new System.Drawing.Size(130, 20);
            this.TB_B_Pais.TabIndex = 14;
            // 
            // TB_B_Poblacion
            // 
            this.TB_B_Poblacion.Enabled = false;
            this.TB_B_Poblacion.Location = new System.Drawing.Point(13, 73);
            this.TB_B_Poblacion.Name = "TB_B_Poblacion";
            this.TB_B_Poblacion.Size = new System.Drawing.Size(130, 20);
            this.TB_B_Poblacion.TabIndex = 15;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(225, 9);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(59, 82);
            this.BtnBuscar.TabIndex = 16;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // VistaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 574);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TB_B_Poblacion);
            this.Controls.Add(this.TB_B_Pais);
            this.Controls.Add(this.TB_B_Ciudad);
            this.Controls.Add(this.CB_B_Poblacion);
            this.Controls.Add(this.CB_B_Pais);
            this.Controls.Add(this.CB_B_Ciudad);
            this.Controls.Add(this.BtnCrear);
            this.Controls.Add(this.LabCiudad);
            this.Controls.Add(this.LabPoblacion);
            this.Controls.Add(this.TB_C_Poblacion);
            this.Controls.Add(this.TB_C_Ciudad);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.DGVPais);
            this.Controls.Add(this.DGVCiudad);
            this.Name = "VistaPrincipal";
            this.Text = "Gestor de Ciudad";
            this.Load += new System.EventHandler(this.VistaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCiudad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVCiudad;
        private System.Windows.Forms.DataGridView DGVPais;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.TextBox TB_C_Ciudad;
        private System.Windows.Forms.TextBox TB_C_Poblacion;
        private System.Windows.Forms.Label LabPoblacion;
        private System.Windows.Forms.Label LabCiudad;
        private System.Windows.Forms.Button BtnCrear;
        private System.Windows.Forms.CheckBox CB_B_Ciudad;
        private System.Windows.Forms.CheckBox CB_B_Pais;
        private System.Windows.Forms.CheckBox CB_B_Poblacion;
        private System.Windows.Forms.TextBox TB_B_Ciudad;
        private System.Windows.Forms.TextBox TB_B_Pais;
        private System.Windows.Forms.TextBox TB_B_Poblacion;
        private System.Windows.Forms.Button BtnBuscar;
    }
}