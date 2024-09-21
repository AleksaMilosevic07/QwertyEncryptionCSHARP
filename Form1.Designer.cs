namespace QwertyEncryption
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
            English = new TextBox();
            Qwerty = new TextBox();
            EncryptButton = new Button();
            HelpButton = new Button();
            label1 = new Label();
            ExitButton = new Button();
            label2 = new Label();
            errorLabel = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // English
            // 
            English.BackColor = SystemColors.HotTrack;
            English.Location = new Point(279, 154);
            English.Name = "English";
            English.Size = new Size(232, 23);
            English.TabIndex = 0;
            English.TextChanged += English_TextChanged;
            // 
            // Qwerty
            // 
            Qwerty.BackColor = Color.Red;
            Qwerty.Location = new Point(279, 254);
            Qwerty.Name = "Qwerty";
            Qwerty.Size = new Size(232, 23);
            Qwerty.TabIndex = 1;
            Qwerty.TextChanged += Qwerty_TextChanged;
            // 
            // EncryptButton
            // 
            EncryptButton.Location = new Point(356, 204);
            EncryptButton.Name = "EncryptButton";
            EncryptButton.Size = new Size(75, 23);
            EncryptButton.TabIndex = 2;
            EncryptButton.Text = "Translate!";
            EncryptButton.UseVisualStyleBackColor = true;
            EncryptButton.Click += EncryptButton_Click;
            // 
            // HelpButton
            // 
            HelpButton.Location = new Point(356, 323);
            HelpButton.Name = "HelpButton";
            HelpButton.Size = new Size(75, 23);
            HelpButton.TabIndex = 4;
            HelpButton.Text = "Help?";
            HelpButton.UseVisualStyleBackColor = true;
            HelpButton.Click += HelpButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(224, 79);
            label1.Name = "label1";
            label1.Size = new Size(344, 25);
            label1.TabIndex = 5;
            label1.Text = "Welcome to Qwerty Encryption!";
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(356, 294);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(75, 23);
            ExitButton.TabIndex = 6;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(374, 104);
            label2.Name = "label2";
            label2.Size = new Size(35, 16);
            label2.TabIndex = 7;
            label2.Text = "v1.0";
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            errorLabel.ForeColor = Color.Firebrick;
            errorLabel.Location = new Point(270, 229);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(0, 23);
            errorLabel.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(279, 136);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 9;
            label3.Text = "English:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(279, 276);
            label4.Name = "label4";
            label4.Size = new Size(134, 15);
            label4.TabIndex = 9;
            label4.Text = "QWERTY encrypted text:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(errorLabel);
            Controls.Add(label2);
            Controls.Add(ExitButton);
            Controls.Add(label1);
            Controls.Add(HelpButton);
            Controls.Add(EncryptButton);
            Controls.Add(Qwerty);
            Controls.Add(English);
            Name = "Form1";
            Text = "Qwerty Encryption";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox English;
        private TextBox Qwerty;
        private Button EncryptButton;
        private Button HelpButton;
        private Label label1;
        private Button ExitButton;
        private Label label2;
        private Label errorLabel;
        private Label label3;
        private Label label4;
    }
}
