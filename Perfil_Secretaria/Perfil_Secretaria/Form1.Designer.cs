namespace Perfil_Secretaria
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
            this.BGuardar = new Button();
            LNombre = new Label();
            LApellido = new Label();
            LTel = new Label();
            LDni = new Label();
            TTel = new TextBox();
            TApellido = new TextBox();
            TNombre = new TextBox();
            BoxPerfiles = new ComboBox();
            TDni = new TextBox();
            TPerfil = new Label();
            TCodigo_usuario = new TextBox();
            LCodigo_usuario = new Label();
            SuspendLayout();
            // 
            // BGuardar
            // 
            this.BGuardar.Location = new Point(586, 302);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new Size(75, 23);
            this.BGuardar.TabIndex = 1;
            this.BGuardar.Text = "GUARDAR";
            this.BGuardar.UseVisualStyleBackColor = true;
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(101, 45);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(51, 15);
            LNombre.TabIndex = 2;
            LNombre.Text = "Nombre";
            LNombre.Click += label1_Click;
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(101, 120);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(51, 15);
            LApellido.TabIndex = 3;
            LApellido.Text = "Apellido";
            // 
            // LTel
            // 
            LTel.AutoSize = true;
            LTel.Location = new Point(101, 200);
            LTel.Name = "LTel";
            LTel.Size = new Size(52, 15);
            LTel.TabIndex = 4;
            LTel.Text = "Telefono";
            // 
            // LDni
            // 
            LDni.AutoSize = true;
            LDni.Location = new Point(112, 286);
            LDni.Name = "LDni";
            LDni.Size = new Size(27, 15);
            LDni.TabIndex = 5;
            LDni.Text = "DNI";
            // 
            // TTel
            // 
            TTel.Location = new Point(171, 218);
            TTel.Name = "TTel";
            TTel.Size = new Size(165, 23);
            TTel.TabIndex = 7;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(171, 140);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(165, 23);
            TApellido.TabIndex = 8;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(171, 66);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(165, 23);
            TNombre.TabIndex = 9;
            // 
            // BoxPerfiles
            // 
            BoxPerfiles.FormattingEnabled = true;
            BoxPerfiles.Location = new Point(533, 192);
            BoxPerfiles.Name = "BoxPerfiles";
            BoxPerfiles.Size = new Size(174, 23);
            BoxPerfiles.TabIndex = 10;
            // 
            // TDni
            // 
            TDni.Location = new Point(171, 302);
            TDni.Name = "TDni";
            TDni.Size = new Size(165, 23);
            TDni.TabIndex = 11;
            // 
            // TPerfil
            // 
            TPerfil.AutoSize = true;
            TPerfil.Location = new Point(460, 173);
            TPerfil.Name = "TPerfil";
            TPerfil.Size = new Size(34, 15);
            TPerfil.TabIndex = 12;
            TPerfil.Text = "Perfil";
            // 
            // TCodigo_usuario
            // 
            TCodigo_usuario.Location = new Point(533, 103);
            TCodigo_usuario.Name = "TCodigo_usuario";
            TCodigo_usuario.Size = new Size(174, 23);
            TCodigo_usuario.TabIndex = 13;
            // 
            // LCodigo_usuario
            // 
            LCodigo_usuario.AutoSize = true;
            LCodigo_usuario.Location = new Point(429, 74);
            LCodigo_usuario.Name = "LCodigo_usuario";
            LCodigo_usuario.Size = new Size(105, 15);
            LCodigo_usuario.TabIndex = 14;
            LCodigo_usuario.Text = "Codigo de Usuario";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 439);
            Controls.Add(LCodigo_usuario);
            Controls.Add(TCodigo_usuario);
            Controls.Add(TPerfil);
            Controls.Add(TDni);
            Controls.Add(BoxPerfiles);
            Controls.Add(TNombre);
            Controls.Add(TApellido);
            Controls.Add(TTel);
            Controls.Add(LDni);
            Controls.Add(LTel);
            Controls.Add(LApellido);
            Controls.Add(LNombre);
            Controls.Add(this.BGuardar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label LNombre;
        private Label LApellido;
        private Label LTel;
        private Label LDni;
        private Label label5;
        private TextBox TTel;
        private TextBox TApellido;
        private TextBox TNombre;
        private ComboBox BoxPerfiles;
        private TextBox TDni;
        private Label TPerfil;
        private TextBox TCodigo_usuario;
        private Label LCodigo_usuario;
    }
}