namespace MediaPrintService
{
    partial class CartTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            panel2 = new Panel();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Location = new Point(758, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(80, 438);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(301, 0);
            label1.Name = "label1";
            label1.Size = new Size(163, 30);
            label1.TabIndex = 1;
            label1.Text = "Shopping Cart";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLight;
            panel4.Controls.Add(label14);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(168, 322);
            panel4.Name = "panel4";
            panel4.Size = new Size(414, 100);
            panel4.TabIndex = 5;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.Black;
            label14.Location = new Point(78, 67);
            label14.Name = "label14";
            label14.Size = new Size(34, 15);
            label14.TabIndex = 10;
            label14.Text = "$4.22";
            label14.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.Black;
            label13.Location = new Point(78, 37);
            label13.Name = "label13";
            label13.Size = new Size(34, 15);
            label13.TabIndex = 9;
            label13.Text = "$0.12";
            label13.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Black;
            label12.Location = new Point(78, 13);
            label12.Name = "label12";
            label12.Size = new Size(34, 15);
            label12.TabIndex = 8;
            label12.Text = "$1.99";
            label12.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            label11.BorderStyle = BorderStyle.Fixed3D;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label11.Location = new Point(15, 58);
            label11.Name = "label11";
            label11.Size = new Size(102, 2);
            label11.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(12, 67);
            label10.Name = "label10";
            label10.Size = new Size(37, 15);
            label10.TabIndex = 6;
            label10.Text = "Total:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(12, 37);
            label9.Name = "label9";
            label9.Size = new Size(44, 15);
            label9.TabIndex = 5;
            label9.Text = "Taxes: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(12, 13);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 4;
            label8.Text = "Subtotal: ";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Location = new Point(168, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(414, 276);
            panel2.TabIndex = 6;
            // 
            // CartTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "CartTab";
            Size = new Size(838, 438);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel4;
        private Label label8;
        private Label label9;
        private Label label11;
        private Label label10;
        private Label label13;
        private Label label12;
        private Label label14;
        private Panel panel2;
    }
}
