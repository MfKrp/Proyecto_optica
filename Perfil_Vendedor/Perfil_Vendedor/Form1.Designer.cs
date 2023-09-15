namespace Perfil_Vendedor
{
    partial class Form1
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
            LTitulo = new Label();
            LDni_cliente = new Label();
            LTitulo_Cliente = new Label();
            TDni_cliente = new TextBox();
            LDni_vendedor = new Label();
            TDni_vendedor = new TextBox();
            LTitulo_Vendedor = new Label();
            panel_cliente_vendedor = new Panel();
            BGuardar = new Button();
            panel_2 = new Panel();
            panel_form_pago = new Panel();
            LElegir = new Label();
            ComboBox_Forma_pago = new ComboBox();
            LTitulo_Forma_pago = new Label();
            panel_prod = new Panel();
            TCantidad = new TextBox();
            LCantidad = new Label();
            check_m = new CheckBox();
            check_xs = new CheckBox();
            check_L = new CheckBox();
            check_Masc = new CheckBox();
            check_Fem = new CheckBox();
            check_Unisex = new CheckBox();
            check_s = new CheckBox();
            LTalle = new Label();
            ComboBox_Tipo_prod = new ComboBox();
            ComboBox_Marca = new ComboBox();
            ComboBox_Estilo = new ComboBox();
            LColor = new Label();
            LGenero = new Label();
            LEstilo = new Label();
            TColor = new TextBox();
            LMarca = new Label();
            LTitulo_Prod = new Label();
            LTipo = new Label();
            panel_1 = new Panel();
            DVentas = new DataGridView();
            panel_cliente_vendedor.SuspendLayout();
            panel_2.SuspendLayout();
            panel_form_pago.SuspendLayout();
            panel_prod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DVentas).BeginInit();
            SuspendLayout();
            // 
            // LTitulo
            // 
            LTitulo.AutoSize = true;
            LTitulo.BackColor = Color.DarkSlateGray;
            LTitulo.Font = new Font("Copperplate Gothic Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            LTitulo.ForeColor = Color.White;
            LTitulo.Location = new Point(394, 9);
            LTitulo.Name = "LTitulo";
            LTitulo.Size = new Size(147, 30);
            LTitulo.TabIndex = 0;
            LTitulo.Text = "V E N T A";
            // 
            // LDni_cliente
            // 
            LDni_cliente.AutoSize = true;
            LDni_cliente.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            LDni_cliente.ForeColor = Color.White;
            LDni_cliente.Location = new Point(59, 43);
            LDni_cliente.Name = "LDni_cliente";
            LDni_cliente.Size = new Size(35, 16);
            LDni_cliente.TabIndex = 0;
            LDni_cliente.Text = "DNI ";
            LDni_cliente.Click += LDni_Click;
            // 
            // LTitulo_Cliente
            // 
            LTitulo_Cliente.AutoSize = true;
            LTitulo_Cliente.Font = new Font("Copperplate Gothic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LTitulo_Cliente.ForeColor = Color.White;
            LTitulo_Cliente.Location = new Point(15, 9);
            LTitulo_Cliente.Name = "LTitulo_Cliente";
            LTitulo_Cliente.Size = new Size(81, 16);
            LTitulo_Cliente.TabIndex = 1;
            LTitulo_Cliente.Text = "CLIENTE";
            // 
            // TDni_cliente
            // 
            TDni_cliente.Location = new Point(97, 41);
            TDni_cliente.Name = "TDni_cliente";
            TDni_cliente.Size = new Size(192, 23);
            TDni_cliente.TabIndex = 2;
            // 
            // LDni_vendedor
            // 
            LDni_vendedor.AutoSize = true;
            LDni_vendedor.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            LDni_vendedor.ForeColor = Color.White;
            LDni_vendedor.Location = new Point(410, 46);
            LDni_vendedor.Name = "LDni_vendedor";
            LDni_vendedor.Size = new Size(35, 16);
            LDni_vendedor.TabIndex = 3;
            LDni_vendedor.Text = "DNI ";
            LDni_vendedor.Click += label6_Click;
            // 
            // TDni_vendedor
            // 
            TDni_vendedor.Location = new Point(451, 41);
            TDni_vendedor.Name = "TDni_vendedor";
            TDni_vendedor.Size = new Size(192, 23);
            TDni_vendedor.TabIndex = 4;
            // 
            // LTitulo_Vendedor
            // 
            LTitulo_Vendedor.AutoSize = true;
            LTitulo_Vendedor.Font = new Font("Copperplate Gothic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LTitulo_Vendedor.ForeColor = Color.White;
            LTitulo_Vendedor.Location = new Point(336, 9);
            LTitulo_Vendedor.Name = "LTitulo_Vendedor";
            LTitulo_Vendedor.Size = new Size(105, 16);
            LTitulo_Vendedor.TabIndex = 5;
            LTitulo_Vendedor.Text = "VENDEDOR";
            // 
            // panel_cliente_vendedor
            // 
            panel_cliente_vendedor.BackColor = Color.FromArgb(0, 64, 64);
            panel_cliente_vendedor.Controls.Add(LTitulo_Vendedor);
            panel_cliente_vendedor.Controls.Add(TDni_cliente);
            panel_cliente_vendedor.Controls.Add(TDni_vendedor);
            panel_cliente_vendedor.Controls.Add(LDni_vendedor);
            panel_cliente_vendedor.Controls.Add(LTitulo_Cliente);
            panel_cliente_vendedor.Controls.Add(LDni_cliente);
            panel_cliente_vendedor.Location = new Point(0, 14);
            panel_cliente_vendedor.Name = "panel_cliente_vendedor";
            panel_cliente_vendedor.Size = new Size(859, 84);
            panel_cliente_vendedor.TabIndex = 5;
            // 
            // BGuardar
            // 
            BGuardar.BackColor = Color.FromArgb(255, 128, 0);
            BGuardar.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BGuardar.ForeColor = Color.White;
            BGuardar.Location = new Point(420, 622);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(86, 34);
            BGuardar.TabIndex = 6;
            BGuardar.Text = "Guardar";
            BGuardar.UseVisualStyleBackColor = false;
            // 
            // panel_2
            // 
            panel_2.BackColor = Color.Khaki;
            panel_2.Controls.Add(DVentas);
            panel_2.Controls.Add(panel_form_pago);
            panel_2.Controls.Add(panel_prod);
            panel_2.Controls.Add(panel_cliente_vendedor);
            panel_2.Location = new Point(27, 55);
            panel_2.Name = "panel_2";
            panel_2.Size = new Size(859, 546);
            panel_2.TabIndex = 7;
            // 
            // panel_form_pago
            // 
            panel_form_pago.BackColor = Color.FromArgb(0, 64, 64);
            panel_form_pago.Controls.Add(LElegir);
            panel_form_pago.Controls.Add(ComboBox_Forma_pago);
            panel_form_pago.Controls.Add(LTitulo_Forma_pago);
            panel_form_pago.Location = new Point(0, 261);
            panel_form_pago.Name = "panel_form_pago";
            panel_form_pago.Size = new Size(859, 86);
            panel_form_pago.TabIndex = 7;
            // 
            // LElegir
            // 
            LElegir.AutoSize = true;
            LElegir.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            LElegir.ForeColor = Color.White;
            LElegir.Location = new Point(301, 34);
            LElegir.Name = "LElegir";
            LElegir.Size = new Size(42, 16);
            LElegir.TabIndex = 7;
            LElegir.Text = "elegir";
            // 
            // ComboBox_Forma_pago
            // 
            ComboBox_Forma_pago.FormattingEnabled = true;
            ComboBox_Forma_pago.Location = new Point(357, 31);
            ComboBox_Forma_pago.Name = "ComboBox_Forma_pago";
            ComboBox_Forma_pago.Size = new Size(198, 23);
            ComboBox_Forma_pago.TabIndex = 2;
            // 
            // LTitulo_Forma_pago
            // 
            LTitulo_Forma_pago.AutoSize = true;
            LTitulo_Forma_pago.Font = new Font("Copperplate Gothic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LTitulo_Forma_pago.ForeColor = Color.White;
            LTitulo_Forma_pago.Location = new Point(15, 11);
            LTitulo_Forma_pago.Name = "LTitulo_Forma_pago";
            LTitulo_Forma_pago.Size = new Size(150, 16);
            LTitulo_Forma_pago.TabIndex = 1;
            LTitulo_Forma_pago.Text = "FORMA DE PAGO";
            // 
            // panel_prod
            // 
            panel_prod.BackColor = Color.FromArgb(0, 64, 64);
            panel_prod.Controls.Add(TCantidad);
            panel_prod.Controls.Add(LCantidad);
            panel_prod.Controls.Add(check_m);
            panel_prod.Controls.Add(check_xs);
            panel_prod.Controls.Add(check_L);
            panel_prod.Controls.Add(check_Masc);
            panel_prod.Controls.Add(check_Fem);
            panel_prod.Controls.Add(check_Unisex);
            panel_prod.Controls.Add(check_s);
            panel_prod.Controls.Add(LTalle);
            panel_prod.Controls.Add(ComboBox_Tipo_prod);
            panel_prod.Controls.Add(ComboBox_Marca);
            panel_prod.Controls.Add(ComboBox_Estilo);
            panel_prod.Controls.Add(LColor);
            panel_prod.Controls.Add(LGenero);
            panel_prod.Controls.Add(LEstilo);
            panel_prod.Controls.Add(TColor);
            panel_prod.Controls.Add(LMarca);
            panel_prod.Controls.Add(LTitulo_Prod);
            panel_prod.Controls.Add(LTipo);
            panel_prod.Location = new Point(0, 104);
            panel_prod.Name = "panel_prod";
            panel_prod.Size = new Size(859, 151);
            panel_prod.TabIndex = 6;
            panel_prod.Paint += panel_prod_Paint;
            // 
            // TCantidad
            // 
            TCantidad.Location = new Point(756, 107);
            TCantidad.Name = "TCantidad";
            TCantidad.Size = new Size(57, 23);
            TCantidad.TabIndex = 21;
            // 
            // LCantidad
            // 
            LCantidad.AutoSize = true;
            LCantidad.Font = new Font("Tw Cen MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LCantidad.ForeColor = Color.White;
            LCantidad.Location = new Point(687, 111);
            LCantidad.Name = "LCantidad";
            LCantidad.Size = new Size(63, 17);
            LCantidad.TabIndex = 20;
            LCantidad.Text = "Cantidad";
            // 
            // check_m
            // 
            check_m.AutoSize = true;
            check_m.Font = new Font("Tw Cen MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            check_m.ForeColor = Color.White;
            check_m.Location = new Point(589, 109);
            check_m.Name = "check_m";
            check_m.Size = new Size(39, 21);
            check_m.TabIndex = 19;
            check_m.Text = "M";
            check_m.UseVisualStyleBackColor = true;
            // 
            // check_xs
            // 
            check_xs.AutoSize = true;
            check_xs.Font = new Font("Tw Cen MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            check_xs.ForeColor = Color.White;
            check_xs.Location = new Point(512, 109);
            check_xs.Name = "check_xs";
            check_xs.Size = new Size(43, 21);
            check_xs.TabIndex = 18;
            check_xs.Text = "XS";
            check_xs.UseVisualStyleBackColor = true;
            // 
            // check_L
            // 
            check_L.AutoSize = true;
            check_L.Font = new Font("Tw Cen MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            check_L.ForeColor = Color.White;
            check_L.Location = new Point(632, 109);
            check_L.Name = "check_L";
            check_L.Size = new Size(33, 21);
            check_L.TabIndex = 17;
            check_L.Text = "L";
            check_L.UseVisualStyleBackColor = true;
            // 
            // check_Masc
            // 
            check_Masc.AutoSize = true;
            check_Masc.Font = new Font("Tw Cen MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            check_Masc.ForeColor = Color.White;
            check_Masc.Location = new Point(293, 107);
            check_Masc.Name = "check_Masc";
            check_Masc.Size = new Size(108, 21);
            check_Masc.TabIndex = 12;
            check_Masc.Text = "M (masculino)";
            check_Masc.UseVisualStyleBackColor = true;
            check_Masc.CheckedChanged += check_Masc_CheckedChanged;
            // 
            // check_Fem
            // 
            check_Fem.AutoSize = true;
            check_Fem.Font = new Font("Tw Cen MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            check_Fem.ForeColor = Color.White;
            check_Fem.Location = new Point(185, 107);
            check_Fem.Name = "check_Fem";
            check_Fem.Size = new Size(102, 21);
            check_Fem.TabIndex = 14;
            check_Fem.Text = "F (femenino)";
            check_Fem.UseVisualStyleBackColor = true;
            check_Fem.CheckedChanged += check_Fem_CheckedChanged;
            // 
            // check_Unisex
            // 
            check_Unisex.AutoSize = true;
            check_Unisex.Font = new Font("Tw Cen MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            check_Unisex.ForeColor = Color.White;
            check_Unisex.Location = new Point(93, 107);
            check_Unisex.Name = "check_Unisex";
            check_Unisex.Size = new Size(86, 21);
            check_Unisex.TabIndex = 13;
            check_Unisex.Text = "U (unisex)";
            check_Unisex.UseVisualStyleBackColor = true;
            check_Unisex.CheckedChanged += check_Unisex_CheckedChanged;
            // 
            // check_s
            // 
            check_s.AutoSize = true;
            check_s.Font = new Font("Tw Cen MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            check_s.ForeColor = Color.White;
            check_s.Location = new Point(555, 109);
            check_s.Name = "check_s";
            check_s.Size = new Size(35, 21);
            check_s.TabIndex = 16;
            check_s.Text = "S";
            check_s.UseVisualStyleBackColor = true;
            // 
            // LTalle
            // 
            LTalle.AutoSize = true;
            LTalle.Font = new Font("Tw Cen MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LTalle.ForeColor = Color.White;
            LTalle.Location = new Point(464, 111);
            LTalle.Name = "LTalle";
            LTalle.Size = new Size(37, 17);
            LTalle.TabIndex = 15;
            LTalle.Text = "Talle";
            // 
            // ComboBox_Tipo_prod
            // 
            ComboBox_Tipo_prod.FormattingEnabled = true;
            ComboBox_Tipo_prod.Location = new Point(31, 65);
            ComboBox_Tipo_prod.Name = "ComboBox_Tipo_prod";
            ComboBox_Tipo_prod.Size = new Size(180, 23);
            ComboBox_Tipo_prod.TabIndex = 11;
            // 
            // ComboBox_Marca
            // 
            ComboBox_Marca.FormattingEnabled = true;
            ComboBox_Marca.Location = new Point(246, 65);
            ComboBox_Marca.Name = "ComboBox_Marca";
            ComboBox_Marca.Size = new Size(180, 23);
            ComboBox_Marca.TabIndex = 10;
            // 
            // ComboBox_Estilo
            // 
            ComboBox_Estilo.FormattingEnabled = true;
            ComboBox_Estilo.Location = new Point(464, 65);
            ComboBox_Estilo.Name = "ComboBox_Estilo";
            ComboBox_Estilo.Size = new Size(180, 23);
            ComboBox_Estilo.TabIndex = 9;
            // 
            // LColor
            // 
            LColor.AutoSize = true;
            LColor.Font = new Font("Tw Cen MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LColor.ForeColor = Color.White;
            LColor.Location = new Point(661, 65);
            LColor.Name = "LColor";
            LColor.Size = new Size(41, 17);
            LColor.TabIndex = 8;
            LColor.Text = "Color";
            // 
            // LGenero
            // 
            LGenero.AutoSize = true;
            LGenero.Font = new Font("Tw Cen MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LGenero.ForeColor = Color.White;
            LGenero.Location = new Point(31, 107);
            LGenero.Name = "LGenero";
            LGenero.Size = new Size(56, 17);
            LGenero.TabIndex = 7;
            LGenero.Text = "Genero";
            // 
            // LEstilo
            // 
            LEstilo.AutoSize = true;
            LEstilo.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LEstilo.ForeColor = Color.White;
            LEstilo.Location = new Point(464, 43);
            LEstilo.Name = "LEstilo";
            LEstilo.Size = new Size(39, 19);
            LEstilo.TabIndex = 6;
            LEstilo.Text = "Estilo";
            // 
            // TColor
            // 
            TColor.Location = new Point(711, 65);
            TColor.Name = "TColor";
            TColor.Size = new Size(130, 23);
            TColor.TabIndex = 4;
            // 
            // LMarca
            // 
            LMarca.AutoSize = true;
            LMarca.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LMarca.ForeColor = Color.White;
            LMarca.Location = new Point(246, 43);
            LMarca.Name = "LMarca";
            LMarca.Size = new Size(50, 19);
            LMarca.TabIndex = 3;
            LMarca.Text = "Marca";
            // 
            // LTitulo_Prod
            // 
            LTitulo_Prod.AutoSize = true;
            LTitulo_Prod.Font = new Font("Copperplate Gothic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LTitulo_Prod.ForeColor = Color.White;
            LTitulo_Prod.Location = new Point(15, 11);
            LTitulo_Prod.Name = "LTitulo_Prod";
            LTitulo_Prod.Size = new Size(104, 16);
            LTitulo_Prod.TabIndex = 1;
            LTitulo_Prod.Text = "PRODUCTO";
            // 
            // LTipo
            // 
            LTipo.AutoSize = true;
            LTipo.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LTipo.ForeColor = Color.White;
            LTipo.Location = new Point(31, 43);
            LTipo.Name = "LTipo";
            LTipo.Size = new Size(36, 19);
            LTipo.TabIndex = 0;
            LTipo.Text = "Tipo";
            // 
            // panel_1
            // 
            panel_1.BackColor = Color.FromArgb(255, 128, 0);
            panel_1.Location = new Point(12, 42);
            panel_1.Name = "panel_1";
            panel_1.Size = new Size(892, 574);
            panel_1.TabIndex = 0;
            // 
            // DVentas
            // 
            DVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DVentas.Location = new Point(0, 366);
            DVentas.Name = "DVentas";
            DVentas.RowTemplate.Height = 25;
            DVentas.Size = new Size(859, 177);
            DVentas.TabIndex = 8;
            DVentas.CellContentClick += DVentas_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(916, 668);
            Controls.Add(BGuardar);
            Controls.Add(LTitulo);
            Controls.Add(panel_2);
            Controls.Add(panel_1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel_cliente_vendedor.ResumeLayout(false);
            panel_cliente_vendedor.PerformLayout();
            panel_2.ResumeLayout(false);
            panel_form_pago.ResumeLayout(false);
            panel_form_pago.PerformLayout();
            panel_prod.ResumeLayout(false);
            panel_prod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LTitulo;
        private Label LDni_cliente;
        private Label LTitulo_Cliente;
        private TextBox TDni_cliente;
        private Label LDni_vendedor;
        private TextBox TDni_vendedor;
        private Label LTitulo_Vendedor;
        private Panel panel_cliente_vendedor;
        private Button BGuardar;
        private Panel panel_2;
        private Panel panel_1;
        private Panel panel_prod;
        private Label LEstilo;
        private TextBox TColor;
        private Label LMarca;
        private Label LTitulo_Prod;
        private Label LTipo;
        private CheckBox check_Fem;
        private CheckBox check_Unisex;
        private CheckBox check_Masc;
        private ComboBox ComboBox_Tipo_prod;
        private ComboBox ComboBox_Marca;
        private ComboBox ComboBox_Estilo;
        private Label LColor;
        private Label LGenero;
        private Panel panel_form_pago;
        private Label LElegir;
        private ComboBox ComboBox_Forma_pago;
        private Label LTitulo_Forma_pago;
        private CheckBox check_xs;
        private CheckBox check_L;
        private CheckBox check_s;
        private Label LTalle;
        private CheckBox check_m;
        private Label LCantidad;
        private TextBox TCantidad;
        private DataGridView DVentas;
    }
}