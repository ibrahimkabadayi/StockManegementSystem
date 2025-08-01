
namespace Stocks
{
    partial class CustomerBuyingZone
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
            stockListBox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            nameTextBox = new TextBox();
            adressTextBox = new TextBox();
            countryTextBox = new TextBox();
            panel1 = new Panel();
            returnToMenuButton = new Button();
            telephoneNumberTextBox = new MaskedTextBox();
            numberTextBox = new MaskedTextBox();
            label6 = new Label();
            label5 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // stockListBox
            // 
            stockListBox.Dock = DockStyle.Left;
            stockListBox.Font = new Font("Palatino Linotype", 12F);
            stockListBox.FormattingEnabled = true;
            stockListBox.Location = new Point(0, 0);
            stockListBox.Name = "stockListBox";
            stockListBox.Size = new Size(640, 560);
            stockListBox.TabIndex = 0;
            stockListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 12F);
            label1.Location = new Point(646, 13);
            label1.Name = "label1";
            label1.Size = new Size(126, 22);
            label1.TabIndex = 1;
            label1.Text = "Customer Name:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 12F);
            label2.Location = new Point(646, 87);
            label2.Name = "label2";
            label2.Size = new Size(128, 22);
            label2.TabIndex = 2;
            label2.Text = "Customer Adress:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 12F);
            label3.Location = new Point(646, 178);
            label3.Name = "label3";
            label3.Size = new Size(137, 22);
            label3.TabIndex = 3;
            label3.Text = "Customer Country";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 12F);
            label4.Location = new Point(646, 275);
            label4.Name = "label4";
            label4.Size = new Size(214, 22);
            label4.TabIndex = 4;
            label4.Text = "Customer Telephone Number:";
            // 
            // button1
            // 
            button1.Font = new Font("Palatino Linotype", 12F);
            button1.Location = new Point(646, 446);
            button1.Name = "button1";
            button1.Size = new Size(324, 46);
            button1.TabIndex = 5;
            button1.Text = "Buy";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Font = new Font("Palatino Linotype", 12F);
            nameTextBox.Location = new Point(646, 38);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(324, 29);
            nameTextBox.TabIndex = 6;
            nameTextBox.TextChanged += textBox1_TextChanged;
            // 
            // adressTextBox
            // 
            adressTextBox.Font = new Font("Palatino Linotype", 12F);
            adressTextBox.Location = new Point(646, 112);
            adressTextBox.Name = "adressTextBox";
            adressTextBox.Size = new Size(324, 29);
            adressTextBox.TabIndex = 7;
            adressTextBox.TextChanged += textBox2_TextChanged;
            // 
            // countryTextBox
            // 
            countryTextBox.Font = new Font("Palatino Linotype", 12F);
            countryTextBox.Location = new Point(646, 203);
            countryTextBox.Name = "countryTextBox";
            countryTextBox.Size = new Size(324, 29);
            countryTextBox.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Controls.Add(returnToMenuButton);
            panel1.Controls.Add(telephoneNumberTextBox);
            panel1.Controls.Add(numberTextBox);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(stockListBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(nameTextBox);
            panel1.Controls.Add(adressTextBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(countryTextBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(72, 181);
            panel1.Name = "panel1";
            panel1.Size = new Size(989, 560);
            panel1.TabIndex = 10;
            // 
            // returnToMenuButton
            // 
            returnToMenuButton.Font = new Font("Palatino Linotype", 12F);
            returnToMenuButton.Location = new Point(646, 498);
            returnToMenuButton.Name = "returnToMenuButton";
            returnToMenuButton.Size = new Size(324, 46);
            returnToMenuButton.TabIndex = 14;
            returnToMenuButton.Text = "Return to Menu";
            returnToMenuButton.UseVisualStyleBackColor = true;
            returnToMenuButton.Click += returnToMenuButton_Click;
            // 
            // telephoneNumberTextBox
            // 
            telephoneNumberTextBox.Font = new Font("Palatino Linotype", 12F);
            telephoneNumberTextBox.Location = new Point(646, 300);
            telephoneNumberTextBox.Mask = "(999) 000-0000";
            telephoneNumberTextBox.Name = "telephoneNumberTextBox";
            telephoneNumberTextBox.Size = new Size(324, 29);
            telephoneNumberTextBox.TabIndex = 13;
            // 
            // numberTextBox
            // 
            numberTextBox.Font = new Font("Palatino Linotype", 12F);
            numberTextBox.Location = new Point(646, 394);
            numberTextBox.Mask = "00000";
            numberTextBox.Name = "numberTextBox";
            numberTextBox.Size = new Size(324, 29);
            numberTextBox.TabIndex = 12;
            numberTextBox.ValidatingType = typeof(int);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Palatino Linotype", 12F);
            label6.Location = new Point(646, 369);
            label6.Name = "label6";
            label6.Size = new Size(72, 22);
            label6.TabIndex = 10;
            label6.Text = "Number:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Palatino Linotype", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(378, 71);
            label5.Name = "label5";
            label5.Size = new Size(333, 47);
            label5.TabIndex = 11;
            label5.Text = "Welcome Customer!";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Palatino Linotype", 12F);
            label7.Location = new Point(72, 156);
            label7.Name = "label7";
            label7.Size = new Size(52, 22);
            label7.TabIndex = 12;
            label7.Text = "Stock:";
            // 
            // CustomerBuyingZone
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 825);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(panel1);
            Name = "CustomerBuyingZone";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += CustomerBuyingZone_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CustomerBuyingZone_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private ListBox stockListBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private TextBox nameTextBox;
        private TextBox adressTextBox;
        private TextBox countryTextBox;
        private Panel panel1;
        private Label label5;
        private Label label6;
        private MaskedTextBox telephoneNumberTextBox;
        private MaskedTextBox numberTextBox;
        private Label label7;
        private Button returnToMenuButton;
    }
}