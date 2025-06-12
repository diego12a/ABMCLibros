using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMCLibros.Negocio
{
    public class Autor
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public override string ToString()
        {
            return Nombre; 
        }
    }
}
