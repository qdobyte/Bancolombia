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
        public CreditosForm()
        {
            InitializeComponent();
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
    }
}
