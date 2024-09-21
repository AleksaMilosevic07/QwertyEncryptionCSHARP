namespace QwertyEncryption
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label13 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(229, 9);
            label1.Name = "label1";
            label1.Size = new Size(330, 23);
            label1.TabIndex = 0;
            label1.Text = "How to use QWERTY encryption?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(202, 15);
            label2.TabIndex = 1;
            label2.Text = "How does QWERTY decryption work?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 68);
            label3.Name = "label3";
            label3.Size = new Size(535, 15);
            label3.TabIndex = 2;
            label3.Text = "It is quite simple; it is inspired by the QWERTY-style keyboard that you are probably using right now. ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 83);
            label4.Name = "label4";
            label4.Size = new Size(782, 15);
            label4.TabIndex = 3;
            label4.Text = "Essentially, you use the key above your desired key. For example, if you want to type the letter Q, you will type what is above the letter Q, which is 1.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 98);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 4;
            label5.Text = "Examples:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 130);
            label6.Name = "label6";
            label6.Size = new Size(118, 15);
            label6.TabIndex = 5;
            label6.Text = "QWERTY ==> 123456";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 157);
            label7.Name = "label7";
            label7.Size = new Size(124, 15);
            label7.TabIndex = 5;
            label7.Text = "PYTHON ==> 065Y9H";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 193);
            label8.Name = "label8";
            label8.Size = new Size(125, 15);
            label8.TabIndex = 5;
            label8.Text = "How can you use this?";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 208);
            label9.Name = "label9";
            label9.Size = new Size(645, 15);
            label9.TabIndex = 5;
            label9.Text = "My main idea is that you can use this to create secure passwords without having to write them down or remember them. ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 223);
            label10.Name = "label10";
            label10.Size = new Size(785, 15);
            label10.TabIndex = 5;
            label10.Text = "By using this method of encryption, you can turn regular, easy-to-remember words into something that is not easily decrypted and is hard to guess.";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label11.Location = new Point(120, 252);
            label11.Name = "label11";
            label11.Size = new Size(537, 14);
            label11.TabIndex = 5;
            label11.Text = "You write text in English only in the blue field, while QWERTY text only in the red field";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label13.Location = new Point(189, 278);
            label13.Name = "label13";
            label13.Size = new Size(399, 14);
            label13.TabIndex = 5;
            label13.Text = "Leave at least one field empty and use UPPERCASE letters only!";
            // 
            // button1
            // 
            button1.Location = new Point(334, 322);
            button1.Name = "button1";
            button1.Size = new Size(111, 41);
            button1.TabIndex = 6;
            button1.Text = "Close help page";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label13);
            Controls.Add(label11);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Help page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label13;
        private Button button1;
    }
}