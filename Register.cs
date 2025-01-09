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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
            {
                labelLogin.Text = "Register";
                labelLogin.Location = new Point(184, 72);
                labelPassword.Text = "Password";
                labelConfirmPassword.Text = "Confirm Password";
                labelNickname.Text = "Nickname";
                buttonEnter.Text = "Enter";
                this.Text = "Register";
            }
            else
            {
                labelLogin.Text = "Inregistrare";
                labelLogin.Location = new Point(77, 72);
                labelPassword.Text = "Parola";
                labelConfirmPassword.Text = "Confirma Parola";
                labelNickname.Text = "Porecla";
                buttonEnter.Text = "Introdu";
                this.Text = "Inregistrare";
            }
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "" || textBoxNickname.Text == "" || textBoxPassword.Text == "" || textBoxCPassword.Text == "")
            {
                if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                    MessageBox.Show("Introduceti datele");
                else
                    MessageBox.Show("Input data");
                return;
            }
            if(textBoxPassword.Text != textBoxCPassword.Text)
            {
                if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                    MessageBox.Show("Password doesn't match");
                else
                    MessageBox.Show("Parolele nu corespund");
                return;
            }
            SqlConnection conectiune = new SqlConnection(MeniuPrincipal.Variabile_globale.conexiuneString);
            conectiune.Open();
            SqlCommand inserare = new SqlCommand("Insert Into Conturi (email, nickname, parola) Values ('"+textBoxEmail.Text+ "', '" + textBoxNickname.Text +"', '" + textBoxPassword.Text +"')", conectiune);
            inserare.ExecuteNonQuery();
            conectiune.Close();
            if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                MessageBox.Show("Account has been added");
            else
                MessageBox.Show("Contul a fost adaugat");
            this.Hide();
        }

        private void buttonShow_Click(object sender, EventArgs e)
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

        private void buttonHide2_Click(object sender, EventArgs e)
        {
            textBoxCPassword.PasswordChar = '*';
            buttonHide2.Visible = false;
            buttonShow2.Visible = true;
        }

        private void buttonShow2_Click(object sender, EventArgs e)
        {
            textBoxCPassword.PasswordChar = '\0';
            buttonShow2.Visible = false;
            buttonHide2.Visible = true;
        }
    }
}
