
namespace Neoris_Empresa_de_Viajes
{
    partial class frmPaquetes
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.chbxVigencia = new System.Windows.Forms.GroupBox();
            this.dtSalida = new System.Windows.Forms.DateTimePicker();
            this.chbxVigente = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCancelarPaquete = new System.Windows.Forms.Button();
            this.btnAceptarPaquete = new System.Windows.Forms.Button();
            this.txtNombrePaquete = new System.Windows.Forms.TextBox();
            this.cbTipoPaquete = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxLugares = new System.Windows.Forms.GroupBox();
            this.cbProvincia = new System.Windows.Forms.ComboBox();
            this.cbPais = new System.Windows.Forms.ComboBox();
            this.btnAgregarLugar = new System.Windows.Forms.Button();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbCiudad = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCantidadDias = new System.Windows.Forms.TextBox();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.Lugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.País = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estadia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acción = new System.Windows.Forms.DataGridViewButtonColumn();
            this.chbxVigencia.SuspendLayout();
            this.gbxLugares.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(191, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "PAQUETES";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Coral;
            this.btnSalir.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(541, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(20, 20);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // chbxVigencia
            // 
            this.chbxVigencia.Controls.Add(this.dtSalida);
            this.chbxVigencia.Controls.Add(this.chbxVigente);
            this.chbxVigencia.Controls.Add(this.label12);
            this.chbxVigencia.Controls.Add(this.btnAceptarPaquete);
            this.chbxVigencia.Controls.Add(this.txtNombrePaquete);
            this.chbxVigencia.Controls.Add(this.cbTipoPaquete);
            this.chbxVigencia.Controls.Add(this.label9);
            this.chbxVigencia.Controls.Add(this.btnCancelarPaquete);
            this.chbxVigencia.Controls.Add(this.label8);
            this.chbxVigencia.Controls.Add(this.txtPrecio);
            this.chbxVigencia.Controls.Add(this.label4);
            this.chbxVigencia.Controls.Add(this.label3);
            this.chbxVigencia.Controls.Add(this.txtDuracion);
            this.chbxVigencia.Controls.Add(this.label2);
            this.chbxVigencia.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxVigencia.ForeColor = System.Drawing.Color.DimGray;
            this.chbxVigencia.Location = new System.Drawing.Point(12, 51);
            this.chbxVigencia.Name = "chbxVigencia";
            this.chbxVigencia.Size = new System.Drawing.Size(549, 147);
            this.chbxVigencia.TabIndex = 14;
            this.chbxVigencia.TabStop = false;
            this.chbxVigencia.Text = "Datos del Paquete";
            // 
            // dtSalida
            // 
            this.dtSalida.CustomFormat = "\"dd-MM-yyyy\"";
            this.dtSalida.Location = new System.Drawing.Point(350, 65);
            this.dtSalida.MinDate = new System.DateTime(2022, 11, 10, 0, 0, 0, 0);
            this.dtSalida.Name = "dtSalida";
            this.dtSalida.Size = new System.Drawing.Size(162, 23);
            this.dtSalida.TabIndex = 27;
            // 
            // chbxVigente
            // 
            this.chbxVigente.AutoSize = true;
            this.chbxVigente.Location = new System.Drawing.Point(350, 94);
            this.chbxVigente.Name = "chbxVigente";
            this.chbxVigente.Size = new System.Drawing.Size(77, 20);
            this.chbxVigente.TabIndex = 26;
            this.chbxVigente.Text = "Vigente";
            this.chbxVigente.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(283, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 16);
            this.label12.TabIndex = 25;
            this.label12.Text = "Tipo :";
            // 
            // btnCancelarPaquete
            // 
            this.btnCancelarPaquete.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancelarPaquete.ForeColor = System.Drawing.Color.White;
            this.btnCancelarPaquete.Location = new System.Drawing.Point(466, 118);
            this.btnCancelarPaquete.Name = "btnCancelarPaquete";
            this.btnCancelarPaquete.Size = new System.Drawing.Size(77, 23);
            this.btnCancelarPaquete.TabIndex = 24;
            this.btnCancelarPaquete.Text = "CANCELAR";
            this.btnCancelarPaquete.UseVisualStyleBackColor = false;
            this.btnCancelarPaquete.Click += new System.EventHandler(this.btnCancelarPaquete_Click);
            // 
            // btnAceptarPaquete
            // 
            this.btnAceptarPaquete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAceptarPaquete.ForeColor = System.Drawing.Color.White;
            this.btnAceptarPaquete.Location = new System.Drawing.Point(380, 118);
            this.btnAceptarPaquete.Name = "btnAceptarPaquete";
            this.btnAceptarPaquete.Size = new System.Drawing.Size(80, 23);
            this.btnAceptarPaquete.TabIndex = 23;
            this.btnAceptarPaquete.Text = "ACEPTAR";
            this.btnAceptarPaquete.UseVisualStyleBackColor = false;
            this.btnAceptarPaquete.Click += new System.EventHandler(this.btnAceptarPaquete_Click);
            // 
            // txtNombrePaquete
            // 
            this.txtNombrePaquete.Location = new System.Drawing.Point(97, 36);
            this.txtNombrePaquete.Name = "txtNombrePaquete";
            this.txtNombrePaquete.Size = new System.Drawing.Size(147, 23);
            this.txtNombrePaquete.TabIndex = 22;
            // 
            // cbTipoPaquete
            // 
            this.cbTipoPaquete.FormattingEnabled = true;
            this.cbTipoPaquete.Location = new System.Drawing.Point(350, 35);
            this.cbTipoPaquete.Name = "cbTipoPaquete";
            this.cbTipoPaquete.Size = new System.Drawing.Size(162, 24);
            this.cbTipoPaquete.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(283, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 16);
            this.label9.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(283, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Salida :";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(97, 65);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(147, 23);
            this.txtPrecio.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Precio :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre  :";
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(97, 93);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.ReadOnly = true;
            this.txtDuracion.Size = new System.Drawing.Size(147, 23);
            this.txtDuracion.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Duración :";
            // 
            // gbxLugares
            // 
            this.gbxLugares.Controls.Add(this.txtCantidadDias);
            this.gbxLugares.Controls.Add(this.label7);
            this.gbxLugares.Controls.Add(this.label5);
            this.gbxLugares.Controls.Add(this.cbCiudad);
            this.gbxLugares.Controls.Add(this.cbProvincia);
            this.gbxLugares.Controls.Add(this.cbPais);
            this.gbxLugares.Controls.Add(this.btnAgregarLugar);
            this.gbxLugares.Controls.Add(this.txtLugar);
            this.gbxLugares.Controls.Add(this.label6);
            this.gbxLugares.Controls.Add(this.label10);
            this.gbxLugares.Controls.Add(this.label11);
            this.gbxLugares.Controls.Add(this.label13);
            this.gbxLugares.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxLugares.ForeColor = System.Drawing.Color.DimGray;
            this.gbxLugares.Location = new System.Drawing.Point(12, 204);
            this.gbxLugares.Name = "gbxLugares";
            this.gbxLugares.Size = new System.Drawing.Size(549, 152);
            this.gbxLugares.TabIndex = 27;
            this.gbxLugares.TabStop = false;
            this.gbxLugares.Text = "Agregar lugares al paquete";
            // 
            // cbProvincia
            // 
            this.cbProvincia.FormattingEnabled = true;
            this.cbProvincia.Location = new System.Drawing.Point(250, 62);
            this.cbProvincia.Name = "cbProvincia";
            this.cbProvincia.Size = new System.Drawing.Size(91, 24);
            this.cbProvincia.TabIndex = 29;
            // 
            // cbPais
            // 
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Location = new System.Drawing.Point(76, 62);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(84, 24);
            this.cbPais.TabIndex = 28;
            // 
            // btnAgregarLugar
            // 
            this.btnAgregarLugar.BackColor = System.Drawing.Color.Orange;
            this.btnAgregarLugar.ForeColor = System.Drawing.Color.White;
            this.btnAgregarLugar.Location = new System.Drawing.Point(76, 121);
            this.btnAgregarLugar.Name = "btnAgregarLugar";
            this.btnAgregarLugar.Size = new System.Drawing.Size(436, 23);
            this.btnAgregarLugar.TabIndex = 27;
            this.btnAgregarLugar.Text = "AGREGAR";
            this.btnAgregarLugar.UseVisualStyleBackColor = false;
            this.btnAgregarLugar.Click += new System.EventHandler(this.btnAgregarLugar_Click);
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(76, 33);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(436, 23);
            this.txtLugar.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(266, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "País :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 16);
            this.label11.TabIndex = 5;
            this.label11.Text = "Lugar  :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(166, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Provincia :";
            // 
            // cbCiudad
            // 
            this.cbCiudad.FormattingEnabled = true;
            this.cbCiudad.Location = new System.Drawing.Point(416, 62);
            this.cbCiudad.Name = "cbCiudad";
            this.cbCiudad.Size = new System.Drawing.Size(96, 24);
            this.cbCiudad.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Ciudad :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Días :";
            // 
            // txtCantidadDias
            // 
            this.txtCantidadDias.Location = new System.Drawing.Point(76, 92);
            this.txtCantidadDias.Name = "txtCantidadDias";
            this.txtCantidadDias.Size = new System.Drawing.Size(84, 23);
            this.txtCantidadDias.TabIndex = 28;
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lugar,
            this.Ciudad,
            this.Provincia,
            this.País,
            this.Estadia,
            this.Acción});
            this.dgvDetalles.Location = new System.Drawing.Point(12, 362);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvDetalles.Size = new System.Drawing.Size(549, 130);
            this.dgvDetalles.TabIndex = 28;
            // 
            // Lugar
            // 
            this.Lugar.HeaderText = "Lugar";
            this.Lugar.Name = "Lugar";
            this.Lugar.ReadOnly = true;
            // 
            // Ciudad
            // 
            this.Ciudad.HeaderText = "Ciudad";
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.ReadOnly = true;
            // 
            // Provincia
            // 
            this.Provincia.HeaderText = "Provincia";
            this.Provincia.Name = "Provincia";
            this.Provincia.ReadOnly = true;
            // 
            // País
            // 
            this.País.HeaderText = "País";
            this.País.Name = "País";
            this.País.ReadOnly = true;
            // 
            // Estadia
            // 
            this.Estadia.HeaderText = "Estadia";
            this.Estadia.Name = "Estadia";
            // 
            // Acción
            // 
            this.Acción.HeaderText = "Acción";
            this.Acción.Name = "Acción";
            // 
            // frmPaquetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(573, 504);
            this.ControlBox = false;
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.gbxLugares);
            this.Controls.Add(this.chbxVigencia);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Name = "frmPaquetes";
            this.chbxVigencia.ResumeLayout(false);
            this.chbxVigencia.PerformLayout();
            this.gbxLugares.ResumeLayout(false);
            this.gbxLugares.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox chbxVigencia;
        private System.Windows.Forms.CheckBox chbxVigente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCancelarPaquete;
        private System.Windows.Forms.Button btnAceptarPaquete;
        private System.Windows.Forms.TextBox txtNombrePaquete;
        private System.Windows.Forms.ComboBox cbTipoPaquete;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbxLugares;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnAgregarLugar;
        private System.Windows.Forms.ComboBox cbProvincia;
        private System.Windows.Forms.ComboBox cbPais;
        private System.Windows.Forms.DateTimePicker dtSalida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCiudad;
        private System.Windows.Forms.TextBox txtCantidadDias;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lugar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn País;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estadia;
        private System.Windows.Forms.DataGridViewButtonColumn Acción;
    }
}