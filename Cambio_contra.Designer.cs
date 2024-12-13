namespace Proyecto_ropa
{
    partial class Cambio_contra
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
            panel1 = new Panel();
            button1 = new Button();
            contra2 = new TextBox();
            contra1 = new TextBox();
            usuario = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(contra2);
            panel1.Controls.Add(contra1);
            panel1.Controls.Add(usuario);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1072, 623);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.Location = new Point(579, 519);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // contra2
            // 
            contra2.Location = new Point(579, 403);
            contra2.Name = "contra2";
            contra2.Size = new Size(241, 27);
            contra2.TabIndex = 8;
            // 
            // contra1
            // 
            contra1.Location = new Point(579, 334);
            contra1.Name = "contra1";
            contra1.Size = new Size(241, 27);
            contra1.TabIndex = 7;
            // 
            // usuario
            // 
            usuario.Location = new Point(579, 251);
            usuario.Name = "usuario";
            usuario.Size = new Size(241, 27);
            usuario.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(313, 409);
            label5.Name = "label5";
            label5.Size = new Size(197, 21);
            label5.TabIndex = 5;
            label5.Text = "Restaurar contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(313, 336);
            label4.Name = "label4";
            label4.Size = new Size(168, 21);
            label4.TabIndex = 4;
            label4.Text = "Nueva contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(313, 257);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 3;
            label3.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            label2.Location = new Point(465, 150);
            label2.Name = "label2";
            label2.Size = new Size(258, 21);
            label2.TabIndex = 2;
            label2.Text = "Ingresa los datos solicitados";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 19.8000011F);
            label1.Location = new Point(426, 92);
            label1.Name = "label1";
            label1.Size = new Size(345, 37);
            label1.TabIndex = 1;
            label1.Text = "Restaurar contraseña";
            // 
            // panel2
            // 
            panel2.BackColor = Color.RosyBrown;
            panel2.Location = new Point(3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1066, 49);
            panel2.TabIndex = 0;
            // 
            // Cambio_contra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 615);
            Controls.Add(panel1);
            Name = "Cambio_contra";
            Text = "Cambio_contra";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Button button1;
        private TextBox contra2;
        private TextBox contra1;
        private TextBox usuario;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}