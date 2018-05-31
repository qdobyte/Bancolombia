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
    public partial class CreditosForm : Form
    {
        protected string cedula;
        public CreditosForm()
        {
            InitializeComponent();
            btnCreditosDesembolsar.Enabled = false;
            dropCreditosProducto.Hide();
            txtCreditosMonto.Hide();
            txtCreditosPlazo.Hide();
            CreditCard.Visible = true;
            CreditCardListar.Visible = false;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ClientesForm clientesForm = new ClientesForm();
            clientesForm.Visible = true;
            this.Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCloseUserMessage_Click(object sender, EventArgs e)
        {
            lblUserMessage.Text = "";
            btnCloseUserMessage.Hide();
        }

        private void MostrarMensaje(string mensaje)
        {
            lblUserMessage.Text = mensaje;
            btnCloseUserMessage.Show();
        }

        private void OcultarCards() {
            CreditCard.Visible = false;
            CreditCardListar.Visible = false;
        }

        private void btnViabilidadCliente_Click(object sender, EventArgs e)
        {
            string cedula, response, mensaje;
            cedula = txtCreditosCedula.Text.ToString();
            OcultarCards();
            CreditCard.Visible = true;

            if (cedula != "") {
                btnCreditosDesembolsar.Enabled = false;
                dropCreditosProducto.Hide();
                txtCreditosMonto.Hide();
                txtCreditosPlazo.Hide();

                BackendWebService.WebServiceSoapClient backend = new BackendWebService.WebServiceSoapClient();
                response = backend.ValidarViabilidadCredito(cedula);

                switch (response)
                {
                    case "flujoCajaNegativo":
                        mensaje = "El cliente tiene flujo de caja negativo";
                        break;
                    case "capacidadEndeudamiento":
                        mensaje = "La capacidad de endeudamiento debe ser superior al 20%";
                        break;
                    case "mayor15vecesSalario":
                        mensaje = "Las deudas del cliente superan 15 veces su salario";
                        break;
                    case "aprobado":
                        mensaje = "El credito puede ser desembolsado, proceda a crearlo";
                        btnCreditosDesembolsar.Enabled = true;
                        dropCreditosProducto.Show();
                        txtCreditosMonto.Show();
                        txtCreditosPlazo.Show();
                        this.cedula = cedula;
                        break;
                    default:
                        mensaje = response;
                        break;
                }
            }
            else
            {
                mensaje = "Por favor ingrese una cédula";
                txtCreditosCedula.LineIdleColor = Color.FromArgb(235, 26, 45);
            }


            this.MostrarMensaje(mensaje);
        }

        private void btnCreditosDesembolsar_Click(object sender, EventArgs e)
        {
            string cedula, producto, response;
            int monto, plazo;

            OcultarCards();
            CreditCard.Visible = true;

            cedula = this.cedula;
            producto = dropCreditosProducto.selectedValue;
            monto = Convert.ToInt32(txtCreditosMonto.Text.ToString());
            plazo = Convert.ToInt32(txtCreditosPlazo.Text.ToString());

            BackendWebService.WebServiceSoapClient backend = new BackendWebService.WebServiceSoapClient();
            response = backend.InsertarCredito(producto, plazo, monto, cedula);

            if (response == "creado")
            {
                this.MostrarMensaje("El crédito ha sido creado para el usuario: " + cedula);
                btnCreditosDesembolsar.Enabled = false;
                txtCreditosCedula.Text = "";
                txtCreditosMonto.Text = "";
                txtCreditosPlazo.Text = "";
            }
            else {
                this.MostrarMensaje(response);
            }
        }
        public void btnCreditosListar_Click(object sender, EventArgs e) {
            OcultarCards();
            CreditCard.Visible = true;
            CreditCardListar.Visible = true;
        }

    }
}
