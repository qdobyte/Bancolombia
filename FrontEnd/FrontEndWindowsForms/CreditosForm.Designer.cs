namespace FrontEndWindowsForms
{
    partial class CreditosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditosForm));
            this.CreditPanelHeader = new System.Windows.Forms.Panel();
            this.clientNavbar = new System.Windows.Forms.Panel();
            this.btnViabilidadCliente = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCreditosDesembolsar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.CreditCard = new Bunifu.Framework.UI.BunifuCards();
            this.dropCreditosProducto = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtCreditosMonto = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCreditosPlazo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCreditosCedula = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CreditPanelNavbar = new System.Windows.Forms.Panel();
            this.bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
            this.btnSalir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCreditos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClientes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.CreditPanelFooter = new System.Windows.Forms.Panel();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.btnCloseUserMessage = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblUserMessage = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.CreditPanelHeader.SuspendLayout();
            this.clientNavbar.SuspendLayout();
            this.CreditCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.CreditPanelNavbar.SuspendLayout();
            this.bunifuCards3.SuspendLayout();
            this.CreditPanelFooter.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseUserMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // CreditPanelHeader
            // 
            this.CreditPanelHeader.Controls.Add(this.clientNavbar);
            this.CreditPanelHeader.Controls.Add(this.logoPanel);
            this.CreditPanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.CreditPanelHeader.Location = new System.Drawing.Point(0, 0);
            this.CreditPanelHeader.Name = "CreditPanelHeader";
            this.CreditPanelHeader.Size = new System.Drawing.Size(901, 78);
            this.CreditPanelHeader.TabIndex = 0;
            // 
            // clientNavbar
            // 
            this.clientNavbar.Controls.Add(this.btnViabilidadCliente);
            this.clientNavbar.Controls.Add(this.btnCreditosDesembolsar);
            this.clientNavbar.Location = new System.Drawing.Point(313, 12);
            this.clientNavbar.Name = "clientNavbar";
            this.clientNavbar.Size = new System.Drawing.Size(441, 60);
            this.clientNavbar.TabIndex = 7;
            // 
            // btnViabilidadCliente
            // 
            this.btnViabilidadCliente.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnViabilidadCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(143)))), ((int)(((byte)(185)))));
            this.btnViabilidadCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViabilidadCliente.BorderRadius = 0;
            this.btnViabilidadCliente.ButtonText = "Verificar Viabilidad";
            this.btnViabilidadCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViabilidadCliente.DisabledColor = System.Drawing.Color.Gray;
            this.btnViabilidadCliente.Iconcolor = System.Drawing.Color.Transparent;
            this.btnViabilidadCliente.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnViabilidadCliente.Iconimage")));
            this.btnViabilidadCliente.Iconimage_right = null;
            this.btnViabilidadCliente.Iconimage_right_Selected = null;
            this.btnViabilidadCliente.Iconimage_Selected = null;
            this.btnViabilidadCliente.IconMarginLeft = 0;
            this.btnViabilidadCliente.IconMarginRight = 0;
            this.btnViabilidadCliente.IconRightVisible = true;
            this.btnViabilidadCliente.IconRightZoom = 0D;
            this.btnViabilidadCliente.IconVisible = true;
            this.btnViabilidadCliente.IconZoom = 90D;
            this.btnViabilidadCliente.IsTab = false;
            this.btnViabilidadCliente.Location = new System.Drawing.Point(57, 3);
            this.btnViabilidadCliente.Name = "btnViabilidadCliente";
            this.btnViabilidadCliente.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(143)))), ((int)(((byte)(185)))));
            this.btnViabilidadCliente.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(168)))));
            this.btnViabilidadCliente.OnHoverTextColor = System.Drawing.Color.White;
            this.btnViabilidadCliente.selected = false;
            this.btnViabilidadCliente.Size = new System.Drawing.Size(153, 53);
            this.btnViabilidadCliente.TabIndex = 5;
            this.btnViabilidadCliente.Text = "Verificar Viabilidad";
            this.btnViabilidadCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnViabilidadCliente.Textcolor = System.Drawing.Color.White;
            this.btnViabilidadCliente.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViabilidadCliente.Click += new System.EventHandler(this.btnViabilidadCliente_Click);
            // 
            // btnCreditosDesembolsar
            // 
            this.btnCreditosDesembolsar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnCreditosDesembolsar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(143)))), ((int)(((byte)(185)))));
            this.btnCreditosDesembolsar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreditosDesembolsar.BorderRadius = 0;
            this.btnCreditosDesembolsar.ButtonText = "Desembolsar Crédito";
            this.btnCreditosDesembolsar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreditosDesembolsar.DisabledColor = System.Drawing.Color.Gray;
            this.btnCreditosDesembolsar.Enabled = false;
            this.btnCreditosDesembolsar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCreditosDesembolsar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCreditosDesembolsar.Iconimage")));
            this.btnCreditosDesembolsar.Iconimage_right = null;
            this.btnCreditosDesembolsar.Iconimage_right_Selected = null;
            this.btnCreditosDesembolsar.Iconimage_Selected = null;
            this.btnCreditosDesembolsar.IconMarginLeft = 0;
            this.btnCreditosDesembolsar.IconMarginRight = 0;
            this.btnCreditosDesembolsar.IconRightVisible = true;
            this.btnCreditosDesembolsar.IconRightZoom = 0D;
            this.btnCreditosDesembolsar.IconVisible = true;
            this.btnCreditosDesembolsar.IconZoom = 90D;
            this.btnCreditosDesembolsar.IsTab = false;
            this.btnCreditosDesembolsar.Location = new System.Drawing.Point(232, 3);
            this.btnCreditosDesembolsar.Name = "btnCreditosDesembolsar";
            this.btnCreditosDesembolsar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(143)))), ((int)(((byte)(185)))));
            this.btnCreditosDesembolsar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(168)))));
            this.btnCreditosDesembolsar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCreditosDesembolsar.selected = false;
            this.btnCreditosDesembolsar.Size = new System.Drawing.Size(153, 53);
            this.btnCreditosDesembolsar.TabIndex = 4;
            this.btnCreditosDesembolsar.Text = "Desembolsar Crédito";
            this.btnCreditosDesembolsar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCreditosDesembolsar.Textcolor = System.Drawing.Color.White;
            this.btnCreditosDesembolsar.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreditosDesembolsar.Click += new System.EventHandler(this.btnCreditosDesembolsar_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoPanel.BackgroundImage")));
            this.logoPanel.Location = new System.Drawing.Point(-5, -8);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(210, 85);
            this.logoPanel.TabIndex = 4;
            // 
            // CreditCard
            // 
            this.CreditCard.AccessibleDescription = "Producto";
            this.CreditCard.AllowDrop = true;
            this.CreditCard.BackColor = System.Drawing.Color.White;
            this.CreditCard.BorderRadius = 5;
            this.CreditCard.BottomSahddow = true;
            this.CreditCard.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(140)))));
            this.CreditCard.Controls.Add(this.dropCreditosProducto);
            this.CreditCard.Controls.Add(this.bunifuImageButton1);
            this.CreditCard.Controls.Add(this.txtCreditosMonto);
            this.CreditCard.Controls.Add(this.txtCreditosPlazo);
            this.CreditCard.Controls.Add(this.txtCreditosCedula);
            this.CreditCard.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditCard.LeftSahddow = false;
            this.CreditCard.Location = new System.Drawing.Point(206, 78);
            this.CreditCard.Name = "CreditCard";
            this.CreditCard.RightSahddow = true;
            this.CreditCard.ShadowDepth = 40;
            this.CreditCard.Size = new System.Drawing.Size(692, 314);
            this.CreditCard.TabIndex = 3;
            // 
            // dropCreditosProducto
            // 
            this.dropCreditosProducto.BackColor = System.Drawing.Color.Transparent;
            this.dropCreditosProducto.BorderRadius = 3;
            this.dropCreditosProducto.DisabledColor = System.Drawing.Color.Gray;
            this.dropCreditosProducto.ForeColor = System.Drawing.Color.White;
            this.dropCreditosProducto.Items = new string[] {
        "libreInversion",
        "vehiculo",
        "vivienda"};
            this.dropCreditosProducto.Location = new System.Drawing.Point(216, 114);
            this.dropCreditosProducto.Name = "dropCreditosProducto";
            this.dropCreditosProducto.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(140)))));
            this.dropCreditosProducto.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(140)))));
            this.dropCreditosProducto.selectedIndex = -1;
            this.dropCreditosProducto.Size = new System.Drawing.Size(286, 35);
            this.dropCreditosProducto.TabIndex = 4;
            this.dropCreditosProducto.Tag = "Producto";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.White;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(175, 25);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(33, 35);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 2;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // txtCreditosMonto
            // 
            this.txtCreditosMonto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCreditosMonto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreditosMonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCreditosMonto.HintForeColor = System.Drawing.Color.Gray;
            this.txtCreditosMonto.HintText = "Monto";
            this.txtCreditosMonto.isPassword = false;
            this.txtCreditosMonto.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtCreditosMonto.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(140)))));
            this.txtCreditosMonto.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(140)))));
            this.txtCreditosMonto.LineThickness = 3;
            this.txtCreditosMonto.Location = new System.Drawing.Point(279, 200);
            this.txtCreditosMonto.Margin = new System.Windows.Forms.Padding(4);
            this.txtCreditosMonto.Name = "txtCreditosMonto";
            this.txtCreditosMonto.Size = new System.Drawing.Size(157, 33);
            this.txtCreditosMonto.TabIndex = 3;
            this.txtCreditosMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCreditosPlazo
            // 
            this.txtCreditosPlazo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCreditosPlazo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreditosPlazo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCreditosPlazo.HintForeColor = System.Drawing.Color.Gray;
            this.txtCreditosPlazo.HintText = "Plazo";
            this.txtCreditosPlazo.isPassword = false;
            this.txtCreditosPlazo.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtCreditosPlazo.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(140)))));
            this.txtCreditosPlazo.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(140)))));
            this.txtCreditosPlazo.LineThickness = 3;
            this.txtCreditosPlazo.Location = new System.Drawing.Point(279, 157);
            this.txtCreditosPlazo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCreditosPlazo.Name = "txtCreditosPlazo";
            this.txtCreditosPlazo.Size = new System.Drawing.Size(157, 33);
            this.txtCreditosPlazo.TabIndex = 2;
            this.txtCreditosPlazo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCreditosCedula
            // 
            this.txtCreditosCedula.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCreditosCedula.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreditosCedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCreditosCedula.HintForeColor = System.Drawing.Color.Gray;
            this.txtCreditosCedula.HintText = "Cédula";
            this.txtCreditosCedula.isPassword = false;
            this.txtCreditosCedula.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtCreditosCedula.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(140)))));
            this.txtCreditosCedula.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(140)))));
            this.txtCreditosCedula.LineThickness = 3;
            this.txtCreditosCedula.Location = new System.Drawing.Point(215, 29);
            this.txtCreditosCedula.Margin = new System.Windows.Forms.Padding(4);
            this.txtCreditosCedula.Name = "txtCreditosCedula";
            this.txtCreditosCedula.Size = new System.Drawing.Size(286, 33);
            this.txtCreditosCedula.TabIndex = 0;
            this.txtCreditosCedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CreditPanelNavbar
            // 
            this.CreditPanelNavbar.Controls.Add(this.bunifuCards3);
            this.CreditPanelNavbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.CreditPanelNavbar.Location = new System.Drawing.Point(0, 78);
            this.CreditPanelNavbar.Name = "CreditPanelNavbar";
            this.CreditPanelNavbar.Size = new System.Drawing.Size(200, 372);
            this.CreditPanelNavbar.TabIndex = 4;
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
            this.bunifuCards3.TabIndex = 4;
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
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // CreditPanelFooter
            // 
            this.CreditPanelFooter.Controls.Add(this.bunifuCards2);
            this.CreditPanelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CreditPanelFooter.Location = new System.Drawing.Point(200, 395);
            this.CreditPanelFooter.Name = "CreditPanelFooter";
            this.CreditPanelFooter.Size = new System.Drawing.Size(701, 55);
            this.CreditPanelFooter.TabIndex = 5;
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
            this.bunifuCards2.TabIndex = 4;
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
            this.lblUserMessage.Text = "Ingrese cédula y presione el botón Verificar Viabilidad";
            this.lblUserMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreditosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(901, 450);
            this.Controls.Add(this.CreditPanelFooter);
            this.Controls.Add(this.CreditPanelNavbar);
            this.Controls.Add(this.CreditCard);
            this.Controls.Add(this.CreditPanelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreditosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Créditos";
            this.CreditPanelHeader.ResumeLayout(false);
            this.clientNavbar.ResumeLayout(false);
            this.CreditCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.CreditPanelNavbar.ResumeLayout(false);
            this.bunifuCards3.ResumeLayout(false);
            this.CreditPanelFooter.ResumeLayout(false);
            this.bunifuCards2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseUserMessage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CreditPanelHeader;
        private Bunifu.Framework.UI.BunifuCards CreditCard;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCreditosCedula;
        private System.Windows.Forms.Panel CreditPanelNavbar;
        private System.Windows.Forms.Panel CreditPanelFooter;
        private System.Windows.Forms.Panel logoPanel;
        private Bunifu.Framework.UI.BunifuCards bunifuCards3;
        private Bunifu.Framework.UI.BunifuFlatButton btnSalir;
        private Bunifu.Framework.UI.BunifuFlatButton btnCreditos;
        private Bunifu.Framework.UI.BunifuFlatButton btnClientes;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private Bunifu.Framework.UI.BunifuImageButton btnCloseUserMessage;
        private Bunifu.Framework.UI.BunifuCustomLabel lblUserMessage;
        private System.Windows.Forms.Panel clientNavbar;
        private Bunifu.Framework.UI.BunifuFlatButton btnViabilidadCliente;
        private Bunifu.Framework.UI.BunifuFlatButton btnCreditosDesembolsar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCreditosMonto;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCreditosPlazo;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuDropdown dropCreditosProducto;
    }
}