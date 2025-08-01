namespace Stocks
{
    partial class SalesManSignIn
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
            passwordAgainTextBox = new TextBox();
            label5 = new Label();
            button1 = new Button();
            label4 = new Label();
            registerButton = new Button();
            passwordTextBox = new TextBox();
            nameTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            telephoneNumberTextBox = new MaskedTextBox();
            SuspendLayout();
            // 
            // passwordAgainTextBox
            // 
            passwordAgainTextBox.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            passwordAgainTextBox.Location = new Point(718, 388);
            passwordAgainTextBox.Name = "passwordAgainTextBox";
            passwordAgainTextBox.Size = new Size(262, 29);
            passwordAgainTextBox.TabIndex = 44;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Palatino Linotype", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(718, 348);
            label5.Name = "label5";
            label5.Size = new Size(165, 28);
            label5.TabIndex = 43;
            label5.Text = "Password again:";
            // 
            // button1
            // 
            button1.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.Location = new Point(718, 532);
            button1.Name = "button1";
            button1.Size = new Size(246, 45);
            button1.TabIndex = 41;
            button1.Text = "Return To Menu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(262, 82);
            label4.Name = "label4";
            label4.Size = new Size(564, 47);
            label4.TabIndex = 39;
            label4.Text = "Welcome to Stock Tracking System!";
            // 
            // registerButton
            // 
            registerButton.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            registerButton.Location = new Point(153, 532);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(262, 45);
            registerButton.TabIndex = 40;
            registerButton.Text = "Sign In";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            passwordTextBox.Location = new Point(718, 243);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(246, 29);
            passwordTextBox.TabIndex = 38;
            // 
            // nameTextBox
            // 
            nameTextBox.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            nameTextBox.Location = new Point(153, 243);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(262, 29);
            nameTextBox.TabIndex = 37;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(718, 203);
            label2.Name = "label2";
            label2.Size = new Size(108, 28);
            label2.TabIndex = 36;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(153, 203);
            label1.Name = "label1";
            label1.Size = new Size(215, 28);
            label1.TabIndex = 35;
            label1.Text = "Name And Surname:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(153, 332);
            label3.Name = "label3";
            label3.Size = new Size(204, 28);
            label3.TabIndex = 42;
            label3.Text = "Telephone Number:";
            // 
            // telephoneNumberTextBox
            // 
            telephoneNumberTextBox.Font = new Font("Palatino Linotype", 12F);
            telephoneNumberTextBox.Location = new Point(153, 388);
            telephoneNumberTextBox.Mask = "(999) 000-0000";
            telephoneNumberTextBox.Name = "telephoneNumberTextBox";
            telephoneNumberTextBox.Size = new Size(262, 29);
            telephoneNumberTextBox.TabIndex = 45;
            // 
            // SalesManSignIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 825);
            Controls.Add(telephoneNumberTextBox);
            Controls.Add(passwordAgainTextBox);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(registerButton);
            Controls.Add(passwordTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SalesManSignIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox passwordAgainTextBox;
        private Label label5;
        private Button button1;
        private Label label4;
        private Button registerButton;
        private TextBox passwordTextBox;
        private TextBox nameTextBox;
        private Label label2;
        private Label label1;
        private Label label3;
        private MaskedTextBox telephoneNumberTextBox;
    }
}