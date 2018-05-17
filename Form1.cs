using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms; //genutzte Systeme
namespace Filialauthentifizierung
{
    public partial class Form1 : Form
    {
        private Boolean TimerRunning = false;
        private Authenticator authenticator = new Authenticator();

        private int Fnummer = 0;

        //Voreinstellungen
        public Form1()
        {
            InitializeComponent();
            txtb_c1.Visible = false;
            txtb_c2.Visible = false;

            initTimer();
        }

        private void initTimer()
        {
            Timer timer = new Timer();
            timer.Interval = (100); 
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private bool validate()
        {
            int temp;
            return (txtb_FN.TextLength == 4 && int.TryParse(txtb_FN.Text, out temp));
        }

        private void updateCode()
        {
            txtb_c1.Visible = true;
            txtb_c2.Visible = true;

            byte[] hash = authenticator.GenerateKey(Fnummer);
            txtb_c2.Text = authenticator.HashToString(hash);
        }

        private void displayErrorInvalidFn()
        {
            MessageBox.Show("Bitte Filialnummer angeben!" + "\n" +
                "Bsp.: 0007");
        }
        
        private void btn_Code_Click(object sender, EventArgs e)
        {
            try //anti-Crash-System+Code generieren
            {
                if (!TimerRunning)
                {
                    TimerRunning = true;
                }


                if (validate())
                {
                    Fnummer = (Int32.Parse(txtb_FN.Text));

                    updateCode();
                }
                else {
                    TimerRunning = false;
                    txtb_c1.Visible = false;
                    txtb_c2.Visible = false;

                    displayErrorInvalidFn();
                }
            }
            catch
            {
                txtb_c1.Visible = false;
                txtb_c2.Visible = false;
                MessageBox.Show("Fehler! Den Fehler haben nicht mal die Programmierer geschafft!Applaus!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Location = new Point(Screen.PrimaryScreen.WorkingArea.Width -261, Screen.PrimaryScreen.WorkingArea.Height -254);
        } //Position
        private void timer_Tick(object sender, EventArgs e)
        {
            if (TimerRunning)
            {
                updateCode();
            }
        }
    }
}