using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace AppFacturacion2024.Clases
{
    internal static class Usuario 
    {
        public static ConexionBD conexion = new ConexionBD();


        //atributos de la clase 
        static public int id_usuario;
        static public string nombres;
        static public string identificacion;
        static public string correo;
        static public string usuario;
        static public string tipo;
        static public string contraseña;
        static public int id_tipo_usuario;



        //Funcion para iniciar sesion y retornar los datos del usuario
        static public DataTable Verificar_Inicio_Sesion(string usuario, string contrasena)
        {
            ManejoSesion.Instance.UsuarioVendedor = usuario;
            string sql = "SP_INICIO_SESION";

            var parametros = new List<System.Data.SqlClient.SqlParameter>
             {
                 new System.Data.SqlClient.SqlParameter("@USUARIO", usuario),
                 new System.Data.SqlClient.SqlParameter("@CONTRASENA", contrasena)
             };
            DataTable Datos = conexion.Cargar_Data_Table(sql, parametros);
            GuardarDatosSesion(Datos);
            return Datos;
        }
        static private void GuardarDatosSesion( DataTable InfoUsuario)
        {
            if (InfoUsuario != null && InfoUsuario.Rows.Count > 0 && InfoUsuario.Columns.Count > 0)
            {
                DataRow fila = InfoUsuario.Rows[0];
                //string usuarioIDPorIndice = fila[0].ToString();
                id_usuario =int.Parse( fila[0].ToString());
                nombres= fila[1].ToString();
                identificacion = fila[2].ToString();
                correo = fila[3].ToString();
                usuario = fila[4].ToString();
                tipo = fila[5].ToString();
                id_tipo_usuario = int.Parse(fila[6].ToString());
            }
        }
        static public bool CrearUsuario()
        {
            string sql = "SP_CREAR_USUARIO";
            // crear parametros

            var parametros = new List<System.Data.SqlClient.SqlParameter>
            {
                new System.Data.SqlClient.SqlParameter("@NOMBRES", nombres),
                new System.Data.SqlClient.SqlParameter("@IDENTIFICACION", identificacion),
                new System.Data.SqlClient.SqlParameter("@CORREO", correo),
                new System.Data.SqlClient.SqlParameter("@USUARIO", usuario),
                new System.Data.SqlClient.SqlParameter("@CONTRASENA", contraseña),
                new System.Data.SqlClient.SqlParameter("@ID_TIPO_USUARIO", id_tipo_usuario),
            };
            conexion.ConcatenacionCadena(sql, parametros);
            return conexion.TransaccionCompleta;
        }
        static public bool EditarUsuario()  
        {
            string sql = "SP_EDITAR_USUARIO";
            // crear parametros

            var parametros = new List<System.Data.SqlClient.SqlParameter>
            {
                new System.Data.SqlClient.SqlParameter("@NOMBRES", nombres),
                new System.Data.SqlClient.SqlParameter("@IDENTIFICACION", identificacion),
                new System.Data.SqlClient.SqlParameter("@CORREO", correo),
                new System.Data.SqlClient.SqlParameter("@USUARIO", usuario),
                new System.Data.SqlClient.SqlParameter("@CONTRASENA", contraseña),
                new System.Data.SqlClient.SqlParameter("@ID_TIPO_USUARIO", id_tipo_usuario),
            };
            conexion.ConcatenacionCadena(sql, parametros);
            return conexion.TransaccionCompleta;
        }
        static public DataTable Listar_usuarios()
        {
            return conexion.Cargar_Data_Table("EXEC SP_Mostrar_Usuarios;");
        }
        //Buscar_Usuario_columna_especifica
        static public DataTable Buscar_Usuario_columna_especifica(string Palabra_Clave, string Columna)
        {
            //return Cargar_Data_Table("[SP_Buscar_Producto]'" + Palabra_Clave + "'");
            string sql = "SP_BUSQUEDA_ESPECIFICA_USUARIOS";

            var parametros = new List<System.Data.SqlClient.SqlParameter>
             {
                      new System.Data.SqlClient.SqlParameter("@Palabra_Clave", Palabra_Clave),
                      new System.Data.SqlClient.SqlParameter("@Columna", Columna)
             };
            return conexion.Cargar_Data_Table(sql, parametros);
        }

        static public void EliminarUsuario()
        {
            string sql = "SP_ELIMINAR_USUARIO";
            var parametros = new List<SqlParameter>
        {
            new SqlParameter("@IDENTIFICACION", identificacion)
        };

            try
            {
                conexion.ConcatenacionCadena(sql, parametros);
                MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
