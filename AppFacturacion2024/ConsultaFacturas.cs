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
    public partial class ConsultaFacturas : Form
    { 
        Factura obj_facturas = new Factura();
        bool accion_ = false;
    
        public ConsultaFacturas(bool accion = false)
        {
            InitializeComponent();
            this.KeyPreview = true;
            accion_ = accion;
            txtBuscar.Select();
            txtBuscar.Focus();
            cmbBuscar.SelectedIndex = 1;
        }

        private void ConsultaFacturasLista()
        {
            //DataTable dataTable = obj_facturas.Listar_Facturas();
            //LlenarGrid(dataTable);
        }

        private void ConsultaFacturas_Load(object sender, EventArgs e)
        {
           // ConsultaFacturasLista();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de que deseas eliminar esta factura?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    obj_facturas.Eliminar_Factura();
                    //ConsultaFacturasLista();
                    Buscador();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

           
        }

        private void dtLisaFacturas_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    if (e.RowIndex >= 0)
                    {
                        dtLisaFacturas.CurrentCell = dtLisaFacturas.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        //aqui se debe tomar los datos para abrir una nueva ventana si en caso quiere actualizar la linea 
                        menuOpciones.Show(Cursor.Position);
                        DataGridViewRow row = dtLisaFacturas.Rows[e.RowIndex];
                        obj_facturas.COD_FACTURA_ = row.Cells[0].Value.ToString();
                        obj_facturas.COD_CLIENTE_ = row.Cells[1].Value.ToString();
                        obj_facturas.ESTABLECIMIENTO_ = row.Cells[2].Value.ToString();
                        obj_facturas.SUCURSAL_ = row.Cells[3].Value.ToString();
                        obj_facturas.FECHA_EMISION_ = row.Cells[4].Value.ToString();
                        obj_facturas.NUMERO_AUTORIZACION_ = row.Cells[5].Value.ToString();
                        obj_facturas.NOMBRE_CLIENTE_ = row.Cells[6].Value.ToString();
                        obj_facturas.IDENTIFICACION_CLIENTE_ = row.Cells[7].Value.ToString();
                        obj_facturas.CORREO_CLIENTE_ = row.Cells[8].Value.ToString();
                        obj_facturas.DIRECCION_CLIENTE_ = row.Cells[9].Value.ToString();
                        obj_facturas.DESCUENTO_ = row.Cells[10].Value.ToString();
                        obj_facturas.IVA_ = row.Cells[11].Value.ToString();
                    }
                }
                catch (Exception en)
                {
                    MessageBox.Show(en.Message);
                }
            }
        }

        private void dtLisaFacturas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que el índice de la fila no sea el de los encabezados de columna
            if (e.RowIndex >= 0)
            {
                // Obtiene la fila actual
                DataGridViewRow row = dtLisaFacturas.Rows[e.RowIndex];
                
                string COD_FACTURA_ = row.Cells[0].Value.ToString();

               //MessageBox.Show(COD_FACTURA_);

                VizualizarFactura vizualizarFactura = new VizualizarFactura(int.Parse(COD_FACTURA_));
                vizualizarFactura.ShowDialog();

            }
        }

        private void ConsultaFacturas_KeyDown(object sender, KeyEventArgs e)
        {/*
            if (e.Control && e.KeyCode == Keys.B)
            {
                txtBuscador.Visible = true;
                txtBuscador.BringToFront();
                txtBuscador.Focus();
            }
           
            if (e.Control && e.KeyCode == Keys.R)
            {
                ConsultaFacturasLista();
            }*/
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void txtBuscador_KeyDown(object sender, KeyEventArgs e)
        {
            //detectar si se da enter para aceptar la busqueda del texto que contiene
            if (e.KeyCode == Keys.Enter)
            {
                //funcion para buscar
                Busqueda_Palabra_Clave();
                txtBuscador.Visible = false;
                txtBuscador.Text = "";

            }
        }
        private void Busqueda_Palabra_Clave()
        {
            DataTable dataTable = obj_facturas.Buscar_Factura(txtBuscador.Text);
            LlenarGrid(dataTable);
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
            DataTable dataTable = obj_facturas.Buscar_Factura_columna_especifica(Palabra_Clave, Columna);
            LlenarGrid(dataTable);
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
        private void LlenarGrid(DataTable dataTable)
        {
            if (dataTable != null)
            {
                dtLisaFacturas.DataSource = dataTable; //para enviarla directamente al data source 
            }
            else
            {
                MessageBox.Show("No se pudo obtener datos de la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
