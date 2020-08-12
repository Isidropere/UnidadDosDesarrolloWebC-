using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Diplomado_Desarrollo_Producto.Web.Models
{
    public class RegistroProducto
    {
        private SqlConnection Conn;
        private void Conexion()
        {
            string ConSTR = ConfigurationManager.ConnectionStrings["ConexionDB"].ToString();
            Conn = new SqlConnection(ConSTR);
        }
        /*se Inserta el registro en la base de datos*/
        public int GrabarProductoRegistro(Producto produc)
        {
            Conexion();
            SqlCommand ComandoExec = new SqlCommand("INSERT INTO TBL_PRODUCTO " +
                                                     "(Descripcion, Tipo, Precio)" +
                                                    " VALUES(@Descripcion, @Tipo, @Precio)" ,Conn);
            ComandoExec.Parameters.Add("@Descripcion", SqlDbType.VarChar);
            ComandoExec.Parameters.Add("@Tipo", SqlDbType.VarChar);
            ComandoExec.Parameters.Add("@Precio", SqlDbType.Float);
            //-----------------------------------------------------
            ComandoExec.Parameters["@Descripcion"].Value = produc.Descripcion;
            ComandoExec.Parameters["@Tipo"].Value = produc.Tipo;
            ComandoExec.Parameters["@Precio"].Value = produc.Precio;
            Conn.Open();
            int i = ComandoExec.ExecuteNonQuery();
            Conn.Close();
            return i;
        }
        /*Muestra un registro todos los productos*/
        public List<Producto> RecuperarTodosRegistro()
        {
            Conexion();
            List<Producto> productos = new List<Producto>();
            SqlCommand ComandoExec = new SqlCommand("SELECT ID, Descripcion,Tipo,Precio " +
                                                    "FROM TBL_PRODUCTO",Conn);
            Conn.Open();
            SqlDataReader Registros = ComandoExec.ExecuteReader();
            while (Registros.Read())
            {
                Producto Product = new Producto
                {
                   ID = int.Parse(Registros["ID"].ToString()),
                   Descripcion = Registros["Descripcion"].ToString(),
                   Tipo = Registros["Tipo"].ToString(),
                    Precio = float.Parse(Registros["Precio"].ToString())
                };
                productos.Add(Product);
            }
            Conn.Close();
            return productos;
        }
        /*Mostrar un registro especifico de la base de datos */
        public Producto RecuperaUnoRegistro(int id)
        {
            Conexion();
            SqlCommand ComandoExec = new SqlCommand("SELECT ID, Descripcion,Tipo,Precio " +
                                                    "FROM TBL_PRODUCTO WHERE ID =@ID", Conn);
            ComandoExec.Parameters.Add("@ID", SqlDbType.Int);
            ComandoExec.Parameters["@ID"].Value = id;
            Conn.Open();
            SqlDataReader Registro = ComandoExec.ExecuteReader();
            Producto Product = new Producto();
            if (Registro.Read())
            {
                Product.ID = int.Parse(Registro["ID"].ToString());
                Product.Descripcion = Registro["Descripcion"].ToString();
                Product.Tipo = Registro["Tipo"].ToString();
                Product.Precio = float.Parse(Registro["Precio"].ToString());
            }
            Conn.Close();
            return Product;
        }
        /*modificar unregistro de la base de datos*/
        public int ModificarActualizar(Producto produc)
        {
            Conexion();
            SqlCommand ComandoExec = new SqlCommand("UPDATE TBL_PRODUCTO SET  Descripcion = @Descripcion, Tipo = @Tipo, Precio = @Precio " +
                                                    " WHERE ID = @ID", Conn);
            ComandoExec.Parameters.Add("@ID", SqlDbType.Int);
            ComandoExec.Parameters["@ID"].Value = produc.ID;
            //----------------------------------------------------
            ComandoExec.Parameters.Add("@Descripcion", SqlDbType.VarChar);
            ComandoExec.Parameters["@Descripcion"].Value = produc.Descripcion;
            //-----------------------------------------------------
            ComandoExec.Parameters.Add("@Tipo", SqlDbType.VarChar);
            ComandoExec.Parameters["@Tipo"].Value = produc.Tipo;
            //-----------------------------------------------------
            ComandoExec.Parameters.Add("@Precio", SqlDbType.Float);
            ComandoExec.Parameters["@Precio"].Value = produc.Precio;

            Conn.Open();
            int i = ComandoExec.ExecuteNonQuery();
            Conn.Close();
            return i;
        }
        /*Paa borrar un registro especifico de la BD*/
        public int BorrarUnoRegistro(int id)
        {
            Conexion();
            SqlCommand ComandoExec = new SqlCommand("DELETE  FROM TBL_PRODUCTO WHERE ID =@ID", Conn);
            ComandoExec.Parameters.Add("@ID", SqlDbType.Int);
            ComandoExec.Parameters["@ID"].Value = id;
            Conn.Open();
            int i = ComandoExec.ExecuteNonQuery();
            Conn.Close();
            return 1;
        }
    }
}