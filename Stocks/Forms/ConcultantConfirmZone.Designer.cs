namespace Stocks
{
    partial class ConcultantConfirmZone
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
            label3 = new Label();
            dateTextBox = new MaskedTextBox();
            button1 = new Button();
            label1 = new Label();
            label4 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            customerListBox = new ListBox();
            ordersListBox = new ListBox();
            returnToMenuButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 12F);
            label3.Location = new Point(49, 703);
            label3.Name = "label3";
            label3.Size = new Size(46, 22);
            label3.TabIndex = 20;
            label3.Text = "Date:";
            // 
            // dateTextBox
            // 
            dateTextBox.Font = new Font("Palatino Linotype", 12F);
            dateTextBox.Location = new Point(49, 734);
            dateTextBox.Mask = "00/00/0000 90:00";
            dateTextBox.Name = "dateTextBox";
            dateTextBox.Size = new Size(482, 29);
            dateTextBox.TabIndex = 19;
            dateTextBox.ValidatingType = typeof(DateTime);
            // 
            // button1
            // 
            button1.Font = new Font("Palatino Linotype", 12F);
            button1.Location = new Point(552, 703);
            button1.Name = "button1";
            button1.Size = new Size(263, 63);
            button1.TabIndex = 18;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += confirmButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 12F);
            label1.Location = new Point(49, 158);
            label1.Name = "label1";
            label1.Size = new Size(86, 22);
            label1.TabIndex = 14;
            label1.Text = "Customers:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(263, 58);
            label4.Name = "label4";
            label4.Size = new Size(564, 47);
            label4.TabIndex = 16;
            label4.Text = "Welcome to Stock Tracking System!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 12F);
            label2.Location = new Point(569, 158);
            label2.Name = "label2";
            label2.Size = new Size(61, 22);
            label2.TabIndex = 15;
            label2.Text = "Orders:";
            // 
            // panel1
            // 
            panel1.Controls.Add(customerListBox);
            panel1.Controls.Add(ordersListBox);
            panel1.Location = new Point(49, 183);
            panel1.Name = "panel1";
            panel1.Size = new Size(1036, 506);
            panel1.TabIndex = 17;
            // 
            // customerListBox
            // 
            customerListBox.Dock = DockStyle.Left;
            customerListBox.Font = new Font("Palatino Linotype", 12F);
            customerListBox.FormattingEnabled = true;
            customerListBox.Location = new Point(0, 0);
            customerListBox.Name = "customerListBox";
            customerListBox.Size = new Size(515, 506);
            customerListBox.TabIndex = 1;
            customerListBox.SelectedIndexChanged += customerListBox_SelectedIndexChanged;
            // 
            // ordersListBox
            // 
            ordersListBox.Dock = DockStyle.Right;
            ordersListBox.Font = new Font("Palatino Linotype", 12F);
            ordersListBox.FormattingEnabled = true;
            ordersListBox.Location = new Point(520, 0);
            ordersListBox.Name = "ordersListBox";
            ordersListBox.Size = new Size(516, 506);
            ordersListBox.TabIndex = 0;
            // 
            // returnToMenuButton
            // 
            returnToMenuButton.Font = new Font("Palatino Linotype", 12F);
            returnToMenuButton.Location = new Point(822, 703);
            returnToMenuButton.Name = "returnToMenuButton";
            returnToMenuButton.Size = new Size(263, 60);
            returnToMenuButton.TabIndex = 21;
            returnToMenuButton.Text = "Return to Menu";
            returnToMenuButton.UseVisualStyleBackColor = true;
            returnToMenuButton.Click += returnToMenuButton_Click;
            // 
            // ConcultantConfirmZone
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 825);
            Controls.Add(returnToMenuButton);
            Controls.Add(label3);
            Controls.Add(dateTextBox);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "ConcultantConfirmZone";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConcultantConfirmZone";
            Load += ConcultantConfirmZone_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private MaskedTextBox dateTextBox;
        private Button button1;
        private Label label1;
        private Label label4;
        private Label label2;
        private Panel panel1;
        private ListBox customerListBox;
        private ListBox ordersListBox;
        private Button returnToMenuButton;
    }
}