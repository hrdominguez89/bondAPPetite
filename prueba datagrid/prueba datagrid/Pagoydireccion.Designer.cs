namespace prueba_datagrid
{
    partial class Pagoydireccion
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
            label2 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 55);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 3;
            label2.Text = "Ingrese su dirección:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(214, 47);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(365, 23);
            textBox2.TabIndex = 4;
            // 
            // Pagoydireccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 606);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Name = "Pagoydireccion";
            Text = "Pagoydireccion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox textBox2;
    }
}