using Entidades;
using Negocio.Implementaciones;
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
    public partial class frmPaquetes : Form
    {
        public frmPaquetes()
        {
            InitializeComponent();
        }

        PaqueteNegocio pneg = new PaqueteNegocio();

        //Metodos
        #region
        private void limpiarCampos()
        {

            txtNombrePaquete.Text = "";
            txtPrecio.Text = "";
            txtDuracion.Text = "";
            txtLugar.Text = "";
            chbxVigente.Checked = false;
        }


        #endregion

        //Eventos
        #region
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }



       

        private void btnAceptarPaquete_Click(object sender, EventArgs e)
        {
            //faltan los sp para insertar paquete y detalle
            //falta configurar el dgview con los detalles a medida que se agregan


            if (dgvDetalles.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un lugar...", "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            Paquete oPaquete = new Paquete();
            oPaquete.IdPaquete = pneg.proximoIdPaquete();
            oPaquete.NombrePaquete = txtNombrePaquete.Text;
            oPaquete.Precio = Convert.ToDecimal(txtPrecio.Text);
            oPaquete.FechaSalida = dtSalida.Value;
            oPaquete.OTipoPaquete.IdTipoPaquete =(int) cbTipoPaquete.SelectedValue;
            if (chbxVigente.Checked)
            {
                oPaquete.EstaVigente = true;
            }
            else {
                oPaquete.EstaVigente = false;
            }
            oPaquete.Duracion = oPaquete.calcularDuracion();
            txtDuracion.Text= oPaquete.calcularDuracion().ToString();


            if (pneg.insertPaquete(oPaquete)!=0)
            {

                MessageBox.Show("El paquete se guardo exitosamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarCampos();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Error el paquete no se guardo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiarCampos();
                return;
            }

        }

        private void btnCancelarPaquete_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void btnAgregarLugar_Click(object sender, EventArgs e)
        {



        }


        #endregion
    }
}
