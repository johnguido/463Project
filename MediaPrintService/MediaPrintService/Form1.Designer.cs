namespace MediaPrintService
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
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            createPrintTab = new CreatePrintTab();
            accountTab = new AccountTab();
            cartTab = new CartTab();
            checkoutTab = new CheckoutTab();
            checkoutButton = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 535);
            panel1.TabIndex = 0;
            // 
            // button5
            // 
            button5.BackColor = Color.Aqua;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button5.ForeColor = Color.Black;
            button5.Location = new Point(0, 97);
            button5.Name = "button5";
            button5.Size = new Size(200, 40);
            button5.TabIndex = 1;
            button5.Text = "Summary";
            button5.UseVisualStyleBackColor = false;
            button5.Click += onSummaryTabClick;
            // 
            // button4
            // 
            button4.BackColor = Color.Aqua;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(0, 281);
            button4.Name = "button4";
            button4.Size = new Size(200, 40);
            button4.TabIndex = 5;
            button4.Text = "Account";
            button4.UseVisualStyleBackColor = false;
            button4.Click += onAccountClick;
            // 
            // button3
            // 
            button3.BackColor = Color.Aqua;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(0, 235);
            button3.Name = "button3";
            button3.Size = new Size(200, 40);
            button3.TabIndex = 3;
            button3.Text = "Orders";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Aqua;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(0, 143);
            button2.Name = "button2";
            button2.Size = new Size(200, 40);
            button2.TabIndex = 2;
            button2.Text = "Create Print";
            button2.UseVisualStyleBackColor = false;
            button2.Click += onCreatePrintClick;
            // 
            // button1
            // 
            button1.BackColor = Color.Aqua;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(0, 189);
            button1.Name = "button1";
            button1.Size = new Size(200, 40);
            button1.TabIndex = 4;
            button1.Text = "Cart";
            button1.UseVisualStyleBackColor = false;
            button1.Click += onCartClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(38, 32);
            label1.Name = "label1";
            label1.Size = new Size(117, 28);
            label1.TabIndex = 0;
            label1.Text = "MediaPrint";
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(200, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(838, 98);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(723, 9);
            label2.Name = "label2";
            label2.Size = new Size(105, 19);
            label2.TabIndex = 0;
            label2.Text = "garret.schuster";
            // 
            // createPrintTab
            // 
            createPrintTab.BackColor = SystemColors.ControlDark;
            createPrintTab.Location = new Point(200, 97);
            createPrintTab.Name = "createPrintTab";
            createPrintTab.Size = new Size(838, 438);
            createPrintTab.TabIndex = 2;
            // 
            // accountTab
            // 
            accountTab.BackColor = SystemColors.ControlDark;
            accountTab.Location = new Point(200, 97);
            accountTab.Name = "accountTab";
            accountTab.Size = new Size(838, 438);
            accountTab.TabIndex = 3;
            // 
            // cartTab
            // 
            cartTab.BackColor = SystemColors.ControlDark;
            cartTab.Location = new Point(200, 97);
            cartTab.Name = "cartTab";
            cartTab.Size = new Size(838, 438);
            cartTab.TabIndex = 4;
            // 
            // checkoutTab
            // 
            checkoutTab.BackColor = SystemColors.ControlDark;
            checkoutTab.Location = new Point(200, 97);
            checkoutTab.Name = "checkoutTab";
            checkoutTab.Size = new Size(838, 438);
            checkoutTab.TabIndex = 5;
            // 
            // checkoutButton
            // 
            checkoutButton.FlatStyle = FlatStyle.Flat;
            checkoutButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            checkoutButton.ForeColor = Color.Black;
            checkoutButton.Location = new Point(565, 443);
            checkoutButton.Name = "checkoutButton";
            checkoutButton.Size = new Size(147, 38);
            checkoutButton.TabIndex = 6;
            checkoutButton.Text = "Checkout";
            checkoutButton.UseVisualStyleBackColor = true;
            checkoutButton.Click += onCheckoutButtonClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1038, 535);
            Controls.Add(checkoutButton);
            Controls.Add(checkoutTab);
            Controls.Add(cartTab);
            Controls.Add(accountTab);
            Controls.Add(createPrintTab);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
        private Label label2;
        private Button button5;
        private CreatePrintTab createPrintTab;
        private AccountTab accountTab;
        private CartTab cartTab;
        private CheckoutTab checkoutTab;
        private Button checkoutButton;
    }
}
