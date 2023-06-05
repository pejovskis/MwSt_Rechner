namespace WinFormsApp1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblBrutto = new Label();
            lblNetto = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnReset = new Button();
            btnSpeichern = new Button();
            tbxEingabeIn = new TextBox();
            tbxBruttoIn = new TextBox();
            tbxSteuerIn = new TextBox();
            tbxGesamtBrutto = new TextBox();
            tbxGesamtNetto = new TextBox();
            tbxGesamtSteuer = new TextBox();
            tbxMwstIn = new TextBox();
            tbxNettoIn = new TextBox();
            rBtnBrutto = new RadioButton();
            radioBtnNetto = new RadioButton();
            groupBox1 = new GroupBox();
            btnRechne = new Button();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 49);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "MwSt:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 87);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "Eingabe:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(140, 49);
            label3.Name = "label3";
            label3.Size = new Size(17, 15);
            label3.TabIndex = 2;
            label3.Text = "%";
            label3.Click += label3_Click;
            // 
            // lblBrutto
            // 
            lblBrutto.AutoSize = true;
            lblBrutto.Location = new Point(59, 114);
            lblBrutto.Name = "lblBrutto";
            lblBrutto.Size = new Size(46, 15);
            lblBrutto.TabIndex = 3;
            lblBrutto.Text = "Brutto: ";
            lblBrutto.Click += label4_Click;
            // 
            // lblNetto
            // 
            lblNetto.AutoSize = true;
            lblNetto.Location = new Point(59, 140);
            lblNetto.Name = "lblNetto";
            lblNetto.Size = new Size(40, 15);
            lblNetto.TabIndex = 4;
            lblNetto.Text = "Netto:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(53, 168);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 5;
            label6.Text = "Steuer: ";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 213);
            label7.Name = "label7";
            label7.Size = new Size(89, 15);
            label7.TabIndex = 6;
            label7.Text = "Gesamt Brutto: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 241);
            label8.Name = "label8";
            label8.Size = new Size(86, 15);
            label8.TabIndex = 7;
            label8.Text = "Gesamt Netto: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(25, 270);
            label9.Name = "label9";
            label9.Size = new Size(86, 15);
            label9.TabIndex = 8;
            label9.Text = "Gesamt Steuer:";
            // 
            // btnReset
            // 
            btnReset.Cursor = Cursors.Hand;
            btnReset.Location = new Point(93, 357);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(135, 23);
            btnReset.TabIndex = 10;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnSpeichern
            // 
            btnSpeichern.Cursor = Cursors.Hand;
            btnSpeichern.Location = new Point(93, 386);
            btnSpeichern.Name = "btnSpeichern";
            btnSpeichern.Size = new Size(135, 23);
            btnSpeichern.TabIndex = 11;
            btnSpeichern.Text = "Speichern";
            btnSpeichern.UseVisualStyleBackColor = true;
            btnSpeichern.Click += btnSpeichern_Click;
            // 
            // tbxEingabeIn
            // 
            tbxEingabeIn.Location = new Point(140, 84);
            tbxEingabeIn.Name = "tbxEingabeIn";
            tbxEingabeIn.Size = new Size(100, 23);
            tbxEingabeIn.TabIndex = 12;
            tbxEingabeIn.TextChanged += btnRechne_Click;
            // 
            // tbxBruttoIn
            // 
            tbxBruttoIn.Location = new Point(140, 111);
            tbxBruttoIn.Name = "tbxBruttoIn";
            tbxBruttoIn.ReadOnly = true;
            tbxBruttoIn.Size = new Size(100, 23);
            tbxBruttoIn.TabIndex = 13;
            // 
            // tbxSteuerIn
            // 
            tbxSteuerIn.Location = new Point(140, 165);
            tbxSteuerIn.Name = "tbxSteuerIn";
            tbxSteuerIn.ReadOnly = true;
            tbxSteuerIn.Size = new Size(100, 23);
            tbxSteuerIn.TabIndex = 15;
            // 
            // tbxGesamtBrutto
            // 
            tbxGesamtBrutto.Location = new Point(140, 213);
            tbxGesamtBrutto.Name = "tbxGesamtBrutto";
            tbxGesamtBrutto.ReadOnly = true;
            tbxGesamtBrutto.Size = new Size(100, 23);
            tbxGesamtBrutto.TabIndex = 16;
            // 
            // tbxGesamtNetto
            // 
            tbxGesamtNetto.Location = new Point(140, 238);
            tbxGesamtNetto.Name = "tbxGesamtNetto";
            tbxGesamtNetto.ReadOnly = true;
            tbxGesamtNetto.Size = new Size(100, 23);
            tbxGesamtNetto.TabIndex = 17;
            // 
            // tbxGesamtSteuer
            // 
            tbxGesamtSteuer.Location = new Point(140, 267);
            tbxGesamtSteuer.Name = "tbxGesamtSteuer";
            tbxGesamtSteuer.ReadOnly = true;
            tbxGesamtSteuer.Size = new Size(100, 23);
            tbxGesamtSteuer.TabIndex = 18;
            // 
            // tbxMwstIn
            // 
            tbxMwstIn.Location = new Point(105, 46);
            tbxMwstIn.Name = "tbxMwstIn";
            tbxMwstIn.Size = new Size(25, 23);
            tbxMwstIn.TabIndex = 19;
            tbxMwstIn.Text = "19";
            tbxMwstIn.TextAlign = HorizontalAlignment.Center;
            // 
            // tbxNettoIn
            // 
            tbxNettoIn.Location = new Point(140, 137);
            tbxNettoIn.Name = "tbxNettoIn";
            tbxNettoIn.ReadOnly = true;
            tbxNettoIn.Size = new Size(100, 23);
            tbxNettoIn.TabIndex = 20;
            // 
            // rBtnBrutto
            // 
            rBtnBrutto.AutoSize = true;
            rBtnBrutto.Checked = true;
            rBtnBrutto.Location = new Point(6, 23);
            rBtnBrutto.Name = "rBtnBrutto";
            rBtnBrutto.Size = new Size(58, 19);
            rBtnBrutto.TabIndex = 21;
            rBtnBrutto.TabStop = true;
            rBtnBrutto.Text = "Brutto";
            rBtnBrutto.UseVisualStyleBackColor = true;
            // 
            // radioBtnNetto
            // 
            radioBtnNetto.AutoSize = true;
            radioBtnNetto.Location = new Point(6, 48);
            radioBtnNetto.Name = "radioBtnNetto";
            radioBtnNetto.Size = new Size(55, 19);
            radioBtnNetto.TabIndex = 22;
            radioBtnNetto.TabStop = true;
            radioBtnNetto.Text = "Netto";
            radioBtnNetto.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rBtnBrutto);
            groupBox1.Controls.Add(radioBtnNetto);
            groupBox1.Location = new Point(246, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(70, 83);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnRechne
            // 
            btnRechne.Cursor = Cursors.Hand;
            btnRechne.Location = new Point(93, 328);
            btnRechne.Name = "btnRechne";
            btnRechne.Size = new Size(135, 23);
            btnRechne.TabIndex = 24;
            btnRechne.Text = "Rechne";
            btnRechne.UseVisualStyleBackColor = true;
            btnRechne.Click += button1_Click;
            btnRechne.KeyDown += btnRechne_KeyDown_1;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(93, 415);
            button1.Name = "button1";
            button1.Size = new Size(135, 23);
            button1.TabIndex = 25;
            button1.Text = "Speichern .cfg";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(93, 444);
            button2.Name = "button2";
            button2.Size = new Size(135, 23);
            button2.TabIndex = 26;
            button2.Text = "Open .cfg";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AcceptButton = btnSpeichern;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(320, 477);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnRechne);
            Controls.Add(groupBox1);
            Controls.Add(tbxNettoIn);
            Controls.Add(tbxMwstIn);
            Controls.Add(tbxGesamtSteuer);
            Controls.Add(tbxGesamtNetto);
            Controls.Add(tbxGesamtBrutto);
            Controls.Add(tbxSteuerIn);
            Controls.Add(tbxBruttoIn);
            Controls.Add(tbxEingabeIn);
            Controls.Add(btnSpeichern);
            Controls.Add(btnReset);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(lblNetto);
            Controls.Add(lblBrutto);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblBrutto;
        private Label lblNetto;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnReset;
        private Button btnSpeichern;
        private TextBox tbxEingabeIn;
        private TextBox tbxBruttoIn;
        private TextBox tbxSteuerIn;
        private TextBox tbxGesamtBrutto;
        private TextBox tbxGesamtNetto;
        private TextBox tbxGesamtSteuer;
        private TextBox tbxMwstIn;
        private TextBox tbxNettoIn;
        private RadioButton rBtnBrutto;
        private RadioButton radioBtnNetto;
        private GroupBox groupBox1;
        private Button btnRechne;
        private Button button1;
        private Button button2;
    }
}