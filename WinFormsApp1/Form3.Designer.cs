namespace WinFormsApp1
{
    partial class Form3
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
            button2 = new Button();
            button1 = new Button();
            tbxOffnenLage = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(80, 165);
            button2.Name = "button2";
            button2.Size = new Size(59, 23);
            button2.TabIndex = 7;
            button2.Text = "abbrechen";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(161, 165);
            button1.Name = "button1";
            button1.Size = new Size(63, 23);
            button1.TabIndex = 6;
            button1.Text = "offnen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbxOffnenLage
            // 
            tbxOffnenLage.Location = new Point(80, 114);
            tbxOffnenLage.Name = "tbxOffnenLage";
            tbxOffnenLage.Size = new Size(144, 23);
            tbxOffnenLage.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 72);
            label1.Name = "label1";
            label1.Size = new Size(144, 15);
            label1.TabIndex = 4;
            label1.Text = "Name der Datei eingeben:";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 260);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tbxOffnenLage);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox tbxOffnenLage;
        private Label label1;
    }
}