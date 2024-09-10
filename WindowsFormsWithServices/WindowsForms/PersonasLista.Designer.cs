namespace WindowsForms
{
    partial class PersonasLista
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
            personasDataGridView = new DataGridView();
            agregarButton = new Button();
            eliminarButton = new Button();
            modificarButton = new Button();
            ((System.ComponentModel.ISupportInitialize)personasDataGridView).BeginInit();
            // 
            // personasDataGridView
            // 
            personasDataGridView.AllowUserToOrderColumns = true;
            personasDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            personasDataGridView.Location = new Point(39, 38);
            personasDataGridView.MultiSelect = false;
            personasDataGridView.Name = "personasDataGridView";
            personasDataGridView.ReadOnly = true;
            personasDataGridView.RowHeadersWidth = 82;
            personasDataGridView.RowTemplate.Height = 41;
            personasDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            personasDataGridView.Size = new Size(1395, 576);
            personasDataGridView.TabIndex = 0;
            // 
            // agregarButton
            // 
            agregarButton.Location = new Point(1284, 641);
            agregarButton.Name = "agregarButton";
            agregarButton.Size = new Size(150, 46);
            agregarButton.TabIndex = 1;
            agregarButton.Text = "Agregar";
            agregarButton.UseVisualStyleBackColor = true;
            agregarButton.Click += agregarButton_Click;
            // 
            // eliminarButton
            // 
            eliminarButton.Location = new Point(940, 641);
            eliminarButton.Name = "eliminarButton";
            eliminarButton.Size = new Size(150, 46);
            eliminarButton.TabIndex = 2;
            eliminarButton.Text = "Eliminar";
            eliminarButton.UseVisualStyleBackColor = true;
            eliminarButton.Click += eliminarButton_Click;
            // 
            // modificarButton
            // 
            modificarButton.Location = new Point(1111, 641);
            modificarButton.Name = "modificarButton";
            modificarButton.Size = new Size(150, 46);
            modificarButton.TabIndex = 3;
            modificarButton.Text = "Modificar";
            modificarButton.UseVisualStyleBackColor = true;
            modificarButton.Click += modificarButton_Click;
            // 
            // personasLista
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1478, 857);
            Controls.Add(modificarButton);
            Controls.Add(eliminarButton);
            Controls.Add(agregarButton);
            Controls.Add(personasDataGridView);
            Name = "personasLista";
            Text = "personas";
            Load += Personas_Load;
            ((System.ComponentModel.ISupportInitialize)personasDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView personasDataGridView;
        private Button agregarButton;
        private Button eliminarButton;
        private Button modificarButton;
    }
}