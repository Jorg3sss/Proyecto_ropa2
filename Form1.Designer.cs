namespace Proyecto_ropa
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
            panel1 = new Panel();
            button2 = new Button();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            contra = new TextBox();
            usuario = new TextBox();
            label5 = new Label();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(contra);
            panel1.Controls.Add(usuario);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1071, 617);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(575, 357);
            button2.Name = "button2";
            button2.Size = new Size(127, 38);
            button2.TabIndex = 12;
            button2.Text = "Confirmar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(347, 295);
            label4.Name = "label4";
            label4.Size = new Size(141, 27);
            label4.TabIndex = 11;
            label4.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(347, 220);
            label3.Name = "label3";
            label3.Size = new Size(100, 27);
            label3.TabIndex = 10;
            label3.Text = "Usuario";
            label3.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_ropa1;
            pictureBox1.Location = new Point(91, 85);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 148);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(564, 540);
            button1.Name = "button1";
            button1.Size = new Size(127, 38);
            button1.TabIndex = 8;
            button1.Text = "Crear cuenta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // contra
            // 
            contra.Location = new Point(541, 295);
            contra.Name = "contra";
            contra.Size = new Size(218, 27);
            contra.TabIndex = 7;
            // 
            // usuario
            // 
            usuario.Location = new Point(541, 223);
            usuario.Name = "usuario";
            usuario.Size = new Size(218, 27);
            usuario.TabIndex = 6;
            usuario.TextChanged += usuario_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(541, 494);
            label5.Name = "label5";
            label5.Size = new Size(162, 20);
            label5.TabIndex = 5;
            label5.Text = "¿No tienes una cuenta?\r\n";
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.RosyBrown;
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(563, 425);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(149, 20);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Olvide mi contraseña";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(459, 123);
            label2.Name = "label2";
            label2.Size = new Size(294, 21);
            label2.TabIndex = 1;
            label2.Text = "Ingresa con tu cuenta o crea una";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(496, 53);
            label1.Name = "label1";
            label1.Size = new Size(195, 37);
            label1.TabIndex = 0;
            label1.Text = "La Boutique";
            // 
            // panel2
            // 
            panel2.BackColor = Color.RosyBrown;
            panel2.Location = new Point(3, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1065, 33);
            panel2.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 615);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private TextBox contra;
        private TextBox usuario;
        private Label label5;
        private LinkLabel linkLabel1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Panel panel2;
        private Button button2;
    }
}
