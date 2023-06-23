namespace Joan_Damia_Desafio3
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(642, 339);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(660, 12);
            button1.Name = "button1";
            button1.Size = new Size(135, 23);
            button1.TabIndex = 1;
            button1.Text = "Productos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(660, 41);
            button2.Name = "button2";
            button2.Size = new Size(135, 23);
            button2.TabIndex = 2;
            button2.Text = "Productos Vendidos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(660, 70);
            button3.Name = "button3";
            button3.Size = new Size(135, 23);
            button3.TabIndex = 3;
            button3.Text = "Usuarios";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(660, 99);
            button4.Name = "button4";
            button4.Size = new Size(135, 23);
            button4.TabIndex = 4;
            button4.Text = "Ventas";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(251, 415);
            button5.Name = "button5";
            button5.Size = new Size(135, 23);
            button5.TabIndex = 5;
            button5.Text = "Iniciar Sesion";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(358, 386);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(200, 23);
            txtContraseña.TabIndex = 6;
            txtContraseña.TextChanged += txtContraseña_TextChanged;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(142, 386);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(153, 23);
            txtUsuario.TabIndex = 7;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(420, 368);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 8;
            label1.Text = "Contraseña";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(194, 368);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 9;
            label2.Text = "Usuario";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUsuario);
            Controls.Add(txtContraseña);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private Label label1;
        private Label label2;
    }
}