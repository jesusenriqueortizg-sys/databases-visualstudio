namespace proyecto_databases
{
    partial class Proveedores
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
            TxtNombre = new TextBox();
            TxtTelefono = new TextBox();
            TxtCorreo = new TextBox();
            TxtID = new TextBox();
            TxtIDActualizar = new TextBox();
            TxtProveedorActualizar = new TextBox();
            TxtTelefonoActualizar = new TextBox();
            TxtCorreoActualizar = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            BtnAgregar = new Button();
            BtnEliminar = new Button();
            BtnActualizar = new Button();
            BtnMostrar = new Button();
            dgvProveedores = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            SuspendLayout();
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(114, 40);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(100, 23);
            TxtNombre.TabIndex = 0;
            // 
            // TxtTelefono
            // 
            TxtTelefono.Location = new Point(279, 40);
            TxtTelefono.Name = "TxtTelefono";
            TxtTelefono.Size = new Size(100, 23);
            TxtTelefono.TabIndex = 1;
            // 
            // TxtCorreo
            // 
            TxtCorreo.Location = new Point(114, 125);
            TxtCorreo.Name = "TxtCorreo";
            TxtCorreo.Size = new Size(100, 23);
            TxtCorreo.TabIndex = 2;
            // 
            // TxtID
            // 
            TxtID.Location = new Point(548, 40);
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(100, 23);
            TxtID.TabIndex = 3;
            // 
            // TxtIDActualizar
            // 
            TxtIDActualizar.Location = new Point(879, 40);
            TxtIDActualizar.Name = "TxtIDActualizar";
            TxtIDActualizar.Size = new Size(100, 23);
            TxtIDActualizar.TabIndex = 4;
            // 
            // TxtProveedorActualizar
            // 
            TxtProveedorActualizar.Location = new Point(1082, 40);
            TxtProveedorActualizar.Name = "TxtProveedorActualizar";
            TxtProveedorActualizar.Size = new Size(100, 23);
            TxtProveedorActualizar.TabIndex = 5;
            // 
            // TxtTelefonoActualizar
            // 
            TxtTelefonoActualizar.Location = new Point(879, 125);
            TxtTelefonoActualizar.Name = "TxtTelefonoActualizar";
            TxtTelefonoActualizar.Size = new Size(100, 23);
            TxtTelefonoActualizar.TabIndex = 6;
            // 
            // TxtCorreoActualizar
            // 
            TxtCorreoActualizar.Location = new Point(1082, 125);
            TxtCorreoActualizar.Name = "TxtCorreoActualizar";
            TxtCorreoActualizar.Size = new Size(100, 23);
            TxtCorreoActualizar.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 22);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 8;
            label1.Text = "Proveedor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(309, 22);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 10;
            label2.Text = "Telefono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(142, 107);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 12;
            label3.Text = "Correo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(574, 22);
            label4.Name = "label4";
            label4.Size = new Size(18, 15);
            label4.TabIndex = 14;
            label4.Text = "ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(910, 22);
            label5.Name = "label5";
            label5.Size = new Size(18, 15);
            label5.TabIndex = 16;
            label5.Text = "ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1105, 22);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 18;
            label6.Text = "Proveedor";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(910, 107);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 20;
            label7.Text = "Telefono";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1105, 107);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 22;
            label8.Text = "Correo";
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(215, 185);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(75, 23);
            BtnAgregar.TabIndex = 23;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += BtnAgregar_Click_1;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(585, 185);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(75, 23);
            BtnEliminar.TabIndex = 24;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnActualizar
            // 
            BtnActualizar.Location = new Point(992, 185);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new Size(75, 23);
            BtnActualizar.TabIndex = 25;
            BtnActualizar.Text = "Actualizar";
            BtnActualizar.UseVisualStyleBackColor = true;
            BtnActualizar.Click += BtnActualizar_Click;
            // 
            // BtnMostrar
            // 
            BtnMostrar.Location = new Point(585, 281);
            BtnMostrar.Name = "BtnMostrar";
            BtnMostrar.Size = new Size(75, 23);
            BtnMostrar.TabIndex = 26;
            BtnMostrar.Text = "Mostrar";
            BtnMostrar.UseVisualStyleBackColor = true;
            BtnMostrar.Click += BtnMostrar_Click;
            // 
            // dgvProveedores
            // 
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Location = new Point(107, 328);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.Size = new Size(1174, 220);
            dgvProveedores.TabIndex = 27;
            // 
            // Proveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1336, 560);
            Controls.Add(dgvProveedores);
            Controls.Add(BtnMostrar);
            Controls.Add(BtnActualizar);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnAgregar);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtCorreoActualizar);
            Controls.Add(TxtTelefonoActualizar);
            Controls.Add(TxtProveedorActualizar);
            Controls.Add(TxtIDActualizar);
            Controls.Add(TxtID);
            Controls.Add(TxtCorreo);
            Controls.Add(TxtTelefono);
            Controls.Add(TxtNombre);
            Name = "Proveedores";
            Text = "Proveedores";
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtNombre;
        private TextBox TxtTelefono;
        private TextBox TxtCorreo;
        private TextBox TxtID;
        private TextBox TxtIDActualizar;
        private TextBox TxtProveedorActualizar;
        private TextBox TxtTelefonoActualizar;
        private TextBox TxtCorreoActualizar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button BtnAgregar;
        private Button BtnEliminar;
        private Button BtnActualizar;
        private Button BtnMostrar;
        private DataGridView dgvProveedores;
    }
}