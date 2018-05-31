using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEndWindowsForms
{
    public partial class FrontWindow : Form
    {
        public FrontWindow()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ClienteModel clienteModel;
            string cedula = txtCedula.Text.ToString();
            BackendWebService.WebServiceSoapClient backend = new BackendWebService.WebServiceSoapClient();
            
        }

        private void btnInsertarCliente_Click(object sender, EventArgs e)
        {
            string cedula, nombre, direccion, respuesta;
            int ingresos, egresos, pasivos, scoring;

            cedula = txtCedula.Text.ToString();
            nombre = txtCedula.Text.ToString();
            direccion = txtDireccion.Text.ToString();
            ingresos = Convert.ToInt32(txtIngresos.Text.ToString());
            egresos = Convert.ToInt32(txtEgresos.Text.ToString());
            pasivos = Convert.ToInt32(txtPasivos.Text.ToString());
            scoring = Convert.ToInt32(txtScoring.Text.ToString());

            BackendWebService.WebServiceSoapClient backend = new BackendWebService.WebServiceSoapClient();
            respuesta = backend.InsertarCliente(cedula, nombre, direccion, ingresos, egresos, pasivos, scoring);
            this.MostrarMensaje(respuesta);
            this.ReiniciarCampos();
        }

        private void btnCloseUserMessage_Click(object sender, EventArgs e)
        {
            lblUserMessage.Text = "";
            btnCloseUserMessage.Hide();
        }

        private void MostrarMensaje(string mensaje) {
            lblUserMessage.Text = mensaje;
            btnCloseUserMessage.Show();
        }

        private void ReiniciarCampos() {

            txtCedula.Text = "";
            txtCedula.Text = "";
            txtDireccion.Text = "";
            txtIngresos.Text = "";
            txtEgresos.Text = "";
            txtPasivos.Text = "";
            txtScoring.Text = "";
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            string cedula, response;
            cedula = txtCedula.Text.ToString();

            BackendWebService.WebServiceSoapClient backend = new BackendWebService.WebServiceSoapClient();
            response = backend.EliminarCliente(cedula);
            this.MostrarMensaje(response);
            this.ReiniciarCampos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
