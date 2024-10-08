﻿using AppFacturacion2024.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppFacturacion2024
{
    public partial class CrearEditarUsuario : Form
    {
        private bool accion_; 
        private ConexionBD conexion;

        public CrearEditarUsuario(bool accion, int id_usuario=0, string nombres="", string identificacion="", string correo="", string usuario="", string contraseña="", string tipo="", string telefono="")
        {
            InitializeComponent();
            this.KeyPreview = true;
            accion_ = accion; 
            conexion = new ConexionBD();
            cbxTipo.SelectedIndex = 1;
            if (accion)

                lblEtiqueta.Text = "Crear Usuario";
            else
            {
                txtAceptar.Text = "Editar";
                txtCodigoUsuario.Visible = true;
                lblEtiqueta.Text = "Editar Usuario";
                txtCodigoUsuario.Text = id_usuario.ToString();
                txtIdentificacion.Text = identificacion;
                txtNombres.Text = nombres;
                txtCorreo.Text = correo;
                txtUsuario.Text= usuario;
                txtContraseña.Text = contraseña;
                cbxTipo.Text = tipo;
                txtTelefono.Text = telefono;
            }
            //darle los eventos a los txt 
            txtNombres.KeyDown += new KeyEventHandler(TeclaEnter);
            txtIdentificacion.KeyDown += new KeyEventHandler(TeclaEnter);
            txtCorreo.KeyDown += new KeyEventHandler(TeclaEnter);
            txtUsuario.KeyDown += new KeyEventHandler(TeclaEnter);
            txtContraseña.KeyDown += new KeyEventHandler(TeclaEnter);
            txtTelefono.KeyDown += new KeyEventHandler(TeclaEnter);
            cbxTipo.KeyDown += new KeyEventHandler(TeclaEnter);

        }
        private void TeclaEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CrearEditarUsuarios();

            }
        }

        private void txtAceptar_Click(object sender, EventArgs e)
        {
            CrearEditarUsuarios();
        }
        private void CrearEditarUsuarios()
        {
            Usuario.identificacion = txtIdentificacion.Text;
            Usuario.nombres = txtNombres.Text;
            Usuario.correo = txtCorreo.Text;
            Usuario.usuario = txtUsuario.Text;
            Usuario.contraseña = txtContraseña.Text;
            Usuario.telefono = txtTelefono.Text;


            if (cbxTipo.SelectedItem != null)
            {
                // Obtenemos el ID del tipo de usuario seleccionado en el ComboBox para agregar o editar
                string tipoUsuarioSeleccionado = cbxTipo.SelectedItem.ToString();
                Usuario.id_tipo_usuario = Usuario.conexion.ObtenerIdTipoUsuarioPorNombre(tipoUsuarioSeleccionado);
                if (accion_)
                {
                    bool indicador = Usuario.CrearUsuario();
                    if (indicador) this.Close();
                }
                else
                {
                    Usuario.id_usuario = int.Parse(txtCodigoUsuario.Text);
                    bool indicador = Usuario.EditarUsuario();
                    if (indicador) this.Close();
                }
            }
            if (Usuario.id_tipo_usuario == -1)
            {
                MessageBox.Show("Error: Tipo de Usuario no encontrado en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }

        private void cbxTipo_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void CrearEditarUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

    }
}
