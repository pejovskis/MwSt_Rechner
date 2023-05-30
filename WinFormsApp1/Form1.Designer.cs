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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBrutto = new System.Windows.Forms.Label();
            this.lblNetto = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.tbxEingabeIn = new System.Windows.Forms.TextBox();
            this.tbxBruttoIn = new System.Windows.Forms.TextBox();
            this.tbxSteuerIn = new System.Windows.Forms.TextBox();
            this.tbxGesamtBrutto = new System.Windows.Forms.TextBox();
            this.tbxGesamtNetto = new System.Windows.Forms.TextBox();
            this.tbxGesamtSteuer = new System.Windows.Forms.TextBox();
            this.tbxMwstIn = new System.Windows.Forms.TextBox();
            this.tbxNettoIn = new System.Windows.Forms.TextBox();
            this.rBtnBrutto = new System.Windows.Forms.RadioButton();
            this.radioBtnNetto = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRechne = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "MwSt:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Eingabe:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "%";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblBrutto
            // 
            this.lblBrutto.AutoSize = true;
            this.lblBrutto.Location = new System.Drawing.Point(59, 114);
            this.lblBrutto.Name = "lblBrutto";
            this.lblBrutto.Size = new System.Drawing.Size(46, 15);
            this.lblBrutto.TabIndex = 3;
            this.lblBrutto.Text = "Brutto: ";
            this.lblBrutto.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblNetto
            // 
            this.lblNetto.AutoSize = true;
            this.lblNetto.Location = new System.Drawing.Point(59, 140);
            this.lblNetto.Name = "lblNetto";
            this.lblNetto.Size = new System.Drawing.Size(40, 15);
            this.lblNetto.TabIndex = 4;
            this.lblNetto.Text = "Netto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Steuer: ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Gesamt Brutto: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Gesamt Netto: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Gesamt Steuer:";
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Location = new System.Drawing.Point(93, 357);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(135, 23);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSpeichern.Location = new System.Drawing.Point(93, 386);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(135, 23);
            this.btnSpeichern.TabIndex = 11;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // tbxEingabeIn
            // 
            this.tbxEingabeIn.Location = new System.Drawing.Point(140, 84);
            this.tbxEingabeIn.Name = "tbxEingabeIn";
            this.tbxEingabeIn.Size = new System.Drawing.Size(100, 23);
            this.tbxEingabeIn.TabIndex = 12;
            // 
            // tbxBruttoIn
            // 
            this.tbxBruttoIn.Location = new System.Drawing.Point(140, 111);
            this.tbxBruttoIn.Name = "tbxBruttoIn";
            this.tbxBruttoIn.ReadOnly = true;
            this.tbxBruttoIn.Size = new System.Drawing.Size(100, 23);
            this.tbxBruttoIn.TabIndex = 13;
            // 
            // tbxSteuerIn
            // 
            this.tbxSteuerIn.Location = new System.Drawing.Point(140, 165);
            this.tbxSteuerIn.Name = "tbxSteuerIn";
            this.tbxSteuerIn.ReadOnly = true;
            this.tbxSteuerIn.Size = new System.Drawing.Size(100, 23);
            this.tbxSteuerIn.TabIndex = 15;
            // 
            // tbxGesamtBrutto
            // 
            this.tbxGesamtBrutto.Location = new System.Drawing.Point(140, 213);
            this.tbxGesamtBrutto.Name = "tbxGesamtBrutto";
            this.tbxGesamtBrutto.ReadOnly = true;
            this.tbxGesamtBrutto.Size = new System.Drawing.Size(100, 23);
            this.tbxGesamtBrutto.TabIndex = 16;
            // 
            // tbxGesamtNetto
            // 
            this.tbxGesamtNetto.Location = new System.Drawing.Point(140, 238);
            this.tbxGesamtNetto.Name = "tbxGesamtNetto";
            this.tbxGesamtNetto.ReadOnly = true;
            this.tbxGesamtNetto.Size = new System.Drawing.Size(100, 23);
            this.tbxGesamtNetto.TabIndex = 17;
            // 
            // tbxGesamtSteuer
            // 
            this.tbxGesamtSteuer.Location = new System.Drawing.Point(140, 267);
            this.tbxGesamtSteuer.Name = "tbxGesamtSteuer";
            this.tbxGesamtSteuer.ReadOnly = true;
            this.tbxGesamtSteuer.Size = new System.Drawing.Size(100, 23);
            this.tbxGesamtSteuer.TabIndex = 18;
            // 
            // tbxMwstIn
            // 
            this.tbxMwstIn.Location = new System.Drawing.Point(105, 46);
            this.tbxMwstIn.Name = "tbxMwstIn";
            this.tbxMwstIn.Size = new System.Drawing.Size(25, 23);
            this.tbxMwstIn.TabIndex = 19;
            this.tbxMwstIn.Text = "19";
            this.tbxMwstIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxNettoIn
            // 
            this.tbxNettoIn.Location = new System.Drawing.Point(140, 137);
            this.tbxNettoIn.Name = "tbxNettoIn";
            this.tbxNettoIn.ReadOnly = true;
            this.tbxNettoIn.Size = new System.Drawing.Size(100, 23);
            this.tbxNettoIn.TabIndex = 20;
            // 
            // rBtnBrutto
            // 
            this.rBtnBrutto.AutoSize = true;
            this.rBtnBrutto.Checked = true;
            this.rBtnBrutto.Location = new System.Drawing.Point(6, 23);
            this.rBtnBrutto.Name = "rBtnBrutto";
            this.rBtnBrutto.Size = new System.Drawing.Size(58, 19);
            this.rBtnBrutto.TabIndex = 21;
            this.rBtnBrutto.TabStop = true;
            this.rBtnBrutto.Text = "Brutto";
            this.rBtnBrutto.UseVisualStyleBackColor = true;
            // 
            // radioBtnNetto
            // 
            this.radioBtnNetto.AutoSize = true;
            this.radioBtnNetto.Location = new System.Drawing.Point(6, 48);
            this.radioBtnNetto.Name = "radioBtnNetto";
            this.radioBtnNetto.Size = new System.Drawing.Size(55, 19);
            this.radioBtnNetto.TabIndex = 22;
            this.radioBtnNetto.TabStop = true;
            this.radioBtnNetto.Text = "Netto";
            this.radioBtnNetto.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBtnBrutto);
            this.groupBox1.Controls.Add(this.radioBtnNetto);
            this.groupBox1.Location = new System.Drawing.Point(246, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(70, 83);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnRechne
            // 
            this.btnRechne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRechne.Location = new System.Drawing.Point(93, 328);
            this.btnRechne.Name = "btnRechne";
            this.btnRechne.Size = new System.Drawing.Size(135, 23);
            this.btnRechne.TabIndex = 24;
            this.btnRechne.Text = "Rechne";
            this.btnRechne.UseVisualStyleBackColor = true;
            this.btnRechne.Click += new System.EventHandler(this.button1_Click);
            this.btnRechne.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnRechne_KeyDown_1);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(93, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Speichern .cfg";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(93, 444);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Open .cfg";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnRechne;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(320, 477);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRechne);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbxNettoIn);
            this.Controls.Add(this.tbxMwstIn);
            this.Controls.Add(this.tbxGesamtSteuer);
            this.Controls.Add(this.tbxGesamtNetto);
            this.Controls.Add(this.tbxGesamtBrutto);
            this.Controls.Add(this.tbxSteuerIn);
            this.Controls.Add(this.tbxBruttoIn);
            this.Controls.Add(this.tbxEingabeIn);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblNetto);
            this.Controls.Add(this.lblBrutto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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