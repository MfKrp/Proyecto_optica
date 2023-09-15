namespace Perfil_Vendedor
{
    partial class Form3
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
            BGuardar = new Button();
            LTitulo = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            TCorreo = new TextBox();
            LTelefono = new Label();
            LDireccion = new Label();
            TTelefono = new TextBox();
            LCorreo = new Label();
            TDireccion = new TextBox();
            panel4 = new Panel();
            label1 = new Label();
            TDni = new TextBox();
            LNombre = new Label();
            LDni = new Label();
            TApellido = new TextBox();
            TNombre = new TextBox();
            LApellido = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // BGuardar
            // 
            BGuardar.BackColor = Color.FromArgb(255, 128, 0);
            BGuardar.Font = new Font("Tw Cen MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            BGuardar.ForeColor = Color.White;
            BGuardar.Location = new Point(265, 439);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(84, 33);
            BGuardar.TabIndex = 14;
            BGuardar.Text = "GUARDAR";
            BGuardar.UseVisualStyleBackColor = false;
            // 
            // LTitulo
            // 
            LTitulo.AutoSize = true;
            LTitulo.BackColor = Color.DarkSlateGray;
            LTitulo.Font = new Font("Copperplate Gothic Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            LTitulo.ForeColor = Color.White;
            LTitulo.Location = new Point(154, 11);
            LTitulo.Name = "LTitulo";
            LTitulo.Size = new Size(287, 30);
            LTitulo.TabIndex = 13;
            LTitulo.Text = "ALTA DE CLIENTE";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 128, 0);
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(27, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(542, 389);
            panel2.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Khaki;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel4);
            panel1.Location = new Point(13, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(515, 365);
            panel1.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 64, 64);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(TCorreo);
            panel3.Controls.Add(LTelefono);
            panel3.Controls.Add(LDireccion);
            panel3.Controls.Add(TTelefono);
            panel3.Controls.Add(LCorreo);
            panel3.Controls.Add(TDireccion);
            panel3.Location = new Point(0, 190);
            panel3.Name = "panel3";
            panel3.Size = new Size(515, 158);
            panel3.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Copperplate Gothic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 10);
            label2.Name = "label2";
            label2.Size = new Size(155, 16);
            label2.TabIndex = 13;
            label2.Text = "INFO. CONTACTO";
            // 
            // TCorreo
            // 
            TCorreo.Location = new Point(34, 69);
            TCorreo.Name = "TCorreo";
            TCorreo.Size = new Size(232, 23);
            TCorreo.TabIndex = 12;
            // 
            // LTelefono
            // 
            LTelefono.AutoSize = true;
            LTelefono.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LTelefono.ForeColor = Color.White;
            LTelefono.Location = new Point(319, 47);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(63, 19);
            LTelefono.TabIndex = 0;
            LTelefono.Text = "Telefono";
            // 
            // LDireccion
            // 
            LDireccion.AutoSize = true;
            LDireccion.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LDireccion.ForeColor = Color.White;
            LDireccion.Location = new Point(35, 116);
            LDireccion.Name = "LDireccion";
            LDireccion.Size = new Size(65, 19);
            LDireccion.TabIndex = 1;
            LDireccion.Text = "Dirección";
            // 
            // TTelefono
            // 
            TTelefono.Location = new Point(319, 69);
            TTelefono.Name = "TTelefono";
            TTelefono.Size = new Size(158, 23);
            TTelefono.TabIndex = 8;
            // 
            // LCorreo
            // 
            LCorreo.AutoSize = true;
            LCorreo.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LCorreo.ForeColor = Color.White;
            LCorreo.Location = new Point(34, 47);
            LCorreo.Name = "LCorreo";
            LCorreo.Size = new Size(53, 19);
            LCorreo.TabIndex = 2;
            LCorreo.Text = "Correo";
            // 
            // TDireccion
            // 
            TDireccion.Location = new Point(150, 116);
            TDireccion.Name = "TDireccion";
            TDireccion.Size = new Size(327, 23);
            TDireccion.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 64, 64);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(TDni);
            panel4.Controls.Add(LNombre);
            panel4.Controls.Add(LDni);
            panel4.Controls.Add(TApellido);
            panel4.Controls.Add(TNombre);
            panel4.Controls.Add(LApellido);
            panel4.Location = new Point(0, 15);
            panel4.Name = "panel4";
            panel4.Size = new Size(515, 169);
            panel4.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Copperplate Gothic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(186, 16);
            label1.TabIndex = 12;
            label1.Text = "DATOS PERSONALES";
            // 
            // TDni
            // 
            TDni.Location = new Point(69, 93);
            TDni.Name = "TDni";
            TDni.Size = new Size(140, 23);
            TDni.TabIndex = 11;
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LNombre.ForeColor = Color.White;
            LNombre.Location = new Point(252, 38);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(61, 19);
            LNombre.TabIndex = 4;
            LNombre.Text = "Nombre";
            // 
            // LDni
            // 
            LDni.AutoSize = true;
            LDni.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LDni.ForeColor = Color.White;
            LDni.Location = new Point(26, 93);
            LDni.Name = "LDni";
            LDni.Size = new Size(34, 19);
            LDni.TabIndex = 6;
            LDni.Text = "DNI";
            // 
            // TApellido
            // 
            TApellido.Location = new Point(251, 60);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(243, 23);
            TApellido.TabIndex = 9;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(251, 119);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(243, 23);
            TNombre.TabIndex = 10;
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LApellido.ForeColor = Color.White;
            LApellido.Location = new Point(251, 97);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(62, 19);
            LApellido.TabIndex = 3;
            LApellido.Text = "Apellido";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(595, 483);
            Controls.Add(BGuardar);
            Controls.Add(LTitulo);
            Controls.Add(panel2);
            Name = "Form3";
            Text = "Form3";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BGuardar;
        private Label LTitulo;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Label label2;
        private TextBox TCorreo;
        private Label LTelefono;
        private Label LDireccion;
        private TextBox TTelefono;
        private Label LCorreo;
        private TextBox TDireccion;
        private Panel panel4;
        private Label label1;
        private TextBox TDni;
        private Label LNombre;
        private Label LDni;
        private TextBox TApellido;
        private TextBox TNombre;
        private Label LApellido;
    }
}