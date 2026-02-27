namespace proyecto_databases
{
    partial class Clientes
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
            TxtDireccion = new TextBox();
            TxtCorreo = new TextBox();
            TxtTelefono = new TextBox();
            BtnAñadir = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            IDbuscar = new TextBox();
            label8 = new Label();
            BtnEliminar = new Button();
            BtnActualizar = new Button();
            label9 = new Label();
            TxtCorreoActualizar = new TextBox();
            TxtTelefonoActualizar = new TextBox();
            TxtNombreActualizar = new TextBox();
            TxtID = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            BtnMostrar = new Button();
            dgvClientes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(38, 51);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(126, 23);
            TxtNombre.TabIndex = 0;
            // 
            // TxtDireccion
            // 
            TxtDireccion.Location = new Point(38, 118);
            TxtDireccion.Name = "TxtDireccion";
            TxtDireccion.Size = new Size(126, 23);
            TxtDireccion.TabIndex = 1;
            // 
            // TxtCorreo
            // 
            TxtCorreo.Location = new Point(231, 51);
            TxtCorreo.Name = "TxtCorreo";
            TxtCorreo.Size = new Size(121, 23);
            TxtCorreo.TabIndex = 2;
            // 
            // TxtTelefono
            // 
            TxtTelefono.Location = new Point(226, 118);
            TxtTelefono.Name = "TxtTelefono";
            TxtTelefono.Size = new Size(126, 23);
            TxtTelefono.TabIndex = 3;
            // 
            // BtnAñadir
            // 
            BtnAñadir.Location = new Point(158, 165);
            BtnAñadir.Name = "BtnAñadir";
            BtnAñadir.Size = new Size(75, 23);
            BtnAñadir.TabIndex = 5;
            BtnAñadir.Text = "Añadir";
            BtnAñadir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 33);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 6;
            label1.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 100);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 8;
            label3.Text = "Direccion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(263, 33);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 9;
            label4.Text = "Correo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(253, 100);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 10;
            label5.Text = "Telefono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 6);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 11;
            label6.Text = "Insertar";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(436, 6);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 12;
            label7.Text = "Eliminar";
            // 
            // IDbuscar
            // 
            IDbuscar.Location = new Point(520, 61);
            IDbuscar.Name = "IDbuscar";
            IDbuscar.Size = new Size(100, 23);
            IDbuscar.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(558, 33);
            label8.Name = "label8";
            label8.Size = new Size(18, 15);
            label8.TabIndex = 14;
            label8.Text = "ID";
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(520, 165);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(75, 23);
            BtnEliminar.TabIndex = 15;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnActualizar
            // 
            BtnActualizar.Location = new Point(965, 175);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new Size(75, 23);
            BtnActualizar.TabIndex = 16;
            BtnActualizar.Text = "Actualizar";
            BtnActualizar.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(864, 9);
            label9.Name = "label9";
            label9.Size = new Size(59, 15);
            label9.TabIndex = 17;
            label9.Text = "Actualizar";
            // 
            // TxtCorreoActualizar
            // 
            TxtCorreoActualizar.Location = new Point(1013, 51);
            TxtCorreoActualizar.Name = "TxtCorreoActualizar";
            TxtCorreoActualizar.Size = new Size(126, 23);
            TxtCorreoActualizar.TabIndex = 18;
            // 
            // TxtTelefonoActualizar
            // 
            TxtTelefonoActualizar.Location = new Point(1013, 118);
            TxtTelefonoActualizar.Name = "TxtTelefonoActualizar";
            TxtTelefonoActualizar.Size = new Size(126, 23);
            TxtTelefonoActualizar.TabIndex = 19;
            // 
            // TxtNombreActualizar
            // 
            TxtNombreActualizar.Location = new Point(832, 118);
            TxtNombreActualizar.Name = "TxtNombreActualizar";
            TxtNombreActualizar.Size = new Size(126, 23);
            TxtNombreActualizar.TabIndex = 20;
            // 
            // TxtID
            // 
            TxtID.Location = new Point(832, 51);
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(126, 23);
            TxtID.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(854, 96);
            label10.Name = "label10";
            label10.Size = new Size(89, 15);
            label10.TabIndex = 22;
            label10.Text = "Nuevo Nombre";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(884, 33);
            label11.Name = "label11";
            label11.Size = new Size(18, 15);
            label11.TabIndex = 23;
            label11.Text = "ID";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(1036, 33);
            label12.Name = "label12";
            label12.Size = new Size(81, 15);
            label12.TabIndex = 24;
            label12.Text = "Nuevo Correo";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(1036, 96);
            label13.Name = "label13";
            label13.Size = new Size(53, 15);
            label13.TabIndex = 25;
            label13.Text = "Telefono";
            // 
            // BtnMostrar
            // 
            BtnMostrar.Location = new Point(591, 301);
            BtnMostrar.Name = "BtnMostrar";
            BtnMostrar.Size = new Size(75, 23);
            BtnMostrar.TabIndex = 26;
            BtnMostrar.Text = "Mostrar";
            BtnMostrar.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(38, 346);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(1280, 211);
            dgvClientes.TabIndex = 27;
            dgvClientes.CellContentClick += dgvClientes_CellContentClick;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 611);
            Controls.Add(dgvClientes);
            Controls.Add(BtnMostrar);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(TxtID);
            Controls.Add(TxtNombreActualizar);
            Controls.Add(TxtTelefonoActualizar);
            Controls.Add(TxtCorreoActualizar);
            Controls.Add(label9);
            Controls.Add(BtnActualizar);
            Controls.Add(BtnEliminar);
            Controls.Add(label8);
            Controls.Add(IDbuscar);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(BtnAñadir);
            Controls.Add(TxtTelefono);
            Controls.Add(TxtCorreo);
            Controls.Add(TxtDireccion);
            Controls.Add(TxtNombre);
            Name = "Clientes";
            Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtNombre;
        private TextBox TxtDireccion;
        private TextBox TxtCorreo;
        private TextBox TxtTelefono;
        private Button BtnAñadir;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox IDbuscar;
        private Label label8;
        private Button BtnEliminar;
        private Button BtnActualizar;
        private Label label9;
        private TextBox TxtCorreoActualizar;
        private TextBox TxtTelefonoActualizar;
        private TextBox TxtNombreActualizar;
        private TextBox TxtID;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button BtnMostrar;
        private DataGridView dgvClientes;
    }
}