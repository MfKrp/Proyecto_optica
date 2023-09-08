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
            ComboBoxPerfil = new ComboBox();
            LNombre = new Label();
            LApellido = new Label();
            LDni = new Label();
            LPerfil = new Label();
            LDireccion = new Label();
            LTelefono = new Label();
            TNombre = new TextBox();
            TApellido = new TextBox();
            TCodigo_usuario = new TextBox();
            TDni = new TextBox();
            TDireccion = new TextBox();
            TTelefono = new TextBox();
            LCodigo_usuario = new Label();
            LTitulo = new Label();
            BGuardar = new Button();
            SuspendLayout();
            // 
            // ComboBoxPerfil
            // 
            ComboBoxPerfil.BackColor = SystemColors.Window;
            ComboBoxPerfil.FormattingEnabled = true;
            ComboBoxPerfil.Location = new Point(315, 331);
            ComboBoxPerfil.Name = "ComboBoxPerfil";
            ComboBoxPerfil.Size = new Size(199, 23);
            ComboBoxPerfil.TabIndex = 0;
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Font = new Font("Tw Cen MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LNombre.ForeColor = Color.FromArgb(64, 0, 0);
            LNombre.Location = new Point(82, 98);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(72, 22);
            LNombre.TabIndex = 1;
            LNombre.Text = "Nombre";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Font = new Font("Tw Cen MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LApellido.ForeColor = Color.FromArgb(64, 0, 0);
            LApellido.Location = new Point(312, 98);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(73, 22);
            LApellido.TabIndex = 2;
            LApellido.Text = "Apellido";
            // 
            // LDni
            // 
            LDni.AutoSize = true;
            LDni.Font = new Font("Tw Cen MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LDni.ForeColor = Color.FromArgb(64, 0, 0);
            LDni.Location = new Point(556, 98);
            LDni.Name = "LDni";
            LDni.Size = new Size(33, 22);
            LDni.TabIndex = 3;
            LDni.Text = "Dni";
            LDni.Click += label3_Click;
            // 
            // LPerfil
            // 
            LPerfil.AutoSize = true;
            LPerfil.Font = new Font("Tw Cen MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LPerfil.ForeColor = Color.FromArgb(64, 0, 0);
            LPerfil.Location = new Point(315, 305);
            LPerfil.Name = "LPerfil";
            LPerfil.Size = new Size(50, 22);
            LPerfil.TabIndex = 4;
            LPerfil.Text = "Perfil";
            LPerfil.Click += label4_Click;
            // 
            // LDireccion
            // 
            LDireccion.AutoSize = true;
            LDireccion.Font = new Font("Tw Cen MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LDireccion.ForeColor = Color.FromArgb(64, 0, 0);
            LDireccion.Location = new Point(82, 197);
            LDireccion.Name = "LDireccion";
            LDireccion.Size = new Size(77, 22);
            LDireccion.TabIndex = 5;
            LDireccion.Text = "Dirección";
            LDireccion.Click += LDireccion_Click;
            // 
            // LTelefono
            // 
            LTelefono.AutoSize = true;
            LTelefono.Font = new Font("Tw Cen MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LTelefono.ForeColor = Color.FromArgb(64, 0, 0);
            LTelefono.Location = new Point(312, 197);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(76, 22);
            LTelefono.TabIndex = 6;
            LTelefono.Text = "Telefono";
            // 
            // TNombre
            // 
            TNombre.BackColor = SystemColors.Window;
            TNombre.Location = new Point(82, 123);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(199, 23);
            TNombre.TabIndex = 7;
            // 
            // TApellido
            // 
            TApellido.BackColor = SystemColors.Window;
            TApellido.Location = new Point(315, 123);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(199, 23);
            TApellido.TabIndex = 8;
            // 
            // TCodigo_usuario
            // 
            TCodigo_usuario.BackColor = SystemColors.Window;
            TCodigo_usuario.Location = new Point(82, 330);
            TCodigo_usuario.Name = "TCodigo_usuario";
            TCodigo_usuario.Size = new Size(199, 23);
            TCodigo_usuario.TabIndex = 9;
            // 
            // TDni
            // 
            TDni.BackColor = SystemColors.Window;
            TDni.Location = new Point(556, 123);
            TDni.Name = "TDni";
            TDni.Size = new Size(199, 23);
            TDni.TabIndex = 10;
            // 
            // TDireccion
            // 
            TDireccion.BackColor = SystemColors.Window;
            TDireccion.Location = new Point(82, 222);
            TDireccion.Name = "TDireccion";
            TDireccion.Size = new Size(199, 23);
            TDireccion.TabIndex = 11;
            TDireccion.TextChanged += TDireccion_TextChanged;
            // 
            // TTelefono
            // 
            TTelefono.BackColor = SystemColors.Window;
            TTelefono.Location = new Point(315, 222);
            TTelefono.Name = "TTelefono";
            TTelefono.Size = new Size(199, 23);
            TTelefono.TabIndex = 12;
            // 
            // LCodigo_usuario
            // 
            LCodigo_usuario.AutoSize = true;
            LCodigo_usuario.Font = new Font("Tw Cen MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LCodigo_usuario.ForeColor = Color.FromArgb(64, 0, 0);
            LCodigo_usuario.Location = new Point(81, 305);
            LCodigo_usuario.Name = "LCodigo_usuario";
            LCodigo_usuario.Size = new Size(147, 22);
            LCodigo_usuario.TabIndex = 14;
            LCodigo_usuario.Text = "Codigo de usuario";
            // 
            // LTitulo
            // 
            LTitulo.AutoSize = true;
            LTitulo.BackColor = Color.FromArgb(64, 0, 0);
            LTitulo.Font = new Font("Tw Cen MT", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            LTitulo.ForeColor = Color.PapayaWhip;
            LTitulo.Location = new Point(-2, -3);
            LTitulo.Name = "LTitulo";
            LTitulo.Size = new Size(230, 34);
            LTitulo.TabIndex = 15;
            LTitulo.Text = "NUEVO USUARIO";
            // 
            // BGuardar
            // 
            BGuardar.BackColor = Color.FromArgb(64, 0, 0);
            BGuardar.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BGuardar.ForeColor = Color.PapayaWhip;
            BGuardar.Location = new Point(604, 322);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(102, 34);
            BGuardar.TabIndex = 16;
            BGuardar.Text = "Guardar";
            BGuardar.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(800, 450);
            Controls.Add(BGuardar);
            Controls.Add(LTitulo);
            Controls.Add(LCodigo_usuario);
            Controls.Add(TTelefono);
            Controls.Add(TDireccion);
            Controls.Add(TDni);
            Controls.Add(TCodigo_usuario);
            Controls.Add(TApellido);
            Controls.Add(TNombre);
            Controls.Add(LTelefono);
            Controls.Add(LDireccion);
            Controls.Add(LPerfil);
            Controls.Add(LDni);
            Controls.Add(LApellido);
            Controls.Add(LNombre);
            Controls.Add(ComboBoxPerfil);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ComboBoxPerfil;
        private Label LNombre;
        private Label LApellido;
        private Label LDni;
        private Label LPerfil;
        private Label LDireccion;
        private Label LTelefono;
        private TextBox TNombre;
        private TextBox TApellido;
        private TextBox TCodigo_usuario;
        private TextBox TDni;
        private TextBox TDireccion;
        private TextBox TTelefono;
        private Label LCodigo_usuario;
        private Label LTitulo;
        private Button BGuardar;
    }
}