using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FazanProiect
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
            {
                labelLogin.Text = "Login";
                labelLogin.Location = new Point(184, 72);
                buttonRegister.Text = "Register";
                buttonLogin.Text = "Login";
                this.Text = "Login";
            }
            else
            {
                labelLogin.Text = "Autentificare";
                labelLogin.Location = new Point(77, 72);
                buttonRegister.Text = "Inregistrare";
                buttonLogin.Text = "Autentificare";
                this.Text = "Autentificare";
            } 
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            Register F = new Register();
            F.ShowDialog();
            this.Hide();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            LoginAccount F = new LoginAccount();
            F.ShowDialog();
            this.Hide();
        }
    }
}
