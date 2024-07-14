using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AppFacturacion2024.Clases
{
    internal static class Usuario 
    {
        static ConexionBD conexion = new ConexionBD();
        //atributos de la clase 
        static public int id_usuario;
        static public string nombres;
        static public string identificacion;
        static public string correo;
        static public string usuario;
        static public string tipo;
        static public int id_tipo_usuario;


        //Funcion para iniciar sesion y retornar los datos del usuario
        static public DataTable Verificar_Inicio_Sesion(string usuario, string contrasena)
        {
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

    }
}
