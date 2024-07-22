namespace Presentacion.Formularios
{
    partial class InsertarEmpleado
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
            lblTitulo = new Label();
            lblNombres = new Label();
            lblApellidos = new Label();
            lblFechaNacimiento = new Label();
            lblUsuario = new Label();
            lblCargo = new Label();
            lblDireccion = new Label();
            lblEmail = new Label();
            lblSexo = new Label();
            txtNombres = new TextBox();
            txtApellidos = new TextBox();
            dtpFechaNacimiento = new DateTimePicker();
            cmbSexo = new ComboBox();
            cmbCargos = new ComboBox();
            txtUsuario = new TextBox();
            textBox1 = new TextBox();
            txtDireccion = new TextBox();
            gbFormulario = new GroupBox();
            lblInfo = new Label();
            btnGuardar = new Button();
            gbBtn = new GroupBox();
            lblLinea = new Label();
            gbFormulario.SuspendLayout();
            gbBtn.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.None;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(294, 59);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(250, 29);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "NUEVO EMPLEADO";
            // 
            // lblNombres
            // 
            lblNombres.Anchor = AnchorStyles.None;
            lblNombres.AutoSize = true;
            lblNombres.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombres.Location = new Point(26, 27);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(83, 21);
            lblNombres.TabIndex = 1;
            lblNombres.Text = "Nombres:";
            // 
            // lblApellidos
            // 
            lblApellidos.Anchor = AnchorStyles.None;
            lblApellidos.AutoSize = true;
            lblApellidos.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellidos.Location = new Point(281, 27);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(84, 21);
            lblApellidos.TabIndex = 2;
            lblApellidos.Text = "Apellidos:";
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.Anchor = AnchorStyles.None;
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaNacimiento.Location = new Point(26, 61);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(180, 21);
            lblFechaNacimiento.TabIndex = 3;
            lblFechaNacimiento.Text = "fecha de Nacimiento:";
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.None;
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.Location = new Point(26, 129);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(70, 21);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Usuario:";
            // 
            // lblCargo
            // 
            lblCargo.Anchor = AnchorStyles.None;
            lblCargo.AutoSize = true;
            lblCargo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCargo.Location = new Point(227, 95);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(64, 21);
            lblCargo.TabIndex = 5;
            lblCargo.Text = "Cargo:";
            // 
            // lblDireccion
            // 
            lblDireccion.Anchor = AnchorStyles.None;
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDireccion.Location = new Point(26, 163);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(87, 21);
            lblDireccion.TabIndex = 6;
            lblDireccion.Text = "Dirección:";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.None;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(208, 129);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(67, 21);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Correo:";
            // 
            // lblSexo
            // 
            lblSexo.Anchor = AnchorStyles.None;
            lblSexo.AutoSize = true;
            lblSexo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSexo.Location = new Point(26, 95);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(50, 21);
            lblSexo.TabIndex = 8;
            lblSexo.Text = "Sexo:";
            // 
            // txtNombres
            // 
            txtNombres.Anchor = AnchorStyles.None;
            txtNombres.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombres.Location = new Point(115, 25);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(155, 26);
            txtNombres.TabIndex = 9;
            // 
            // txtApellidos
            // 
            txtApellidos.Anchor = AnchorStyles.None;
            txtApellidos.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellidos.Location = new Point(371, 25);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(155, 26);
            txtApellidos.TabIndex = 10;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Anchor = AnchorStyles.None;
            dtpFechaNacimiento.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFechaNacimiento.Location = new Point(212, 59);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(218, 26);
            dtpFechaNacimiento.TabIndex = 11;
            // 
            // cmbSexo
            // 
            cmbSexo.Anchor = AnchorStyles.None;
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Items.AddRange(new object[] { "Femenino", "Masculino" });
            cmbSexo.Location = new Point(81, 97);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(140, 23);
            cmbSexo.TabIndex = 12;
            // 
            // cmbCargos
            // 
            cmbCargos.Anchor = AnchorStyles.None;
            cmbCargos.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCargos.FormattingEnabled = true;
            cmbCargos.Items.AddRange(new object[] { "Encargado de Proyecto", "Encargado de Finanzas" });
            cmbCargos.Location = new Point(297, 93);
            cmbCargos.Name = "cmbCargos";
            cmbCargos.Size = new Size(229, 28);
            cmbCargos.TabIndex = 13;
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.None;
            txtUsuario.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(102, 127);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 26);
            txtUsuario.TabIndex = 14;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(281, 127);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(245, 26);
            textBox1.TabIndex = 15;
            // 
            // txtDireccion
            // 
            txtDireccion.Anchor = AnchorStyles.None;
            txtDireccion.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDireccion.Location = new Point(119, 161);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(407, 59);
            txtDireccion.TabIndex = 16;
            // 
            // gbFormulario
            // 
            gbFormulario.Anchor = AnchorStyles.None;
            gbFormulario.Controls.Add(lblInfo);
            gbFormulario.Controls.Add(lblCargo);
            gbFormulario.Controls.Add(txtDireccion);
            gbFormulario.Controls.Add(lblNombres);
            gbFormulario.Controls.Add(textBox1);
            gbFormulario.Controls.Add(lblApellidos);
            gbFormulario.Controls.Add(txtUsuario);
            gbFormulario.Controls.Add(lblFechaNacimiento);
            gbFormulario.Controls.Add(cmbCargos);
            gbFormulario.Controls.Add(lblUsuario);
            gbFormulario.Controls.Add(cmbSexo);
            gbFormulario.Controls.Add(lblDireccion);
            gbFormulario.Controls.Add(dtpFechaNacimiento);
            gbFormulario.Controls.Add(lblEmail);
            gbFormulario.Controls.Add(txtApellidos);
            gbFormulario.Controls.Add(lblSexo);
            gbFormulario.Controls.Add(txtNombres);
            gbFormulario.Location = new Point(150, 127);
            gbFormulario.Name = "gbFormulario";
            gbFormulario.Size = new Size(598, 244);
            gbFormulario.TabIndex = 17;
            gbFormulario.TabStop = false;
            // 
            // lblInfo
            // 
            lblInfo.Anchor = AnchorStyles.None;
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblInfo.ForeColor = Color.Red;
            lblInfo.Location = new Point(168, 223);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(283, 15);
            lblInfo.TabIndex = 19;
            lblInfo.Text = "* Todos los campos del formulario son obligatorios *";
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.None;
            btnGuardar.BackColor = Color.FromArgb(24, 30, 54);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(13, 93, 142);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(6, 14);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(185, 41);
            btnGuardar.TabIndex = 18;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // gbBtn
            // 
            gbBtn.Anchor = AnchorStyles.None;
            gbBtn.Controls.Add(btnGuardar);
            gbBtn.Location = new Point(347, 377);
            gbBtn.Name = "gbBtn";
            gbBtn.Size = new Size(197, 61);
            gbBtn.TabIndex = 19;
            gbBtn.TabStop = false;
            // 
            // lblLinea
            // 
            lblLinea.Anchor = AnchorStyles.None;
            lblLinea.AutoSize = true;
            lblLinea.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblLinea.Location = new Point(283, 76);
            lblLinea.Name = "lblLinea";
            lblLinea.Size = new Size(273, 20);
            lblLinea.TabIndex = 20;
            lblLinea.Text = "____________________________________________";
            // 
            // InsertarEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 519);
            Controls.Add(lblTitulo);
            Controls.Add(lblLinea);
            Controls.Add(gbBtn);
            Controls.Add(gbFormulario);
            Name = "InsertarEmpleado";
            Text = "Nuevo Empleado";
            gbFormulario.ResumeLayout(false);
            gbFormulario.PerformLayout();
            gbBtn.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNombres;
        private Label lblApellidos;
        private Label lblFechaNacimiento;
        private Label lblUsuario;
        private Label lblCargo;
        private Label lblDireccion;
        private Label lblEmail;
        private Label lblSexo;
        private TextBox txtNombres;
        private TextBox txtApellidos;
        private DateTimePicker dtpFechaNacimiento;
        private ComboBox cmbSexo;
        private ComboBox cmbCargos;
        private TextBox txtUsuario;
        private TextBox textBox1;
        private TextBox txtDireccion;
        private GroupBox gbFormulario;
        private Button btnGuardar;
        private Label lblInfo;
        private GroupBox gbBtn;
        private Label lblLinea;
    }
}