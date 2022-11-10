﻿
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


        private void limpiarCampos() {

            txtAltura.Text = "";
            txtApellido.Text = "";
            txtCalle.Text = "";
            txtCuit.Text = "";
            txtDni.Text = "";
            txtNacionalidad.Text = "";
            txtNombre.Text = "";
            txtRazonSocial.Text = "";
            txtTelefono.Text = "";
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
            oCiudad.IdCiudad= (int)cbCiudad.SelectedValue;
            oCiudad.IdProvincia= (int)cbProvincia.SelectedValue;
            oCiudad.IdPais = (int)cbPais.SelectedValue;
            oCliente.Ciudad=oCiudad;

            if (txtCuit.Text == "") { 
                oCliente.IdTipoCliente= 1;
            }
            if (txtCuit.Text != "")
            {
                oCliente.IdTipoCliente = 2;
                oCliente.Cuit = Convert.ToInt64(txtCuit.Text);
            }
            oCliente.RazonSocial = txtRazonSocial.Text;
            oCliente.Dni= Convert.ToInt64(txtDni.Text);

            int filasAfectadas = cneg.insertCliente(oCliente);

            if (filasAfectadas == 0)
            {
                lblMensaje.Text = "No se pudo agregar Cliente!" ;
            }
            else {

                lblMensaje.Text = "Se agrego Cliente con exito!";
                limpiarCampos();
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            string queryPaises = "SELECT * FROM Paises";
            DataTable paises = cneg.ObtenerTabla("Paises", queryPaises);
                cbPais.DataSource = paises;
                cbPais.ValueMember = paises.Columns[0].ToString();
                cbPais.DisplayMember = paises.Columns[1].ToString();

            string queryCiudades = "SELECT * FROM Ciudades";
            DataTable ciudades = cneg.ObtenerTabla("Ciudades", queryCiudades);
            cbCiudad.DataSource = ciudades;
            cbCiudad.ValueMember = ciudades.Columns[0].ToString();
            cbCiudad.DisplayMember = ciudades.Columns[1].ToString();

            string queryProvincias = "SELECT * FROM Provincias";
            DataTable provincias = cneg.ObtenerTabla("Provincias", queryProvincias);
            cbProvincia.DataSource = provincias;
            cbProvincia.ValueMember = provincias.Columns[0].ToString();
            cbProvincia.DisplayMember = provincias.Columns[1].ToString();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}