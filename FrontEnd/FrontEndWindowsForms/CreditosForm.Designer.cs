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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CreditPanelHeader = new System.Windows.Forms.Panel();
            this.clientNavbar = new System.Windows.Forms.Panel();
            this.btnConsultarCliente = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEliminarCliente = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnInsertarCliente = new Bunifu.Framework.UI.BunifuFlatButton();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.CreditCard = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalInteres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anualidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tnm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMontoInteres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuCustomLabel14 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuMaterialTextbox7 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
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
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
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
            this.clientNavbar.Controls.Add(this.btnConsultarCliente);
            this.clientNavbar.Controls.Add(this.btnEliminarCliente);
            this.clientNavbar.Controls.Add(this.btnInsertarCliente);
            this.clientNavbar.Location = new System.Drawing.Point(298, 12);
            this.clientNavbar.Name = "clientNavbar";
            this.clientNavbar.Size = new System.Drawing.Size(470, 60);
            this.clientNavbar.TabIndex = 7;
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
            this.CreditCard.BackColor = System.Drawing.Color.White;
            this.CreditCard.BorderRadius = 5;
            this.CreditCard.BottomSahddow = true;
            this.CreditCard.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(140)))));
            this.CreditCard.Controls.Add(this.bunifuCustomDataGrid1);
            this.CreditCard.Controls.Add(this.bunifuCustomLabel14);
            this.CreditCard.Controls.Add(this.bunifuMaterialTextbox7);
            this.CreditCard.LeftSahddow = false;
            this.CreditCard.Location = new System.Drawing.Point(206, 78);
            this.CreditCard.Name = "CreditCard";
            this.CreditCard.RightSahddow = true;
            this.CreditCard.ShadowDepth = 40;
            this.CreditCard.Size = new System.Drawing.Size(917, 464);
            this.CreditCard.TabIndex = 3;
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.plazo,
            this.monto,
            this.totalInteres,
            this.anualidad,
            this.tnm,
            this.tea,
            this.totalMontoInteres});
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(20, 80);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(667, 207);
            this.bunifuCustomDataGrid1.TabIndex = 3;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre Producto";
            this.nombre.Name = "nombre";
            // 
            // plazo
            // 
            this.plazo.HeaderText = "Plazo";
            this.plazo.Name = "plazo";
            // 
            // monto
            // 
            this.monto.HeaderText = "Monto";
            this.monto.Name = "monto";
            // 
            // totalInteres
            // 
            this.totalInteres.HeaderText = "Total Interes";
            this.totalInteres.Name = "totalInteres";
            // 
            // anualidad
            // 
            this.anualidad.HeaderText = "Anualidad";
            this.anualidad.Name = "anualidad";
            // 
            // tnm
            // 
            this.tnm.HeaderText = "Tasa Nominal Mensual";
            this.tnm.Name = "tnm";
            // 
            // tea
            // 
            this.tea.HeaderText = "Tasa Efectiva Anual";
            this.tea.Name = "tea";
            // 
            // totalMontoInteres
            // 
            this.totalMontoInteres.HeaderText = "Total Monto mas Interés";
            this.totalMontoInteres.Name = "totalMontoInteres";
            // 
            // bunifuCustomLabel14
            // 
            this.bunifuCustomLabel14.AutoSize = true;
            this.bunifuCustomLabel14.Location = new System.Drawing.Point(146, 40);
            this.bunifuCustomLabel14.Name = "bunifuCustomLabel14";
            this.bunifuCustomLabel14.Size = new System.Drawing.Size(40, 13);
            this.bunifuCustomLabel14.TabIndex = 2;
            this.bunifuCustomLabel14.Text = "Cédula";
            // 
            // bunifuMaterialTextbox7
            // 
            this.bunifuMaterialTextbox7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextbox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox7.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox7.HintText = "";
            this.bunifuMaterialTextbox7.isPassword = false;
            this.bunifuMaterialTextbox7.LineFocusedColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox7.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(140)))));
            this.bunifuMaterialTextbox7.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(140)))));
            this.bunifuMaterialTextbox7.LineThickness = 3;
            this.bunifuMaterialTextbox7.Location = new System.Drawing.Point(215, 29);
            this.bunifuMaterialTextbox7.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox7.Name = "bunifuMaterialTextbox7";
            this.bunifuMaterialTextbox7.Size = new System.Drawing.Size(286, 33);
            this.bunifuMaterialTextbox7.TabIndex = 1;
            this.bunifuMaterialTextbox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.lblUserMessage.Text = "Bienvenido, aquí verá los mensajes del sistema";
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
            this.Name = "CreditosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreditosForm";
            this.CreditPanelHeader.ResumeLayout(false);
            this.clientNavbar.ResumeLayout(false);
            this.CreditCard.ResumeLayout(false);
            this.CreditCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
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
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn plazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalInteres;
        private System.Windows.Forms.DataGridViewTextBoxColumn anualidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn tnm;
        private System.Windows.Forms.DataGridViewTextBoxColumn tea;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMontoInteres;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel14;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox7;
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
        private Bunifu.Framework.UI.BunifuFlatButton btnConsultarCliente;
        private Bunifu.Framework.UI.BunifuFlatButton btnEliminarCliente;
        private Bunifu.Framework.UI.BunifuFlatButton btnInsertarCliente;
    }
}