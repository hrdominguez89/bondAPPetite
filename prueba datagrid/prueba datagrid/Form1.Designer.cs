namespace prueba_datagrid
{
    partial class Form1
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            txtcantidad = new TextBox();
            labelprecio = new Label();
            lblSandwich = new Label();
            btniralista = new Button();
            label3 = new Label();
            txtcant = new TextBox();
            label4 = new Label();
            txtMila = new TextBox();
            label5 = new Label();
            txtprecio = new TextBox();
            btnadd = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(464, 162);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(384, 166);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Precio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(212, 166);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 2;
            label2.Text = "Cant:";
            // 
            // txtcantidad
            // 
            txtcantidad.Location = new Point(253, 162);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(48, 23);
            txtcantidad.TabIndex = 3;
            // 
            // labelprecio
            // 
            labelprecio.AutoSize = true;
            labelprecio.Location = new Point(433, 166);
            labelprecio.Name = "labelprecio";
            labelprecio.Size = new Size(25, 15);
            labelprecio.TabIndex = 4;
            labelprecio.Text = "550";
            // 
            // lblSandwich
            // 
            lblSandwich.AutoSize = true;
            lblSandwich.Location = new Point(323, 165);
            lblSandwich.Name = "lblSandwich";
            lblSandwich.Size = new Size(58, 15);
            lblSandwich.TabIndex = 5;
            lblSandwich.Text = "Sandwich";
            // 
            // btniralista
            // 
            btniralista.Location = new Point(600, 162);
            btniralista.Name = "btniralista";
            btniralista.Size = new Size(169, 23);
            btniralista.TabIndex = 6;
            btniralista.Text = "Ir a mi lista de compras";
            btniralista.UseVisualStyleBackColor = true;
            btniralista.Click += btniralista_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(212, 256);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 7;
            label3.Text = "Cant:";
            // 
            // txtcant
            // 
            txtcant.Location = new Point(254, 256);
            txtcant.Name = "txtcant";
            txtcant.Size = new Size(47, 23);
            txtcant.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(333, 259);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 9;
            label4.Text = "Mila";
            // 
            // txtMila
            // 
            txtMila.Location = new Point(363, 256);
            txtMila.Name = "txtMila";
            txtMila.Size = new Size(95, 23);
            txtMila.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(496, 259);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 11;
            label5.Text = "Precio:";
            // 
            // txtprecio
            // 
            txtprecio.Location = new Point(545, 256);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(100, 23);
            txtprecio.TabIndex = 12;
            // 
            // btnadd
            // 
            btnadd.Location = new Point(688, 255);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(75, 23);
            btnadd.TabIndex = 13;
            btnadd.Text = "Agregar";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnadd);
            Controls.Add(txtprecio);
            Controls.Add(label5);
            Controls.Add(txtMila);
            Controls.Add(label4);
            Controls.Add(txtcant);
            Controls.Add(label3);
            Controls.Add(btniralista);
            Controls.Add(lblSandwich);
            Controls.Add(labelprecio);
            Controls.Add(txtcantidad);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox txtcantidad;
        private Label labelprecio;
        private Label lblSandwich;
        private Button btniralista;
        private Label label3;
        private TextBox txtcant;
        private Label label4;
        private TextBox txtMila;
        private Label label5;
        private TextBox txtprecio;
        private Button btnadd;
    }
}