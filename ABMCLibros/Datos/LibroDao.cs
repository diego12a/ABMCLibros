using ABMCLibros.Negocio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMCLibros.Datos
{
    public class LibroDao
    {
        AccesoDatos oBD;
        public LibroDao()
        {
            oBD= new AccesoDatos();
        }
        public List<Autor> RecuperarAutores()
        {
            List<Autor> Lista= new List<Autor>();
            //Traer dela BD
            DataTable tabla= oBD.ConsultarTabla("Autores");
            //Mapear Autores
            foreach (DataRow fila in tabla.Rows)
            {
                Autor oAutor = new Autor();
                oAutor.Codigo = (int)fila["idAutor"];
                oAutor.Nombre = fila["nombre"].ToString();
                Lista.Add(oAutor);
            }
            return Lista;   
        }

        public List<Libro> RecuperarLibros(Filtro filtro)
        {
            List<Libro> Lista = new List<Libro>();
            //Traer dela BD
            string consultaSQL = "SELECT l.*, a.nombre FROM Libros l, Autores a WHERE l.autor = a.idAutor";
            if (filtro != null)
            {
                if (filtro.Autor != 0)
                {
                    consultaSQL += " AND autor = " + filtro.Autor;
                }

                if (!string.IsNullOrEmpty(filtro.Titulo))
                {
                    consultaSQL += " AND titulo like '% " + filtro.Titulo + "%'";
                }
            }

            DataTable tabla = oBD.ConsultarBD(consultaSQL);
            //Mapear Libros
            foreach (DataRow fila in tabla.Rows)
            {
                Libro oLibro=new Libro();
                oLibro.Codigo = (int)fila[0];
                oLibro.Titulo = fila[1].ToString();
                oLibro.Autor = new Autor();
                oLibro.Autor.Codigo= (int)fila[2];
                oLibro.Autor.Nombre= fila[6].ToString();
                oLibro.Formato = (int)fila[3];
                oLibro.Fecha = (DateTime)fila[4];
                oLibro.Precio = (double)fila[5];    
                Lista.Add(oLibro);
            }
            return Lista;
        }

        public int InsertarLibro(Libro oLibro)
        {
            int filasAfectadas = 0;
           
            string consultaSQL = "INSERT INTO Libros (titulo, autor, formato, fechaPublicacion, precio) " +
                                             "VALUES (@titulo, @autor, @formato, @fechaPublicacion, @precio)";
            List<Parametro> listaParametros = new List<Parametro>();
            listaParametros.Add(new Parametro("@titulo", oLibro.Titulo));
            listaParametros.Add(new Parametro("@autor", oLibro.Autor.Codigo));
            listaParametros.Add(new Parametro("@formato", oLibro.Formato));
            listaParametros.Add(new Parametro("@fechaPublicacion", oLibro.Fecha));
            listaParametros.Add(new Parametro("@precio", oLibro.Precio));

            filasAfectadas = oBD.ActualizarBD(consultaSQL, listaParametros);
            return filasAfectadas;
        }

        public Libro RecuperarLibroPorId(int codigo)
        {
            Libro L = new Libro();
            //Traer dela BD
            string consultaSQL = "SELECT l.*, a.nombre FROM Libros l, Autores a WHERE l.autor = a.idAutor AND l.idLibro="+codigo;

            DataTable tabla = oBD.ConsultarBD(consultaSQL);
            //Mapear Libros
            foreach (DataRow fila in tabla.Rows)
            {
                Libro oLibro = new Libro();
                oLibro.Codigo = (int)fila[0];
                oLibro.Titulo = fila[1].ToString();
                oLibro.Autor = new Autor();
                oLibro.Autor.Codigo = (int)fila[2];
                oLibro.Autor.Nombre = fila[6].ToString();
                oLibro.Formato = (int)fila[3];
                oLibro.Fecha = (DateTime)fila[4];
                oLibro.Precio = (double)fila[5];
                L=oLibro;
            }
            return L;
        }

        public int BorrarLibro(int codigo)
        {
            int filasAfectadas = 0;

            string consultaSQL = "DELETE Libros WHERE idLibro = @codigo";
            List<Parametro> listaParametros = new List<Parametro>();
            listaParametros.Add(new Parametro("@codigo", codigo));

            filasAfectadas = oBD.ActualizarBD(consultaSQL, listaParametros);
            return filasAfectadas;
        }
    }
}
