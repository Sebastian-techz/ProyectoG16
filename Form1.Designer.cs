namespace G16
{
    partial class AppDB
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
            lblDescripcion = new Label();
            label2 = new Label();
            txtDescripcion = new TextBox();
            txtPrecio = new TextBox();
            btnGuardar = new Button();
            label1 = new Label();
            txtNombre = new TextBox();
            dataGridViewProductos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            SuspendLayout();
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(22, 109);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(90, 20);
            lblDescripcion.TabIndex = 0;
            lblDescripcion.Text = "Descripción:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 224);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 0;
            label2.Text = "Precio:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.AcceptsReturn = true;
            txtDescripcion.Location = new Point(118, 111);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.ScrollBars = ScrollBars.Horizontal;
            txtDescripcion.Size = new Size(166, 104);
            txtDescripcion.TabIndex = 2;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(118, 224);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 27);
            txtPrecio.TabIndex = 3;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(118, 281);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(125, 29);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 67);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 6;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(118, 64);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 1;
            // 
            // dataGridViewProductos
            // 
            dataGridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductos.Location = new Point(22, 325);
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.RowHeadersWidth = 51;
            dataGridViewProductos.Size = new Size(569, 169);
            dataGridViewProductos.TabIndex = 8;
            // 
            // AppDB
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 506);
            Controls.Add(dataGridViewProductos);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Controls.Add(txtPrecio);
            Controls.Add(txtDescripcion);
            Controls.Add(label2);
            Controls.Add(lblDescripcion);
            Name = "AppDB";
            Text = "Programa G16";
            Load += AppDB_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDescripcion;
        private Label label2;
        private TextBox txtDescripcion;
        private TextBox txtPrecio;
        private Button btnGuardar;
        private Label label1;
        private TextBox txtNombre;
        private DataGridView dataGridViewProductos;
    }
}
