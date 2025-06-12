using ABMCLibros.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABMCLibros.Presentacion
{
    public enum Modo
    {
        VER = 1,    //1. Ver detalles
        EDITAR,     //2. Editar
        BORRAR,     //3. Borrar
        NUEVO       //4. Nuevo
    }
    public partial class FrmDetalles : Form
    {
        LibroServicio oServicio;
        Modo accion;
        Libro oLibro;

        public FrmDetalles(Modo modo, Libro libro)
        {
            InitializeComponent();
            oServicio = new LibroServicio();
            accion = modo;
            oLibro = libro;
        }

        private void FrmDetalles_Load(object sender, EventArgs e)
        {
            CargarCombo(CboAutor);
            if (accion == Modo.NUEVO)
            {
                oLibro = new Libro();
            }
            else  // modo ver o editar o borrar hay que cargar campos con oLibro
            {
                TxtCodigo.Text = oLibro.Codigo.ToString();
                TxtTitulo.Text = oLibro.Titulo;
                //CboAutor.Text = oLibro.Autor.Nombre;   update???
                CboAutor.SelectedItem = oLibro.Autor;
                if (oLibro.Formato == 1)
                    RbtImpreso.Checked = true;
                else
                    RbtDigital.Checked = true;
                DtpFecha.Value = oLibro.Fecha;
                TxtPrecio.Text = oLibro.Precio.ToString();
            }
            if (accion == Modo.VER || accion == Modo.BORRAR)
            {
                // solo lectura...deshabilitamos todos los campos
                GrbDetalles.Enabled = false;
            }
        }

        private void CargarCombo(ComboBox combo)
        {
            combo.DataSource = oServicio.TraerAutores();
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.SelectedIndex = -1;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (accion == Modo.VER)
            {
                Dispose();
            }
            if (accion == Modo.BORRAR)
            {
                //llamar al servicio delete
                if (oServicio.EliminarLibro(oLibro.Codigo) > 0)
                    MessageBox.Show("Se borró libro!!!");
                else
                    MessageBox.Show("Intente más tarde!");
                Dispose();
            }

            //ValidarDatos
            if (ValidarDatos())
            {
                //Cargar el objeto
                oLibro.Titulo = TxtTitulo.Text;
                oLibro.Autor = (Autor)CboAutor.SelectedItem;
                if (RbtImpreso.Checked)
                    oLibro.Formato = 1;
                else
                    oLibro.Formato = 2;
                oLibro.Fecha = DtpFecha.Value;
                oLibro.Precio = double.Parse(TxtPrecio.Text);

                if (accion == Modo.NUEVO)
                {
                    //llamar al servicio nuevo
                    if (oServicio.CrearLibro(oLibro) > 0)
                        MessageBox.Show("Se creo nuevo libro!!!");
                    else
                        MessageBox.Show("Intente más tarde!");
                }
                if (accion == Modo.EDITAR)
                {
                    //llamar al servicio update
                }
                Dispose();
            }

        }

        private bool ValidarDatos()
        {
            //todas las validaciones según definición de tabla y reglas de negocio
            return true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
