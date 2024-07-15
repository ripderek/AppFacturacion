using AppFacturacion2024.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFacturacion2024
{
    public partial class CrearEditarUsuario : Form
    {
        private bool accion_; 
        private ConexionBD conexion;

        public CrearEditarUsuario(bool accion,string nombres="", string identificacion="", string correo="", string usuario="", string contraseña="", string tipo="")
        {
            InitializeComponent();
            this.KeyPreview = true;
            accion_ = accion; 
            conexion = new ConexionBD();

            if (accion)

                lblEtiqueta.Text = "Crear Usuario";
            else
            {
                txtAceptar.Text = "Editar";
                txtCodigoUsuario.Visible = true;
                lblEtiqueta.Text = "Editar Usuario";
                txtIdentificacion.Visible = false;
                lblIdentificacion.Visible = false;
                txtCodigoUsuario.Text = identificacion;
                txtIdentificacion.Text = identificacion;
                txtNombres.Text = nombres;
                txtCorreo.Text = correo;
                txtUsuario.Text= usuario;
                txtContraseña.Text = contraseña;
                cbxTipo.Text = tipo;
            }


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

            // Obtnemos el ID del tipo de usuario seleccionado en el ComboBox para agregar o editar
            string tipoUsuarioSeleccionado = cbxTipo.SelectedItem.ToString();
            Usuario.id_tipo_usuario = Usuario.conexion.ObtenerIdTipoUsuarioPorNombre(tipoUsuarioSeleccionado);

            if (Usuario.id_tipo_usuario == -1)
            {
                MessageBox.Show("Error: Tipo de Usuario no encontrado en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            if (accion_) 
            {
                try
                {
                    Usuario.CrearUsuario();
                    MessageBox.Show("Usuario creado correctamente.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al crear usuario: " + ex.Message);
                }
            }
            else 
            {
                try
                {
                    Usuario.EditarUsuario();
                    MessageBox.Show("Usuario editado correctamente.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al editar usuario: " + ex.Message);
                }
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
