﻿using AppFacturacion2024.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AppFacturacion2024
{
    public partial class RegistrarFactura : Form
    {
        Factura objFactura = new Factura();
        public RegistrarFactura()
        {
            InitializeComponent();
        }
        private int ClienteID = 0;
        private void btnAñadirCliente_Click(object sender, EventArgs e)
        {
 
            //ConsultaCLientes.ShowDialog();
            using (ConsultaClientes frmClientes = new ConsultaClientes(true,false))
            {
                if (frmClientes.ShowDialog() == DialogResult.OK)
                {

                    ClienteID = frmClientes.ClienteID;
                    txtCorreo.Text = frmClientes.ClienteCorreo;
                    txtNombre.Text = frmClientes.ClienteNombre;
                    //txtIdentificacion.Text = frmClientes.ClienteIdentificacion;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Listar productos 
            using (ConsultaProductos frmProductos = new ConsultaProductos(true,false))
            {
                if (frmProductos.ShowDialog() == DialogResult.OK)
                {
                    //hay una funcion que verifica si el producto ya se encuentra en el datagridview
                    //verificar si el producto ya se encuentra dentro del datagriview
                    
                    if (VerificarIDproducto(frmProductos.CodigoProducto))
                    {
                        MessageBox.Show("El producto ya se encuentra en la lista");
                        return;
                    }
                   
                    //aqui enviar al datagridview directamente y realizar los calculos
   
                    dtListaProdutos.Rows.Add((dtListaProdutos.Rows.Count + 1).ToString(), frmProductos.CodigoProducto, frmProductos.ProductoNombre, frmProductos.PrecioUnitario,1, (1 * decimal.Parse(frmProductos.PrecioUnitario, CultureInfo.InvariantCulture)).ToString("N2"));
                    limpiar_controles();
                    //Calcular el subtotal sin descuento 
                    Calcular_Subtotal();
                    CalcularIVA();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
      
        private decimal cantidad;
        private decimal precio;
        private bool verificar_numeros()
        {
            /*
            string _cantidad = txtCantidad.Text;
            string _precio = txtPrecioUnitario.Text;
            decimal numeroDecimal;

            if (decimal.TryParse(_cantidad, out numeroDecimal))
                cantidad = decimal.Parse(_cantidad, CultureInfo.InvariantCulture);
            else
                return false;
            if (cantidad<=0)
                return false;
            if (decimal.TryParse(_precio, out numeroDecimal))
                precio = decimal.Parse(_precio, CultureInfo.InvariantCulture);
            else
                return false;
           
            */
            return true;
        }
        private bool verificar_controles()
        {
            /*
            if (string.IsNullOrWhiteSpace(txtCantidad.Text))
                return false; 
            */
            return true;
        }
        private void limpiar_controles()
        {/*
            txtCantidad.Text = "";
            txtProducto.Text = "";
            txtProductoCod.Text = "";
            txtPrecioUnitario.Text = "";
            */
        }
        private void Calcular_Subtotal()
        {
            decimal suma = 0;

            foreach (DataGridViewRow fila in dtListaProdutos.Rows)
            {
                if (fila.IsNewRow) continue; 

                if (fila.Cells[4].Value != null && decimal.TryParse(fila.Cells[5].Value.ToString(), out decimal valorCelda))
                {
                    suma += valorCelda;
                }
            }
            txtSubtotal.Text = suma.ToString();
            
            CalcularIVA();
        }
        //funcion para saber si un producto ya se encuentra dentro del data mediante el id del producto 
        private bool VerificarIDproducto(string idproducto)
        {
            foreach (DataGridViewRow fila in dtListaProdutos.Rows)
            {
                if (fila.IsNewRow) continue;

                if (fila.Cells[1].Value.ToString() == idproducto)
                {
                    return true; //ya esta dentro del datagridView
                }
            }
            return false;
        }
        private void CalcularIVA()
        {
            try
            {


                // Reemplazar comas por puntos en el texto del Subtotal y Descuento
                string subtotalText = txtSubtotal.Text.Replace(',', '.');
                string descuentoText = txtDescuento.Text.Replace(',', '.');

                decimal precioDeVenta = decimal.Parse(subtotalText, System.Globalization.CultureInfo.InvariantCulture);
                decimal descuento = 0;

                // Controlar el descuento si el texto de descuento no está vacío y es un número válido
                if (!string.IsNullOrWhiteSpace(descuentoText) && double.TryParse(descuentoText, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out _))
                {
                    descuento = decimal.Parse(descuentoText, System.Globalization.CultureInfo.InvariantCulture);
                    if (descuento >= 0)
                        //precioDeVenta -= descuento;
                        precioDeVenta = precioDeVenta - ((precioDeVenta * descuento) / 100);
                }

                decimal tasaDeIVA = 0.15m;
                decimal baseImponible = precioDeVenta;
                decimal iva = baseImponible * tasaDeIVA;
                decimal precioTotalConIVA = baseImponible + iva;
                txtDescuento.Text = decimal.Parse(descuentoText, System.Globalization.CultureInfo.InvariantCulture).ToString("N2");
                txtTotal.Text = precioTotalConIVA.ToString("N2");
            }
            catch (Exception ex)
            {

            }

        }


        private void txtDescuento_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    string descuentoText = txtDescuento.Text.Replace(',', '.');
                    decimal descuento_ = decimal.Parse(descuentoText, System.Globalization.CultureInfo.InvariantCulture);

                    if (descuento_ > 100 || descuento_ < 0)
                    {
                        MessageBox.Show("El descuento tiene que ser mayor igual a 0 y menor o igual a 100");
                        txtDescuento.Text = "0";
                        CalcularIVA();
                        return;
                    }
                    else
                    {
                        e.SuppressKeyPress = true;
                        CalcularIVA();
                    }

                }
            }
            catch (Exception ne)
            {
                txtDescuento.Text = "0";
                CalcularIVA();
                MessageBox.Show("El campo descuento no puede contener letras, caracteres especiales o espacios vacios    "+ne.Message);
            }
           
        }
        string codigoProducto = "";
        string cantidad_producto = "";
        private int rowIndex = -1;
        private void dtListaProdutos_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    if (e.RowIndex >= 0)
                    {
                        dtListaProdutos.CurrentCell = dtListaProdutos.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        //aqui se debe tomar los datos para abrir una nueva ventana si en caso quiere actualizar la linea 
                        menuOpciones.Show(Cursor.Position);
                        DataGridViewRow row = dtListaProdutos.Rows[e.RowIndex];
                        codigoProducto = row.Cells[1].Value.ToString();
                        cantidad_producto = row.Cells[4].Value.ToString();

                        //indice de la fila seleccionada
                        rowIndex = e.RowIndex;
                    }
                }
                catch (Exception en)
                {
                    MessageBox.Show(en.Message);
                }
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rowIndex >= 0 && rowIndex < dtListaProdutos.Rows.Count)
            {
                // Eliminar la fila en el índice almacenado
                dtListaProdutos.Rows.RemoveAt(rowIndex);

                // Reiniciar el índice después de eliminar
                rowIndex = -1;
                Calcular_Subtotal();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila válida para eliminar.");
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nueva_cantidad = "";
            //abrir el editor skere modo diablo skere skere skere skere
            //EditarProductoDetalleFactura editor = new EditarProductoDetalleFactura(cantidad_producto);
            using (EditarProductoDetalleFactura editor = new EditarProductoDetalleFactura(cantidad_producto))
            {
                if (editor.ShowDialog() == DialogResult.OK)
                {
                    nueva_cantidad = editor.NuevaCantidad;
                    //MessageBox.Show("Nueva cantidad a editar" + nueva_cantidad);
                    //editar la cantidad y hacer el nuevo calculo de la cantidad * el precio unitario y volver a calcular el subtotal, dscuento e iva
                    DataGridViewRow row = dtListaProdutos.Rows[rowIndex];
                    row.Cells[4].Value = nueva_cantidad;
                    //row.Cells[5].Value = el valor de la celda [3] * nueva_cantidad
                    decimal precioUnitario = Convert.ToDecimal(row.Cells[3].Value, CultureInfo.InvariantCulture);

                    decimal nuevaCantidad = Convert.ToDecimal(nueva_cantidad);
                    decimal nuevoSubtotal = precioUnitario * nuevaCantidad;

                    // Actualizar el subtotal
                    row.Cells[5].Value = nuevoSubtotal;
                    Calcular_Subtotal();
                }
            }
        }

        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //hacer la validacion de que el codigo del cliente no puede estar vacio
            //hacer la validacinn de que el datagrid no puede estar vacio tambien 
            //si no existe descuento valido ira con descuento 0
            if (verificarCOdeUser())
            {
                if (DataGridViewNoEstaVacio())
                {
                        //aqui enviar la factura 
                        string XML = ConstruirXmlFactura();
                        System.Console.WriteLine(XML);
                        objFactura.XML_Factura1 = XML;
                        objFactura.CrearFactura();
                        VerFacturaGenerada();
                        Limpiar();
                        //funcion para ver la factura generada;
                }
                else
                    MessageBox.Show("La factura esta incompleta, {se esperaba el detalle}");

            }

            else
                MessageBox.Show("La factura esta incompleta, {se esperaba un cliente}");
        }
        //verficar que el codigo del cliente no este en blaco 
        private bool verificarCOdeUser()
        {
            /*
            if (string.IsNullOrWhiteSpace(txtCodigoCliente.Text))
                return false;
            return true;
            */
            return true;
        }
        private bool DataGridViewNoEstaVacio( )
        {
            // Verificar si hay filas
            if (dtListaProdutos.Rows.Count > 0)
            {
                // Verificar si la última fila es la fila de nueva fila (AllowUserToAddRows)
                if (dtListaProdutos.Rows.Count == 1 && dtListaProdutos.Rows[0].IsNewRow)
                {
                    return false;
                }

                // Verificar si hay filas que no sean la fila de nueva fila
                foreach (DataGridViewRow row in dtListaProdutos.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        //generador del xml para enviarlo a la base de datos como parametro 
        private string ConstruirXmlFactura()
        {
            // Crear un nuevo documento XML
            XmlDocument doc = new XmlDocument();

            // Crear el nodo raíz
            XmlElement root = doc.CreateElement("Factura");
            doc.AppendChild(root);

            // Crear el nodo Cliente
            XmlElement cliente = doc.CreateElement("Cliente");
            root.AppendChild(cliente);

            XmlElement correo = doc.CreateElement("UsuarioCliente");
            correo.InnerText = ClienteID.ToString();
            cliente.AppendChild(correo);

            //Descuento asignado
            XmlElement descuento = doc.CreateElement("Descuento");
            //controlar el descuento si el texto de descuento 
            string discount = "0";
            if (!string.IsNullOrWhiteSpace(txtDescuento.Text) && double.TryParse(txtDescuento.Text, out _))
            {
                discount = txtDescuento.Text.Replace(",", ".");
            }

            descuento.InnerText = discount.ToString();
            cliente.AppendChild(descuento);

            XmlElement usuariovendedor = doc.CreateElement("UsuarioVendedor");
            usuariovendedor.InnerText = Usuario.id_usuario.ToString();
            cliente.AppendChild(usuariovendedor);


            // Crear el nodo Items
            XmlElement items = doc.CreateElement("Items");
            root.AppendChild(items);



            // Recorrer el DataGridView para añadir los ítems
            foreach (DataGridViewRow row in dtListaProdutos.Rows)
            {
                if (!row.IsNewRow) // Ignorar la fila de nueva fila
                {
                    XmlElement item = doc.CreateElement("Item");

                    XmlElement codigo = doc.CreateElement("Codigo");
                    codigo.InnerText = row.Cells[1].Value.ToString(); // Índice 0 para Código
                    item.AppendChild(codigo);

                  

                    XmlElement cantidad = doc.CreateElement("Cantidad");
                    cantidad.InnerText = row.Cells[4].Value.ToString(); // Índice 2 para Cantidad
                    item.AppendChild(cantidad);

                    items.AppendChild(item);
                }
            }

            // Devolver el XML como cadena
            return doc.OuterXml;
        }

        private void RegistrarFactura_Load(object sender, EventArgs e)
        {

        }

        //limpiar los controles xd 
        private void Limpiar()
        {
            dtListaProdutos.Rows.Clear();
            //txtCodigoCliente.Text = "";
            txtCorreo.Text = "";
            txtNombre.Text = "";
           /// txtProductoCod.Text = "";
          //  txtProducto.Text = "";
          //  txtPrecioUnitario.Text = "";
          //  txtCantidad.Text = "";
            txtSubtotal.Text = "0";
            txtDescuento.Text = "0";
            txtTotal.Text = "0";
        }
        //ver la factura recien generada 
        private void VerFacturaGenerada()
        {
            //obtener la ultima factura generada del cliente skere modo diablo
            int ultimaFactura = objFactura.ObtenerUltimaFactura(ClienteID);
            VizualizarFactura vizualizarFactura = new VizualizarFactura(ultimaFactura);
            vizualizarFactura.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtListaProdutos_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                try
                {
                    if (!int.TryParse(e.FormattedValue.ToString(), out int cantidad) || cantidad < 0)
                    {
                        e.Cancel = true;
                        MessageBox.Show("Por favor, ingrese un número entero válido para la cantidad.");
                    }
                }
                catch (Exception ne)
                {
                   
                    MessageBox.Show(ne.Message);
                }
            }
        }

        private void dtListaProdutos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                try {
                    // Obtener la fila actual
                    var row = dtListaProdutos.Rows[e.RowIndex];

                    int cantidad = Convert.ToInt32(row.Cells[4].Value);
                    decimal precioUnitario = Convert.ToDecimal(row.Cells[3].Value, CultureInfo.InvariantCulture);

                    row.Cells[5].Value = (cantidad * precioUnitario).ToString("N2");
                    Calcular_Subtotal();
                }
                catch(Exception ne)
                {
                    
                }
                    
            }
        }

        private void dtListaProdutos_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            Calcular_Subtotal();
        }
    }
}
