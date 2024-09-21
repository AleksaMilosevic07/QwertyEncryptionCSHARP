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
            SwapButton = new Button();
            HelpButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // English
            // 
            English.BackColor = SystemColors.HotTrack;
            English.Location = new Point(279, 154);
            English.Name = "English";
            English.Size = new Size(232, 23);
            English.TabIndex = 0;
            // 
            // Qwerty
            // 
            Qwerty.BackColor = Color.Red;
            Qwerty.Location = new Point(279, 254);
            Qwerty.Name = "Qwerty";
            Qwerty.Size = new Size(232, 23);
            Qwerty.TabIndex = 1;
            // 
            // EncryptButton
            // 
            EncryptButton.Location = new Point(356, 204);
            EncryptButton.Name = "EncryptButton";
            EncryptButton.Size = new Size(75, 23);
            EncryptButton.TabIndex = 2;
            EncryptButton.Text = "Translate!";
            EncryptButton.UseVisualStyleBackColor = true;
            // 
            // SwapButton
            // 
            SwapButton.Location = new Point(290, 204);
            SwapButton.Name = "SwapButton";
            SwapButton.Size = new Size(60, 23);
            SwapButton.TabIndex = 3;
            SwapButton.Text = "Swap!";
            SwapButton.UseVisualStyleBackColor = true;
            // 
            // HelpButton
            // 
            HelpButton.Location = new Point(437, 204);
            HelpButton.Name = "HelpButton";
            HelpButton.Size = new Size(60, 23);
            HelpButton.TabIndex = 4;
            HelpButton.Text = "Help?";
            HelpButton.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(HelpButton);
            Controls.Add(SwapButton);
            Controls.Add(EncryptButton);
            Controls.Add(Qwerty);
            Controls.Add(English);
            Name = "Form1";
            Text = "Qwerty Encryption";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox English;
        private TextBox Qwerty;
        private Button EncryptButton;
        private Button SwapButton;
        private Button HelpButton;
        private Label label1;
    }
}
