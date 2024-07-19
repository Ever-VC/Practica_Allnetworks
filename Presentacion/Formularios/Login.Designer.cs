namespace Presentacion.Formularios
{
    partial class Login
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pnlIzquierda = new Panel();
            lblLinea1 = new Label();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            lblLinea2 = new Label();
            label2 = new Label();
            btnIniciarSesion = new Button();
            linkPassword = new LinkLabel();
            btnMinimizar = new Button();
            btnCerrar = new Button();
            toolTip1 = new ToolTip(components);
            lblError = new Label();
            SuspendLayout();
            // 
            // pnlIzquierda
            // 
            pnlIzquierda.BackColor = Color.FromArgb(0, 122, 204);
            pnlIzquierda.Dock = DockStyle.Left;
            pnlIzquierda.Location = new Point(0, 0);
            pnlIzquierda.Name = "pnlIzquierda";
            pnlIzquierda.Size = new Size(250, 330);
            pnlIzquierda.TabIndex = 0;
            pnlIzquierda.MouseDown += Login_MouseDown;
            // 
            // lblLinea1
            // 
            lblLinea1.AutoSize = true;
            lblLinea1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblLinea1.ForeColor = Color.DimGray;
            lblLinea1.Location = new Point(314, 104);
            lblLinea1.Name = "lblLinea1";
            lblLinea1.Size = new Size(414, 32);
            lblLinea1.TabIndex = 1;
            lblLinea1.Text = "________________________________________";
            lblLinea1.MouseDown += Login_MouseDown;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(15, 15, 15);
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.ForeColor = Color.DimGray;
            txtUsuario.Location = new Point(324, 106);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(393, 20);
            txtUsuario.TabIndex = 0;
            txtUsuario.Text = "USUARIO";
            toolTip1.SetToolTip(txtUsuario, "Usuario");
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(15, 15, 15);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.DimGray;
            txtPassword.Location = new Point(324, 160);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(393, 20);
            txtPassword.TabIndex = 1;
            txtPassword.Text = "CONTRASEÑA";
            toolTip1.SetToolTip(txtPassword, "Contraseña");
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // lblLinea2
            // 
            lblLinea2.AutoSize = true;
            lblLinea2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblLinea2.ForeColor = Color.DimGray;
            lblLinea2.Location = new Point(314, 158);
            lblLinea2.Name = "lblLinea2";
            lblLinea2.Size = new Size(414, 32);
            lblLinea2.TabIndex = 3;
            lblLinea2.Text = "________________________________________";
            lblLinea2.MouseDown += Login_MouseDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(445, 23);
            label2.Name = "label2";
            label2.Size = new Size(118, 38);
            label2.TabIndex = 5;
            label2.Text = "LOGIN";
            label2.MouseDown += Login_MouseDown;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = Color.FromArgb(40, 40, 40);
            btnIniciarSesion.Cursor = Cursors.Hand;
            btnIniciarSesion.FlatAppearance.BorderSize = 0;
            btnIniciarSesion.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnIniciarSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnIniciarSesion.FlatStyle = FlatStyle.Flat;
            btnIniciarSesion.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnIniciarSesion.ForeColor = Color.LightGray;
            btnIniciarSesion.Location = new Point(319, 230);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(402, 40);
            btnIniciarSesion.TabIndex = 2;
            btnIniciarSesion.Text = "ACCEDER";
            toolTip1.SetToolTip(btnIniciarSesion, "Acceder");
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // linkPassword
            // 
            linkPassword.ActiveLinkColor = Color.FromArgb(0, 122, 204);
            linkPassword.AutoSize = true;
            linkPassword.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            linkPassword.LinkColor = Color.LightGray;
            linkPassword.Location = new Point(421, 284);
            linkPassword.Name = "linkPassword";
            linkPassword.Size = new Size(203, 17);
            linkPassword.TabIndex = 3;
            linkPassword.TabStop = true;
            linkPassword.Text = "¿Has olvidado la contraseña?";
            toolTip1.SetToolTip(linkPassword, "Recuperar contraseña");
            // 
            // btnMinimizar
            // 
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(692, 0);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(45, 35);
            btnMinimizar.TabIndex = 4;
            toolTip1.SetToolTip(btnMinimizar, "Minimizar");
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(735, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(45, 35);
            btnCerrar.TabIndex = 5;
            toolTip1.SetToolTip(btnCerrar, "Cerrar");
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("MS Reference Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblError.ForeColor = Color.DarkGray;
            lblError.Image = (Image)resources.GetObject("lblError.Image");
            lblError.ImageAlign = ContentAlignment.TopLeft;
            lblError.Location = new Point(319, 199);
            lblError.Name = "lblError";
            lblError.Size = new Size(118, 16);
            lblError.TabIndex = 6;
            lblError.Text = "Mensaje de error";
            lblError.Visible = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(780, 330);
            Controls.Add(lblError);
            Controls.Add(btnCerrar);
            Controls.Add(btnMinimizar);
            Controls.Add(linkPassword);
            Controls.Add(btnIniciarSesion);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(lblLinea2);
            Controls.Add(txtUsuario);
            Controls.Add(lblLinea1);
            Controls.Add(pnlIzquierda);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            MouseDown += Login_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlIzquierda;
        private Label lblLinea1;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private Label lblLinea2;
        private Label label2;
        private Button btnIniciarSesion;
        private LinkLabel linkPassword;
        private Button btnMinimizar;
        private Button btnCerrar;
        private ToolTip toolTip1;
        private Label lblError;
    }
}