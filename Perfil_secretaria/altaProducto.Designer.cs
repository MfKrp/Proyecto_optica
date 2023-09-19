namespace Perfil_secretaria
{
    partial class altaProducto
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LAltaProd = new Label();
            LNombre = new Label();
            LPrecio_unitario = new Label();
            LDescripcion = new Label();
            LStock = new Label();
            LGenero = new Label();
            Tipo = new Label();
            Marca = new Label();
            LEstilo = new Label();
            TNombre = new TextBox();
            TPrecio = new TextBox();
            TDescripcion = new TextBox();
            TStock = new TextBox();
            DGenero = new ComboBox();
            DTipo = new ComboBox();
            DMarca = new ComboBox();
            DEstilo = new ComboBox();
            BGuardar = new Button();
            SuspendLayout();
            // 
            // LAltaProd
            // 
            LAltaProd.AutoSize = true;
            LAltaProd.Location = new Point(363, 9);
            LAltaProd.Name = "LAltaProd";
            LAltaProd.Size = new Size(28, 15);
            LAltaProd.TabIndex = 0;
            LAltaProd.Text = "Alta";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(40, 75);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(51, 15);
            LNombre.TabIndex = 1;
            LNombre.Text = "Nombre";
            // 
            // LPrecio_unitario
            // 
            LPrecio_unitario.AutoSize = true;
            LPrecio_unitario.Location = new Point(40, 154);
            LPrecio_unitario.Name = "LPrecio_unitario";
            LPrecio_unitario.Size = new Size(85, 15);
            LPrecio_unitario.TabIndex = 2;
            LPrecio_unitario.Text = "Precio Unitario";
            // 
            // LDescripcion
            // 
            LDescripcion.AutoSize = true;
            LDescripcion.Location = new Point(40, 239);
            LDescripcion.Name = "LDescripcion";
            LDescripcion.Size = new Size(69, 15);
            LDescripcion.TabIndex = 3;
            LDescripcion.Text = "Descripción";
            // 
            // LStock
            // 
            LStock.AutoSize = true;
            LStock.Location = new Point(40, 323);
            LStock.Name = "LStock";
            LStock.Size = new Size(95, 15);
            LStock.TabIndex = 4;
            LStock.Text = "Stock Disponible";
            // 
            // LGenero
            // 
            LGenero.AutoSize = true;
            LGenero.Location = new Point(461, 75);
            LGenero.Name = "LGenero";
            LGenero.Size = new Size(45, 15);
            LGenero.TabIndex = 5;
            LGenero.Text = "Genero";
            // 
            // Tipo
            // 
            Tipo.AutoSize = true;
            Tipo.Location = new Point(461, 154);
            Tipo.Name = "Tipo";
            Tipo.Size = new Size(30, 15);
            Tipo.TabIndex = 6;
            Tipo.Text = "Tipo";
            // 
            // Marca
            // 
            Marca.AutoSize = true;
            Marca.Location = new Point(461, 239);
            Marca.Name = "Marca";
            Marca.Size = new Size(40, 15);
            Marca.TabIndex = 7;
            Marca.Text = "Marca";
            // 
            // LEstilo
            // 
            LEstilo.AutoSize = true;
            LEstilo.Location = new Point(461, 323);
            LEstilo.Name = "LEstilo";
            LEstilo.Size = new Size(35, 15);
            LEstilo.TabIndex = 8;
            LEstilo.Text = "Estilo";
            // 
            // TNombre
            // 
            TNombre.Location = new Point(160, 72);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(100, 23);
            TNombre.TabIndex = 9;
            // 
            // TPrecio
            // 
            TPrecio.Location = new Point(160, 151);
            TPrecio.Name = "TPrecio";
            TPrecio.Size = new Size(100, 23);
            TPrecio.TabIndex = 10;
            // 
            // TDescripcion
            // 
            TDescripcion.Location = new Point(160, 236);
            TDescripcion.Name = "TDescripcion";
            TDescripcion.Size = new Size(100, 23);
            TDescripcion.TabIndex = 11;
            // 
            // TStock
            // 
            TStock.Location = new Point(160, 320);
            TStock.Name = "TStock";
            TStock.Size = new Size(100, 23);
            TStock.TabIndex = 12;
            // 
            // DGenero
            // 
            DGenero.FormattingEnabled = true;
            DGenero.Location = new Point(535, 72);
            DGenero.Name = "DGenero";
            DGenero.Size = new Size(121, 23);
            DGenero.TabIndex = 13;
            // 
            // DTipo
            // 
            DTipo.FormattingEnabled = true;
            DTipo.Location = new Point(535, 151);
            DTipo.Name = "DTipo";
            DTipo.Size = new Size(121, 23);
            DTipo.TabIndex = 14;
            // 
            // DMarca
            // 
            DMarca.FormattingEnabled = true;
            DMarca.Location = new Point(535, 236);
            DMarca.Name = "DMarca";
            DMarca.Size = new Size(121, 23);
            DMarca.TabIndex = 15;
            // 
            // DEstilo
            // 
            DEstilo.FormattingEnabled = true;
            DEstilo.Location = new Point(535, 320);
            DEstilo.Name = "DEstilo";
            DEstilo.Size = new Size(121, 23);
            DEstilo.TabIndex = 16;
            // 
            // BGuardar
            // 
            BGuardar.Location = new Point(344, 404);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(75, 23);
            BGuardar.TabIndex = 17;
            BGuardar.Text = "Guardar";
            BGuardar.UseVisualStyleBackColor = true;
            // 
            // altaProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BGuardar);
            Controls.Add(DEstilo);
            Controls.Add(DMarca);
            Controls.Add(DTipo);
            Controls.Add(DGenero);
            Controls.Add(TStock);
            Controls.Add(TDescripcion);
            Controls.Add(TPrecio);
            Controls.Add(TNombre);
            Controls.Add(LEstilo);
            Controls.Add(Marca);
            Controls.Add(Tipo);
            Controls.Add(LGenero);
            Controls.Add(LStock);
            Controls.Add(LDescripcion);
            Controls.Add(LPrecio_unitario);
            Controls.Add(LNombre);
            Controls.Add(LAltaProd);
            Name = "altaProducto";
            Text = "Alta Producto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LAltaProd;
        private Label LNombre;
        private Label LPrecio_unitario;
        private Label LDescripcion;
        private Label LStock;
        private Label LGenero;
        private Label Tipo;
        private Label Marca;
        private Label LEstilo;
        private TextBox TNombre;
        private TextBox TPrecio;
        private TextBox TDescripcion;
        private TextBox TStock;
        private ComboBox DGenero;
        private ComboBox DTipo;
        private ComboBox DMarca;
        private ComboBox DEstilo;
        private Button BGuardar;
    }
}