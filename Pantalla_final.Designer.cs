namespace Proyecto_ropa
{
    partial class Pantalla_final
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
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel3 = new Panel();
            label8 = new Label();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            label9 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1060, 947);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.exit;
            pictureBox2.Location = new Point(956, 823);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(71, 78);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.home;
            pictureBox1.Location = new Point(748, 823);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.IndianRed;
            panel2.Location = new Point(-12, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1069, 39);
            panel2.TabIndex = 10;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(32, 100);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(649, 623);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLight;
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(748, 167);
            panel3.Name = "panel3";
            panel3.Size = new Size(279, 464);
            panel3.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift SemiBold", 10.8F, FontStyle.Bold);
            label8.Location = new Point(22, 398);
            label8.Name = "label8";
            label8.Size = new Size(168, 22);
            label8.TabIndex = 8;
            label8.Text = "Numero de compra";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift SemiBold", 10.8F, FontStyle.Bold);
            label6.Location = new Point(164, 186);
            label6.Name = "label6";
            label6.Size = new Size(59, 22);
            label6.TabIndex = 6;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift SemiBold", 10.8F, FontStyle.Bold);
            label7.Location = new Point(22, 243);
            label7.Name = "label7";
            label7.Size = new Size(59, 22);
            label7.TabIndex = 7;
            label7.Text = "Fecha";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift SemiBold", 10.8F, FontStyle.Bold);
            label5.Location = new Point(163, 130);
            label5.Name = "label5";
            label5.Size = new Size(60, 22);
            label5.TabIndex = 5;
            label5.Text = "label5";
            label5.Click += label5_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Bahnschrift SemiBold", 10.8F, FontStyle.Bold);
            label9.Location = new Point(22, 320);
            label9.Name = "label9";
            label9.Size = new Size(50, 22);
            label9.TabIndex = 9;
            label9.Text = "Hora";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiBold", 10.8F, FontStyle.Bold);
            label4.Location = new Point(163, 64);
            label4.Name = "label4";
            label4.Size = new Size(60, 22);
            label4.TabIndex = 4;
            label4.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiBold", 10.8F, FontStyle.Bold);
            label3.Location = new Point(22, 186);
            label3.Name = "label3";
            label3.Size = new Size(49, 22);
            label3.TabIndex = 3;
            label3.Text = "Total";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold", 10.8F, FontStyle.Bold);
            label1.Location = new Point(22, 64);
            label1.Name = "label1";
            label1.Size = new Size(78, 22);
            label1.TabIndex = 1;
            label1.Text = "Subtotal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold", 10.8F, FontStyle.Bold);
            label2.Location = new Point(22, 130);
            label2.Name = "label2";
            label2.Size = new Size(37, 22);
            label2.TabIndex = 2;
            label2.Text = "IVA";
            // 
            // Pantalla_final
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 942);
            Controls.Add(panel1);
            Name = "Pantalla_final";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pantalla_final";
            Load += Pantalla_final_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label9;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}