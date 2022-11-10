
namespace Neoris_Empresa_de_Viajes
{
    partial class frmPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsuarioLogueado = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnPaquetes = new System.Windows.Forms.Button();
            this.btnFacturas = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.lblUsuarioLogueado);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 205);
            this.panel1.TabIndex = 0;
            // 
            // lblUsuarioLogueado
            // 
            this.lblUsuarioLogueado.AutoSize = true;
            this.lblUsuarioLogueado.Location = new System.Drawing.Point(39, 174);
            this.lblUsuarioLogueado.Name = "lblUsuarioLogueado";
            this.lblUsuarioLogueado.Size = new System.Drawing.Size(124, 16);
            this.lblUsuarioLogueado.TabIndex = 1;
            this.lblUsuarioLogueado.Text = "Usuario Logueado";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Controls.Add(this.btnClientes);
            this.panel2.Controls.Add(this.btnPaquetes);
            this.panel2.Controls.Add(this.btnFacturas);
            this.panel2.Controls.Add(this.btnDashboard);
            this.panel2.Location = new System.Drawing.Point(0, 210);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 473);
            this.panel2.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Coral;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(0, 424);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(190, 49);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Location = new System.Drawing.Point(196, 12);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(776, 660);
            this.pnlPrincipal.TabIndex = 1;
            // 
            // btnClientes
            // 
            this.btnClientes.ForeColor = System.Drawing.Color.DimGray;
            this.btnClientes.Image = global::Neoris_Empresa_de_Viajes.Properties.Resources.clients;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 56);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnClientes.Size = new System.Drawing.Size(190, 49);
            this.btnClientes.TabIndex = 3;
            this.btnClientes.Text = "CLIENTES";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnPaquetes
            // 
            this.btnPaquetes.ForeColor = System.Drawing.Color.DimGray;
            this.btnPaquetes.Image = global::Neoris_Empresa_de_Viajes.Properties.Resources.paquetes;
            this.btnPaquetes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaquetes.Location = new System.Drawing.Point(0, 111);
            this.btnPaquetes.Name = "btnPaquetes";
            this.btnPaquetes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPaquetes.Size = new System.Drawing.Size(190, 49);
            this.btnPaquetes.TabIndex = 2;
            this.btnPaquetes.Text = "PAQUETES";
            this.btnPaquetes.UseVisualStyleBackColor = true;
            this.btnPaquetes.Click += new System.EventHandler(this.btnPaquetes_Click);
            // 
            // btnFacturas
            // 
            this.btnFacturas.ForeColor = System.Drawing.Color.DimGray;
            this.btnFacturas.Image = global::Neoris_Empresa_de_Viajes.Properties.Resources.factura;
            this.btnFacturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturas.Location = new System.Drawing.Point(0, 166);
            this.btnFacturas.Name = "btnFacturas";
            this.btnFacturas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFacturas.Size = new System.Drawing.Size(190, 49);
            this.btnFacturas.TabIndex = 1;
            this.btnFacturas.Text = "FACTURAS";
            this.btnFacturas.UseVisualStyleBackColor = true;
            this.btnFacturas.Click += new System.EventHandler(this.btnFacturas_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.ForeColor = System.Drawing.Color.DimGray;
            this.btnDashboard.Image = global::Neoris_Empresa_de_Viajes.Properties.Resources.monitor;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 1);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(190, 49);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "DASHBOARD";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Neoris_Empresa_de_Viajes.Properties.Resources.usuario;
            this.pictureBox1.Location = new System.Drawing.Point(22, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 132);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 684);
            this.ControlBox = false;
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUsuarioLogueado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnPaquetes;
        private System.Windows.Forms.Button btnFacturas;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel pnlPrincipal;
    }
}