namespace Stocks
{
    partial class Menu
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            nameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            SalesmanRadioButton1 = new RadioButton();
            ConcultantRadioButton2 = new RadioButton();
            registerButton = new Button();
            label5 = new Label();
            label6 = new Label();
            CustomerLinkLAbel = new LinkLabel();
            SalesmanLinkLabel = new LinkLabel();
            ConcultantLinkLabel = new LinkLabel();
            label8 = new Label();
            label4 = new Label();
            label7 = new Label();
            idTextBox = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(166, 193);
            label1.Name = "label1";
            label1.Size = new Size(76, 28);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(731, 193);
            label2.Name = "label2";
            label2.Size = new Size(108, 28);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(166, 325);
            label3.Name = "label3";
            label3.Size = new Size(41, 28);
            label3.TabIndex = 2;
            label3.Text = "ID:";
            // 
            // nameTextBox
            // 
            nameTextBox.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            nameTextBox.Location = new Point(166, 233);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(262, 29);
            nameTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            passwordTextBox.Location = new Point(731, 233);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(246, 29);
            passwordTextBox.TabIndex = 5;
            // 
            // SalesmanRadioButton1
            // 
            SalesmanRadioButton1.AutoSize = true;
            SalesmanRadioButton1.Font = new Font("Palatino Linotype", 12F);
            SalesmanRadioButton1.Location = new Point(731, 334);
            SalesmanRadioButton1.Name = "SalesmanRadioButton1";
            SalesmanRadioButton1.Size = new Size(93, 26);
            SalesmanRadioButton1.TabIndex = 6;
            SalesmanRadioButton1.TabStop = true;
            SalesmanRadioButton1.Text = "Salesman";
            SalesmanRadioButton1.UseVisualStyleBackColor = true;
            // 
            // ConcultantRadioButton2
            // 
            ConcultantRadioButton2.AutoSize = true;
            ConcultantRadioButton2.Font = new Font("Palatino Linotype", 12F);
            ConcultantRadioButton2.Location = new Point(731, 366);
            ConcultantRadioButton2.Name = "ConcultantRadioButton2";
            ConcultantRadioButton2.Size = new Size(103, 26);
            ConcultantRadioButton2.TabIndex = 7;
            ConcultantRadioButton2.TabStop = true;
            ConcultantRadioButton2.Text = "Concultant";
            ConcultantRadioButton2.UseVisualStyleBackColor = true;
            // 
            // registerButton
            // 
            registerButton.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            registerButton.Location = new Point(433, 466);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(261, 45);
            registerButton.TabIndex = 9;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Palatino Linotype", 15.75F);
            label5.Location = new Point(743, 294);
            label5.Name = "label5";
            label5.Size = new Size(58, 28);
            label5.TabIndex = 10;
            label5.Text = "Task:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Palatino Linotype", 15.75F);
            label6.Location = new Point(165, 572);
            label6.Name = "label6";
            label6.Size = new Size(173, 28);
            label6.TabIndex = 11;
            label6.Text = "Contact With Us:";
            // 
            // CustomerLinkLAbel
            // 
            CustomerLinkLAbel.AutoSize = true;
            CustomerLinkLAbel.Font = new Font("Palatino Linotype", 15.75F);
            CustomerLinkLAbel.Location = new Point(166, 678);
            CustomerLinkLAbel.Name = "CustomerLinkLAbel";
            CustomerLinkLAbel.Size = new Size(148, 28);
            CustomerLinkLAbel.TabIndex = 13;
            CustomerLinkLAbel.TabStop = true;
            CustomerLinkLAbel.Text = "Customer Site";
            CustomerLinkLAbel.LinkClicked += CustomerLinkLabel_LinkClicked;
            // 
            // SalesmanLinkLabel
            // 
            SalesmanLinkLabel.AutoSize = true;
            SalesmanLinkLabel.Font = new Font("Palatino Linotype", 15.75F);
            SalesmanLinkLabel.Location = new Point(743, 625);
            SalesmanLinkLabel.Name = "SalesmanLinkLabel";
            SalesmanLinkLabel.Size = new Size(105, 28);
            SalesmanLinkLabel.TabIndex = 14;
            SalesmanLinkLabel.TabStop = true;
            SalesmanLinkLabel.Text = "SalesMan";
            SalesmanLinkLabel.LinkClicked += SalesmanLinkLabel_LinkClicked;
            // 
            // ConcultantLinkLabel
            // 
            ConcultantLinkLabel.AutoSize = true;
            ConcultantLinkLabel.Font = new Font("Palatino Linotype", 15.75F);
            ConcultantLinkLabel.Location = new Point(743, 678);
            ConcultantLinkLabel.Name = "ConcultantLinkLabel";
            ConcultantLinkLabel.Size = new Size(119, 28);
            ConcultantLinkLabel.TabIndex = 15;
            ConcultantLinkLabel.TabStop = true;
            ConcultantLinkLabel.Text = "Concultant";
            ConcultantLinkLabel.LinkClicked += ConcultantLinkLabel_LinkClicked;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Palatino Linotype", 15.75F);
            label8.Location = new Point(743, 572);
            label8.Name = "label8";
            label8.Size = new Size(189, 28);
            label8.TabIndex = 16;
            label8.Text = "If you want to be a";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(260, 73);
            label4.Name = "label4";
            label4.Size = new Size(564, 47);
            label4.TabIndex = 8;
            label4.Text = "Welcome to Stock Tracking System!";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Palatino Linotype", 15.75F);
            label7.Location = new Point(165, 625);
            label7.Name = "label7";
            label7.Size = new Size(285, 28);
            label7.TabIndex = 12;
            label7.Text = "Our Telephone Number: 911";
            // 
            // idTextBox
            // 
            idTextBox.Font = new Font("Palatino Linotype", 12F);
            idTextBox.Location = new Point(166, 365);
            idTextBox.Mask = "00";
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(262, 29);
            idTextBox.TabIndex = 17;
            idTextBox.ValidatingType = typeof(int);
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 825);
            Controls.Add(idTextBox);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(ConcultantLinkLabel);
            Controls.Add(SalesmanLinkLabel);
            Controls.Add(CustomerLinkLAbel);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(registerButton);
            Controls.Add(ConcultantRadioButton2);
            Controls.Add(SalesmanRadioButton1);
            Controls.Add(passwordTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox nameTextBox;
        private TextBox passwordTextBox;
        private RadioButton SalesmanRadioButton1;
        private RadioButton ConcultantRadioButton2;
        private Button registerButton;
        private Label label5;
        private Label label6;
        private LinkLabel CustomerLinkLAbel;
        private LinkLabel SalesmanLinkLabel;
        private LinkLabel ConcultantLinkLabel;
        private Label label8;
        private Label label4;
        private Label label7;
        private MaskedTextBox idTextBox;
    }
}
