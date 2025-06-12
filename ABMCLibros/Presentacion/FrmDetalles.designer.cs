namespace ABMCLibros.Presentacion
{
    partial class FrmDetalles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GrbDetalles = new System.Windows.Forms.GroupBox();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.RbtDigital = new System.Windows.Forms.RadioButton();
            this.RbtImpreso = new System.Windows.Forms.RadioButton();
            this.CboAutor = new System.Windows.Forms.ComboBox();
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblFormato = new System.Windows.Forms.Label();
            this.LblAutor = new System.Windows.Forms.Label();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.GrbDetalles.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrbDetalles
            // 
            this.GrbDetalles.Controls.Add(this.TxtPrecio);
            this.GrbDetalles.Controls.Add(this.LblPrecio);
            this.GrbDetalles.Controls.Add(this.DtpFecha);
            this.GrbDetalles.Controls.Add(this.RbtDigital);
            this.GrbDetalles.Controls.Add(this.RbtImpreso);
            this.GrbDetalles.Controls.Add(this.CboAutor);
            this.GrbDetalles.Controls.Add(this.TxtTitulo);
            this.GrbDetalles.Controls.Add(this.TxtCodigo);
            this.GrbDetalles.Controls.Add(this.LblFecha);
            this.GrbDetalles.Controls.Add(this.LblFormato);
            this.GrbDetalles.Controls.Add(this.LblAutor);
            this.GrbDetalles.Controls.Add(this.LblTitulo);
            this.GrbDetalles.Controls.Add(this.LblCodigo);
            this.GrbDetalles.Location = new System.Drawing.Point(36, 31);
            this.GrbDetalles.Margin = new System.Windows.Forms.Padding(4);
            this.GrbDetalles.Name = "GrbDetalles";
            this.GrbDetalles.Padding = new System.Windows.Forms.Padding(4);
            this.GrbDetalles.Size = new System.Drawing.Size(480, 361);
            this.GrbDetalles.TabIndex = 35;
            this.GrbDetalles.TabStop = false;
            this.GrbDetalles.Text = "Detalles";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(179, 310);
            this.TxtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(132, 22);
            this.TxtPrecio.TabIndex = 6;
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Location = new System.Drawing.Point(96, 316);
            this.LblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(46, 16);
            this.LblPrecio.TabIndex = 42;
            this.LblPrecio.Text = "Precio";
            // 
            // DtpFecha
            // 
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFecha.Location = new System.Drawing.Point(179, 268);
            this.DtpFecha.Margin = new System.Windows.Forms.Padding(4);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(132, 22);
            this.DtpFecha.TabIndex = 5;
            // 
            // RbtDigital
            // 
            this.RbtDigital.AutoSize = true;
            this.RbtDigital.Location = new System.Drawing.Point(181, 214);
            this.RbtDigital.Margin = new System.Windows.Forms.Padding(4);
            this.RbtDigital.Name = "RbtDigital";
            this.RbtDigital.Size = new System.Drawing.Size(83, 20);
            this.RbtDigital.TabIndex = 4;
            this.RbtDigital.TabStop = true;
            this.RbtDigital.Text = "2 - Digital";
            this.RbtDigital.UseVisualStyleBackColor = true;
            // 
            // RbtImpreso
            // 
            this.RbtImpreso.AutoSize = true;
            this.RbtImpreso.Location = new System.Drawing.Point(181, 174);
            this.RbtImpreso.Margin = new System.Windows.Forms.Padding(4);
            this.RbtImpreso.Name = "RbtImpreso";
            this.RbtImpreso.Size = new System.Drawing.Size(94, 20);
            this.RbtImpreso.TabIndex = 3;
            this.RbtImpreso.TabStop = true;
            this.RbtImpreso.Text = "1 - Impreso";
            this.RbtImpreso.UseVisualStyleBackColor = true;
            // 
            // CboAutor
            // 
            this.CboAutor.FormattingEnabled = true;
            this.CboAutor.Location = new System.Drawing.Point(179, 127);
            this.CboAutor.Margin = new System.Windows.Forms.Padding(4);
            this.CboAutor.Name = "CboAutor";
            this.CboAutor.Size = new System.Drawing.Size(245, 24);
            this.CboAutor.TabIndex = 2;
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.Location = new System.Drawing.Point(179, 82);
            this.TxtTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(245, 22);
            this.TxtTitulo.TabIndex = 1;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Enabled = false;
            this.TxtCodigo.Location = new System.Drawing.Point(179, 37);
            this.TxtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(132, 22);
            this.TxtCodigo.TabIndex = 0;
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Location = new System.Drawing.Point(19, 268);
            this.LblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(118, 16);
            this.LblFecha.TabIndex = 39;
            this.LblFecha.Text = "Fecha Publicaciòn";
            // 
            // LblFormato
            // 
            this.LblFormato.AutoSize = true;
            this.LblFormato.Location = new System.Drawing.Point(85, 193);
            this.LblFormato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFormato.Name = "LblFormato";
            this.LblFormato.Size = new System.Drawing.Size(57, 16);
            this.LblFormato.TabIndex = 37;
            this.LblFormato.Text = "Formato";
            // 
            // LblAutor
            // 
            this.LblAutor.AutoSize = true;
            this.LblAutor.Location = new System.Drawing.Point(89, 132);
            this.LblAutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAutor.Name = "LblAutor";
            this.LblAutor.Size = new System.Drawing.Size(38, 16);
            this.LblAutor.TabIndex = 35;
            this.LblAutor.Text = "Autor";
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Location = new System.Drawing.Point(85, 84);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(40, 16);
            this.LblTitulo.TabIndex = 33;
            this.LblTitulo.Text = "Titulo";
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Location = new System.Drawing.Point(85, 41);
            this.LblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(51, 16);
            this.LblCodigo.TabIndex = 31;
            this.LblCodigo.Text = "Código";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(296, 413);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(173, 39);
            this.BtnCancelar.TabIndex = 1;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(78, 413);
            this.BtnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(173, 39);
            this.BtnAceptar.TabIndex = 0;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // FrmDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 463);
            this.Controls.Add(this.GrbDetalles);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDetalles";
            this.Text = "FrmDetalles";
            this.Load += new System.EventHandler(this.FrmDetalles_Load);
            this.GrbDetalles.ResumeLayout(false);
            this.GrbDetalles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbDetalles;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.RadioButton RbtDigital;
        private System.Windows.Forms.RadioButton RbtImpreso;
        private System.Windows.Forms.ComboBox CboAutor;
        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblFormato;
        private System.Windows.Forms.Label LblAutor;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
    }
}