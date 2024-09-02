namespace AppFacturacion2024
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txtUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtNombreUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtUsuarioTipo = new System.Windows.Forms.ToolStripStatusLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelOPCIONES = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.MenuUsuarios = new System.Windows.Forms.Panel();
            this.btnConsultarUsuarios = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.MenuFacturas = new System.Windows.Forms.Panel();
            this.btnImprimirFactura = new System.Windows.Forms.Button();
            this.btnRegistrarFactura = new System.Windows.Forms.Button();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.MenuProductos = new System.Windows.Forms.Panel();
            this.btnListaProductos = new System.Windows.Forms.Button();
            this.btnConsultaProductos = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.MenuClientes = new System.Windows.Forms.Panel();
            this.btnImprimirListaClientes = new System.Windows.Forms.Button();
            this.btnConsultaClientes = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.MenuProveedores = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.MenuUsuarios.SuspendLayout();
            this.MenuFacturas.SuspendLayout();
            this.MenuProductos.SuspendLayout();
            this.MenuClientes.SuspendLayout();
            this.MenuProveedores.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 80);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(217)))), ((int)(((byte)(208)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtUsuario,
            this.txtNombreUsuario,
            this.txtUsuarioTipo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 647);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txtUsuario
            // 
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(46, 17);
            this.txtUsuario.Text = "usuario";
            this.txtUsuario.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(90, 3, 0, 2);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(118, 17);
            this.txtNombreUsuario.Text = "toolStripStatusLabel1";
            // 
            // txtUsuarioTipo
            // 
            this.txtUsuarioTipo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUsuarioTipo.Margin = new System.Windows.Forms.Padding(90, 3, 0, 2);
            this.txtUsuarioTipo.Name = "txtUsuarioTipo";
            this.txtUsuarioTipo.Size = new System.Drawing.Size(118, 17);
            this.txtUsuarioTipo.Text = "toolStripStatusLabel1";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folderyellow_92963.png");
            this.imageList1.Images.SetKeyName(1, "exe_File_36909.png");
            this.imageList1.Images.SetKeyName(2, "Printer-blue_37120.png");
            this.imageList1.Images.SetKeyName(3, "gui_print_icon_157059.png");
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.panelOPCIONES);
            this.panel3.Controls.Add(this.panelMenu);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 647);
            this.panel3.TabIndex = 3;
            // 
            // panelOPCIONES
            // 
            this.panelOPCIONES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.panelOPCIONES.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOPCIONES.Location = new System.Drawing.Point(196, 0);
            this.panelOPCIONES.Name = "panelOPCIONES";
            this.panelOPCIONES.Size = new System.Drawing.Size(604, 647);
            this.panelOPCIONES.TabIndex = 4;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(231)))), ((int)(((byte)(220)))));
            this.panelMenu.Controls.Add(this.MenuProveedores);
            this.panelMenu.Controls.Add(this.button2);
            this.panelMenu.Controls.Add(this.MenuUsuarios);
            this.panelMenu.Controls.Add(this.btnUsuarios);
            this.panelMenu.Controls.Add(this.MenuFacturas);
            this.panelMenu.Controls.Add(this.btnFacturacion);
            this.panelMenu.Controls.Add(this.MenuProductos);
            this.panelMenu.Controls.Add(this.btnProductos);
            this.panelMenu.Controls.Add(this.MenuClientes);
            this.panelMenu.Controls.Add(this.btnClientes);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(196, 647);
            this.panelMenu.TabIndex = 3;
            // 
            // MenuUsuarios
            // 
            this.MenuUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(127)))));
            this.MenuUsuarios.Controls.Add(this.btnConsultarUsuarios);
            this.MenuUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuUsuarios.Location = new System.Drawing.Point(0, 483);
            this.MenuUsuarios.Name = "MenuUsuarios";
            this.MenuUsuarios.Size = new System.Drawing.Size(196, 50);
            this.MenuUsuarios.TabIndex = 8;
            this.MenuUsuarios.Visible = false;
            // 
            // btnConsultarUsuarios
            // 
            this.btnConsultarUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(127)))));
            this.btnConsultarUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultarUsuarios.FlatAppearance.BorderSize = 0;
            this.btnConsultarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarUsuarios.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F, System.Drawing.FontStyle.Bold);
            this.btnConsultarUsuarios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConsultarUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarUsuarios.Image")));
            this.btnConsultarUsuarios.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnConsultarUsuarios.Location = new System.Drawing.Point(0, 0);
            this.btnConsultarUsuarios.Name = "btnConsultarUsuarios";
            this.btnConsultarUsuarios.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnConsultarUsuarios.Size = new System.Drawing.Size(196, 37);
            this.btnConsultarUsuarios.TabIndex = 2;
            this.btnConsultarUsuarios.Text = "Consultar";
            this.btnConsultarUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultarUsuarios.UseVisualStyleBackColor = false;
            this.btnConsultarUsuarios.Click += new System.EventHandler(this.btnConsultarUsuarios_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(217)))), ((int)(((byte)(208)))));
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 13F, System.Drawing.FontStyle.Bold);
            this.btnUsuarios.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 446);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUsuarios.Size = new System.Drawing.Size(196, 37);
            this.btnUsuarios.TabIndex = 7;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // MenuFacturas
            // 
            this.MenuFacturas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(127)))));
            this.MenuFacturas.Controls.Add(this.btnImprimirFactura);
            this.MenuFacturas.Controls.Add(this.btnRegistrarFactura);
            this.MenuFacturas.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuFacturas.Location = new System.Drawing.Point(0, 361);
            this.MenuFacturas.Name = "MenuFacturas";
            this.MenuFacturas.Size = new System.Drawing.Size(196, 85);
            this.MenuFacturas.TabIndex = 6;
            this.MenuFacturas.Visible = false;
            // 
            // btnImprimirFactura
            // 
            this.btnImprimirFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(127)))));
            this.btnImprimirFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimirFactura.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImprimirFactura.FlatAppearance.BorderSize = 0;
            this.btnImprimirFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirFactura.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F, System.Drawing.FontStyle.Bold);
            this.btnImprimirFactura.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnImprimirFactura.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimirFactura.Image")));
            this.btnImprimirFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimirFactura.Location = new System.Drawing.Point(0, 37);
            this.btnImprimirFactura.Name = "btnImprimirFactura";
            this.btnImprimirFactura.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnImprimirFactura.Size = new System.Drawing.Size(196, 37);
            this.btnImprimirFactura.TabIndex = 3;
            this.btnImprimirFactura.Text = "Imprimir";
            this.btnImprimirFactura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimirFactura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimirFactura.UseVisualStyleBackColor = false;
            this.btnImprimirFactura.Click += new System.EventHandler(this.btnImprimirFactura_Click);
            // 
            // btnRegistrarFactura
            // 
            this.btnRegistrarFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(127)))));
            this.btnRegistrarFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarFactura.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistrarFactura.FlatAppearance.BorderSize = 0;
            this.btnRegistrarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarFactura.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegistrarFactura.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegistrarFactura.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarFactura.Image")));
            this.btnRegistrarFactura.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRegistrarFactura.Location = new System.Drawing.Point(0, 0);
            this.btnRegistrarFactura.Name = "btnRegistrarFactura";
            this.btnRegistrarFactura.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnRegistrarFactura.Size = new System.Drawing.Size(196, 37);
            this.btnRegistrarFactura.TabIndex = 2;
            this.btnRegistrarFactura.Text = "Registrar";
            this.btnRegistrarFactura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarFactura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrarFactura.UseVisualStyleBackColor = false;
            this.btnRegistrarFactura.Click += new System.EventHandler(this.btnRegistrarFactura_Click);
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(217)))), ((int)(((byte)(208)))));
            this.btnFacturacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFacturacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFacturacion.FlatAppearance.BorderSize = 0;
            this.btnFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturacion.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 13F, System.Drawing.FontStyle.Bold);
            this.btnFacturacion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFacturacion.Image = ((System.Drawing.Image)(resources.GetObject("btnFacturacion.Image")));
            this.btnFacturacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturacion.Location = new System.Drawing.Point(0, 324);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFacturacion.Size = new System.Drawing.Size(196, 37);
            this.btnFacturacion.TabIndex = 5;
            this.btnFacturacion.Text = "Facturacion";
            this.btnFacturacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFacturacion.UseVisualStyleBackColor = false;
            this.btnFacturacion.Click += new System.EventHandler(this.btnFacturacion_Click);
            // 
            // MenuProductos
            // 
            this.MenuProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(127)))));
            this.MenuProductos.Controls.Add(this.btnListaProductos);
            this.MenuProductos.Controls.Add(this.btnConsultaProductos);
            this.MenuProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuProductos.Location = new System.Drawing.Point(0, 239);
            this.MenuProductos.Name = "MenuProductos";
            this.MenuProductos.Size = new System.Drawing.Size(196, 85);
            this.MenuProductos.TabIndex = 4;
            this.MenuProductos.Visible = false;
            // 
            // btnListaProductos
            // 
            this.btnListaProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(127)))));
            this.btnListaProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListaProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListaProductos.FlatAppearance.BorderSize = 0;
            this.btnListaProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaProductos.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F, System.Drawing.FontStyle.Bold);
            this.btnListaProductos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnListaProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnListaProductos.Image")));
            this.btnListaProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaProductos.Location = new System.Drawing.Point(0, 37);
            this.btnListaProductos.Name = "btnListaProductos";
            this.btnListaProductos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnListaProductos.Size = new System.Drawing.Size(196, 37);
            this.btnListaProductos.TabIndex = 3;
            this.btnListaProductos.Text = "Lista";
            this.btnListaProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListaProductos.UseVisualStyleBackColor = false;
            // 
            // btnConsultaProductos
            // 
            this.btnConsultaProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(127)))));
            this.btnConsultaProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultaProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultaProductos.FlatAppearance.BorderSize = 0;
            this.btnConsultaProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaProductos.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F, System.Drawing.FontStyle.Bold);
            this.btnConsultaProductos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConsultaProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultaProductos.Image")));
            this.btnConsultaProductos.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnConsultaProductos.Location = new System.Drawing.Point(0, 0);
            this.btnConsultaProductos.Name = "btnConsultaProductos";
            this.btnConsultaProductos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnConsultaProductos.Size = new System.Drawing.Size(196, 37);
            this.btnConsultaProductos.TabIndex = 2;
            this.btnConsultaProductos.Text = "Consulta";
            this.btnConsultaProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultaProductos.UseVisualStyleBackColor = false;
            this.btnConsultaProductos.Click += new System.EventHandler(this.btnConsultaProductos_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(217)))), ((int)(((byte)(208)))));
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 13F, System.Drawing.FontStyle.Bold);
            this.btnProductos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos.Image")));
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(0, 202);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProductos.Size = new System.Drawing.Size(196, 37);
            this.btnProductos.TabIndex = 3;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // MenuClientes
            // 
            this.MenuClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(127)))));
            this.MenuClientes.Controls.Add(this.btnImprimirListaClientes);
            this.MenuClientes.Controls.Add(this.btnConsultaClientes);
            this.MenuClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuClientes.Location = new System.Drawing.Point(0, 117);
            this.MenuClientes.Name = "MenuClientes";
            this.MenuClientes.Size = new System.Drawing.Size(196, 85);
            this.MenuClientes.TabIndex = 2;
            this.MenuClientes.Visible = false;
            // 
            // btnImprimirListaClientes
            // 
            this.btnImprimirListaClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(127)))));
            this.btnImprimirListaClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimirListaClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImprimirListaClientes.FlatAppearance.BorderSize = 0;
            this.btnImprimirListaClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirListaClientes.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F, System.Drawing.FontStyle.Bold);
            this.btnImprimirListaClientes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnImprimirListaClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimirListaClientes.Image")));
            this.btnImprimirListaClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimirListaClientes.Location = new System.Drawing.Point(0, 37);
            this.btnImprimirListaClientes.Name = "btnImprimirListaClientes";
            this.btnImprimirListaClientes.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnImprimirListaClientes.Size = new System.Drawing.Size(196, 37);
            this.btnImprimirListaClientes.TabIndex = 3;
            this.btnImprimirListaClientes.Text = "Lista";
            this.btnImprimirListaClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimirListaClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimirListaClientes.UseVisualStyleBackColor = false;
            this.btnImprimirListaClientes.Click += new System.EventHandler(this.btnImprimirListaClientes_Click);
            // 
            // btnConsultaClientes
            // 
            this.btnConsultaClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(127)))));
            this.btnConsultaClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultaClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultaClientes.FlatAppearance.BorderSize = 0;
            this.btnConsultaClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaClientes.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F, System.Drawing.FontStyle.Bold);
            this.btnConsultaClientes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConsultaClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultaClientes.Image")));
            this.btnConsultaClientes.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnConsultaClientes.Location = new System.Drawing.Point(0, 0);
            this.btnConsultaClientes.Name = "btnConsultaClientes";
            this.btnConsultaClientes.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnConsultaClientes.Size = new System.Drawing.Size(196, 37);
            this.btnConsultaClientes.TabIndex = 2;
            this.btnConsultaClientes.Text = "Consulta";
            this.btnConsultaClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultaClientes.UseVisualStyleBackColor = false;
            this.btnConsultaClientes.Click += new System.EventHandler(this.btnConsultaClientes_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(217)))), ((int)(((byte)(208)))));
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 13F, System.Drawing.FontStyle.Bold);
            this.btnClientes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 80);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnClientes.Size = new System.Drawing.Size(196, 37);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // MenuProveedores
            // 
            this.MenuProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(127)))));
            this.MenuProveedores.Controls.Add(this.button1);
            this.MenuProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuProveedores.Location = new System.Drawing.Point(0, 570);
            this.MenuProveedores.Name = "MenuProveedores";
            this.MenuProveedores.Size = new System.Drawing.Size(196, 50);
            this.MenuProveedores.TabIndex = 10;
            this.MenuProveedores.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(127)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(196, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Consultar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(217)))), ((int)(((byte)(208)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 13F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 533);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(196, 37);
            this.button2.TabIndex = 9;
            this.button2.Text = "Proveedores";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 669);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturación APP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.MenuUsuarios.ResumeLayout(false);
            this.MenuFacturas.ResumeLayout(false);
            this.MenuProductos.ResumeLayout(false);
            this.MenuClientes.ResumeLayout(false);
            this.MenuProveedores.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel txtUsuario;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripStatusLabel txtNombreUsuario;
        private System.Windows.Forms.ToolStripStatusLabel txtUsuarioTipo;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Panel MenuClientes;
        private System.Windows.Forms.Button btnConsultaClientes;
        private System.Windows.Forms.Button btnImprimirListaClientes;
        private System.Windows.Forms.Panel panelOPCIONES;
        private System.Windows.Forms.Panel MenuProductos;
        private System.Windows.Forms.Button btnListaProductos;
        private System.Windows.Forms.Button btnConsultaProductos;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Panel MenuFacturas;
        private System.Windows.Forms.Button btnImprimirFactura;
        private System.Windows.Forms.Button btnRegistrarFactura;
        private System.Windows.Forms.Button btnFacturacion;
        private System.Windows.Forms.Panel MenuUsuarios;
        private System.Windows.Forms.Button btnConsultarUsuarios;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Panel MenuProveedores;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

