namespace MediaPrintService
{
    partial class CreatePrintTab
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
            button1 = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            comboBox2 = new ComboBox();
            button2 = new Button();
            panel1 = new Panel();
            label4 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            button3 = new Button();
            button4 = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.ForeColor = Color.Black;
            button1.Location = new Point(82, 95);
            button1.Name = "button1";
            button1.Size = new Size(97, 23);
            button1.TabIndex = 0;
            button1.Text = "Upload Image";
            button1.UseVisualStyleBackColor = true;
            button1.Click += onUploadImage;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(185, 99);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 1;
            label1.Text = "No Image Selected";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Mug", "Pin", "T-Shirt" });
            comboBox1.Location = new Point(82, 182);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += onMediaTypeSelected;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(82, 164);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 3;
            label2.Text = "Select Media Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(82, 240);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 5;
            label3.Text = "Select Size";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(82, 258);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 4;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(82, 325);
            button2.Name = "button2";
            button2.Size = new Size(121, 40);
            button2.TabIndex = 6;
            button2.Text = "Create Print";
            button2.UseVisualStyleBackColor = true;
            button2.Click += onCreatePrint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Location = new Point(758, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(80, 438);
            panel1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(294, 0);
            label4.Name = "label4";
            label4.Size = new Size(148, 30);
            label4.TabIndex = 8;
            label4.Text = "Print Creator";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(label5);
            panel2.Location = new Point(395, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(317, 322);
            panel2.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(122, 4);
            label5.Name = "label5";
            label5.Size = new Size(74, 30);
            label5.TabIndex = 10;
            label5.Text = "Prints";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(395, 386);
            button3.Name = "button3";
            button3.Size = new Size(146, 40);
            button3.TabIndex = 10;
            button3.Text = "Add Prints To Cart";
            button3.UseVisualStyleBackColor = true;
            button3.Click += onAddPrintsToCart;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(566, 386);
            button4.Name = "button4";
            button4.Size = new Size(146, 40);
            button4.TabIndex = 11;
            button4.Text = "Clear Prints";
            button4.UseVisualStyleBackColor = true;
            button4.Click += onClearPrints;
            // 
            // CreatePrintTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "CreatePrintTab";
            Size = new Size(838, 438);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox2;
        private Button button2;
        private Panel panel1;
        private Label label4;
        private Panel panel2;
        private Label label5;
        private Button button3;
        private Panel panel3;
        private Label label7;
        private Label label6;
        private Label labelTest;
        private PictureBox pictureBox1;
        private Label label8;
        private Button button4;
    }
}
