using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms; //genutzte Systeme
namespace Filialauthentifizierung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtb_c1.Visible = false;
            txtb_c2.Visible = false;
        } //Voreinstellungen

        Boolean timer =false;

        public static byte[] GetHash(string inputString)
        {
            HashAlgorithm algorithm = SHA256.Create();  
            return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        } //Verschlüsselung -> Definition
        
        private void Timer1(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = (100); // 10 secs
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }
        
        private void btn_Code_Click(object sender, EventArgs e)
        {
            try //anti-Crash-System+Code generieren
            {
                if (timer == false)
                {
                    Timer1(sender, e);
                    timer = true;
                }
                int temp;
                if (txtb_FN.TextLength == 4 && int.TryParse(txtb_FN.Text, out temp)) 
                {
                    txtb_c1.Visible = true;
                    txtb_c2.Visible = true;
                    int fn = Convert.ToInt32(txtb_FN.Text);
                    int clock = Int32.Parse(DateTime.Now.ToString("hmm"));
                    int day = Int32.Parse(DateTime.Today.Day.ToString());
                    int month = Int32.Parse(DateTime.Today.Month.ToString());
                    int year = Int32.Parse(DateTime.Today.Year.ToString());
                    int cmdCDMYF = clock * day * month * year * fn;
                    string cmbToString = cmdCDMYF.ToString();
                    byte[] hash = GetHash(cmbToString);
                    string mdfHash = "";
                    for (int i = 0; i <= 7; i++)
                    {
                        mdfHash = mdfHash + hash[i].ToString("X");
                    } //Verschlüsselung
                    mdfHash = mdfHash.Substring(0, 8);
                    txtb_c2.Text = mdfHash;
                } //Code generieren
                else {
                    txtb_c1.Visible = false;
                    txtb_c2.Visible = false;
                    MessageBox.Show("Bitte Filialnummer angeben!" + "\n" +
                        "Bsp.: 0007");
                } //Keine gültige Filialnummer angegeben
            }
            catch
            {
                txtb_c1.Visible = false;
                txtb_c2.Visible = false;
                MessageBox.Show("Fehler! Den Fehler haben nicht mal die Programmierer geschafft!Applaus!");
            }

        } //Code generieren bei Klicken des Knopfes

        private void Form1_Load(object sender, EventArgs e)
        {
            Location = new Point(Screen.PrimaryScreen.WorkingArea.Width -261, Screen.PrimaryScreen.WorkingArea.Height -254);
        } //Position
        private void timer_Tick(object sender, EventArgs e)
        {
            btn_Code_Click(sender, e);
        }
    }
} //Programm