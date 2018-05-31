namespace FrontEndWindowsForms
{
    partial class ClientesForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientesForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.header = new System.Windows.Forms.Panel();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.clientNavbar = new System.Windows.Forms.Panel();
            this.btnConsultarCliente = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEliminarCliente = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnInsertarCliente = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtPasivos = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtEgresos = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtIngresos = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtDireccion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtNombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtCedula = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.navbar = new System.Windows.Forms.Panel();
            this.bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
            this.btnSalir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCreditos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClientes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.btnCloseUserMessage = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblUserMessage = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.footer = new System.Windows.Forms.Panel();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCustomDataGrid2 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCards4 = new Bunifu.Framework.UI.BunifuCards();
            this.txtClientCedula = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtClientIngresos = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtClientPasivos = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtClientNombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblNombre = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel13 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtClientEgresos = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtClientDireccion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtClientScoring = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblDireccion = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel15 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.header.SuspendLayout();
            this.clientNavbar.SuspendLayout();
            this.navbar.SuspendLayout();
            this.bunifuCards3.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseUserMessage)).BeginInit();
            this.footer.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).BeginInit();
            this.bunifuCards4.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.White;
            this.header.Controls.Add(this.logoPanel);
            this.header.Controls.Add(this.clientNavbar);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(901, 78);
            this.header.TabIndex = 0;
            // 
            // logoPanel
            // 
            this.logoPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoPanel.BackgroundImage")));
            this.logoPanel.Location = new System.Drawing.Point(-5, -8);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(210, 85);
            this.logoPanel.TabIndex = 3;
            // 
            // clientNavbar
            // 
            this.clientNavbar.Controls.Add(this.btnConsultarCliente);
            this.clientNavbar.Controls.Add(this.btnEliminarCliente);
            this.clientNavbar.Controls.Add(this.btnInsertarCliente);
            this.clientNavbar.Location = new System.Drawing.Point(298, 12);
            this.clientNavbar.Name = "clientNavbar";
            this.clientNavbar.Size = new System.Drawing.Size(470, 60);
            this.clientNavbar.TabIndex = 6;
            // 
            // btnConsultarCliente
            // 
            this.btnConsultarCliente.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnConsultarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(143)))), ((int)(((byte)(185)))));
            this.btnConsultarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsultarCliente.BorderRadius = 0;
            this.btnConsultarCliente.ButtonText = "Consultar";
            this.btnConsultarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarCliente.DisabledColor = System.Drawing.Color.Gray;
            this.btnConsultarCliente.Iconcolor = System.Drawing.Color.Transparent;
            this.btnConsultarCliente.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnConsultarCliente.Iconimage")));
            this.btnConsultarCliente.Iconimage_right = null;
            this.btnConsultarCliente.Iconimage_right_Selected = null;
            this.btnConsultarCliente.Iconimage_Selected = null;
            this.btnConsultarCliente.IconMarginLeft = 0;
            this.btnConsultarCliente.IconMarginRight = 0;
            this.btnConsultarCliente.IconRightVisible = true;
            this.btnConsultarCliente.IconRightZoom = 0D;
            this.btnConsultarCliente.IconVisible = true;
            this.btnConsultarCliente.IconZoom = 90D;
            this.btnConsultarCliente.IsTab = false;
            this.btnConsultarCliente.Location = new System.Drawing.Point(45, 3);
            this.btnConsultarCliente.Name = "btnConsultarCliente";
            this.btnConsultarCliente.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(143)))), ((int)(((byte)(185)))));
            this.btnConsultarCliente.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(168)))));
            this.btnConsultarCliente.OnHoverTextColor = System.Drawing.Color.White;
            this.btnConsultarCliente.selected = false;
            this.btnConsultarCliente.Size = new System.Drawing.Size(122, 53);
            this.btnConsultarCliente.TabIndex = 5;
            this.btnConsultarCliente.Text = "Consultar";
            this.btnConsultarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConsultarCliente.Textcolor = System.Drawing.Color.White;
            this.btnConsultarCliente.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarCliente.Click += new System.EventHandler(this.btnConsultarCliente_Click);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnEliminarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(143)))), ((int)(((byte)(185)))));
            this.btnEliminarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarCliente.BorderRadius = 0;
            this.btnEliminarCliente.ButtonText = "Eliminar";
            this.btnEliminarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarCliente.DisabledColor = System.Drawing.Color.Gray;
            this.btnEliminarCliente.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEliminarCliente.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEliminarCliente.Iconimage")));
            this.btnEliminarCliente.Iconimage_right = null;
            this.btnEliminarCliente.Iconimage_right_Selected = null;
            this.btnEliminarCliente.Iconimage_Selected = null;
            this.btnEliminarCliente.IconMarginLeft = 0;
            this.btnEliminarCliente.IconMarginRight = 0;
            this.btnEliminarCliente.IconRightVisible = true;
            this.btnEliminarCliente.IconRightZoom = 0D;
            this.btnEliminarCliente.IconVisible = true;
            this.btnEliminarCliente.IconZoom = 90D;
            this.btnEliminarCliente.IsTab = false;
            this.btnEliminarCliente.Location = new System.Drawing.Point(173, 3);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(143)))), ((int)(((byte)(185)))));
            this.btnEliminarCliente.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(168)))));
            this.btnEliminarCliente.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEliminarCliente.selected = false;
            this.btnEliminarCliente.Size = new System.Drawing.Size(122, 53);
            this.btnEliminarCliente.TabIndex = 4;
            this.btnEliminarCliente.Text = "Eliminar";
            this.btnEliminarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEliminarCliente.Textcolor = System.Drawing.Color.White;
            this.btnEliminarCliente.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // btnInsertarCliente
            // 
            this.btnInsertarCliente.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnInsertarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(143)))), ((int)(((byte)(185)))));
            this.btnInsertarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInsertarCliente.BorderRadius = 0;
            this.btnInsertarCliente.ButtonText = "Insertar";
            this.btnInsertarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsertarCliente.DisabledColor = System.Drawing.Color.Gray;
            this.btnInsertarCliente.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInsertarCliente.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnInsertarCliente.Iconimage")));
            this.btnInsertarCliente.Iconimage_right = null;
            this.btnInsertarCliente.Iconimage_right_Selected = null;
            this.btnInsertarCliente.Iconimage_Selected = null;
            this.btnInsertarCliente.IconMarginLeft = 0;
            this.btnInsertarCliente.IconMarginRight = 0;
            this.btnInsertarCliente.IconRightVisible = true;
            this.btnInsertarCliente.IconRightZoom = 0D;
            this.btnInsertarCliente.IconVisible = true;
            this.btnInsertarCliente.IconZoom = 90D;
            this.btnInsertarCliente.IsTab = false;
            this.btnInsertarCliente.Location = new System.Drawing.Point(300, 3);
            this.btnInsertarCliente.Name = "btnInsertarCliente";
            this.btnInsertarCliente.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(143)))), ((int)(((byte)(185)))));
            this.btnInsertarCliente.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(168)))));
            this.btnInsertarCliente.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInsertarCliente.selected = false;
            this.btnInsertarCliente.Size = new System.Drawing.Size(122, 53);
            this.btnInsertarCliente.TabIndex = 3;
            this.btnInsertarCliente.Text = "Insertar";
            this.btnInsertarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInsertarCliente.Textcolor = System.Drawing.Color.White;
            this.btnInsertarCliente.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarCliente.Click += new System.EventHandler(this.btnInsertarCliente_Click);
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(17, 256);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(44, 13);
            this.bunifuCustomLabel7.TabIndex = 12;
            this.bunifuCustomLabel7.Text = "Pasivos";
            // 
            // txtPasivos
            // 
            this.txtPasivos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPasivos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasivos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPasivos.HintForeColor = System.Drawing.Color.Empty;
            this.txtPasivos.HintText = "";
            this.txtPasivos.isPassword = false;
            this.txtPasivos.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtPasivos.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(140)))));
            this.txtPasivos.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(140)))));
            this.txtPasivos.LineThickness = 3;
            this.txtPasivos.Location = new System.Drawing.Point(88, 245);
            this.txtPasivos.Margin = new System.Windows.Forms.Padding(4);
            this.txtPasivos.Name = "txtPasivos";
            this.txtPasivos.Size = new System.Drawing.Size(238, 33);
            this.txtPasivos.TabIndex = 11;
            this.txtPasivos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(349, 181);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(45, 13);
            this.bunifuCustomLabel4.TabIndex = 10;
            this.bunifuCustomLabel4.Text = "Egresos";
            // 
            // txtEgresos
            // 
            this.txtEgresos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEgresos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEgresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEgresos.HintForeColor = System.Drawing.Color.Empty;
            this.txtEgresos.HintText = "";
            this.txtEgresos.isPassword = false;
            this.txtEgresos.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtEgresos.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(140)))));
            this.txtEgresos.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(140)))));
            this.txtEgresos.LineThickness = 3;
            this.txtEgresos.Location = new System.Drawing.Point(420, 170);
            this.txtEgresos.Margin = new System.Windows.Forms.Padding(4);
            this.txtEgresos.Name = "txtEgresos";
            this.txtEgresos.Size = new System.Drawing.Size(238, 33);
            this.txtEgresos.TabIndex = 9;
            this.txtEgresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(17, 181);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(47, 13);
            this.bunifuCustomLabel5.TabIndex = 8;
            this.bunifuCustomLabel5.Text = "Ingresos";
            // 
            // txtIngresos
            // 
            this.txtIngresos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIngresos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIngresos.HintForeColor = System.Drawing.Color.Empty;
            this.txtIngresos.HintText = "";
            this.txtIngresos.isPassword = false;
            this.txtIngresos.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtIngresos.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(140)))));
            this.txtIngresos.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(140)))));
            this.txtIngresos.LineThickness = 3;
            this.txtIngresos.Location = new System.Drawing.Point(88, 170);
            this.txtIngresos.Margin = new System.Windows.Forms.Padding(4);
            this.txtIngresos.Name = "txtIngresos";
            this.txtIngresos.Size = new System.Drawing.Size(238, 33);
            this.txtIngresos.TabIndex = 7;
            this.txtIngresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(349, 106);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(52, 13);
            this.bunifuCustomLabel3.TabIndex = 6;
            this.bunifuCustomLabel3.Text = "Dirección";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDireccion.HintForeColor = System.Drawing.Color.Empty;
            this.txtDireccion.HintText = "";
            this.txtDireccion.isPassword = false;
            this.txtDireccion.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtDireccion.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(140)))));
            this.txtDireccion.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(140)))));
            this.txtDireccion.LineThickness = 3;
            this.txtDireccion.Location = new System.Drawing.Point(420, 95);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(238, 33);
            this.txtDireccion.TabIndex = 5;
            this.txtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(17, 106);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(44, 13);
            this.bunifuCustomLabel2.TabIndex = 4;
            this.bunifuCustomLabel2.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombre.HintForeColor = System.Drawing.Color.Empty;
            this.txtNombre.HintText = "";
            this.txtNombre.isPassword = false;
            this.txtNombre.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtNombre.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(140)))));
            this.txtNombre.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(140)))));
            this.txtNombre.LineThickness = 3;
            this.txtNombre.Location = new System.Drawing.Point(88, 95);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(238, 33);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(146, 40);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(40, 13);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Cédula";
            // 
            // txtCedula
            // 
            this.txtCedula.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCedula.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCedula.HintForeColor = System.Drawing.Color.Empty;
            this.txtCedula.HintText = "";
            this.txtCedula.isPassword = false;
            this.txtCedula.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtCedula.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(140)))));
            this.txtCedula.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(140)))));
            this.txtCedula.LineThickness = 3;
            this.txtCedula.Location = new System.Drawing.Point(215, 29);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(286, 33);
            this.txtCedula.TabIndex = 1;
            this.txtCedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // navbar
            // 
            this.navbar.BackColor = System.Drawing.Color.White;
            this.navbar.Controls.Add(this.bunifuCards3);
            this.navbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.navbar.Location = new System.Drawing.Point(0, 78);
            this.navbar.Name = "navbar";
            this.navbar.Size = new System.Drawing.Size(200, 372);
            this.navbar.TabIndex = 1;
            // 
            // bunifuCards3
            // 
            this.bunifuCards3.BackColor = System.Drawing.Color.White;
            this.bunifuCards3.BorderRadius = 5;
            this.bunifuCards3.BottomSahddow = true;
            this.bunifuCards3.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(140)))));
            this.bunifuCards3.Controls.Add(this.btnSalir);
            this.bunifuCards3.Controls.Add(this.btnCreditos);
            this.bunifuCards3.Controls.Add(this.btnClientes);
            this.bunifuCards3.LeftSahddow = false;
            this.bunifuCards3.Location = new System.Drawing.Point(4, 0);
            this.bunifuCards3.Name = "bunifuCards3";
            this.bunifuCards3.RightSahddow = true;
            this.bunifuCards3.ShadowDepth = 40;
            this.bunifuCards3.Size = new System.Drawing.Size(193, 367);
            this.bunifuCards3.TabIndex = 3;
            // 
            // btnSalir
            // 
            this.btnSalir.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(26)))), ((int)(((byte)(45)))));
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(26)))), ((int)(((byte)(45)))));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.BorderRadius = 0;
            this.btnSalir.ButtonText = "Salir";
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.DisabledColor = System.Drawing.Color.Gray;
            this.btnSalir.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSalir.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSalir.Iconimage")));
            this.btnSalir.Iconimage_right = null;
            this.btnSalir.Iconimage_right_Selected = null;
            this.btnSalir.Iconimage_Selected = null;
            this.btnSalir.IconMarginLeft = 0;
            this.btnSalir.IconMarginRight = 0;
            this.btnSalir.IconRightVisible = true;
            this.btnSalir.IconRightZoom = 0D;
            this.btnSalir.IconVisible = true;
            this.btnSalir.IconZoom = 90D;
            this.btnSalir.IsTab = false;
            this.btnSalir.Location = new System.Drawing.Point(13, 310);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(26)))), ((int)(((byte)(45)))));
            this.btnSalir.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            this.btnSalir.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSalir.selected = false;
            this.btnSalir.Size = new System.Drawing.Size(167, 48);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Textcolor = System.Drawing.Color.White;
            this.btnSalir.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCreditos
            // 
            this.btnCreditos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnCreditos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(140)))));
            this.btnCreditos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreditos.BorderRadius = 0;
            this.btnCreditos.ButtonText = "Creditos";
            this.btnCreditos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreditos.DisabledColor = System.Drawing.Color.Gray;
            this.btnCreditos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCreditos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCreditos.Iconimage")));
            this.btnCreditos.Iconimage_right = null;
            this.btnCreditos.Iconimage_right_Selected = null;
            this.btnCreditos.Iconimage_Selected = null;
            this.btnCreditos.IconMarginLeft = 0;
            this.btnCreditos.IconMarginRight = 0;
            this.btnCreditos.IconRightVisible = true;
            this.btnCreditos.IconRightZoom = 0D;
            this.btnCreditos.IconVisible = true;
            this.btnCreditos.IconZoom = 90D;
            this.btnCreditos.IsTab = false;
            this.btnCreditos.Location = new System.Drawing.Point(13, 80);
            this.btnCreditos.Name = "btnCreditos";
            this.btnCreditos.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(140)))));
            this.btnCreditos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(168)))));
            this.btnCreditos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCreditos.selected = false;
            this.btnCreditos.Size = new System.Drawing.Size(167, 48);
            this.btnCreditos.TabIndex = 1;
            this.btnCreditos.Text = "Creditos";
            this.btnCreditos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreditos.Textcolor = System.Drawing.Color.White;
            this.btnCreditos.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreditos.Click += new System.EventHandler(this.btnCreditos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(140)))));
            this.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClientes.BorderRadius = 0;
            this.btnClientes.ButtonText = "Clientes";
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.DisabledColor = System.Drawing.Color.Gray;
            this.btnClientes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClientes.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnClientes.Iconimage")));
            this.btnClientes.Iconimage_right = null;
            this.btnClientes.Iconimage_right_Selected = null;
            this.btnClientes.Iconimage_Selected = null;
            this.btnClientes.IconMarginLeft = 0;
            this.btnClientes.IconMarginRight = 0;
            this.btnClientes.IconRightVisible = true;
            this.btnClientes.IconRightZoom = 0D;
            this.btnClientes.IconVisible = true;
            this.btnClientes.IconZoom = 90D;
            this.btnClientes.IsTab = false;
            this.btnClientes.Location = new System.Drawing.Point(13, 25);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(140)))));
            this.btnClientes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(168)))));
            this.btnClientes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClientes.selected = false;
            this.btnClientes.Size = new System.Drawing.Size(167, 48);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Textcolor = System.Drawing.Color.White;
            this.btnClientes.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(26)))), ((int)(((byte)(45)))));
            this.bunifuCards2.Controls.Add(this.btnCloseUserMessage);
            this.bunifuCards2.Controls.Add(this.lblUserMessage);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(3, 3);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(696, 48);
            this.bunifuCards2.TabIndex = 3;
            // 
            // btnCloseUserMessage
            // 
            this.btnCloseUserMessage.BackColor = System.Drawing.Color.White;
            this.btnCloseUserMessage.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseUserMessage.Image")));
            this.btnCloseUserMessage.ImageActive = null;
            this.btnCloseUserMessage.Location = new System.Drawing.Point(659, 11);
            this.btnCloseUserMessage.Name = "btnCloseUserMessage";
            this.btnCloseUserMessage.Size = new System.Drawing.Size(28, 29);
            this.btnCloseUserMessage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCloseUserMessage.TabIndex = 15;
            this.btnCloseUserMessage.TabStop = false;
            this.btnCloseUserMessage.Zoom = 20;
            this.btnCloseUserMessage.Click += new System.EventHandler(this.btnCloseUserMessage_Click);
            // 
            // lblUserMessage
            // 
            this.lblUserMessage.Location = new System.Drawing.Point(44, 11);
            this.lblUserMessage.Name = "lblUserMessage";
            this.lblUserMessage.Size = new System.Drawing.Size(596, 27);
            this.lblUserMessage.TabIndex = 1;
            this.lblUserMessage.Text = "Bienvenido, aquí verá los mensajes del sistema";
            this.lblUserMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // footer
            // 
            this.footer.Controls.Add(this.bunifuCards2);
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Location = new System.Drawing.Point(200, 395);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(701, 55);
            this.footer.TabIndex = 4;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(140)))));
            this.bunifuCards1.Controls.Add(this.bunifuCustomDataGrid2);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel8);
            this.bunifuCards1.Controls.Add(this.bunifuMaterialTextbox1);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(-1, 1);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 40;
            this.bunifuCards1.Size = new System.Drawing.Size(696, 304);
            this.bunifuCards1.TabIndex = 2;
            // 
            // bunifuCustomDataGrid2
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.bunifuCustomDataGrid2.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.bunifuCustomDataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.bunifuCustomDataGrid2.DoubleBuffered = true;
            this.bunifuCustomDataGrid2.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid2.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid2.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid2.Location = new System.Drawing.Point(20, 80);
            this.bunifuCustomDataGrid2.Name = "bunifuCustomDataGrid2";
            this.bunifuCustomDataGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid2.Size = new System.Drawing.Size(667, 207);
            this.bunifuCustomDataGrid2.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre Producto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Plazo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Monto";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Total Interes";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Anualidad";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Tasa Nominal Mensual";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Tasa Efectiva Anual";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Total Monto mas Interés";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(146, 40);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(40, 13);
            this.bunifuCustomLabel8.TabIndex = 2;
            this.bunifuCustomLabel8.Text = "Cédula";
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(140)))));
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(140)))));
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(215, 29);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(286, 33);
            this.bunifuMaterialTextbox1.TabIndex = 1;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCards4
            // 
            this.bunifuCards4.BackColor = System.Drawing.Color.White;
            this.bunifuCards4.BorderRadius = 5;
            this.bunifuCards4.BottomSahddow = true;
            this.bunifuCards4.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(140)))));
            this.bunifuCards4.Controls.Add(this.bunifuCustomLabel15);
            this.bunifuCards4.Controls.Add(this.lblDireccion);
            this.bunifuCards4.Controls.Add(this.bunifuCustomLabel12);
            this.bunifuCards4.Controls.Add(this.txtClientScoring);
            this.bunifuCards4.Controls.Add(this.txtClientDireccion);
            this.bunifuCards4.Controls.Add(this.txtClientEgresos);
            this.bunifuCards4.Controls.Add(this.bunifuCustomLabel13);
            this.bunifuCards4.Controls.Add(this.lblNombre);
            this.bunifuCards4.Controls.Add(this.bunifuCustomLabel11);
            this.bunifuCards4.Controls.Add(this.txtClientNombre);
            this.bunifuCards4.Controls.Add(this.txtClientPasivos);
            this.bunifuCards4.Controls.Add(this.txtClientIngresos);
            this.bunifuCards4.Controls.Add(this.bunifuCustomLabel6);
            this.bunifuCards4.Controls.Add(this.txtClientCedula);
            this.bunifuCards4.LeftSahddow = false;
            this.bunifuCards4.Location = new System.Drawing.Point(206, 78);
            this.bunifuCards4.Name = "bunifuCards4";
            this.bunifuCards4.RightSahddow = true;
            this.bunifuCards4.ShadowDepth = 40;
            this.bunifuCards4.Size = new System.Drawing.Size(690, 311);
            this.bunifuCards4.TabIndex = 2;
            // 
            // txtClientCedula
            // 
            this.txtClientCedula.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClientCedula.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientCedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtClientCedula.HintForeColor = System.Drawing.Color.Empty;
            this.txtClientCedula.HintText = "";
            this.txtClientCedula.isPassword = false;
            this.txtClientCedula.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtClientCedula.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(140)))));
            this.txtClientCedula.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(140)))));
            this.txtClientCedula.LineThickness = 3;
            this.txtClientCedula.Location = new System.Drawing.Point(215, 29);
            this.txtClientCedula.Margin = new System.Windows.Forms.Padding(4);
            this.txtClientCedula.Name = "txtClientCedula";
            this.txtClientCedula.Size = new System.Drawing.Size(286, 33);
            this.txtClientCedula.TabIndex = 1;
            this.txtClientCedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(146, 40);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(40, 13);
            this.bunifuCustomLabel6.TabIndex = 2;
            this.bunifuCustomLabel6.Text = "Cédula";
            // 
            // txtClientIngresos
            // 
            this.txtClientIngresos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClientIngresos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientIngresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtClientIngresos.HintForeColor = System.Drawing.Color.Empty;
            this.txtClientIngresos.HintText = "";
            this.txtClientIngresos.isPassword = false;
            this.txtClientIngresos.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtClientIngresos.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(140)))));
            this.txtClientIngresos.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(140)))));
            this.txtClientIngresos.LineThickness = 3;
            this.txtClientIngresos.Location = new System.Drawing.Point(83, 171);
            this.txtClientIngresos.Margin = new System.Windows.Forms.Padding(4);
            this.txtClientIngresos.Name = "txtClientIngresos";
            this.txtClientIngresos.Size = new System.Drawing.Size(244, 32);
            this.txtClientIngresos.TabIndex = 1;
            this.txtClientIngresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtClientPasivos
            // 
            this.txtClientPasivos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClientPasivos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientPasivos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtClientPasivos.HintForeColor = System.Drawing.Color.Empty;
            this.txtClientPasivos.HintText = "";
            this.txtClientPasivos.isPassword = false;
            this.txtClientPasivos.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtClientPasivos.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(140)))));
            this.txtClientPasivos.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(140)))));
            this.txtClientPasivos.LineThickness = 3;
            this.txtClientPasivos.Location = new System.Drawing.Point(83, 227);
            this.txtClientPasivos.Margin = new System.Windows.Forms.Padding(4);
            this.txtClientPasivos.Name = "txtClientPasivos";
            this.txtClientPasivos.Size = new System.Drawing.Size(244, 32);
            this.txtClientPasivos.TabIndex = 1;
            this.txtClientPasivos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtClientNombre
            // 
            this.txtClientNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClientNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtClientNombre.HintForeColor = System.Drawing.Color.Empty;
            this.txtClientNombre.HintText = "";
            this.txtClientNombre.isPassword = false;
            this.txtClientNombre.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtClientNombre.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(140)))));
            this.txtClientNombre.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(140)))));
            this.txtClientNombre.LineThickness = 3;
            this.txtClientNombre.Location = new System.Drawing.Point(83, 115);
            this.txtClientNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtClientNombre.Name = "txtClientNombre";
            this.txtClientNombre.Size = new System.Drawing.Size(244, 32);
            this.txtClientNombre.TabIndex = 1;
            this.txtClientNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(14, 179);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(47, 13);
            this.bunifuCustomLabel11.TabIndex = 2;
            this.bunifuCustomLabel11.Text = "Ingresos";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(14, 124);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.AutoSize = true;
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(14, 236);
            this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
            this.bunifuCustomLabel13.Size = new System.Drawing.Size(44, 13);
            this.bunifuCustomLabel13.TabIndex = 2;
            this.bunifuCustomLabel13.Text = "Pasivos";
            // 
            // txtClientEgresos
            // 
            this.txtClientEgresos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClientEgresos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientEgresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtClientEgresos.HintForeColor = System.Drawing.Color.Empty;
            this.txtClientEgresos.HintText = "";
            this.txtClientEgresos.isPassword = false;
            this.txtClientEgresos.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtClientEgresos.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(140)))));
            this.txtClientEgresos.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(140)))));
            this.txtClientEgresos.LineThickness = 3;
            this.txtClientEgresos.Location = new System.Drawing.Point(419, 171);
            this.txtClientEgresos.Margin = new System.Windows.Forms.Padding(4);
            this.txtClientEgresos.Name = "txtClientEgresos";
            this.txtClientEgresos.Size = new System.Drawing.Size(244, 32);
            this.txtClientEgresos.TabIndex = 1;
            this.txtClientEgresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtClientDireccion
            // 
            this.txtClientDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClientDireccion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtClientDireccion.HintForeColor = System.Drawing.Color.Empty;
            this.txtClientDireccion.HintText = "";
            this.txtClientDireccion.isPassword = false;
            this.txtClientDireccion.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtClientDireccion.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(140)))));
            this.txtClientDireccion.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(140)))));
            this.txtClientDireccion.LineThickness = 3;
            this.txtClientDireccion.Location = new System.Drawing.Point(419, 115);
            this.txtClientDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtClientDireccion.Name = "txtClientDireccion";
            this.txtClientDireccion.Size = new System.Drawing.Size(244, 32);
            this.txtClientDireccion.TabIndex = 1;
            this.txtClientDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtClientScoring
            // 
            this.txtClientScoring.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClientScoring.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientScoring.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtClientScoring.HintForeColor = System.Drawing.Color.Empty;
            this.txtClientScoring.HintText = "";
            this.txtClientScoring.isPassword = false;
            this.txtClientScoring.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtClientScoring.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(140)))));
            this.txtClientScoring.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(140)))));
            this.txtClientScoring.LineThickness = 3;
            this.txtClientScoring.Location = new System.Drawing.Point(419, 227);
            this.txtClientScoring.Margin = new System.Windows.Forms.Padding(4);
            this.txtClientScoring.Name = "txtClientScoring";
            this.txtClientScoring.Size = new System.Drawing.Size(244, 32);
            this.txtClientScoring.TabIndex = 1;
            this.txtClientScoring.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(350, 179);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(45, 13);
            this.bunifuCustomLabel12.TabIndex = 2;
            this.bunifuCustomLabel12.Text = "Egresos";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(350, 124);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Direccion";
            // 
            // bunifuCustomLabel15
            // 
            this.bunifuCustomLabel15.AutoSize = true;
            this.bunifuCustomLabel15.Location = new System.Drawing.Point(350, 236);
            this.bunifuCustomLabel15.Name = "bunifuCustomLabel15";
            this.bunifuCustomLabel15.Size = new System.Drawing.Size(43, 13);
            this.bunifuCustomLabel15.TabIndex = 2;
            this.bunifuCustomLabel15.Text = "Scoring";
            // 
            // FrontWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(901, 450);
            this.ControlBox = false;
            this.Controls.Add(this.bunifuCards4);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.navbar);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrontWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Creditos Bancolombia";
            this.header.ResumeLayout(false);
            this.clientNavbar.ResumeLayout(false);
            this.navbar.ResumeLayout(false);
            this.bunifuCards3.ResumeLayout(false);
            this.bunifuCards2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseUserMessage)).EndInit();
            this.footer.ResumeLayout(false);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).EndInit();
            this.bunifuCards4.ResumeLayout(false);
            this.bunifuCards4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel navbar;
        private Bunifu.Framework.UI.BunifuFlatButton btnClientes;
        private Bunifu.Framework.UI.BunifuFlatButton btnSalir;
        private Bunifu.Framework.UI.BunifuFlatButton btnCreditos;
        private Bunifu.Framework.UI.BunifuFlatButton btnConsultarCliente;
        private Bunifu.Framework.UI.BunifuFlatButton btnEliminarCliente;
        private Bunifu.Framework.UI.BunifuFlatButton btnInsertarCliente;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private Bunifu.Framework.UI.BunifuCustomLabel lblUserMessage;
        private Bunifu.Framework.UI.BunifuCards bunifuCards3;
        private Bunifu.Framework.UI.BunifuImageButton btnCloseUserMessage;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPasivos;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEgresos;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtIngresos;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDireccion;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNombre;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCedula;
        private System.Windows.Forms.Panel clientNavbar;
        private System.Windows.Forms.Panel footer;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private System.Windows.Forms.Panel logoPanel;
        private Bunifu.Framework.UI.BunifuCards bunifuCards4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel15;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDireccion;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtClientScoring;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtClientDireccion;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtClientEgresos;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel13;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNombre;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtClientNombre;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtClientPasivos;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtClientIngresos;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtClientCedula;
    }
}

