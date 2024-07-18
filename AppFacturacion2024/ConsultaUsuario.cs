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
    public partial class ConsultaUsuario : Form

    {

        bool accion_ = false;

        public ConsultaUsuario(bool acccion = false)
        {
            InitializeComponent();
            this.KeyPreview = true;
            accion_ = acccion;
            dtListaUsuario.KeyDown += new KeyEventHandler(dtListaUsuario_KeyDown);
            dtListaUsuario.CellEnter += new DataGridViewCellEventHandler(dtListaUsuario_CellEnter);
        }

        private void ConsultaUsuario_Load(object sender, EventArgs e)
        {
            ConsultaUsuarioLista();
            
        }
        private void ConsultaUsuarioLista()
        {
            DataTable dataTable = Usuario.Listar_usuarios();
            LlenarGrid(dataTable);      
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void crearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearEditarUsuario ventana_crear_editar_usuarios = new CrearEditarUsuario(true);
            ventana_crear_editar_usuarios.ShowDialog();
            ConsultaUsuarioLista();
        }

        private void dtListaUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.O)
            {
                if (currentRowIndex >= 0 && currentColumnIndex >= 0)
                {
                    dtListaUsuario.CurrentCell = dtListaUsuario.Rows[currentRowIndex].Cells[currentColumnIndex];
                    Rectangle cellRectangle = dtListaUsuario.GetCellDisplayRectangle(currentColumnIndex, currentRowIndex, false);
                    Point cellLocation = dtListaUsuario.PointToScreen(new Point(cellRectangle.X, cellRectangle.Y));
                    menuOpciones.Show(cellLocation);
                    DataGridViewRow row = dtListaUsuario.Rows[currentRowIndex];

                    Usuario.identificacion = row.Cells[0].Value.ToString();
                    Usuario.nombres = row.Cells[1].Value.ToString();
                    Usuario.correo = row.Cells[2].Value.ToString();
                    Usuario.usuario = row.Cells[3].Value.ToString();
                    //Usuario.contraseña = row.Cells[4].Value.ToString();
                    Usuario.tipo = row.Cells[4].Value.ToString();
                }
                e.Handled = true; 
            }
        }
        private int currentRowIndex = -1;
        private int currentColumnIndex = -1;

        private void dtListaUsuario_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtListaUsuario_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    if (e.RowIndex >= 0)
                    {
                        dtListaUsuario.CurrentCell = dtListaUsuario.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        menuOpciones.Show(Cursor.Position);
                        DataGridViewRow row = dtListaUsuario.Rows[e.RowIndex];

                        Usuario.nombres = row.Cells[0].Value.ToString();
                        Usuario.identificacion = row.Cells[1].Value.ToString();
                        Usuario.correo = row.Cells[2].Value.ToString();
                        Usuario.usuario = row.Cells[3].Value.ToString();
                        //Usuario.contraseña = row.Cells[4].Value.ToString();
                        Usuario.tipo = row.Cells[4].Value.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public string UsuarioNombre { get; private set; }
        public string UsuarioCorreo { get; private set; }
        public string UsuarioUsuario { get; private set; }
        public string UsuarioContraseña { get; private set; }
        public string UsuarioTipo { get; private set; }

        private void dtListaUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtListaUsuario.Rows[e.RowIndex];

                UsuarioNombre = row.Cells[1].Value.ToString(); 
                UsuarioCorreo = row.Cells[2].Value.ToString(); 
                UsuarioUsuario = row.Cells[3].Value.ToString(); 
               // UsuarioContraseña = row.Cells[4].Value.ToString(); 
                UsuarioTipo = row.Cells[4].Value.ToString(); 

                this.DialogResult = DialogResult.OK;
               // this.Close();
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearEditarUsuario ventana_crear_editar_usuario = new CrearEditarUsuario(
         false, 
         Usuario.nombres,
         Usuario.identificacion,
         Usuario.correo,
         Usuario.usuario,
         "",
         Usuario.tipo
     );
            ventana_crear_editar_usuario.ShowDialog();
            ConsultaUsuarioLista(); 
        }

        private void ConsultaUsuario_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Estás seguro de que deseas eliminar este usuario?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Usuario.EliminarUsuario();
                    ConsultaUsuarioLista(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            CrearEditarUsuario ventana_crear_editar_usuarios = new CrearEditarUsuario(true);
            ventana_crear_editar_usuarios.ShowDialog();
            ConsultaUsuarioLista();
        }
        private void LlenarGrid(DataTable dataTable)
        {
            if (dataTable != null)
            {
                dtListaUsuario.DataSource = dataTable; //para enviarla directamente al data source 
            }
            else
            {
                MessageBox.Show("No se pudo obtener datos de la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Buscador();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscador();
        }
        private void Buscador()
        {
            //controlar que el select del combobox no este vacio o nullo skere modo diablo
            if (cmbBuscar.SelectedItem != null)
            {
                //MessageBox.Show(cmbBuscar.SelectedItem.ToString());
                //accionar el buscador
                BusquedaEspeficia(txtBuscar.Text, cmbBuscar.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Seleccione un filtro de busqueda");
            }
        }
        private void BusquedaEspeficia(string Palabra_Clave, string Columna)
        {
            DataTable dataTable = Usuario.Buscar_Usuario_columna_especifica(Palabra_Clave, Columna);
            LlenarGrid(dataTable);
        }

        private void ConsultaUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.R)
            {
                ConsultaUsuarioLista();
            }
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}
