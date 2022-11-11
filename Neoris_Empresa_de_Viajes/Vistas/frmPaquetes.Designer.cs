
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
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
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelarLugar = new System.Windows.Forms.Button();
            this.btnAceptarLugar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnAgregarLugar = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dtSalida = new System.Windows.Forms.DateTimePicker();
            this.chbxVigencia.SuspendLayout();
            this.gbxLugares.SuspendLayout();
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
            this.chbxVigencia.Controls.Add(this.checkBox1);
            this.chbxVigencia.Controls.Add(this.label12);
            this.chbxVigencia.Controls.Add(this.btnCancelarPaquete);
            this.chbxVigencia.Controls.Add(this.btnAceptarPaquete);
            this.chbxVigencia.Controls.Add(this.txtNombrePaquete);
            this.chbxVigencia.Controls.Add(this.cbTipoPaquete);
            this.chbxVigencia.Controls.Add(this.label9);
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
            this.chbxVigencia.Size = new System.Drawing.Size(549, 167);
            this.chbxVigencia.TabIndex = 14;
            this.chbxVigencia.TabStop = false;
            this.chbxVigencia.Text = "Datos del Paquete";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(407, 91);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 20);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "Vigente";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(289, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 16);
            this.label12.TabIndex = 25;
            this.label12.Text = "Tipo :";
            // 
            // btnCancelarPaquete
            // 
            this.btnCancelarPaquete.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancelarPaquete.ForeColor = System.Drawing.Color.White;
            this.btnCancelarPaquete.Location = new System.Drawing.Point(466, 138);
            this.btnCancelarPaquete.Name = "btnCancelarPaquete";
            this.btnCancelarPaquete.Size = new System.Drawing.Size(77, 23);
            this.btnCancelarPaquete.TabIndex = 24;
            this.btnCancelarPaquete.Text = "CANCELAR";
            this.btnCancelarPaquete.UseVisualStyleBackColor = false;
            // 
            // btnAceptarPaquete
            // 
            this.btnAceptarPaquete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAceptarPaquete.ForeColor = System.Drawing.Color.White;
            this.btnAceptarPaquete.Location = new System.Drawing.Point(380, 138);
            this.btnAceptarPaquete.Name = "btnAceptarPaquete";
            this.btnAceptarPaquete.Size = new System.Drawing.Size(80, 23);
            this.btnAceptarPaquete.TabIndex = 23;
            this.btnAceptarPaquete.Text = "ACEPTAR";
            this.btnAceptarPaquete.UseVisualStyleBackColor = false;
            // 
            // txtNombrePaquete
            // 
            this.txtNombrePaquete.Location = new System.Drawing.Point(160, 32);
            this.txtNombrePaquete.Name = "txtNombrePaquete";
            this.txtNombrePaquete.Size = new System.Drawing.Size(100, 23);
            this.txtNombrePaquete.TabIndex = 22;
            // 
            // cbTipoPaquete
            // 
            this.cbTipoPaquete.FormattingEnabled = true;
            this.cbTipoPaquete.Location = new System.Drawing.Point(394, 32);
            this.cbTipoPaquete.Name = "cbTipoPaquete";
            this.cbTipoPaquete.Size = new System.Drawing.Size(100, 24);
            this.cbTipoPaquete.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(287, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 16);
            this.label9.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(287, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Salida :";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(160, 61);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 23);
            this.txtPrecio.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Precio :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre  :";
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(160, 90);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(100, 23);
            this.txtDuracion.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Duración :";
            // 
            // gbxLugares
            // 
            this.gbxLugares.Controls.Add(this.comboBox3);
            this.gbxLugares.Controls.Add(this.comboBox2);
            this.gbxLugares.Controls.Add(this.btnAgregarLugar);
            this.gbxLugares.Controls.Add(this.label5);
            this.gbxLugares.Controls.Add(this.btnCancelarLugar);
            this.gbxLugares.Controls.Add(this.btnAceptarLugar);
            this.gbxLugares.Controls.Add(this.textBox1);
            this.gbxLugares.Controls.Add(this.comboBox1);
            this.gbxLugares.Controls.Add(this.label6);
            this.gbxLugares.Controls.Add(this.label10);
            this.gbxLugares.Controls.Add(this.label11);
            this.gbxLugares.Controls.Add(this.label13);
            this.gbxLugares.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxLugares.ForeColor = System.Drawing.Color.DimGray;
            this.gbxLugares.Location = new System.Drawing.Point(12, 224);
            this.gbxLugares.Name = "gbxLugares";
            this.gbxLugares.Size = new System.Drawing.Size(549, 168);
            this.gbxLugares.TabIndex = 27;
            this.gbxLugares.TabStop = false;
            this.gbxLugares.Text = "Lugares incluidos en el Paquete";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Ciudad :";
            // 
            // btnCancelarLugar
            // 
            this.btnCancelarLugar.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancelarLugar.ForeColor = System.Drawing.Color.White;
            this.btnCancelarLugar.Location = new System.Drawing.Point(466, 138);
            this.btnCancelarLugar.Name = "btnCancelarLugar";
            this.btnCancelarLugar.Size = new System.Drawing.Size(77, 23);
            this.btnCancelarLugar.TabIndex = 24;
            this.btnCancelarLugar.Text = "CANCELAR";
            this.btnCancelarLugar.UseVisualStyleBackColor = false;
            // 
            // btnAceptarLugar
            // 
            this.btnAceptarLugar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAceptarLugar.ForeColor = System.Drawing.Color.White;
            this.btnAceptarLugar.Location = new System.Drawing.Point(380, 138);
            this.btnAceptarLugar.Name = "btnAceptarLugar";
            this.btnAceptarLugar.Size = new System.Drawing.Size(80, 23);
            this.btnAceptarLugar.TabIndex = 23;
            this.btnAceptarLugar.Text = "ACEPTAR";
            this.btnAceptarLugar.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 22;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(394, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 24);
            this.comboBox1.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "País :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 16);
            this.label11.TabIndex = 5;
            this.label11.Text = "Nombre  :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(49, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Provincia :";
            // 
            // btnAgregarLugar
            // 
            this.btnAgregarLugar.BackColor = System.Drawing.Color.Orange;
            this.btnAgregarLugar.ForeColor = System.Drawing.Color.White;
            this.btnAgregarLugar.Location = new System.Drawing.Point(52, 138);
            this.btnAgregarLugar.Name = "btnAgregarLugar";
            this.btnAgregarLugar.Size = new System.Drawing.Size(80, 23);
            this.btnAgregarLugar.TabIndex = 27;
            this.btnAgregarLugar.Text = "AGREGAR";
            this.btnAgregarLugar.UseVisualStyleBackColor = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(160, 61);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 24);
            this.comboBox2.TabIndex = 28;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(160, 91);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(100, 24);
            this.comboBox3.TabIndex = 29;
            // 
            // dtSalida
            // 
            this.dtSalida.CustomFormat = "\"dd-MM-yyyy\"";
            this.dtSalida.Location = new System.Drawing.Point(394, 62);
            this.dtSalida.MinDate = new System.DateTime(2022, 11, 10, 0, 0, 0, 0);
            this.dtSalida.Name = "dtSalida";
            this.dtSalida.Size = new System.Drawing.Size(100, 23);
            this.dtSalida.TabIndex = 27;
            // 
            // frmPaquetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(573, 504);
            this.ControlBox = false;
            this.Controls.Add(this.gbxLugares);
            this.Controls.Add(this.chbxVigencia);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Name = "frmPaquetes";
            this.chbxVigencia.ResumeLayout(false);
            this.chbxVigencia.PerformLayout();
            this.gbxLugares.ResumeLayout(false);
            this.gbxLugares.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox chbxVigencia;
        private System.Windows.Forms.CheckBox checkBox1;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelarLugar;
        private System.Windows.Forms.Button btnAceptarLugar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnAgregarLugar;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DateTimePicker dtSalida;
    }
}