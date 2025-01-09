using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FazanProiect
{
    public partial class LoginAccount : Form
    {
        public static LoginAccount Instance;
        public string s;

        public LoginAccount()
        {
            InitializeComponent();
            Instance = this;
            if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
            {
                labelLogin.Text = "Login";
                labelLogin.Location = new Point(184, 72);
                labelPassword.Text = "Password";
                buttonEnter.Text = "Enter";
                this.Text = "LoginAccount";
            }
            else
            {
                labelLogin.Text = "Autentificare";
                labelLogin.Location = new Point(77, 72);
                labelPassword.Text = "Parola";
                buttonEnter.Text = "Introdu";
                this.Text = "AutentificareCont";
            }
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "" || textBoxPassword.Text == "")
            {
                if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                    MessageBox.Show("Introduceti datele");
                else
                    MessageBox.Show("Input data");
                return;
            }
            SqlConnection conectiune = new SqlConnection(MeniuPrincipal.Variabile_globale.conexiuneString);
            conectiune.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Conturi WHERE email = '" + textBoxEmail.Text + "' and parola = '" + textBoxPassword.Text + "'", conectiune);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                s = Convert.ToString(dt.Rows[0]["nickname"]);
                if(MeniuPrincipal.Variabile_globale.Numar == 1)
                {
                    Joc.Instance.lab1.Text = s;
                    MeniuPrincipal.Variabile_globale.Numar2 += 1;
                    Joc.Instance.but1.Visible = false;
                    Joc.Instance.txt1.Visible = true;
                }
                if(MeniuPrincipal.Variabile_globale.Numar == 2)
                {
                    Joc.Instance.lab2.Text = s;
                    MeniuPrincipal.Variabile_globale.Numar2 += 2;
                    Joc.Instance.but2.Visible = false;
                    Joc.Instance.txt2.Visible = true;
                }
                if(MeniuPrincipal.Variabile_globale.Numar == 3)
                {
                    Joc.Instance.lab3.Text = s;
                    MeniuPrincipal.Variabile_globale.Numar2 += 30;
                    Joc.Instance.but3.Visible = false;
                    Joc.Instance.txt3.Visible = true;
                }
                if(MeniuPrincipal.Variabile_globale.Numar == 4)
                {
                    Joc.Instance.lab4.Text = s;
                    MeniuPrincipal.Variabile_globale.Numar2 += 40;
                    Joc.Instance.but4.Visible = false;
                    Joc.Instance.txt4.Visible = true;
                }
                conectiune.Close();
                this.Hide();
                return;
            }
            else
            {
                if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                    MessageBox.Show("Email or Password are incorect");
                else
                    MessageBox.Show("Email sau Parola gresite");
                conectiune.Close();
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '\0';
            buttonShow.Visible = false; 
            buttonHide.Visible = true;
        }

        private void buttonHide_Click(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*';
            buttonHide.Visible = false; 
            buttonShow.Visible = true;   
        }
    }
}
