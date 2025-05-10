namespace appii
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
            iblnombre = new Label();
            iblpeso = new Label();
            iblaltura = new Label();
            ibltipo = new Label();
            textBox1 = new TextBox();
            btbuscar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // iblnombre
            // 
            iblnombre.AutoSize = true;
            iblnombre.Location = new Point(61, 56);
            iblnombre.Name = "iblnombre";
            iblnombre.Size = new Size(61, 20);
            iblnombre.TabIndex = 0;
            iblnombre.Text = "nombre";
            // 
            // iblpeso
            // 
            iblpeso.AutoSize = true;
            iblpeso.Location = new Point(97, 117);
            iblpeso.Name = "iblpeso";
            iblpeso.Size = new Size(41, 20);
            iblpeso.TabIndex = 1;
            iblpeso.Text = "peso";
            // 
            // iblaltura
            // 
            iblaltura.AutoSize = true;
            iblaltura.Location = new Point(298, 117);
            iblaltura.Name = "iblaltura";
            iblaltura.Size = new Size(47, 20);
            iblaltura.TabIndex = 2;
            iblaltura.Text = "altura";
            // 
            // ibltipo
            // 
            ibltipo.AutoSize = true;
            ibltipo.Location = new Point(545, 117);
            ibltipo.Name = "ibltipo";
            ibltipo.Size = new Size(36, 20);
            ibltipo.TabIndex = 3;
            ibltipo.Text = "tipo";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(187, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 27);
            textBox1.TabIndex = 4;
            // 
            // btbuscar
            // 
            btbuscar.Location = new Point(270, 214);
            btbuscar.Name = "btbuscar";
            btbuscar.Size = new Size(94, 29);
            btbuscar.TabIndex = 5;
            btbuscar.Text = "Buscar";
            btbuscar.UseVisualStyleBackColor = true;
            btbuscar.Click += btbuscar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(462, 178);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 260);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btbuscar);
            Controls.Add(textBox1);
            Controls.Add(ibltipo);
            Controls.Add(iblaltura);
            Controls.Add(iblpeso);
            Controls.Add(iblnombre);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label iblnombre;
        private Label iblpeso;
        private Label iblaltura;
        private Label ibltipo;
        private TextBox textBox1;
        private Button btbuscar;
        private PictureBox pictureBox1;
    }
}
