namespace bondAPPetite.View
{
    partial class ProductoCliente
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
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.labelImagen = new System.Windows.Forms.Label();
            this.buttonAgregarAlCarrito = new System.Windows.Forms.Button();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textDescripcion = new System.Windows.Forms.RichTextBox();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textCantidad = new System.Windows.Forms.TextBox();
            this.labelTituloTipoProducto = new System.Windows.Forms.Label();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLimpiar.Location = new System.Drawing.Point(493, 595);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(92, 28);
            this.buttonLimpiar.TabIndex = 49;
            this.buttonLimpiar.Text = "Volver";
            this.buttonLimpiar.UseVisualStyleBackColor = false;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscar.ForeColor = System.Drawing.Color.Gray;
            this.labelBuscar.Location = new System.Drawing.Point(42, 358);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(70, 20);
            this.labelBuscar.TabIndex = 46;
            this.labelBuscar.Text = "Buscar:";
            // 
            // textBuscar
            // 
            this.textBuscar.Location = new System.Drawing.Point(112, 360);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(212, 20);
            this.textBuscar.TabIndex = 45;
            this.textBuscar.TextChanged += new System.EventHandler(this.textBuscar_TextChanged);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.categoria,
            this.nombre,
            this.precio,
            this.descripcion,
            this.Imagen});
            this.dgvProductos.Location = new System.Drawing.Point(42, 386);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.Size = new System.Drawing.Size(803, 194);
            this.dgvProductos.TabIndex = 42;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoria";
            this.categoria.MinimumWidth = 6;
            this.categoria.Name = "categoria";
            this.categoria.Width = 125;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.Width = 125;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.MinimumWidth = 6;
            this.precio.Name = "precio";
            this.precio.Width = 125;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.MinimumWidth = 6;
            this.descripcion.Name = "descripcion";
            this.descripcion.Width = 125;
            // 
            // Imagen
            // 
            this.Imagen.HeaderText = "Imagen";
            this.Imagen.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Imagen.MinimumWidth = 6;
            this.Imagen.Name = "Imagen";
            this.Imagen.Width = 125;
            // 
            // labelImagen
            // 
            this.labelImagen.AutoSize = true;
            this.labelImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImagen.ForeColor = System.Drawing.Color.Gray;
            this.labelImagen.Location = new System.Drawing.Point(632, 80);
            this.labelImagen.Name = "labelImagen";
            this.labelImagen.Size = new System.Drawing.Size(74, 20);
            this.labelImagen.TabIndex = 41;
            this.labelImagen.Text = "Imagen:";
            // 
            // buttonAgregarAlCarrito
            // 
            this.buttonAgregarAlCarrito.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonAgregarAlCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarAlCarrito.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAgregarAlCarrito.Location = new System.Drawing.Point(41, 595);
            this.buttonAgregarAlCarrito.Name = "buttonAgregarAlCarrito";
            this.buttonAgregarAlCarrito.Size = new System.Drawing.Size(150, 28);
            this.buttonAgregarAlCarrito.TabIndex = 40;
            this.buttonAgregarAlCarrito.Text = "Agregar al carrito";
            this.buttonAgregarAlCarrito.UseVisualStyleBackColor = false;
            this.buttonAgregarAlCarrito.Click += new System.EventHandler(this.buttonAgregarAlCarrito_Click);
            // 
            // textPrecio
            // 
            this.textPrecio.Location = new System.Drawing.Point(46, 223);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(132, 20);
            this.textPrecio.TabIndex = 39;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(46, 153);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(306, 20);
            this.textNombre.TabIndex = 38;
            // 
            // textDescripcion
            // 
            this.textDescripcion.Location = new System.Drawing.Point(392, 103);
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(207, 203);
            this.textDescripcion.TabIndex = 37;
            this.textDescripcion.Text = "";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcion.ForeColor = System.Drawing.Color.Gray;
            this.labelDescripcion.Location = new System.Drawing.Point(388, 80);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(108, 20);
            this.labelDescripcion.TabIndex = 34;
            this.labelDescripcion.Text = "Descripción:";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.ForeColor = System.Drawing.Color.Gray;
            this.labelPrecio.Location = new System.Drawing.Point(42, 200);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(64, 20);
            this.labelPrecio.TabIndex = 33;
            this.labelPrecio.Text = "Precio:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.Gray;
            this.labelNombre.Location = new System.Drawing.Point(42, 130);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(76, 20);
            this.labelNombre.TabIndex = 32;
            this.labelNombre.Text = "Nombre:";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(482, 187);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(14, 20);
            this.textId.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(216, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 50;
            this.label1.Text = "Cantidad";
            // 
            // textCantidad
            // 
            this.textCantidad.Location = new System.Drawing.Point(220, 223);
            this.textCantidad.Name = "textCantidad";
            this.textCantidad.Size = new System.Drawing.Size(132, 20);
            this.textCantidad.TabIndex = 51;
            // 
            // labelTituloTipoProducto
            // 
            this.labelTituloTipoProducto.AutoSize = true;
            this.labelTituloTipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloTipoProducto.ForeColor = System.Drawing.Color.Gray;
            this.labelTituloTipoProducto.Location = new System.Drawing.Point(42, 20);
            this.labelTituloTipoProducto.Name = "labelTituloTipoProducto";
            this.labelTituloTipoProducto.Size = new System.Drawing.Size(71, 20);
            this.labelTituloTipoProducto.TabIndex = 52;
            this.labelTituloTipoProducto.Text = "TITULO";
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(636, 103);
            this.pbImagen.Margin = new System.Windows.Forms.Padding(2);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(209, 203);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 44;
            this.pbImagen.TabStop = false;
            // 
            // ProductoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 688);
            this.Controls.Add(this.labelTituloTipoProducto);
            this.Controls.Add(this.textCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.labelBuscar);
            this.Controls.Add(this.textBuscar);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.labelImagen);
            this.Controls.Add(this.buttonAgregarAlCarrito);
            this.Controls.Add(this.textPrecio);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.textDescripcion);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.textId);
            this.Name = "ProductoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ProductoCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewImageColumn Imagen;
        private System.Windows.Forms.Label labelImagen;
        private System.Windows.Forms.Button buttonAgregarAlCarrito;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.RichTextBox textDescripcion;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCantidad;
        private System.Windows.Forms.Label labelTituloTipoProducto;
    }
}