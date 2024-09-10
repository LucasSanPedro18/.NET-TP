﻿namespace WindowsForms
{
    partial class PersonaDetalle
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
            nombreTextBox = new TextBox();
            nombreLabel = new Label();
            aceptarButton = new Button();
            errorProvider = new ErrorProvider(components);
            cancelarButton = new Button();
            label1 = new Label();
            apellidoTextBox = new TextBox();
            label2 = new Label();
            direccionTextBox = new TextBox();
            label3 = new Label();
            telefonoTextBox = new TextBox();
            label4 = new Label();
            fechaNacPicker = new DateTimePicker();
            label5 = new Label();
            legajoTextBox = new TextBox();
            label6 = new Label();
            tipoTextBox = new TextBox();
            label7 = new Label();
            emailTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(72, 6);
            nombreTextBox.Margin = new Padding(2, 1, 2, 1);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(110, 23);
            nombreTextBox.TabIndex = 0;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new Point(11, 9);
            nombreLabel.Margin = new Padding(2, 0, 2, 0);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(51, 15);
            nombreLabel.TabIndex = 1;
            nombreLabel.Text = "Nombre";
            // 
            // aceptarButton
            // 
            aceptarButton.Location = new Point(239, 172);
            aceptarButton.Margin = new Padding(2, 1, 2, 1);
            aceptarButton.Name = "aceptarButton";
            aceptarButton.Size = new Size(81, 22);
            aceptarButton.TabIndex = 2;
            aceptarButton.Text = "Aceptar";
            aceptarButton.UseVisualStyleBackColor = true;
            aceptarButton.Click += aceptarButton_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(331, 172);
            cancelarButton.Margin = new Padding(2, 1, 2, 1);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(81, 22);
            cancelarButton.TabIndex = 3;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(239, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 4;
            label1.Text = "Apellido";
            // 
            // apellidoTextBox
            // 
            apellidoTextBox.Location = new Point(302, 6);
            apellidoTextBox.Margin = new Padding(2, 1, 2, 1);
            apellidoTextBox.Name = "apellidoTextBox";
            apellidoTextBox.Size = new Size(110, 23);
            apellidoTextBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 52);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 6;
            label2.Text = "Direccion";
            // 
            // direccionTextBox
            // 
            direccionTextBox.Location = new Point(72, 49);
            direccionTextBox.Margin = new Padding(2, 1, 2, 1);
            direccionTextBox.Name = "direccionTextBox";
            direccionTextBox.Size = new Size(110, 23);
            direccionTextBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(239, 52);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 8;
            label3.Text = "Telefono";
            // 
            // telefonoTextBox
            // 
            telefonoTextBox.Location = new Point(302, 52);
            telefonoTextBox.Margin = new Padding(2, 1, 2, 1);
            telefonoTextBox.Name = "telefonoTextBox";
            telefonoTextBox.Size = new Size(110, 23);
            telefonoTextBox.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 96);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(119, 15);
            label4.TabIndex = 10;
            label4.Text = "Fecha de Nacimiento";
            // 
            // fechaNacPicker
            // 
            fechaNacPicker.Location = new Point(148, 90);
            fechaNacPicker.Name = "fechaNacPicker";
            fechaNacPicker.Size = new Size(264, 23);
            fechaNacPicker.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 130);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 12;
            label5.Text = "Legajo";
            // 
            // legajoTextBox
            // 
            legajoTextBox.Location = new Point(72, 130);
            legajoTextBox.Margin = new Padding(2, 1, 2, 1);
            legajoTextBox.Name = "legajoTextBox";
            legajoTextBox.RightToLeft = RightToLeft.No;
            legajoTextBox.Size = new Size(110, 23);
            legajoTextBox.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(239, 133);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 14;
            label6.Text = "Tipo";
            // 
            // tipoTextBox
            // 
            tipoTextBox.Location = new Point(302, 133);
            tipoTextBox.Margin = new Padding(2, 1, 2, 1);
            tipoTextBox.Name = "tipoTextBox";
            tipoTextBox.Size = new Size(110, 23);
            tipoTextBox.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 176);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 16;
            label7.Text = "Email";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(72, 169);
            emailTextBox.Margin = new Padding(2, 1, 2, 1);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(110, 23);
            emailTextBox.TabIndex = 17;
            // 
            // personaDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 211);
            Controls.Add(emailTextBox);
            Controls.Add(label7);
            Controls.Add(tipoTextBox);
            Controls.Add(label6);
            Controls.Add(legajoTextBox);
            Controls.Add(label5);
            Controls.Add(fechaNacPicker);
            Controls.Add(label4);
            Controls.Add(telefonoTextBox);
            Controls.Add(label3);
            Controls.Add(direccionTextBox);
            Controls.Add(label2);
            Controls.Add(apellidoTextBox);
            Controls.Add(label1);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Controls.Add(nombreLabel);
            Controls.Add(nombreTextBox);
            Margin = new Padding(2, 1, 2, 1);
            Name = "personaDetalle";
            Text = "Agregue una Persona";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nombreTextBox;
        private Label nombreLabel;
        private Button aceptarButton;
        private ErrorProvider errorProvider;
        private Button cancelarButton;
        private Label label1;
        private TextBox apellidoTextBox;
        private TextBox direccionTextBox;
        private Label label2;
        private TextBox telefonoTextBox;
        private Label label3;
        private TextBox tipoTextBox;
        private Label label6;
        private TextBox legajoTextBox;
        private Label label5;
        private DateTimePicker fechaNacPicker;
        private Label label4;
        private Label label7;
        private TextBox emailTextBox;
    }
}