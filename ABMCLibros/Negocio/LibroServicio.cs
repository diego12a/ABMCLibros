using ABMCLibros.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMCLibros.Negocio
{
    public class LibroServicio
    {
        LibroDao oDao;
        public LibroServicio()
        {
            oDao= new LibroDao();
        }
        public List<Autor> TraerAutores()
        {
            return oDao.RecuperarAutores();
        }

        public List<Libro> TraerLibros(Filtro oFiltro)
        {
            return oDao.RecuperarLibros(oFiltro);
        }

        public int CrearLibro(Libro l)
        {
            return oDao.InsertarLibro(l);
        }

        public Libro TraerLibroPorId(int codigo)
        {
            return oDao.RecuperarLibroPorId(codigo);
        }

        public int EliminarLibro(int codigo)
        {
            return oDao.BorrarLibro(codigo);
        }
    }
}
