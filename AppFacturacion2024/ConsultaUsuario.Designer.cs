namespace AppFacturacion2024
{
    partial class ConsultaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaUsuario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBuscar = new System.Windows.Forms.ComboBox();
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.dtListaUsuario = new System.Windows.Forms.DataGridView();
            this.menuOpciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            this.panelOpciones.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtListaUsuario)).BeginInit();
            this.menuOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panelOpciones);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 65);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.txtBuscar);
            this.panel3.Controls.Add(this.btnBuscar);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cmbBuscar);
            this.panel3.Location = new System.Drawing.Point(358, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(430, 48);
            this.panel3.TabIndex = 22;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI Variable Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(187, 8);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(182, 27);
            this.txtBuscar.TabIndex = 18;
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(375, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(46, 41);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Buscar:";
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscar.FormattingEnabled = true;
            this.cmbBuscar.Items.AddRange(new object[] {
            "ID_USUARIO",
            "NOMBRES",
            "IDENTIFICACION",
            "CORREO",
            "TELEFONO",
            "USUARIO",
            "TIPO"});
            this.cmbBuscar.Location = new System.Drawing.Point(60, 13);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(121, 21);
            this.cmbBuscar.TabIndex = 16;
            // 
            // panelOpciones
            // 
            this.panelOpciones.Controls.Add(this.btnFacturacion);
            this.panelOpciones.Location = new System.Drawing.Point(12, 8);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(245, 51);
            this.panelOpciones.TabIndex = 16;
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(217)))), ((int)(((byte)(208)))));
            this.btnFacturacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFacturacion.FlatAppearance.BorderSize = 0;
            this.btnFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturacion.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 13F, System.Drawing.FontStyle.Bold);
            this.btnFacturacion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFacturacion.Image = ((System.Drawing.Image)(resources.GetObject("btnFacturacion.Image")));
            this.btnFacturacion.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnFacturacion.Location = new System.Drawing.Point(12, 8);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnFacturacion.Size = new System.Drawing.Size(192, 37);
            this.btnFacturacion.TabIndex = 14;
            this.btnFacturacion.Text = "Agregar";
            this.btnFacturacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFacturacion.UseVisualStyleBackColor = false;
            this.btnFacturacion.Click += new System.EventHandler(this.btnFacturacion_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtBuscador);
            this.panel2.Controls.Add(this.dtListaUsuario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 385);
            this.panel2.TabIndex = 5;
            // 
            // txtBuscador
            // 
            this.txtBuscador.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscador.Location = new System.Drawing.Point(268, 95);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(241, 31);
            this.txtBuscador.TabIndex = 1;
            this.txtBuscador.Visible = false;
            // 
            // dtListaUsuario
            // 
            this.dtListaUsuario.AllowUserToAddRows = false;
            this.dtListaUsuario.AllowUserToDeleteRows = false;
            this.dtListaUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtListaUsuario.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtListaUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtListaUsuario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtListaUsuario.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dtListaUsuario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtListaUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtListaUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListaUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtListaUsuario.Location = new System.Drawing.Point(0, 0);
            this.dtListaUsuario.MultiSelect = false;
            this.dtListaUsuario.Name = "dtListaUsuario";
            this.dtListaUsuario.ReadOnly = true;
            this.dtListaUsuario.Size = new System.Drawing.Size(800, 385);
            this.dtListaUsuario.TabIndex = 0;
            this.dtListaUsuario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtListaUsuario_CellDoubleClick);
            this.dtListaUsuario.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtListaUsuario_CellEnter);
            this.dtListaUsuario.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtListaUsuario_CellMouseDown);
            this.dtListaUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtListaUsuario_KeyDown);
            // 
            // menuOpciones
            // 
            this.menuOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.menuOpciones.Name = "menuOpciones";
            this.menuOpciones.Size = new System.Drawing.Size(118, 48);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // ConsultaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ConsultaUsuario";
            this.Text = "ConsultaUsuario";
            this.Load += new System.EventHandler(this.ConsultaUsuario_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConsultaUsuario_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ConsultaUsuario_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            this.panelOpciones.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtListaUsuario)).EndInit();
            this.menuOpciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.DataGridView dtListaUsuario;
        private System.Windows.Forms.ContextMenuStrip menuOpciones;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.Panel panelOpciones;
        private System.Windows.Forms.Button btnFacturacion;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.PictureBox btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBuscar;
    }
}