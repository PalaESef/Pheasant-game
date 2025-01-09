using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;// pentru muzica

namespace FazanProiect
{
    public partial class MeniuPrincipal : Form
    {

        WindowsMediaPlayer player = new WindowsMediaPlayer();//tot pt muzica

        public MeniuPrincipal()
        {
            InitializeComponent();
            Ascunde();
            player.URL = "Rainy Jazz - Music for Relax, Sleep _ Jazz History.mp3";// asa pui muzica
        }

        private void Engleza()
        {
            languageToolStripMenuItem.Text = "Language";
            musicToolStripMenuItem.Text = "Music";
            rulesToolStripMenuItem.Text = "Rules";
            exitToolStripMenuItem.Text = "Exit";
            buttonPlay.Text = "PLAY";
            buttonExit.Text = "EXIT";
            labelNr.Text = "Numbers of players : ";
            buttonPlayNr.Text = "PLAY";
            this.Text = "Main Menu";
            if (Variabile_globale.muzica2 == 0)
                pauseToolStripMenuItem.Text = "Pause";
            else
                pauseToolStripMenuItem.Text = "Unpause";
        }

        private void Romana()
        {
            languageToolStripMenuItem.Text = "Limba";
            musicToolStripMenuItem.Text = "Muzica";
            rulesToolStripMenuItem.Text = "Reguli";
            exitToolStripMenuItem.Text = "Iesire";
            buttonPlay.Text = "JOACA";
            buttonExit.Text = "IESIRE";
            labelNr.Text = "Numarul de jucatori : ";
            buttonPlayNr.Text = "JOACA";
            this.Text = "Meniu Principal";
            if (Variabile_globale.muzica2 == 0)
                pauseToolStripMenuItem.Text = "Pauza";
            else
                pauseToolStripMenuItem.Text = "Reia";
        }

        public static class Variabile_globale
        {
            public static int limbaGlobala = 0;
            public static int NrJucatori;
            public static int muzica = 0;
            public static int muzica2 = 0;
            public static string conexiuneString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\IT Projects\FazanProiect\Database1.mdf"";Integrated Security=True";
            public static int Numar = 1;
            public static int Numar2 = 0;
            public static int Faza4P2 = 1;
            public static int Faza4P3 = 3;
            public static int Faza4P4 = 3;
            public static int FazanP1 = 0;
            public static int FazanP2 = 0;
            public static int FazanP3 = 0;
            public static int FazanP4 = 0;
        }

        private void Ascunde()
        {
            labelNr.Visible = false;
            textBoxNr.Visible = false;
            buttonPlayNr.Visible = false;
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Engleza();
            Variabile_globale.limbaGlobala = 0;
        }

        private void romanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Romana();
            Variabile_globale.limbaGlobala = 1;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            buttonPlay.Visible = false;
            buttonExit.Visible = false;
            labelNr.Visible = true;
            textBoxNr.Visible = true;
            buttonPlayNr.Visible = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonPlayNr_Click(object sender, EventArgs e)
        {
            try
            {
                Variabile_globale.NrJucatori = Convert.ToInt32(textBoxNr.Text);
            }
            catch
            {
                if (Variabile_globale.limbaGlobala == 0)
                    MessageBox.Show("Insert a number between 2-4");
                else
                    MessageBox.Show("Introdu un nr intre 2-4");
                return;
            }
            if (Variabile_globale.NrJucatori < 2 || Variabile_globale.NrJucatori > 4)
            {
                if (Variabile_globale.limbaGlobala == 0)
                    MessageBox.Show("Insert a number between 2-4");
                else
                    MessageBox.Show("Introdu un nr intre 2-4");
                textBoxNr.Text = "";
                return;
            }
            Variabile_globale.NrJucatori = Convert.ToInt32(textBoxNr.Text);
            player.controls.stop();
            Joc F = new Joc();
            this.Hide();
            F.ShowDialog();
        }

        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReguli F = new FormReguli();
            F.ShowDialog();
        }

        private void FormMeniuPrincipal_Load(object sender, EventArgs e)
        {
            player.controls.play();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Variabile_globale.muzica == 0)
            {
                player.controls.stop();
                Variabile_globale.muzica = 1;
                stopToolStripMenuItem.Text = "Start";
                pauseToolStripMenuItem.Enabled = false;
            }
            else
            {
                player.controls.play();
                Variabile_globale.muzica = 0;
                stopToolStripMenuItem.Text = "Stop";
                pauseToolStripMenuItem.Enabled = true;
            }
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Variabile_globale.muzica2 == 0)
            {
                player.controls.pause();
                Variabile_globale.muzica2 = 1;
                if (Variabile_globale.limbaGlobala == 0)
                    pauseToolStripMenuItem.Text = "Unpause";
                else
                    pauseToolStripMenuItem.Text = "Reia";
                stopToolStripMenuItem.Enabled = false;
            }
            else
            {
                player.controls.play();
                Variabile_globale.muzica2 = 0;
                if (Variabile_globale.limbaGlobala == 0)
                    pauseToolStripMenuItem.Text = "Pause";
                else
                    pauseToolStripMenuItem.Text = "Pauza";
                stopToolStripMenuItem.Enabled = true;
            }
        }
    }
}

