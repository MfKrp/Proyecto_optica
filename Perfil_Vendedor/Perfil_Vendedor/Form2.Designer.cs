namespace Perfil_Vendedor
{
    partial class Form2
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
            ComboBox_Marco = new ComboBox();
            ComboBox_Tipo_Lente = new ComboBox();
            TOjo_Izquierdo = new TextBox();
            TOjo_Derecho = new TextBox();
            TNombreyApellido = new TextBox();
            LNombreyApellido = new Label();
            LOjo_Derecho = new Label();
            LOjo_Izquierdo = new Label();
            LMarco = new Label();
            LTipo_Lente = new Label();
            BGuardar = new Button();
            LTitulo = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            LPrecio_total = new Label();
            LVendedor = new Label();
            SuspendLayout();
            // 
            // ComboBox_Marco
            // 
            ComboBox_Marco.FormattingEnabled = true;
            ComboBox_Marco.Location = new Point(310, 250);
            ComboBox_Marco.Name = "ComboBox_Marco";
            ComboBox_Marco.Size = new Size(228, 23);
            ComboBox_Marco.TabIndex = 0;
            // 
            // ComboBox_Tipo_Lente
            // 
            ComboBox_Tipo_Lente.FormattingEnabled = true;
            ComboBox_Tipo_Lente.Location = new Point(49, 250);
            ComboBox_Tipo_Lente.Name = "ComboBox_Tipo_Lente";
            ComboBox_Tipo_Lente.Size = new Size(231, 23);
            ComboBox_Tipo_Lente.TabIndex = 1;
            // 
            // TOjo_Izquierdo
            // 
            TOjo_Izquierdo.Location = new Point(164, 165);
            TOjo_Izquierdo.Name = "TOjo_Izquierdo";
            TOjo_Izquierdo.Size = new Size(116, 23);
            TOjo_Izquierdo.TabIndex = 2;
            // 
            // TOjo_Derecho
            // 
            TOjo_Derecho.Location = new Point(422, 165);
            TOjo_Derecho.Name = "TOjo_Derecho";
            TOjo_Derecho.Size = new Size(116, 23);
            TOjo_Derecho.TabIndex = 3;
            // 
            // TNombreyApellido
            // 
            TNombreyApellido.Location = new Point(44, 111);
            TNombreyApellido.Name = "TNombreyApellido";
            TNombreyApellido.Size = new Size(331, 23);
            TNombreyApellido.TabIndex = 4;
            // 
            // LNombreyApellido
            // 
            LNombreyApellido.AutoSize = true;
            LNombreyApellido.Font = new Font("Tw Cen MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LNombreyApellido.ForeColor = Color.FromArgb(64, 0, 0);
            LNombreyApellido.Location = new Point(44, 86);
            LNombreyApellido.Name = "LNombreyApellido";
            LNombreyApellido.Size = new Size(155, 22);
            LNombreyApellido.TabIndex = 5;
            LNombreyApellido.Text = "Nombre y Apellido";
            // 
            // LOjo_Derecho
            // 
            LOjo_Derecho.AutoSize = true;
            LOjo_Derecho.Font = new Font("Tw Cen MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LOjo_Derecho.ForeColor = Color.FromArgb(64, 0, 0);
            LOjo_Derecho.Location = new Point(310, 163);
            LOjo_Derecho.Name = "LOjo_Derecho";
            LOjo_Derecho.Size = new Size(106, 22);
            LOjo_Derecho.TabIndex = 6;
            LOjo_Derecho.Text = "Ojo Derecho";
            LOjo_Derecho.Click += LOjo_Derecho_Click;
            // 
            // LOjo_Izquierdo
            // 
            LOjo_Izquierdo.AutoSize = true;
            LOjo_Izquierdo.Font = new Font("Tw Cen MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LOjo_Izquierdo.ForeColor = Color.FromArgb(64, 0, 0);
            LOjo_Izquierdo.Location = new Point(44, 163);
            LOjo_Izquierdo.Name = "LOjo_Izquierdo";
            LOjo_Izquierdo.Size = new Size(114, 22);
            LOjo_Izquierdo.TabIndex = 7;
            LOjo_Izquierdo.Text = "Ojo Izquierdo";
            // 
            // LMarco
            // 
            LMarco.AutoSize = true;
            LMarco.Font = new Font("Tw Cen MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LMarco.ForeColor = Color.FromArgb(64, 0, 0);
            LMarco.Location = new Point(310, 225);
            LMarco.Name = "LMarco";
            LMarco.Size = new Size(58, 22);
            LMarco.TabIndex = 8;
            LMarco.Text = "Marco";
            // 
            // LTipo_Lente
            // 
            LTipo_Lente.AutoSize = true;
            LTipo_Lente.Font = new Font("Tw Cen MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LTipo_Lente.ForeColor = Color.FromArgb(64, 0, 0);
            LTipo_Lente.Location = new Point(49, 225);
            LTipo_Lente.Name = "LTipo_Lente";
            LTipo_Lente.Size = new Size(109, 22);
            LTipo_Lente.TabIndex = 9;
            LTipo_Lente.Text = "Tipo de lente";
            // 
            // BGuardar
            // 
            BGuardar.BackColor = Color.FromArgb(64, 0, 0);
            BGuardar.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BGuardar.ForeColor = SystemColors.Window;
            BGuardar.Location = new Point(233, 464);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(88, 40);
            BGuardar.TabIndex = 10;
            BGuardar.Text = "Guardar";
            BGuardar.UseVisualStyleBackColor = false;
            // 
            // LTitulo
            // 
            LTitulo.AutoSize = true;
            LTitulo.BackColor = Color.FromArgb(64, 0, 0);
            LTitulo.Font = new Font("Tw Cen MT", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            LTitulo.ForeColor = Color.PapayaWhip;
            LTitulo.Location = new Point(-2, -1);
            LTitulo.Name = "LTitulo";
            LTitulo.Size = new Size(238, 31);
            LTitulo.TabIndex = 11;
            LTitulo.Text = "MODIFICAR VENTA";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(438, 407);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(49, 334);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(326, 23);
            textBox2.TabIndex = 13;
            // 
            // LPrecio_total
            // 
            LPrecio_total.AutoSize = true;
            LPrecio_total.Font = new Font("Tw Cen MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LPrecio_total.ForeColor = Color.FromArgb(64, 0, 0);
            LPrecio_total.Location = new Point(334, 408);
            LPrecio_total.Name = "LPrecio_total";
            LPrecio_total.Size = new Size(99, 22);
            LPrecio_total.TabIndex = 14;
            LPrecio_total.Text = "Precio Total";
            // 
            // LVendedor
            // 
            LVendedor.AutoSize = true;
            LVendedor.Font = new Font("Tw Cen MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LVendedor.ForeColor = Color.FromArgb(64, 0, 0);
            LVendedor.Location = new Point(49, 309);
            LVendedor.Name = "LVendedor";
            LVendedor.Size = new Size(85, 22);
            LVendedor.TabIndex = 15;
            LVendedor.Text = "Vendedor";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(568, 516);
            Controls.Add(LVendedor);
            Controls.Add(LPrecio_total);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(LTitulo);
            Controls.Add(BGuardar);
            Controls.Add(LTipo_Lente);
            Controls.Add(LMarco);
            Controls.Add(LOjo_Izquierdo);
            Controls.Add(LOjo_Derecho);
            Controls.Add(LNombreyApellido);
            Controls.Add(TNombreyApellido);
            Controls.Add(TOjo_Derecho);
            Controls.Add(TOjo_Izquierdo);
            Controls.Add(ComboBox_Tipo_Lente);
            Controls.Add(ComboBox_Marco);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ComboBox_Marco;
        private ComboBox ComboBox_Tipo_Lente;
        private TextBox TOjo_Izquierdo;
        private TextBox TOjo_Derecho;
        private TextBox TNombreyApellido;
        private Label LNombreyApellido;
        private Label LOjo_Derecho;
        private Label LOjo_Izquierdo;
        private Label LMarco;
        private Label LTipo_Lente;
        private Button BGuardar;
        private Label LTitulo;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label LPrecio_total;
        private Label LVendedor;
    }
}