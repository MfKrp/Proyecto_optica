namespace Perfil_Secretaria
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
            BGuardar = new Button();
            LNombre = new Label();
            LTelefono = new Label();
            LDireccion = new Label();
            LPerfil = new Label();
            LCodigo_usuario = new Label();
            LApellido = new Label();
            ComboBoxPerfil = new ComboBox();
            TDireccion = new TextBox();
            TCodigo_usuario = new TextBox();
            TNombre = new TextBox();
            TApellido = new TextBox();
            LTitulo = new Label();
            TTelefono = new TextBox();
            TDni = new TextBox();
            LDni = new Label();
            SuspendLayout();
            // 
            // BGuardar
            // 
            BGuardar.BackColor = Color.FromArgb(64, 0, 0);
            BGuardar.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BGuardar.ForeColor = Color.PapayaWhip;
            BGuardar.Location = new Point(604, 322);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(102, 34);
            BGuardar.TabIndex = 0;
            BGuardar.Text = "Guardar";
            BGuardar.UseVisualStyleBackColor = false;
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Font = new Font("Tw Cen MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LNombre.ForeColor = Color.FromArgb(64, 0, 0);
            LNombre.Location = new Point(83, 99);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(72, 22);
            LNombre.TabIndex = 1;
            LNombre.Text = "Nombre";
            // 
            // LTelefono
            // 
            LTelefono.AutoSize = true;
            LTelefono.Font = new Font("Tw Cen MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LTelefono.ForeColor = Color.FromArgb(64, 0, 0);
            LTelefono.Location = new Point(314, 197);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(76, 22);
            LTelefono.TabIndex = 2;
            LTelefono.Text = "Telefono";
            // 
            // LDireccion
            // 
            LDireccion.AutoSize = true;
            LDireccion.Font = new Font("Tw Cen MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LDireccion.ForeColor = Color.FromArgb(64, 0, 0);
            LDireccion.Location = new Point(83, 197);
            LDireccion.Name = "LDireccion";
            LDireccion.Size = new Size(77, 22);
            LDireccion.TabIndex = 3;
            LDireccion.Text = "Dirección";
            // 
            // LPerfil
            // 
            LPerfil.AutoSize = true;
            LPerfil.Font = new Font("Tw Cen MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LPerfil.ForeColor = Color.FromArgb(64, 0, 0);
            LPerfil.Location = new Point(314, 308);
            LPerfil.Name = "LPerfil";
            LPerfil.Size = new Size(50, 22);
            LPerfil.TabIndex = 5;
            LPerfil.Text = "Perfil";
            // 
            // LCodigo_usuario
            // 
            LCodigo_usuario.AutoSize = true;
            LCodigo_usuario.Font = new Font("Tw Cen MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LCodigo_usuario.ForeColor = Color.FromArgb(64, 0, 0);
            LCodigo_usuario.Location = new Point(83, 308);
            LCodigo_usuario.Name = "LCodigo_usuario";
            LCodigo_usuario.Size = new Size(147, 22);
            LCodigo_usuario.TabIndex = 6;
            LCodigo_usuario.Text = "Codigo de usuario";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Font = new Font("Tw Cen MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LApellido.ForeColor = Color.FromArgb(64, 0, 0);
            LApellido.Location = new Point(311, 99);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(73, 22);
            LApellido.TabIndex = 7;
            LApellido.Text = "Apellido";
            // 
            // ComboBoxPerfil
            // 
            ComboBoxPerfil.BackColor = SystemColors.Window;
            ComboBoxPerfil.FormattingEnabled = true;
            ComboBoxPerfil.Location = new Point(314, 333);
            ComboBoxPerfil.Name = "ComboBoxPerfil";
            ComboBoxPerfil.Size = new Size(199, 23);
            ComboBoxPerfil.TabIndex = 8;
            // 
            // TDireccion
            // 
            TDireccion.BackColor = SystemColors.Window;
            TDireccion.Location = new Point(83, 222);
            TDireccion.Name = "TDireccion";
            TDireccion.Size = new Size(199, 23);
            TDireccion.TabIndex = 9;
            // 
            // TCodigo_usuario
            // 
            TCodigo_usuario.BackColor = SystemColors.Window;
            TCodigo_usuario.Location = new Point(83, 333);
            TCodigo_usuario.Name = "TCodigo_usuario";
            TCodigo_usuario.Size = new Size(199, 23);
            TCodigo_usuario.TabIndex = 10;
            // 
            // TNombre
            // 
            TNombre.BackColor = SystemColors.Window;
            TNombre.Location = new Point(83, 124);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(199, 23);
            TNombre.TabIndex = 11;
            // 
            // TApellido
            // 
            TApellido.BackColor = SystemColors.Window;
            TApellido.Location = new Point(311, 124);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(199, 23);
            TApellido.TabIndex = 12;
            // 
            // LTitulo
            // 
            LTitulo.AutoSize = true;
            LTitulo.BackColor = Color.FromArgb(64, 0, 0);
            LTitulo.Font = new Font("Tw Cen MT", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            LTitulo.ForeColor = Color.PapayaWhip;
            LTitulo.Location = new Point(0, 0);
            LTitulo.Name = "LTitulo";
            LTitulo.Size = new Size(266, 31);
            LTitulo.TabIndex = 13;
            LTitulo.Text = "MODIFICAR USUARIO";
            // 
            // TTelefono
            // 
            TTelefono.BackColor = SystemColors.Window;
            TTelefono.Location = new Point(314, 222);
            TTelefono.Name = "TTelefono";
            TTelefono.Size = new Size(199, 23);
            TTelefono.TabIndex = 14;
            // 
            // TDni
            // 
            TDni.BackColor = SystemColors.Window;
            TDni.Location = new Point(554, 124);
            TDni.Name = "TDni";
            TDni.Size = new Size(199, 23);
            TDni.TabIndex = 15;
            // 
            // LDni
            // 
            LDni.AutoSize = true;
            LDni.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LDni.ForeColor = Color.FromArgb(64, 0, 0);
            LDni.Location = new Point(554, 102);
            LDni.Name = "LDni";
            LDni.Size = new Size(29, 19);
            LDni.TabIndex = 16;
            LDni.Text = "Dni";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(800, 450);
            Controls.Add(LDni);
            Controls.Add(TDni);
            Controls.Add(TTelefono);
            Controls.Add(LTitulo);
            Controls.Add(TApellido);
            Controls.Add(TNombre);
            Controls.Add(TCodigo_usuario);
            Controls.Add(TDireccion);
            Controls.Add(ComboBoxPerfil);
            Controls.Add(LApellido);
            Controls.Add(LCodigo_usuario);
            Controls.Add(LPerfil);
            Controls.Add(LDireccion);
            Controls.Add(LTelefono);
            Controls.Add(LNombre);
            Controls.Add(BGuardar);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BGuardar;
        private Label LNombre;
        private Label LTelefono;
        private Label LDireccion;
        private Label LPerfil;
        private Label LCodigo_usuario;
        private Label LApellido;
        private ComboBox ComboBoxPerfil;
        private TextBox TDireccion;
        private TextBox TCodigo_usuario;
        private TextBox TNombre;
        private TextBox TApellido;
        private Label LTitulo;
        private TextBox TTelefono;
        private TextBox TDni;
        private Label LDni;
    }
}