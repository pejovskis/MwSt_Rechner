namespace WinFormsApp1
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
            tbxSpeicherLage = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 63);
            label1.Name = "label1";
            label1.Size = new Size(144, 15);
            label1.TabIndex = 0;
            label1.Text = "Name der Datei eingeben:";
            // 
            // tbxSpeicherLage
            // 
            tbxSpeicherLage.Location = new Point(86, 105);
            tbxSpeicherLage.Name = "tbxSpeicherLage";
            tbxSpeicherLage.Size = new Size(144, 23);
            tbxSpeicherLage.TabIndex = 1;
            tbxSpeicherLage.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(167, 156);
            button1.Name = "button1";
            button1.Size = new Size(63, 23);
            button1.TabIndex = 2;
            button1.Text = "speichern";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(86, 156);
            button2.Name = "button2";
            button2.Size = new Size(59, 23);
            button2.TabIndex = 3;
            button2.Text = "abbrechen";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 227);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tbxSpeicherLage);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbxSpeicherLage;
        private Button button1;
        private Button button2;
    }
}