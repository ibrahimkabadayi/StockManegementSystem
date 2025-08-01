namespace Stocks
{
    partial class Marketplace
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
            StockListBox = new ListBox();
            productsListBox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            BuyButton = new Button();
            numberTextBox = new MaskedTextBox();
            label3 = new Label();
            returnToMenuButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // StockListBox
            // 
            StockListBox.Dock = DockStyle.Right;
            StockListBox.Font = new Font("Palatino Linotype", 12F);
            StockListBox.FormattingEnabled = true;
            StockListBox.Location = new Point(520, 0);
            StockListBox.Name = "StockListBox";
            StockListBox.Size = new Size(516, 506);
            StockListBox.TabIndex = 0;
            // 
            // productsListBox
            // 
            productsListBox.Dock = DockStyle.Left;
            productsListBox.Font = new Font("Palatino Linotype", 12F);
            productsListBox.FormattingEnabled = true;
            productsListBox.Location = new Point(0, 0);
            productsListBox.Name = "productsListBox";
            productsListBox.Size = new Size(515, 506);
            productsListBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 12F);
            label1.Location = new Point(45, 162);
            label1.Name = "label1";
            label1.Size = new Size(74, 22);
            label1.TabIndex = 2;
            label1.Text = "Products:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 12F);
            label2.Location = new Point(565, 162);
            label2.Name = "label2";
            label2.Size = new Size(52, 22);
            label2.TabIndex = 3;
            label2.Text = "Stock:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(259, 62);
            label4.Name = "label4";
            label4.Size = new Size(564, 47);
            label4.TabIndex = 9;
            label4.Text = "Welcome to Stock Tracking System!";
            // 
            // panel1
            // 
            panel1.Controls.Add(productsListBox);
            panel1.Controls.Add(StockListBox);
            panel1.Location = new Point(45, 187);
            panel1.Name = "panel1";
            panel1.Size = new Size(1036, 506);
            panel1.TabIndex = 10;
            // 
            // BuyButton
            // 
            BuyButton.Font = new Font("Palatino Linotype", 12F);
            BuyButton.Location = new Point(565, 707);
            BuyButton.Name = "BuyButton";
            BuyButton.Size = new Size(258, 63);
            BuyButton.TabIndex = 11;
            BuyButton.Text = "Buy";
            BuyButton.UseVisualStyleBackColor = true;
            BuyButton.Click += BuyButton_Click;
            // 
            // numberTextBox
            // 
            numberTextBox.Font = new Font("Palatino Linotype", 12F);
            numberTextBox.Location = new Point(45, 738);
            numberTextBox.Mask = "00000";
            numberTextBox.Name = "numberTextBox";
            numberTextBox.Size = new Size(482, 29);
            numberTextBox.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 12F);
            label3.Location = new Point(45, 707);
            label3.Name = "label3";
            label3.Size = new Size(134, 22);
            label3.TabIndex = 13;
            label3.Text = "Enter the number:";
            // 
            // returnToMenuButton
            // 
            returnToMenuButton.Font = new Font("Palatino Linotype", 12F);
            returnToMenuButton.Location = new Point(838, 707);
            returnToMenuButton.Name = "returnToMenuButton";
            returnToMenuButton.Size = new Size(243, 60);
            returnToMenuButton.TabIndex = 14;
            returnToMenuButton.Text = "Return to Menu";
            returnToMenuButton.UseVisualStyleBackColor = true;
            returnToMenuButton.Click += returnToMenuButton_Click;
            // 
            // Marketplace
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 825);
            Controls.Add(returnToMenuButton);
            Controls.Add(label3);
            Controls.Add(numberTextBox);
            Controls.Add(BuyButton);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Marketplace";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            Load += Marketplace_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox StockListBox;
        private ListBox productsListBox;
        private Label label1;
        private Label label2;
        private Label label4;
        private Panel panel1;
        private Button BuyButton;
        private MaskedTextBox numberTextBox;
        private Label label3;
        private Button returnToMenuButton;
    }
}