namespace proyecto_databases
{
    partial class Categorias
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
            TxtCategoria = new TextBox();
            Eliminar = new TextBox();
            TxtIDActualizar = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            TxtCategoriaActualizar = new TextBox();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // TxtCategoria
            // 
            TxtCategoria.Location = new Point(53, 50);
            TxtCategoria.Name = "TxtCategoria";
            TxtCategoria.Size = new Size(100, 23);
            TxtCategoria.TabIndex = 0;
            // 
            // Eliminar
            // 
            Eliminar.Location = new Point(414, 50);
            Eliminar.Name = "Eliminar";
            Eliminar.Size = new Size(100, 23);
            Eliminar.TabIndex = 3;
            // 
            // TxtIDActualizar
            // 
            TxtIDActualizar.Location = new Point(707, 50);
            TxtIDActualizar.Name = "TxtIDActualizar";
            TxtIDActualizar.Size = new Size(100, 23);
            TxtIDActualizar.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(64, 94);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Añadir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(427, 94);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(785, 115);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 7;
            button3.Text = "Actualizar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // TxtCategoriaActualizar
            // 
            TxtCategoriaActualizar.Location = new Point(861, 50);
            TxtCategoriaActualizar.Name = "TxtCategoriaActualizar";
            TxtCategoriaActualizar.Size = new Size(100, 23);
            TxtCategoriaActualizar.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 32);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 11;
            label1.Text = "Categoria";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(743, 32);
            label5.Name = "label5";
            label5.Size = new Size(18, 15);
            label5.TabIndex = 15;
            label5.Text = "ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(866, 32);
            label6.Name = "label6";
            label6.Size = new Size(95, 15);
            label6.TabIndex = 16;
            label6.Text = "Nueva Categoria";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(42, 292);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(904, 199);
            dataGridView1.TabIndex = 19;
            // 
            // button4
            // 
            button4.Location = new Point(427, 250);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 20;
            button4.Text = "Mostrar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(444, 23);
            label4.Name = "label4";
            label4.Size = new Size(18, 15);
            label4.TabIndex = 14;
            label4.Text = "ID";
            // 
            // Categorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 515);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(TxtCategoriaActualizar);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(TxtIDActualizar);
            Controls.Add(Eliminar);
            Controls.Add(TxtCategoria);
            Name = "Categorias";
            Text = "Categorias";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtCategoria;
        private TextBox Eliminar;
        private TextBox TxtIDActualizar;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox TxtCategoriaActualizar;
        private Label label1;
        private Label label5;
        private Label label6;
        private DataGridView dataGridView1;
        private Button button4;
        private Label label4;
    }
}