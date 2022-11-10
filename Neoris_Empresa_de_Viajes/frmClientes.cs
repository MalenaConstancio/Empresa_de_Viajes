
using Entidades;
using Negocio;
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
    public partial class frmClientes : Form
    {

        IClienteNegocio cneg = new ClienteNegocio();
        

        public frmClientes()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }






        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Cliente oCliente = new Cliente();

            oCliente.Apellido = txtApellido.Text;
            oCliente.Nombre = txtNombre.Text;
            oCliente.Telefono = Convert.ToInt64(txtTelefono.Text);
            oCliente.Nacionalidad = txtNacionalidad.Text;
            oCliente.Calle = txtCalle.Text;
            oCliente.NroCalle=Convert.ToInt32(txtAltura.Text);

            Ciudad oCiudad = new Ciudad();
            oCiudad.IdCiudad= (int)cbCiudad.SelectedItem;
            oCiudad.IdProvincia= (int)cbProvincia.SelectedItem;
            oCiudad.IdPais = (int)cbPais.SelectedItem;
            oCliente.Ciudad=oCiudad;

            if (txtCuit.Text == "") { 
                oCliente.IdTipoCliente= 1;
            }
            if (txtDni.Text == "")
            {
                oCliente.IdTipoCliente = 2;
            }
            oCliente.RazonSocial = txtRazonSocial.Text;
            oCliente.Cuit= Convert.ToInt64(txtCuit.Text);
            oCliente.Dni= Convert.ToInt64(txtDni.Text);


            int filasAfectadas = cneg.insertCliente(oCliente);

            if (filasAfectadas > 0)
            {
                lblMensaje.Text = "Se agrego Cliente con exito!";
            }
            else {

                lblMensaje.Text = "No se pudo agregar Cliente!";
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Paises";
            DataTable paises = cneg.ObtenerTabla("Paises",query);
                cbPais.DataSource = paises;
                cbPais.ValueMember = paises.Columns[0].ToString();
                cbPais.DisplayMember = paises.Columns[1].ToString();
        }
    }
}
