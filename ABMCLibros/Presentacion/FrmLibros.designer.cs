namespace ABMCLibros.Presentacion
{
    partial class FrmLibros
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.GrbCriterios = new System.Windows.Forms.GroupBox();
            this.DgvLibros = new System.Windows.Forms.DataGridView();
            this.ColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColVer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CboAutor = new System.Windows.Forms.ComboBox();
            this.LblAutor = new System.Windows.Forms.Label();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.ChkTodos = new System.Windows.Forms.CheckBox();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.GrbCriterios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(16, 438);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(87, 60);
            this.BtnNuevo.TabIndex = 14;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(1016, 441);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(87, 60);
            this.BtnSalir.TabIndex = 17;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // GrbCriterios
            // 
            this.GrbCriterios.Controls.Add(this.DgvLibros);
            this.GrbCriterios.Controls.Add(this.CboAutor);
            this.GrbCriterios.Controls.Add(this.LblAutor);
            this.GrbCriterios.Controls.Add(this.LblTitulo);
            this.GrbCriterios.Controls.Add(this.TxtTitulo);
            this.GrbCriterios.Controls.Add(this.ChkTodos);
            this.GrbCriterios.Controls.Add(this.BtnConsultar);
            this.GrbCriterios.Location = new System.Drawing.Point(16, 32);
            this.GrbCriterios.Margin = new System.Windows.Forms.Padding(4);
            this.GrbCriterios.Name = "GrbCriterios";
            this.GrbCriterios.Padding = new System.Windows.Forms.Padding(4);
            this.GrbCriterios.Size = new System.Drawing.Size(1087, 399);
            this.GrbCriterios.TabIndex = 13;
            this.GrbCriterios.TabStop = false;
            this.GrbCriterios.Text = "Criterios";
            // 
            // DgvLibros
            // 
            this.DgvLibros.AllowUserToAddRows = false;
            this.DgvLibros.AllowUserToDeleteRows = false;
            this.DgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCodigo,
            this.ColNombre,
            this.ColAutor,
            this.ColVer,
            this.ColEditar,
            this.ColBorrar});
            this.DgvLibros.Location = new System.Drawing.Point(8, 178);
            this.DgvLibros.Margin = new System.Windows.Forms.Padding(4);
            this.DgvLibros.Name = "DgvLibros";
            this.DgvLibros.ReadOnly = true;
            this.DgvLibros.RowHeadersWidth = 51;
            this.DgvLibros.RowTemplate.Height = 24;
            this.DgvLibros.Size = new System.Drawing.Size(1072, 185);
            this.DgvLibros.TabIndex = 4;
            this.DgvLibros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLibros_CellClick);
            // 
            // ColCodigo
            // 
            this.ColCodigo.HeaderText = "Código";
            this.ColCodigo.MinimumWidth = 6;
            this.ColCodigo.Name = "ColCodigo";
            this.ColCodigo.ReadOnly = true;
            this.ColCodigo.Visible = false;
            this.ColCodigo.Width = 125;
            // 
            // ColNombre
            // 
            this.ColNombre.HeaderText = "Nombre";
            this.ColNombre.MinimumWidth = 6;
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
            this.ColNombre.Width = 250;
            // 
            // ColAutor
            // 
            this.ColAutor.HeaderText = "Autor";
            this.ColAutor.MinimumWidth = 6;
            this.ColAutor.Name = "ColAutor";
            this.ColAutor.ReadOnly = true;
            this.ColAutor.Width = 150;
            // 
            // ColVer
            // 
            this.ColVer.HeaderText = "Ver";
            this.ColVer.MinimumWidth = 6;
            this.ColVer.Name = "ColVer";
            this.ColVer.ReadOnly = true;
            this.ColVer.Text = "Ver";
            this.ColVer.UseColumnTextForButtonValue = true;
            this.ColVer.Width = 125;
            // 
            // ColEditar
            // 
            this.ColEditar.HeaderText = "Editar";
            this.ColEditar.MinimumWidth = 6;
            this.ColEditar.Name = "ColEditar";
            this.ColEditar.ReadOnly = true;
            this.ColEditar.Text = "Editar";
            this.ColEditar.UseColumnTextForButtonValue = true;
            this.ColEditar.Width = 125;
            // 
            // ColBorrar
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            this.ColBorrar.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColBorrar.HeaderText = "Borrar";
            this.ColBorrar.MinimumWidth = 6;
            this.ColBorrar.Name = "ColBorrar";
            this.ColBorrar.ReadOnly = true;
            this.ColBorrar.Text = "Borrar";
            this.ColBorrar.UseColumnTextForButtonValue = true;
            this.ColBorrar.Width = 125;
            // 
            // CboAutor
            // 
            this.CboAutor.FormattingEnabled = true;
            this.CboAutor.Location = new System.Drawing.Point(167, 90);
            this.CboAutor.Margin = new System.Windows.Forms.Padding(4);
            this.CboAutor.Name = "CboAutor";
            this.CboAutor.Size = new System.Drawing.Size(336, 24);
            this.CboAutor.TabIndex = 1;
            // 
            // LblAutor
            // 
            this.LblAutor.AutoSize = true;
            this.LblAutor.Location = new System.Drawing.Point(65, 94);
            this.LblAutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAutor.Name = "LblAutor";
            this.LblAutor.Size = new System.Drawing.Size(38, 16);
            this.LblAutor.TabIndex = 5;
            this.LblAutor.Text = "Autor";
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Location = new System.Drawing.Point(51, 41);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(43, 16);
            this.LblTitulo.TabIndex = 1;
            this.LblTitulo.Text = "Titulo:";
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtTitulo.Location = new System.Drawing.Point(167, 42);
            this.TxtTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(337, 15);
            this.TxtTitulo.TabIndex = 0;
            // 
            // ChkTodos
            // 
            this.ChkTodos.AutoSize = true;
            this.ChkTodos.Location = new System.Drawing.Point(167, 138);
            this.ChkTodos.Margin = new System.Windows.Forms.Padding(4);
            this.ChkTodos.Name = "ChkTodos";
            this.ChkTodos.Size = new System.Drawing.Size(69, 20);
            this.ChkTodos.TabIndex = 2;
            this.ChkTodos.Text = "Todos";
            this.ChkTodos.UseVisualStyleBackColor = true;
            this.ChkTodos.CheckedChanged += new System.EventHandler(this.ChkTodos_CheckedChanged);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(907, 127);
            this.BtnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(175, 44);
            this.BtnConsultar.TabIndex = 3;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // FrmLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 517);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.GrbCriterios);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmLibros";
            this.Text = "Libros";
            this.Load += new System.EventHandler(this.FrmLibros_Load);
            this.GrbCriterios.ResumeLayout(false);
            this.GrbCriterios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLibros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.GroupBox GrbCriterios;
        private System.Windows.Forms.DataGridView DgvLibros;
        private System.Windows.Forms.ComboBox CboAutor;
        private System.Windows.Forms.Label LblAutor;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.CheckBox ChkTodos;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAutor;
        private System.Windows.Forms.DataGridViewButtonColumn ColVer;
        private System.Windows.Forms.DataGridViewButtonColumn ColEditar;
        private System.Windows.Forms.DataGridViewButtonColumn ColBorrar;
    }
}

