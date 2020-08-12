using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DasarrolloWebMVC_Pelicula.Web.Models
{
  
    public class RegistroPelicula
    {
        private SqlConnection con;
        private void Conectar()
        {
            string constr = ConfigurationManager.ConnectionStrings["ConexionDB"].ToString();
            con = new SqlConnection(constr);
        }
        /*insertar un regisro en la base de datos*/
       public int GrabarPelicula(Pelicula peli)
        {
            Conectar();
            SqlCommand Comando = new SqlCommand("INSERT INTO  dbo.TBL_PELICULA (Titulo, Director, AutorPrincipal, NumAutor, Duracion, Estreno)" +
                                                "VALUES (@Titulo, @Director, @AutorPrincipal, @NumAutor, @Duracion, @Estreno  )", con);

            Comando.Parameters.Add("@Titulo", SqlDbType.VarChar);
            Comando.Parameters.Add("@Director", SqlDbType.VarChar);
            Comando.Parameters.Add("@AutorPrincipal", SqlDbType.VarChar);
            Comando.Parameters.Add("@NumAutor", SqlDbType.Int);
            Comando.Parameters.Add("@Duracion", SqlDbType.Float);
            Comando.Parameters.Add("@Estreno ", SqlDbType.Int);
            //--------------------------------------------------
            Comando.Parameters["@Titulo"].Value = peli.Titulo;
            Comando.Parameters["@Director"].Value = peli.Director;
            Comando.Parameters["@AutorPrincipal"].Value = peli.AutorPrincipal;
            Comando.Parameters["@NumAutor"].Value = peli.NumAutor;
            Comando.Parameters["@Duracion"].Value = peli.Duracion;
            Comando.Parameters["@Estreno "].Value = peli.Estreno;
            con.Open();
            int i = Comando.ExecuteNonQuery();
            con.Close();
            return i;
        }
        /*Mostrar un registro especifico de la base de datos */
        public  List<Pelicula> RecuperarTodos()
        {
            Conectar();
            List<Pelicula> peliculas = new List<Pelicula>();
            SqlCommand Coman = new SqlCommand("SELECT Codigo, Titulo, Director, AutorPrincipal, NumAutor , Duracion , Estreno " +
                                                "FROM  TBL_PELICULA", con);
            con.Open();
            SqlDataReader registros = Coman.ExecuteReader();

            while (registros.Read())
            {
                Pelicula peli = new Pelicula
                {
                    Codigo = int.Parse(registros["Codigo"].ToString()),
                    Titulo = registros["Titulo"].ToString(),
                    Director = registros["Director"].ToString(),
                    AutorPrincipal = registros["AutorPrincipal"].ToString(),
                    NumAutor = int.Parse(registros["NumAutor"].ToString()),
                    Duracion = double.Parse(registros["Duracion"].ToString()),
                    Estreno = int.Parse(registros["Estreno"].ToString())
                };
                peliculas.Add(peli);
            }
            con.Close();
            return peliculas;
        }
        
        /*Mostrar un registro especifico de la base de datos */
        public Pelicula Recuperar(int Codigo)
        {
            Conectar();
            SqlCommand Comando = new SqlCommand("SELECT Codigo, Titulo, Director, AutorPrincipal, NumAutor , Duracion , Estreno " +
                                                "  FROM  TBL_PELICULA WHERE CODIGO = @Codigo", con);
            Comando.Parameters.Add("@Codigo",SqlDbType.Int);
            Comando.Parameters["@Codigo"].Value = Codigo;
            con.Open();
            SqlDataReader registros = Comando.ExecuteReader();
            Pelicula pelicula = new Pelicula();
            if (registros.Read())
            {
                pelicula.Titulo = registros["Titulo"].ToString();
                pelicula.Director = registros["Director"].ToString();
                pelicula.AutorPrincipal = registros["AutorPrincipal"].ToString();
                pelicula.NumAutor = int.Parse( registros["NumAutor"].ToString());
                pelicula.Duracion =double.Parse( registros["Duracion"].ToString());
                pelicula.Estreno = int.Parse( registros["Estreno"].ToString());
            }
            con.Close();
            return pelicula;
        }

        /*modificar unregistro de la base de datos*/
        public int Modificar(Pelicula Peli)
        {
            Conectar();
            SqlCommand Comando = new SqlCommand("UPDATE  TBL_PELICULA SET Titulo = @Titulo, Director = @Director,AutorPrincipal = @AutorPrincipal, NumAutor = @NumAutor," +
                                                 "Duracion = @Duracion,Estreno = @Estreno" +
                                                 " WHERE  Codigo = @Codigo", con);
            Comando.Parameters.Add("@Codigo", SqlDbType.VarChar);
            Comando.Parameters["@Codigo"].Value = Peli.Codigo;

            Comando.Parameters.Add("@Titulo", SqlDbType.VarChar);
            Comando.Parameters["@Titulo"].Value = Peli.Titulo;
            //------------------------------------------------
            Comando.Parameters.Add("@Director", SqlDbType.VarChar);
            Comando.Parameters["@Director"].Value = Peli.Director;
            //------------------------------------------------
            Comando.Parameters.Add("@AutorPrincipal", SqlDbType.VarChar);
            Comando.Parameters["@AutorPrincipal"].Value = Peli.AutorPrincipal;
            //------------------------------------------------
            Comando.Parameters.Add("@NumAutor", SqlDbType.Int);
            Comando.Parameters["@NumAutor"].Value = Peli.NumAutor;
            //------------------------------------------------
            Comando.Parameters.Add("@Duracion", SqlDbType.Float);
            Comando.Parameters["@Duracion"].Value = Peli.Duracion;
            //------------------------------------------------
            Comando.Parameters.Add("@Estreno ", SqlDbType.Int);
            Comando.Parameters["@Estreno "].Value = Peli.Estreno;

            con.Open();
            int i = Comando.ExecuteNonQuery();
            con.Close();
            return i;
        }
        /*Paa borrar un registro especial de la BD*/
        public int Borrar(int codigo)
        {
            Conectar();
            SqlCommand Comando = new SqlCommand("DELETE FROM  TBL_PELICULA WHERE Codigo=@Codigo",con);
            Comando.Parameters.Add("@Codigo", SqlDbType.Int);
            Comando.Parameters["@Codigo"].Value = codigo;
            con.Open();
            int i = Comando.ExecuteNonQuery();
            con.Close();
            return i;
        }

    }
   
}