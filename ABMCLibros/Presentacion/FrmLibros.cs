
using ABMCLibros.Datos;
using ABMCLibros.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABMCLibros.Presentacion
{
    public partial class FrmLibros : Form
    {
        LibroServicio oServicio;
        public FrmLibros()
        {
            InitializeComponent();
            oServicio = new LibroServicio();
        }

        private void FrmLibros_Load(object sender, EventArgs e)
        {
            CargarCombo(CboAutor);
            ChkTodos.Checked= true;
        }

        private void CargarCombo(ComboBox combo)
        {
            combo.DataSource = oServicio.TraerAutores();
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.SelectedIndex = -1;
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            Filtro oFiltro = null;
            if (!ChkTodos.Checked)
            {
                oFiltro = new Filtro();
                if (!string.IsNullOrEmpty(TxtTitulo.Text))
                    oFiltro.Titulo = TxtTitulo.Text;
                if (CboAutor.SelectedIndex != -1)
                    oFiltro.Autor = ((Autor)CboAutor.SelectedItem).Codigo;
            }

            //Cargar la grilla con los datos de la lista de libros
            List<Libro> lista = oServicio.TraerLibros(oFiltro);

            DgvLibros.Rows.Clear();
            foreach (Libro L in lista)
            {
                DgvLibros.Rows.Add(L.Codigo, L.Titulo, L.Autor.Nombre);
            }
        }
        private void ChkTodos_CheckedChanged(object sender, EventArgs e)
        {
            TxtTitulo.Enabled = !ChkTodos.Checked;
            CboAutor.Enabled = !ChkTodos.Checked;
        }
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmDetalles fd = new FrmDetalles(Modo.NUEVO, null);
            fd.ShowDialog();
        }
        private void DgvLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columna = DgvLibros.CurrentCell.ColumnIndex;
            if (columna > 2)
            {
                Modo modo = 0;
                switch (columna)
                {
                    case 3:
                        {
                            modo = Modo.VER;
                            break;
                        }
                    case 4:
                        {
                            modo = Modo.EDITAR;
                            break;
                        }
                    case 5:
                        {
                            modo = Modo.BORRAR;
                            break;
                        }
                }
                //Recuperar libro por id oculto en columna 0
                Libro libro = oServicio.TraerLibroPorId((int)DgvLibros.CurrentRow.Cells[0].Value);

                //LLamar FrmDetalles con modo y libro encontrado
                FrmDetalles fd = new FrmDetalles(modo, libro);
                fd.ShowDialog();
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
