﻿namespace Presentacion.Formularios
{
    partial class InsertarProyecto
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
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(290, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(107, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "NUEVO PROYECTO";
            // 
            // InsertarProyecto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitulo);
            Name = "InsertarProyecto";
            Text = "InsertarProyecto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
    }
}