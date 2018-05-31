using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;


namespace FrontEndWindowsForms
{
    public partial class ClientesForm : Form
    {
        public object JsonConvert { get; private set; }

        public ClientesForm()
        {
            InitializeComponent();
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

            txtClientCedula.Text = "";
            txtClientNombre.Text = "";
            txtClientDireccion.Text = "";
            txtClientIngresos.Text = "";
            txtClientEgresos.Text = "";
            txtClientPasivos.Text = "";
            txtClientScoring.Text = "";
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            string cedula, response;
            cedula = txtClientCedula.Text.ToString();

            BackendWebService.WebServiceSoapClient backend = new BackendWebService.WebServiceSoapClient();
            response = backend.EliminarCliente(cedula);
            this.MostrarMensaje(response);
            this.ReiniciarCampos();
        }

        private void btnInsertarCliente_Click(object sender, EventArgs e)
        {
            string cedula, nombre, direccion, respuesta;
            int ingresos, egresos, pasivos, scoring;

            cedula = txtClientCedula.Text.ToString();
            nombre = txtClientNombre.Text.ToString();
            direccion = txtClientDireccion.Text.ToString();
            ingresos = Convert.ToInt32(txtClientIngresos.Text.ToString());
            egresos = Convert.ToInt32(txtClientEgresos.Text.ToString());
            pasivos = Convert.ToInt32(txtClientPasivos.Text.ToString());
            scoring = Convert.ToInt32(txtClientScoring.Text.ToString());

            BackendWebService.WebServiceSoapClient backend = new BackendWebService.WebServiceSoapClient();
            respuesta = backend.InsertarCliente(cedula, nombre, direccion, ingresos, egresos, pasivos, scoring);
            this.MostrarMensaje(respuesta);
            this.ReiniciarCampos();
        }

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            string cedula, response;
            cedula = txtClientCedula.Text.ToString();

            BackendWebService.WebServiceSoapClient backend = new BackendWebService.WebServiceSoapClient();
            response = backend.ConsultarCliente(cedula);

            //Texto con formato JSON a Objeto JSON 
            JObject jObject = JObject.Parse(response);


            if ((jObject["Error"].ToString() != ""))
            {
                this.MostrarMensaje(jObject["Error"].ToString());
                this.ReiniciarCampos();
            }
            else {
                txtClientNombre.Text = jObject["Nombre"].ToString();
                txtClientDireccion.Text = jObject["Direccion"].ToString();
                txtClientIngresos.Text = jObject["Ingresos"].ToString();
                txtClientEgresos.Text = jObject["Egresos"].ToString();
                txtClientPasivos.Text = jObject["Pasivos"].ToString();
                txtClientScoring.Text = jObject["Scoring"].ToString();
                this.MostrarMensaje("Consulta ejecutada correctamente");
            }
            
            
        }

        private void btnCreditos_Click(object sender, EventArgs e)
        {
            CreditosForm creditosForm = new CreditosForm();
            creditosForm.Visible = true;
            this.Visible = false;
        }
    }
}
