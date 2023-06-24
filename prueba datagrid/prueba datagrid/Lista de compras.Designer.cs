namespace prueba_datagrid
{
    partial class Lista_de_compras
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
            button1 = new Button();
            btnborrarelemento = new Button();
            button3 = new Button();
            button4 = new Button();
            tbllista = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            button5 = new Button();
            button6 = new Button();
            labelTotal = new Label();
            labelsuma = new Label();
            labelsumar = new Label();
            btnadd = new Button();
            label5 = new Label();
            label4 = new Label();
            txtcant = new TextBox();
            label3 = new Label();
            textBoxmedio = new TextBox();
            label2 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)tbllista).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(639, 58);
            button1.Name = "button1";
            button1.Size = new Size(114, 23);
            button1.TabIndex = 1;
            button1.Text = "Borrar lista";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnborrarelemento
            // 
            btnborrarelemento.Location = new Point(639, 96);
            btnborrarelemento.Name = "btnborrarelemento";
            btnborrarelemento.Size = new Size(114, 23);
            btnborrarelemento.TabIndex = 2;
            btnborrarelemento.Text = "Borrar elemento";
            btnborrarelemento.UseVisualStyleBackColor = true;
            btnborrarelemento.Click += btnborrarelemento_Click;
            // 
            // button3
            // 
            button3.Location = new Point(474, 393);
            button3.Name = "button3";
            button3.Size = new Size(114, 23);
            button3.TabIndex = 3;
            button3.Text = "Ir al pago";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(639, 138);
            button4.Name = "button4";
            button4.Size = new Size(114, 23);
            button4.TabIndex = 4;
            button4.Text = "Volver";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // tbllista
            // 
            tbllista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbllista.Columns.AddRange(new DataGridViewColumn[] { Codigo, Cantidad, Producto, Precio });
            tbllista.Location = new Point(68, 152);
            tbllista.Name = "tbllista";
            tbllista.RowTemplate.Height = 25;
            tbllista.Size = new Size(442, 150);
            tbllista.TabIndex = 5;
            tbllista.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "cod";
            Codigo.Name = "Codigo";
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            // 
            // button5
            // 
            button5.Location = new Point(241, 360);
            button5.Name = "button5";
            button5.Size = new Size(155, 23);
            button5.TabIndex = 6;
            button5.Text = "Finalizar lista de compra";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(639, 186);
            button6.Name = "button6";
            button6.Size = new Size(114, 23);
            button6.TabIndex = 7;
            button6.Text = "Salir";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(94, 364);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(44, 15);
            labelTotal.TabIndex = 8;
            labelTotal.Text = "Total $:";
            // 
            // labelsuma
            // 
            labelsuma.AutoSize = true;
            labelsuma.Location = new Point(147, 364);
            labelsuma.Name = "labelsuma";
            labelsuma.Size = new Size(0, 15);
            labelsuma.TabIndex = 9;
            // 
            // labelsumar
            // 
            labelsumar.AutoSize = true;
            labelsumar.Location = new Point(153, 364);
            labelsumar.Name = "labelsumar";
            labelsumar.Size = new Size(38, 15);
            labelsumar.TabIndex = 10;
            labelsumar.Text = "label1";
            // 
            // btnadd
            // 
            btnadd.Location = new Point(452, 24);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(114, 23);
            btnadd.TabIndex = 20;
            btnadd.Text = "Agregar";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(346, 31);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 18;
            label5.Text = "Precio: 550";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(183, 31);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 16;
            label4.Text = "Milanesa";
            // 
            // txtcant
            // 
            txtcant.Location = new Point(104, 28);
            txtcant.Name = "txtcant";
            txtcant.Size = new Size(47, 23);
            txtcant.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 32);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 14;
            label3.Text = "Cant:";
            label3.Click += label3_Click;
            // 
            // textBoxmedio
            // 
            textBoxmedio.Location = new Point(214, 393);
            textBoxmedio.Name = "textBoxmedio";
            textBoxmedio.Size = new Size(236, 23);
            textBoxmedio.TabIndex = 23;
            textBoxmedio.TextChanged += textBoxmedio_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 396);
            label2.Name = "label2";
            label2.Size = new Size(146, 15);
            label2.TabIndex = 22;
            label2.Text = "Ingrese su medio de pago:";
            // 
            // button2
            // 
            button2.Location = new Point(640, 242);
            button2.Name = "button2";
            button2.Size = new Size(113, 23);
            button2.TabIndex = 24;
            button2.Text = "imprimir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Lista_de_compras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(textBoxmedio);
            Controls.Add(label2);
            Controls.Add(btnadd);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtcant);
            Controls.Add(label3);
            Controls.Add(labelsumar);
            Controls.Add(labelsuma);
            Controls.Add(labelTotal);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(tbllista);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btnborrarelemento);
            Controls.Add(button1);
            Name = "Lista_de_compras";
            Text = "Lista_de_compras";
            Load += Lista_de_compras_Load;
            ((System.ComponentModel.ISupportInitialize)tbllista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button btnborrarelemento;
        private Button button3;
        private Button button4;
        private DataGridView tbllista;
        private Button button5;
        private Button button6;
        private Label labelTotal;
        private Label labelsuma;
        private Label labelsumar;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Precio;
        private Button btnadd;
        private Label label5;
        private Label label4;
        private TextBox txtcant;
        private Label label3;
        private TextBox textBoxmedio;
        private Label label2;
        private Button button2;
    }
}