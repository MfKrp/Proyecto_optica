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
            panel_1 = new Panel();
            panel_prod = new Panel();
            TColor = new TextBox();
            LMarca = new Label();
            LTitulo_Prod = new Label();
            LTipo = new Label();
            LEstilo = new Label();
            LColor = new Label();
            LGenero = new Label();
            ComboBox_Estilo = new ComboBox();
            ComboBox_Marca = new ComboBox();
            ComboBox_Tipo_prod = new ComboBox();
            check_Masc = new CheckBox();
            check_Unisex = new CheckBox();
            check_Fem = new CheckBox();
            panel_form_pago = new Panel();
            LTitulo_Forma_pago = new Label();
            ComboBox_Forma_pago = new ComboBox();
            LElegir = new Label();
            panel_cliente_vendedor.SuspendLayout();
            panel_2.SuspendLayout();
            panel_prod.SuspendLayout();
            panel_form_pago.SuspendLayout();
            SuspendLayout();
            // 
            // LTitulo
            // 
            LTitulo.AutoSize = true;
            LTitulo.BackColor = Color.DarkSlateGray;
            LTitulo.Font = new Font("Lucida Sans Typewriter", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            LTitulo.ForeColor = Color.White;
            LTitulo.Location = new Point(282, 8);
            LTitulo.Name = "LTitulo";
            LTitulo.Size = new Size(158, 31);
            LTitulo.TabIndex = 0;
            LTitulo.Text = "V E N T A";
            // 
            // LDni_cliente
            // 
            LDni_cliente.AutoSize = true;
            LDni_cliente.Font = new Font("Lucida Sans Typewriter", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LDni_cliente.ForeColor = Color.White;
            LDni_cliente.Location = new Point(68, 47);
            LDni_cliente.Name = "LDni_cliente";
            LDni_cliente.Size = new Size(35, 13);
            LDni_cliente.TabIndex = 0;
            LDni_cliente.Text = "DNI ";
            LDni_cliente.Click += LDni_Click;
            // 
            // LTitulo_Cliente
            // 
            LTitulo_Cliente.AutoSize = true;
            LTitulo_Cliente.Font = new Font("Lucida Sans Typewriter", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LTitulo_Cliente.ForeColor = Color.White;
            LTitulo_Cliente.Location = new Point(13, 11);
            LTitulo_Cliente.Name = "LTitulo_Cliente";
            LTitulo_Cliente.Size = new Size(71, 17);
            LTitulo_Cliente.TabIndex = 1;
            LTitulo_Cliente.Text = "CLIENTE";
            // 
            // TDni_cliente
            // 
            TDni_cliente.Location = new Point(109, 43);
            TDni_cliente.Name = "TDni_cliente";
            TDni_cliente.Size = new Size(192, 23);
            TDni_cliente.TabIndex = 2;
            // 
            // LDni_vendedor
            // 
            LDni_vendedor.AutoSize = true;
            LDni_vendedor.Font = new Font("Lucida Sans Typewriter", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LDni_vendedor.ForeColor = Color.White;
            LDni_vendedor.Location = new Point(410, 46);
            LDni_vendedor.Name = "LDni_vendedor";
            LDni_vendedor.Size = new Size(35, 13);
            LDni_vendedor.TabIndex = 3;
            LDni_vendedor.Text = "DNI ";
            LDni_vendedor.Click += label6_Click;
            // 
            // TDni_vendedor
            // 
            TDni_vendedor.Location = new Point(451, 43);
            TDni_vendedor.Name = "TDni_vendedor";
            TDni_vendedor.Size = new Size(192, 23);
            TDni_vendedor.TabIndex = 4;
            // 
            // LTitulo_Vendedor
            // 
            LTitulo_Vendedor.AutoSize = true;
            LTitulo_Vendedor.Font = new Font("Lucida Sans Typewriter", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LTitulo_Vendedor.ForeColor = Color.White;
            LTitulo_Vendedor.Location = new Point(345, 11);
            LTitulo_Vendedor.Name = "LTitulo_Vendedor";
            LTitulo_Vendedor.Size = new Size(80, 17);
            LTitulo_Vendedor.TabIndex = 5;
            LTitulo_Vendedor.Text = "VENDEDOR";
            // 
            // panel_cliente_vendedor
            // 
            panel_cliente_vendedor.BackColor = Color.DarkOliveGreen;
            panel_cliente_vendedor.Controls.Add(LTitulo_Vendedor);
            panel_cliente_vendedor.Controls.Add(TDni_cliente);
            panel_cliente_vendedor.Controls.Add(TDni_vendedor);
            panel_cliente_vendedor.Controls.Add(LDni_vendedor);
            panel_cliente_vendedor.Controls.Add(LTitulo_Cliente);
            panel_cliente_vendedor.Controls.Add(LDni_cliente);
            panel_cliente_vendedor.Location = new Point(0, 14);
            panel_cliente_vendedor.Name = "panel_cliente_vendedor";
            panel_cliente_vendedor.Size = new Size(673, 95);
            panel_cliente_vendedor.TabIndex = 5;
            // 
            // BGuardar
            // 
            BGuardar.BackColor = Color.FromArgb(255, 128, 0);
            BGuardar.Font = new Font("Lucida Sans Typewriter", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BGuardar.ForeColor = Color.White;
            BGuardar.Location = new Point(331, 496);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(86, 34);
            BGuardar.TabIndex = 6;
            BGuardar.Text = "Guardar";
            BGuardar.UseVisualStyleBackColor = false;
            // 
            // panel_2
            // 
            panel_2.BackColor = Color.Khaki;
            panel_2.Controls.Add(panel_form_pago);
            panel_2.Controls.Add(panel_prod);
            panel_2.Controls.Add(panel_cliente_vendedor);
            panel_2.Location = new Point(36, 55);
            panel_2.Name = "panel_2";
            panel_2.Size = new Size(673, 421);
            panel_2.TabIndex = 7;
            // 
            // panel_1
            // 
            panel_1.BackColor = Color.FromArgb(255, 128, 0);
            panel_1.Location = new Point(25, 42);
            panel_1.Name = "panel_1";
            panel_1.Size = new Size(696, 448);
            panel_1.TabIndex = 0;
            // 
            // panel_prod
            // 
            panel_prod.BackColor = Color.DarkOliveGreen;
            panel_prod.Controls.Add(check_Fem);
            panel_prod.Controls.Add(check_Unisex);
            panel_prod.Controls.Add(check_Masc);
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
            panel_prod.Location = new Point(0, 130);
            panel_prod.Name = "panel_prod";
            panel_prod.Size = new Size(673, 176);
            panel_prod.TabIndex = 6;
            // 
            // TColor
            // 
            TColor.Location = new Point(461, 133);
            TColor.Name = "TColor";
            TColor.Size = new Size(192, 23);
            TColor.TabIndex = 4;
            // 
            // LMarca
            // 
            LMarca.AutoSize = true;
            LMarca.Font = new Font("Lucida Sans Typewriter", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LMarca.ForeColor = Color.White;
            LMarca.Location = new Point(257, 46);
            LMarca.Name = "LMarca";
            LMarca.Size = new Size(42, 13);
            LMarca.TabIndex = 3;
            LMarca.Text = "Marca";
            // 
            // LTitulo_Prod
            // 
            LTitulo_Prod.AutoSize = true;
            LTitulo_Prod.Font = new Font("Lucida Sans Typewriter", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LTitulo_Prod.ForeColor = Color.White;
            LTitulo_Prod.Location = new Point(13, 11);
            LTitulo_Prod.Name = "LTitulo_Prod";
            LTitulo_Prod.Size = new Size(80, 17);
            LTitulo_Prod.TabIndex = 1;
            LTitulo_Prod.Text = "PRODUCTO";
            // 
            // LTipo
            // 
            LTipo.AutoSize = true;
            LTipo.Font = new Font("Lucida Sans Typewriter", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LTipo.ForeColor = Color.White;
            LTipo.Location = new Point(30, 46);
            LTipo.Name = "LTipo";
            LTipo.Size = new Size(35, 13);
            LTipo.TabIndex = 0;
            LTipo.Text = "Tipo";
            // 
            // LEstilo
            // 
            LEstilo.AutoSize = true;
            LEstilo.Font = new Font("Lucida Sans Typewriter", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LEstilo.ForeColor = Color.White;
            LEstilo.Location = new Point(473, 46);
            LEstilo.Name = "LEstilo";
            LEstilo.Size = new Size(49, 13);
            LEstilo.TabIndex = 6;
            LEstilo.Text = "Estilo";
            // 
            // LColor
            // 
            LColor.AutoSize = true;
            LColor.Font = new Font("Lucida Sans Typewriter", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LColor.ForeColor = Color.White;
            LColor.Location = new Point(403, 112);
            LColor.Name = "LColor";
            LColor.Size = new Size(42, 13);
            LColor.TabIndex = 8;
            LColor.Text = "Color";
            // 
            // LGenero
            // 
            LGenero.AutoSize = true;
            LGenero.Font = new Font("Lucida Sans Typewriter", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LGenero.ForeColor = Color.White;
            LGenero.Location = new Point(30, 112);
            LGenero.Name = "LGenero";
            LGenero.Size = new Size(49, 13);
            LGenero.TabIndex = 7;
            LGenero.Text = "Genero";
            // 
            // ComboBox_Estilo
            // 
            ComboBox_Estilo.FormattingEnabled = true;
            ComboBox_Estilo.Location = new Point(473, 62);
            ComboBox_Estilo.Name = "ComboBox_Estilo";
            ComboBox_Estilo.Size = new Size(180, 23);
            ComboBox_Estilo.TabIndex = 9;
            // 
            // ComboBox_Marca
            // 
            ComboBox_Marca.FormattingEnabled = true;
            ComboBox_Marca.Location = new Point(257, 62);
            ComboBox_Marca.Name = "ComboBox_Marca";
            ComboBox_Marca.Size = new Size(180, 23);
            ComboBox_Marca.TabIndex = 10;
            // 
            // ComboBox_Tipo_prod
            // 
            ComboBox_Tipo_prod.FormattingEnabled = true;
            ComboBox_Tipo_prod.Location = new Point(30, 62);
            ComboBox_Tipo_prod.Name = "ComboBox_Tipo_prod";
            ComboBox_Tipo_prod.Size = new Size(180, 23);
            ComboBox_Tipo_prod.TabIndex = 11;
            // 
            // check_Masc
            // 
            check_Masc.AutoSize = true;
            check_Masc.ForeColor = Color.White;
            check_Masc.Location = new Point(88, 135);
            check_Masc.Name = "check_Masc";
            check_Masc.Size = new Size(103, 19);
            check_Masc.TabIndex = 12;
            check_Masc.Text = "M (masculino)";
            check_Masc.UseVisualStyleBackColor = true;
            // 
            // check_Unisex
            // 
            check_Unisex.AutoSize = true;
            check_Unisex.ForeColor = Color.White;
            check_Unisex.Location = new Point(295, 135);
            check_Unisex.Name = "check_Unisex";
            check_Unisex.Size = new Size(79, 19);
            check_Unisex.TabIndex = 13;
            check_Unisex.Text = "U (unisex)";
            check_Unisex.UseVisualStyleBackColor = true;
            // 
            // check_Fem
            // 
            check_Fem.AutoSize = true;
            check_Fem.ForeColor = Color.White;
            check_Fem.Location = new Point(197, 135);
            check_Fem.Name = "check_Fem";
            check_Fem.Size = new Size(94, 19);
            check_Fem.TabIndex = 14;
            check_Fem.Text = "F (femenino)";
            check_Fem.UseVisualStyleBackColor = true;
            // 
            // panel_form_pago
            // 
            panel_form_pago.BackColor = Color.DarkOliveGreen;
            panel_form_pago.Controls.Add(LElegir);
            panel_form_pago.Controls.Add(ComboBox_Forma_pago);
            panel_form_pago.Controls.Add(LTitulo_Forma_pago);
            panel_form_pago.Location = new Point(0, 326);
            panel_form_pago.Name = "panel_form_pago";
            panel_form_pago.Size = new Size(673, 81);
            panel_form_pago.TabIndex = 7;
            // 
            // LTitulo_Forma_pago
            // 
            LTitulo_Forma_pago.AutoSize = true;
            LTitulo_Forma_pago.Font = new Font("Lucida Sans Typewriter", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LTitulo_Forma_pago.ForeColor = Color.White;
            LTitulo_Forma_pago.Location = new Point(13, 12);
            LTitulo_Forma_pago.Name = "LTitulo_Forma_pago";
            LTitulo_Forma_pago.Size = new Size(125, 17);
            LTitulo_Forma_pago.TabIndex = 1;
            LTitulo_Forma_pago.Text = "FORMA DE PAGO";
            // 
            // ComboBox_Forma_pago
            // 
            ComboBox_Forma_pago.FormattingEnabled = true;
            ComboBox_Forma_pago.Location = new Point(257, 33);
            ComboBox_Forma_pago.Name = "ComboBox_Forma_pago";
            ComboBox_Forma_pago.Size = new Size(198, 23);
            ComboBox_Forma_pago.TabIndex = 2;
            // 
            // LElegir
            // 
            LElegir.AutoSize = true;
            LElegir.Font = new Font("Lucida Sans Typewriter", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LElegir.ForeColor = Color.White;
            LElegir.Location = new Point(197, 37);
            LElegir.Name = "LElegir";
            LElegir.Size = new Size(49, 13);
            LElegir.TabIndex = 7;
            LElegir.Text = "elegir";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(744, 542);
            Controls.Add(BGuardar);
            Controls.Add(LTitulo);
            Controls.Add(panel_2);
            Controls.Add(panel_1);
            Name = "Form1";
            Text = "Form1";
            panel_cliente_vendedor.ResumeLayout(false);
            panel_cliente_vendedor.PerformLayout();
            panel_2.ResumeLayout(false);
            panel_prod.ResumeLayout(false);
            panel_prod.PerformLayout();
            panel_form_pago.ResumeLayout(false);
            panel_form_pago.PerformLayout();
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
    }
}