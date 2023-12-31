﻿using System;

namespace bondAPPetite.View
{
    partial class ProductosAdmin
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.comboCategoria = new System.Windows.Forms.ComboBox();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.textDescripcion = new System.Windows.Forms.RichTextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.labelImagen = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.ofdSeleccionar = new System.Windows.Forms.OpenFileDialog();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.textId = new System.Windows.Forms.TextBox();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.buttonVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.Gray;
            this.labelNombre.Location = new System.Drawing.Point(19, 62);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(76, 20);
            this.labelNombre.TabIndex = 11;
            this.labelNombre.Text = "Nombre:";
            this.labelNombre.Click += new System.EventHandler(this.labelNombre_Click);
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.ForeColor = System.Drawing.Color.Gray;
            this.labelPrecio.Location = new System.Drawing.Point(19, 99);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(64, 20);
            this.labelPrecio.TabIndex = 13;
            this.labelPrecio.Text = "Precio:";
            this.labelPrecio.Click += new System.EventHandler(this.labelPrecio_Click);
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcion.ForeColor = System.Drawing.Color.Gray;
            this.labelDescripcion.Location = new System.Drawing.Point(19, 133);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(108, 20);
            this.labelDescripcion.TabIndex = 15;
            this.labelDescripcion.Text = "Descripción:";
            this.labelDescripcion.Click += new System.EventHandler(this.labelDescripcion_Click);
            // 
            // comboCategoria
            // 
            this.comboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.Location = new System.Drawing.Point(117, 24);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(212, 21);
            this.comboCategoria.TabIndex = 16;
            this.comboCategoria.SelectedIndexChanged += new System.EventHandler(this.comboCategoria_SelectedIndexChanged);
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoria.ForeColor = System.Drawing.Color.Gray;
            this.labelCategoria.Location = new System.Drawing.Point(19, 22);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(92, 20);
            this.labelCategoria.TabIndex = 17;
            this.labelCategoria.Text = "Categoria:";
            this.labelCategoria.Click += new System.EventHandler(this.labelCategoria_Click);
            // 
            // textDescripcion
            // 
            this.textDescripcion.Location = new System.Drawing.Point(23, 158);
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(306, 96);
            this.textDescripcion.TabIndex = 18;
            this.textDescripcion.Text = "";
            this.textDescripcion.TextChanged += new System.EventHandler(this.textDescripcion_TextChanged);
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(117, 64);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(212, 20);
            this.textNombre.TabIndex = 19;
            this.textNombre.TextChanged += new System.EventHandler(this.textNombre_TextChanged);
            // 
            // textPrecio
            // 
            this.textPrecio.Location = new System.Drawing.Point(117, 99);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(212, 20);
            this.textPrecio.TabIndex = 20;
            this.textPrecio.TextChanged += new System.EventHandler(this.textPrecio_TextChanged);
            // 
            // buttonCargar
            // 
            this.buttonCargar.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCargar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCargar.Location = new System.Drawing.Point(23, 550);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(92, 28);
            this.buttonCargar.TabIndex = 21;
            this.buttonCargar.Text = "Cargar";
            this.buttonCargar.UseVisualStyleBackColor = false;
            this.buttonCargar.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelImagen
            // 
            this.labelImagen.AutoSize = true;
            this.labelImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImagen.ForeColor = System.Drawing.Color.Gray;
            this.labelImagen.Location = new System.Drawing.Point(364, 22);
            this.labelImagen.Name = "labelImagen";
            this.labelImagen.Size = new System.Drawing.Size(74, 20);
            this.labelImagen.TabIndex = 23;
            this.labelImagen.Text = "Imagen:";
            this.labelImagen.Click += new System.EventHandler(this.label1_Click);
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
            this.dgvProductos.Location = new System.Drawing.Point(24, 341);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.Size = new System.Drawing.Size(545, 194);
            this.dgvProductos.TabIndex = 24;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
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
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.MediumPurple;
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSeleccionar.Location = new System.Drawing.Point(358, 257);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(209, 28);
            this.btnSeleccionar.TabIndex = 25;
            this.btnSeleccionar.Text = "Seleccionar imagen";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // ofdSeleccionar
            // 
            this.ofdSeleccionar.FileName = "openFileDialog1";
            // 
            // textBuscar
            // 
            this.textBuscar.Location = new System.Drawing.Point(94, 315);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(212, 20);
            this.textBuscar.TabIndex = 27;
            this.textBuscar.TextChanged += new System.EventHandler(this.textBuscar_TextChanged);
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscar.ForeColor = System.Drawing.Color.Gray;
            this.labelBuscar.Location = new System.Drawing.Point(24, 313);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(70, 20);
            this.labelBuscar.TabIndex = 28;
            this.labelBuscar.Text = "Buscar:";
            this.labelBuscar.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // buttonModificar
            // 
            this.buttonModificar.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonModificar.Location = new System.Drawing.Point(138, 550);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(92, 28);
            this.buttonModificar.TabIndex = 29;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = false;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(197, 205);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(14, 20);
            this.textId.TabIndex = 30;
            this.textId.TextChanged += new System.EventHandler(this.textId_TextChanged);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLimpiar.Location = new System.Drawing.Point(251, 550);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(92, 28);
            this.buttonLimpiar.TabIndex = 31;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = false;
            this.buttonLimpiar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(358, 49);
            this.pbImagen.Margin = new System.Windows.Forms.Padding(2);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(209, 203);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 26;
            this.pbImagen.TabStop = false;
            this.pbImagen.Click += new System.EventHandler(this.pbImagen_Click);
            // 
            // buttonVolver
            // 
            this.buttonVolver.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVolver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonVolver.Location = new System.Drawing.Point(477, 550);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(92, 28);
            this.buttonVolver.TabIndex = 32;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = false;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // ProductosAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(593, 590);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.labelBuscar);
            this.Controls.Add(this.textBuscar);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.labelImagen);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.textPrecio);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.textDescripcion);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.comboCategoria);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.textId);
            this.Name = "ProductosAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ProductosAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.ComboBox comboCategoria;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.RichTextBox textDescripcion;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.Label labelImagen;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.OpenFileDialog ofdSeleccionar;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewImageColumn Imagen;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonVolver;
    }
}