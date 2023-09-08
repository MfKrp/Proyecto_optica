namespace Perfil_Repositor
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
            LTitulo = new Label();
            LTipo_Lente = new Label();
            TTipo_Lente = new TextBox();
            BGuardar = new Button();
            LPrecio = new Label();
            TPrecio = new TextBox();
            SuspendLayout();
            // 
            // LTitulo
            // 
            LTitulo.AutoSize = true;
            LTitulo.BackColor = Color.FromArgb(64, 0, 0);
            LTitulo.Font = new Font("Tw Cen MT", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            LTitulo.ForeColor = Color.PapayaWhip;
            LTitulo.Location = new Point(-2, 0);
            LTitulo.Name = "LTitulo";
            LTitulo.Size = new Size(196, 31);
            LTitulo.TabIndex = 0;
            LTitulo.Text = "CARGAR LENTE";
            // 
            // LTipo_Lente
            // 
            LTipo_Lente.AutoSize = true;
            LTipo_Lente.Font = new Font("Tw Cen MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LTipo_Lente.ForeColor = Color.FromArgb(64, 0, 0);
            LTipo_Lente.Location = new Point(23, 102);
            LTipo_Lente.Name = "LTipo_Lente";
            LTipo_Lente.Size = new Size(109, 22);
            LTipo_Lente.TabIndex = 1;
            LTipo_Lente.Text = "Tipo de lente";
            // 
            // TTipo_Lente
            // 
            TTipo_Lente.Location = new Point(138, 101);
            TTipo_Lente.Name = "TTipo_Lente";
            TTipo_Lente.Size = new Size(222, 23);
            TTipo_Lente.TabIndex = 2;
            // 
            // BGuardar
            // 
            BGuardar.BackColor = Color.FromArgb(64, 0, 0);
            BGuardar.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BGuardar.ForeColor = SystemColors.Window;
            BGuardar.Location = new Point(152, 224);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(88, 36);
            BGuardar.TabIndex = 3;
            BGuardar.Text = "Guardar";
            BGuardar.UseVisualStyleBackColor = false;
            // 
            // LPrecio
            // 
            LPrecio.AutoSize = true;
            LPrecio.Font = new Font("Tw Cen MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LPrecio.ForeColor = Color.FromArgb(64, 0, 0);
            LPrecio.Location = new Point(41, 155);
            LPrecio.Name = "LPrecio";
            LPrecio.Size = new Size(57, 22);
            LPrecio.TabIndex = 4;
            LPrecio.Text = "Precio";
            // 
            // TPrecio
            // 
            TPrecio.Location = new Point(138, 154);
            TPrecio.Name = "TPrecio";
            TPrecio.Size = new Size(100, 23);
            TPrecio.TabIndex = 5;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(401, 283);
            Controls.Add(TPrecio);
            Controls.Add(LPrecio);
            Controls.Add(BGuardar);
            Controls.Add(TTipo_Lente);
            Controls.Add(LTipo_Lente);
            Controls.Add(LTitulo);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LTitulo;
        private Label LTipo_Lente;
        private TextBox TTipo_Lente;
        private Button BGuardar;
        private Label LPrecio;
        private TextBox TPrecio;
    }
}