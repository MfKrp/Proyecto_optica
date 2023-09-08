namespace Perfil_Repositor
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
            label1 = new Label();
            BGuardar = new Button();
            TMarca = new TextBox();
            LColor = new Label();
            LMarca = new Label();
            LTalle = new Label();
            LMaterial = new Label();
            TColor = new TextBox();
            TTalle = new TextBox();
            TMaterial = new TextBox();
            TPrecio = new TextBox();
            LPrecio = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(64, 0, 0);
            label1.Font = new Font("Tw Cen MT", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.PapayaWhip;
            label1.Location = new Point(-1, 0);
            label1.Name = "label1";
            label1.Size = new Size(218, 31);
            label1.TabIndex = 0;
            label1.Text = "CARGAR MARCO";
            label1.Click += label1_Click;
            // 
            // BGuardar
            // 
            BGuardar.BackColor = Color.FromArgb(64, 0, 0);
            BGuardar.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BGuardar.ForeColor = SystemColors.Window;
            BGuardar.Location = new Point(146, 394);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(86, 35);
            BGuardar.TabIndex = 1;
            BGuardar.Text = "Guardar";
            BGuardar.UseVisualStyleBackColor = false;
            // 
            // TMarca
            // 
            TMarca.Location = new Point(147, 167);
            TMarca.Name = "TMarca";
            TMarca.Size = new Size(189, 23);
            TMarca.TabIndex = 2;
            // 
            // LColor
            // 
            LColor.AutoSize = true;
            LColor.Font = new Font("Tw Cen MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LColor.ForeColor = Color.FromArgb(64, 0, 0);
            LColor.Location = new Point(48, 110);
            LColor.Name = "LColor";
            LColor.Size = new Size(51, 22);
            LColor.TabIndex = 3;
            LColor.Text = "Color";
            // 
            // LMarca
            // 
            LMarca.AutoSize = true;
            LMarca.Font = new Font("Tw Cen MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LMarca.ForeColor = Color.FromArgb(64, 0, 0);
            LMarca.Location = new Point(48, 167);
            LMarca.Name = "LMarca";
            LMarca.Size = new Size(58, 22);
            LMarca.TabIndex = 4;
            LMarca.Text = "Marca";
            // 
            // LTalle
            // 
            LTalle.AutoSize = true;
            LTalle.Font = new Font("Tw Cen MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LTalle.ForeColor = Color.FromArgb(64, 0, 0);
            LTalle.Location = new Point(48, 220);
            LTalle.Name = "LTalle";
            LTalle.Size = new Size(46, 22);
            LTalle.TabIndex = 5;
            LTalle.Text = "Talle";
            LTalle.Click += label4_Click;
            // 
            // LMaterial
            // 
            LMaterial.AutoSize = true;
            LMaterial.Font = new Font("Tw Cen MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LMaterial.ForeColor = Color.FromArgb(64, 0, 0);
            LMaterial.Location = new Point(48, 271);
            LMaterial.Name = "LMaterial";
            LMaterial.Size = new Size(74, 22);
            LMaterial.TabIndex = 6;
            LMaterial.Text = "Material";
            // 
            // TColor
            // 
            TColor.Location = new Point(147, 109);
            TColor.Name = "TColor";
            TColor.Size = new Size(189, 23);
            TColor.TabIndex = 7;
            // 
            // TTalle
            // 
            TTalle.Location = new Point(147, 219);
            TTalle.Name = "TTalle";
            TTalle.Size = new Size(64, 23);
            TTalle.TabIndex = 8;
            // 
            // TMaterial
            // 
            TMaterial.Location = new Point(146, 270);
            TMaterial.Name = "TMaterial";
            TMaterial.Size = new Size(190, 23);
            TMaterial.TabIndex = 9;
            // 
            // TPrecio
            // 
            TPrecio.Location = new Point(146, 325);
            TPrecio.Name = "TPrecio";
            TPrecio.Size = new Size(65, 23);
            TPrecio.TabIndex = 10;
            // 
            // LPrecio
            // 
            LPrecio.AutoSize = true;
            LPrecio.Font = new Font("Tw Cen MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LPrecio.ForeColor = Color.FromArgb(64, 0, 0);
            LPrecio.Location = new Point(49, 326);
            LPrecio.Name = "LPrecio";
            LPrecio.Size = new Size(57, 22);
            LPrecio.TabIndex = 11;
            LPrecio.Text = "Precio";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(401, 450);
            Controls.Add(LPrecio);
            Controls.Add(TPrecio);
            Controls.Add(TMaterial);
            Controls.Add(TTalle);
            Controls.Add(TColor);
            Controls.Add(LMaterial);
            Controls.Add(LTalle);
            Controls.Add(LMarca);
            Controls.Add(LColor);
            Controls.Add(TMarca);
            Controls.Add(BGuardar);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BGuardar;
        private TextBox TMarca;
        private Label LColor;
        private Label LMarca;
        private Label LTalle;
        private Label LMaterial;
        private TextBox TColor;
        private TextBox TTalle;
        private TextBox TMaterial;
        private TextBox TPrecio;
        private Label LPrecio;
    }
}