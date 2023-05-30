using System.Linq.Expressions;
using System.Reflection;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        double mwst;
        double eingabe;
        double brutto;
        double netto;
        double steuer;
        double gesamtBrutto;
        double gesamtNetto;
        double gesamtSteuer;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnRechne_Click(object sender, EventArgs e)
        {

            try 
            {
                mwst = Convert.ToDouble(tbxMwstIn.Text);
                eingabe = Convert.ToDouble(tbxEingabeIn.Text);

                if (rBtnBrutto.Checked == true)
                {
                    brutto = eingabe;
                    netto = eingabe - ((mwst * eingabe) / 100);
                }
                else
                {
                    netto = eingabe;
                    brutto = eingabe + ((mwst * eingabe) / 100);
                }

                steuer = brutto - netto;

                tbxBruttoIn.Text = brutto.ToString("F2");
                tbxNettoIn.Text = netto.ToString("F2");
                tbxSteuerIn.Text = steuer.ToString("F2");

                tbxEingabeIn.Clear();
                tbxEingabeIn.Focus();
            } catch {
                MessageBox.Show("Please enter valid number", "Alert", MessageBoxButtons.OK);
                tbxEingabeIn.Clear();
            }

           
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {

            gesamtBrutto += brutto;
            gesamtNetto += netto;
            gesamtSteuer += steuer;

            tbxGesamtBrutto.Text = gesamtBrutto.ToString("F2");
            tbxGesamtNetto.Text = gesamtNetto.ToString("F2");
            tbxGesamtSteuer.Text = gesamtSteuer.ToString("F2");

            tbxEingabeIn.Text = "";
            tbxBruttoIn.Text = "";
            tbxNettoIn.Text = "";
            tbxSteuerIn.Text = "";

            tbxEingabeIn.Focus();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbxGesamtBrutto.Text = "";
            tbxGesamtNetto.Text = "";
            tbxGesamtSteuer.Text = "";
            tbxEingabeIn.Text = "";
            tbxBruttoIn.Text = "";
            tbxNettoIn.Text = "";
            tbxSteuerIn.Text = "";

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnRechne_Click(sender, e);
        }

        private void btnRechne_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRechne_Click(sender, e);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("test.cfg", true))
                {
                    sw.WriteLine(brutto);
                    sw.WriteLine(netto);
                    sw.WriteLine(steuer);
                    sw.WriteLine("\n");
                }
            } catch (IOException)
            {
                MessageBox.Show("Error Writing File", "Error", MessageBoxButtons.OK);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fileName = "test.cfg";

            try
            {
                if(File.Exists(fileName))
                {
                    using (StreamReader sr = new StreamReader(fileName))
                    {
                        tbxGesamtBrutto.Text = sr.ReadLine();
                        tbxGesamtNetto.Text = sr.ReadLine();
                        tbxGesamtSteuer.Text = sr.ReadLine();
                    }
                } else
                {
                    MessageBox.Show("File does not Exist", "Error", MessageBoxButtons.OK);
                }
                
            } catch
            {
                MessageBox.Show("Error Opening File", "Error", MessageBoxButtons.OK);
            }
        }
    }
}