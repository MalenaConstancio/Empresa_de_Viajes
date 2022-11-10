using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neoris_Empresa_de_Viajes
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }


        //METODOS----------------------------------------------------------->

        private Form activeForm = null;
        private void AbrirForm(Form form)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = form;
            form.TopLevel = false;
            pnlPrincipal.Controls.Add(form);
            pnlPrincipal.Tag = form;
            form.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Form dashboard = new frmDashboard();
            AbrirForm(dashboard);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Form clientes = new frmClientes();
            AbrirForm(clientes);

        }

        private void btnPaquetes_Click(object sender, EventArgs e)
        {
            Form paquetes = new frmPaquetes();
            AbrirForm(paquetes);
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            Form facturas = new frmFacturas();
            AbrirForm(facturas);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
