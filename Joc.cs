using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace FazanProiect
{
    public partial class Joc : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public static Joc Instance;
        public Label lab1;
        public Label lab2;
        public Label lab3;
        public Label lab4;
        public Button but1;
        public Button but2;
        public Button but3;
        public Button but4;
        public TextBox txt1;
        public TextBox txt2;
        public TextBox txt3;
        public TextBox txt4;
        public string sJoc;
        public string sJoc2;
        public string ultimulCuv;

        public Joc()
        {
            InitializeComponent();
            player.URL = "Rainy Jazz - Music for Relax, Sleep _ Jazz History.mp3";
            MeniuPrincipal.Variabile_globale.muzica = 0;
            Ascunde();
            if (MeniuPrincipal.Variabile_globale.NrJucatori == 3)
            {
                labelP3.Visible = true;
                buttonP3.Visible = true;
            }
            if (MeniuPrincipal.Variabile_globale.NrJucatori == 4)
            {
                labelP3.Visible = true;
                labelP4.Visible = true;
                buttonP3.Visible = true;
                buttonP4.Visible = true;
            }
            if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                Engleza();
            else
                Romana();
            Instance = this;
            lab1 = labelP1;
            lab2 = labelP2; 
            lab3 = labelP3;
            lab4 = labelP4;
            but1 = buttonP1;
            but2 = buttonP2;
            but3 = buttonP3;
            but4 = buttonP4;
            txt1 = textBoxP1;
            txt2 = textBoxP2;
            txt3 = textBoxP3;
            txt4 = textBoxP4;
            /*
            if (MeniuPrincipal.Variabile_globale.Numar == 1)
                lab1 = labelP1;
            else if (MeniuPrincipal.Variabile_globale.Numar == 2)
                lab1 = labelP2;
            else if (MeniuPrincipal.Variabile_globale.Numar == 3)
                lab1 = labelP3;
            else if (MeniuPrincipal.Variabile_globale.Numar == 4)
                lab1 = labelP4;
            */
        }

        private void Ascunde()
        {
            labelP3.Visible = false;
            labelP4.Visible = false;
            buttonP3.Visible = false;
            buttonP4.Visible = false;
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Engleza();
            MeniuPrincipal.Variabile_globale.limbaGlobala = 0;
        }

        private void romanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Romana();
            MeniuPrincipal.Variabile_globale.limbaGlobala = 1;
        }

        private void Engleza()
        {
            languageToolStripMenuItem.Text = "Language";
            musicToolStripMenuItem.Text = "Music";
            rulesToolStripMenuItem.Text = "Rules";
            exitToolStripMenuItem.Text = "Exit";
            buttonPlayFaza1.Text = "Play";
            if (MeniuPrincipal.Variabile_globale.muzica2 == 0)
                pauseToolStripMenuItem.Text = "Pause";
            else
                pauseToolStripMenuItem.Text = "Unpause";
            if (MeniuPrincipal.Variabile_globale.Numar2 == 1)
            {
                labelP2.Text = "Player 2";
                labelP3.Text = "Player 3";
                labelP4.Text = "Player 4";
                buttonP2.Text = "Login";
                buttonP3.Text = "Login";
                buttonP4.Text = "Login";
            }
            if (MeniuPrincipal.Variabile_globale.Numar2 == 2)
            {
                labelP1.Text = "Player 1";
                labelP3.Text = "Player 3";
                labelP4.Text = "Player 4";
                buttonP1.Text = "Login";
                buttonP3.Text = "Login";
                buttonP4.Text = "Login";
            }
            if (MeniuPrincipal.Variabile_globale.Numar2 == 30)
            {
                labelP1.Text = "Player 1";
                labelP2.Text = "Player 2";
                labelP4.Text = "Player 4";
                buttonP1.Text = "Login";
                buttonP2.Text = "Login";
                buttonP4.Text = "Login";
            }
            if (MeniuPrincipal.Variabile_globale.Numar2 == 40)
            {
                labelP1.Text = "Player 1";
                labelP2.Text = "Player 2";
                labelP3.Text = "Player 3";
                buttonP1.Text = "Login";
                buttonP2.Text = "Login";
                buttonP3.Text = "Login";
            }
            if (MeniuPrincipal.Variabile_globale.Numar2 == 3)
            {
                labelP3.Text = "Player 3";
                labelP4.Text = "Player 4";
                buttonP3.Text = "Login";
                buttonP4.Text = "Login";
            }
            if (MeniuPrincipal.Variabile_globale.Numar2 == 31)
            {
                labelP2.Text = "Player 2";
                labelP4.Text = "Player 4";
                buttonP2.Text = "Login";
                buttonP4.Text = "Login";
            }
            if (MeniuPrincipal.Variabile_globale.Numar2 == 41)
            {
                labelP2.Text = "Player 2";
                labelP3.Text = "Player 3";
                buttonP2.Text = "Login";
                buttonP3.Text = "Login";
            }
            if (MeniuPrincipal.Variabile_globale.Numar2 == 32)
            {
                labelP1.Text = "Player 1";
                labelP4.Text = "Player 4";
                buttonP1.Text = "Login";
                buttonP4.Text = "Login";
            }
            if (MeniuPrincipal.Variabile_globale.Numar2 == 42)
            {
                labelP1.Text = "Player 1";
                labelP3.Text = "Player 3";
                buttonP1.Text = "Login";
                buttonP3.Text = "Login";
            }
            if (MeniuPrincipal.Variabile_globale.Numar2 == 70)
            {
                labelP1.Text = "Player 1";
                labelP2.Text = "Player 2";
                buttonP1.Text = "Login";
                buttonP2.Text = "Login";
            }
            if (MeniuPrincipal.Variabile_globale.Numar2 == 33)
            {
                labelP4.Text = "Player 4";
                buttonP4.Text = "Login";
            }
            if (MeniuPrincipal.Variabile_globale.Numar2 == 43)
            {
                labelP3.Text = "Player 3";
                buttonP3.Text = "Login";
            }
            if (MeniuPrincipal.Variabile_globale.Numar2 == 71)
            {
                labelP2.Text = "Player 2";
                buttonP2.Text = "Login";
            }
            if (MeniuPrincipal.Variabile_globale.Numar2 == 72)
            {
                labelP1.Text = "Player 1";
                buttonP1.Text = "Login";
            }
            if (MeniuPrincipal.Variabile_globale.Numar2 == 0)
            {
                labelP1.Text = "Player 1";
                labelP2.Text = "Player 2";
                labelP3.Text = "Player 3";
                labelP4.Text = "Player 4";
                buttonP1.Text = "Login";
                buttonP2.Text = "Login";
                buttonP3.Text = "Login";
                buttonP4.Text = "Login";
            }
        }

        private void Romana()
        {
            languageToolStripMenuItem.Text = "Limba";
            musicToolStripMenuItem.Text = "Muzica";
            rulesToolStripMenuItem.Text = "Reguli";
            exitToolStripMenuItem.Text = "Iesire";
            buttonPlayFaza1.Text = "Joaca";
            if (MeniuPrincipal.Variabile_globale.muzica2 == 0)
                pauseToolStripMenuItem.Text = "Pauza";
            else
                pauseToolStripMenuItem.Text = "Reia";
            if(MeniuPrincipal.Variabile_globale.Numar2 == 1)
            {
                labelP2.Text = "Jucator 2";
                labelP3.Text = "Jucator 3";
                labelP4.Text = "Jucator 4";
                buttonP2.Text = "Autentificare";
                buttonP3.Text = "Autentificare";
                buttonP4.Text = "Autentificare";
            }
            if(MeniuPrincipal.Variabile_globale.Numar2 == 2)
            {
                labelP1.Text = "Jucator 1";
                labelP3.Text = "Jucator 3";
                labelP4.Text = "Jucator 4";
                buttonP1.Text = "Autentificare";
                buttonP3.Text = "Autentificare";
                buttonP4.Text = "Autentificare";
            }
            if(MeniuPrincipal.Variabile_globale.Numar2 == 30)
            {
                labelP1.Text = "Jucator 1";
                labelP2.Text = "Jucator 2";
                labelP4.Text = "Jucator 4";
                buttonP1.Text = "Autentificare";
                buttonP2.Text = "Autentificare";
                buttonP4.Text = "Autentificare";
            }
            if(MeniuPrincipal.Variabile_globale.Numar2 == 40)
            {
                labelP1.Text = "Jucator 1";
                labelP2.Text = "Jucator 2";
                labelP3.Text = "Jucator 3";
                buttonP1.Text = "Autentificare";
                buttonP2.Text = "Autentificare";
                buttonP3.Text = "Autentificare";
            }
            if(MeniuPrincipal.Variabile_globale.Numar2 == 3)
            {
                labelP3.Text = "Jucator 3";
                labelP4.Text = "Jucator 4";
                buttonP3.Text = "Autentificare";
                buttonP4.Text = "Autentificare";
            }
            if(MeniuPrincipal.Variabile_globale.Numar2 == 31)
            {
                labelP2.Text = "Jucator 2";
                labelP4.Text = "Jucator 4";
                buttonP2.Text = "Autentificare";
                buttonP4.Text = "Autentificare";
            }
            if(MeniuPrincipal.Variabile_globale.Numar2 == 41)
            {
                labelP2.Text = "Jucator 2";
                labelP3.Text = "Jucator 3";
                buttonP2.Text = "Autentificare";
                buttonP3.Text = "Autentificare";
            }
            if(MeniuPrincipal.Variabile_globale.Numar2 == 32)
            {
                labelP1.Text = "Jucator 1";
                labelP4.Text = "Jucator 4";
                buttonP1.Text = "Autentificare";
                buttonP4.Text = "Autentificare";
            }
            if(MeniuPrincipal.Variabile_globale.Numar2 == 42)
            {
                labelP1.Text = "Jucator 1";
                labelP3.Text = "Jucator 3";
                buttonP1.Text = "Autentificare";
                buttonP3.Text = "Autentificare";
            }
            if(MeniuPrincipal.Variabile_globale.Numar2 == 70)
            {
                labelP1.Text = "Jucator 1";
                labelP2.Text = "Jucator 2";
                buttonP1.Text = "Autentificare";
                buttonP2.Text = "Autentificare";
            }
            if(MeniuPrincipal.Variabile_globale.Numar2 == 33)
            {
                labelP4.Text = "Jucator 4";
                buttonP4.Text = "Autentificare";
            }
            if(MeniuPrincipal.Variabile_globale.Numar2 == 43)
            {
                labelP3.Text = "Jucator 3";
                buttonP3.Text = "Autentificare";
            }
            if(MeniuPrincipal.Variabile_globale.Numar2 == 71)
            {
                labelP2.Text = "Jucator 2";
                buttonP2.Text = "Autentificare";
            }
            if(MeniuPrincipal.Variabile_globale.Numar2 == 72)
            {
                labelP1.Text = "Jucator 1";
                buttonP1.Text = "Autentificare";
            }
            if(MeniuPrincipal.Variabile_globale.Numar2 == 0)
            {
                labelP1.Text = "Jucator 1";
                labelP2.Text = "Jucator 2";
                labelP3.Text = "Jucator 3";
                labelP4.Text = "Jucator 4";
                buttonP1.Text = "Autentificare";
                buttonP2.Text = "Autentificare";
                buttonP3.Text = "Autentificare";
                buttonP4.Text = "Autentificare";
            }
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeniuPrincipal.Variabile_globale.muzica == 0)
            {
                player.controls.stop();
                MeniuPrincipal.Variabile_globale.muzica = 1;
                stopToolStripMenuItem.Text = "Start";
                pauseToolStripMenuItem.Enabled = false;
            }
            else
            {
                player.controls.play();
                MeniuPrincipal.Variabile_globale.muzica = 0;
                stopToolStripMenuItem.Text = "Stop";
                pauseToolStripMenuItem.Enabled = true;
            }
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeniuPrincipal.Variabile_globale.muzica2 == 0)
            {
                player.controls.pause();
                MeniuPrincipal.Variabile_globale.muzica2 = 1;
                if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                    pauseToolStripMenuItem.Text = "Unpause";
                else
                    pauseToolStripMenuItem.Text = "Reia";
                stopToolStripMenuItem.Enabled = false;
            }
            else
            {
                player.controls.play();
                MeniuPrincipal.Variabile_globale.muzica2 = 0;
                if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                    pauseToolStripMenuItem.Text = "Pause";
                else
                    pauseToolStripMenuItem.Text = "Pauza";
                stopToolStripMenuItem.Enabled = true;
            }
        }

        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReguli F = new FormReguli();
            F.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonP1_Click(object sender, EventArgs e)
        {
            MeniuPrincipal.Variabile_globale.Numar = 1;
            Login F = new Login();
            F.ShowDialog();
        }

        private void buttonP2_Click(object sender, EventArgs e)
        {
            MeniuPrincipal.Variabile_globale.Numar = 2;
            Login F = new Login();
            F.ShowDialog();
        }

        private void buttonP3_Click(object sender, EventArgs e)
        {
            MeniuPrincipal.Variabile_globale.Numar = 3;
            Login F = new Login();
            F.ShowDialog();
        }

        private void buttonP4_Click(object sender, EventArgs e)
        {
            MeniuPrincipal.Variabile_globale.Numar = 4;
            Login F = new Login();
            F.ShowDialog();
        }

        private bool VerifFaza2(string cuv, char x)
        {
            return cuv[0] == x;  
        }

        private bool VerifFaza4(string prevWord, string newWord)
        {
            return (newWord[0] == prevWord[prevWord.Length - 2] && newWord[1] == prevWord[prevWord.Length - 1]);
        }

        private bool VerifInchis(string prevWord)
        {
            if(prevWord[prevWord.Length - 2] == 'n' && prevWord[prevWord.Length - 1] == 't')
                return false;
            else if(prevWord[prevWord.Length - 2] == 'c' && prevWord[prevWord.Length - 1] == 't')
                return false;
            else if(prevWord[prevWord.Length - 2] == 'e' && prevWord[prevWord.Length - 1] == 'e')
                return false;
            else if (prevWord[prevWord.Length - 2] == 'r' && prevWord[prevWord.Length - 1] == 'b')
                return false;
            else if (prevWord[prevWord.Length - 2] == 'r' && prevWord[prevWord.Length - 1] == 't')
                return false;
            else if (prevWord[prevWord.Length - 2] == 'n' && prevWord[prevWord.Length - 1] == 's')
                return false;
            else if (prevWord[prevWord.Length - 2] == 'n' && prevWord[prevWord.Length - 1] == 'c')
                return false;
            else if (prevWord[prevWord.Length - 2] == 'r' && prevWord[prevWord.Length - 1] == 'd')
                return false;
            else if (prevWord[prevWord.Length - 2] == 'l' && prevWord[prevWord.Length - 1] == 't')
                return false;
            else if (prevWord[prevWord.Length - 2] == 'e' && prevWord[prevWord.Length - 1] == 'j')
                return false;
            else if (prevWord[prevWord.Length - 2] == 'f' && prevWord[prevWord.Length - 1] == 't')
                return false;
            else if (prevWord[prevWord.Length - 2] == 'n' && prevWord[prevWord.Length - 1] == 'g')
                return false;
            else if (prevWord[prevWord.Length - 2] == 't' && prevWord[prevWord.Length - 1] == 'm')
                return false;
            else if (prevWord[prevWord.Length - 2] == 'n' && prevWord[prevWord.Length - 1] == 'd')
                return false;
            else if (prevWord[prevWord.Length - 2] == 'n' && prevWord[prevWord.Length - 1] == 'z')
                return false;
            else if (prevWord[prevWord.Length - 2] == 'l' && prevWord[prevWord.Length - 1] == 'm')
                return false;
            else if (prevWord[prevWord.Length - 2] == 'r' && prevWord[prevWord.Length - 1] == 'n')
                return false;
            else if (prevWord[prevWord.Length - 2] == 'n' && prevWord[prevWord.Length - 1] == 's')
                return false;
            else if (prevWord[prevWord.Length - 2] == 'r' && prevWord[prevWord.Length - 1] == 's')
                return false;
            else if (prevWord[prevWord.Length - 2] == 'l' && prevWord[prevWord.Length - 1] == 'b')
                return false;
            else if (prevWord[prevWord.Length - 2] == 'm' && prevWord[prevWord.Length - 1] == 'n')
                return false;
            else if (prevWord[prevWord.Length - 2] == 'n' && prevWord[prevWord.Length - 1] == 'j')
                return false;
            else if (prevWord[prevWord.Length - 2] == 'r' && prevWord[prevWord.Length - 1] == 'm')
                return false;
            else if (prevWord[prevWord.Length - 2] == 'l' && prevWord[prevWord.Length - 1] == 's')
                return false;
            else if (prevWord[prevWord.Length - 2] == 'n' && prevWord[prevWord.Length - 1] == 'c')
                return false;
            else if (prevWord[prevWord.Length - 2] == 'l' && prevWord[prevWord.Length - 1] == 'f')
                return false;
            else if (prevWord[prevWord.Length - 2] == 'u' && prevWord[prevWord.Length - 1] == 'p')
                return false;
            else if (prevWord[prevWord.Length - 2] == 'h' && prevWord[prevWord.Length - 1] == 't')
                return false;
            else if (prevWord[prevWord.Length - 2] == 'r' && prevWord[prevWord.Length - 1] == 'h')
                return false;
            else if (prevWord[prevWord.Length - 2] == 'u' && prevWord[prevWord.Length - 1] == 'u')
                return false;
            else if (prevWord[prevWord.Length - 2] == 'r' && prevWord[prevWord.Length - 1] == 'g')
                return false;
            else if (prevWord[prevWord.Length - 2] == 'u' && prevWord[prevWord.Length - 1] == 'x')
                return false;
            else if (prevWord[prevWord.Length - 2] == 'l' && prevWord[prevWord.Length - 1] == 'c')
                return false;
            else
                return true;
        }

        private void faza1()
        {
            if (MeniuPrincipal.Variabile_globale.NrJucatori == 2)
            {
                if (MeniuPrincipal.Variabile_globale.Numar2 != 3)
                    if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                    {
                        MessageBox.Show("Login in all spot");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Autentificati-va in toate locurile");
                        return;
                    }
                textBoxP1.Enabled = true;
                if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                    labelJoc.Text = "Enter the letter of the alphabet you reached";
                else
                    labelJoc.Text = "Introduceti litera din alfabet la care ati ajuns";
                labelJoc.Visible = true;
            }

            if (MeniuPrincipal.Variabile_globale.NrJucatori == 3)
            {
                if (MeniuPrincipal.Variabile_globale.Numar2 != 33)
                    if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                    {
                        MessageBox.Show("Login in all spot");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Autentificati-va in toate locurile");
                        return;
                    }
                textBoxP1.Enabled = true;
                if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                    labelJoc.Text = "Enter the letter of the alphabet you reached";
                else
                    labelJoc.Text = "Introduceti litera din alfabet la care ati ajuns";
                labelJoc.Visible = true;
            }

            if (MeniuPrincipal.Variabile_globale.NrJucatori == 4)
            {
                if (MeniuPrincipal.Variabile_globale.Numar2 != 73)
                    if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                    {
                        MessageBox.Show("Login in all spot");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Autentificati-va in toate locurile");
                        return;
                    }
                textBoxP1.Enabled = true;
                if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                    labelJoc.Text = "Enter the letter of the alphabet you reached";
                else
                    labelJoc.Text = "Introduceti litera din alfabet la care ati ajuns";
                labelJoc.Visible = true;
            }
            buttonPlayFaza1.Visible = false;
            buttonPlayFaza2.Visible = true;
        }

        private void faza2()
        {
            if (textBoxP1.Text.Length != 1)
            {
                if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                    MessageBox.Show("Insert only a letter");
                else
                    MessageBox.Show("Introduceti o singura litera");
                return;
            }
            else
            {
                sJoc = textBoxP1.Text;
                textBoxP1.Text = "";
                textBoxP1.Enabled = false;
                textBoxP2.Enabled = true;
                buttonPlayFaza2.Visible = false;
                buttonPlayFaza3.Visible = true;
                if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                    labelJoc.Text = "Introduce a word which begins with the leter " + sJoc;
                else
                    labelJoc.Text = "Introduceti un cuvant care incepe cu litera " + sJoc;
            }
        }

        private void faza3()
        {
            if (textBoxP2.Text.Length <= 2)
            {
                textBoxP2.Text = "";
                if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                    MessageBox.Show("Introduce a word with more than 2 letters");
                else
                    MessageBox.Show("Introduceti un cuvant cu mai mult de 2 litere");
                return;
            }
            if (VerifFaza2(textBoxP2.Text, sJoc[0]))
            {
                sJoc2 = textBoxP2.Text[textBoxP2.Text.Length - 2].ToString() + textBoxP2.Text[textBoxP2.Text.Length - 1].ToString();
                if(MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                    labelJoc.Text = "Introduce a word which begins with the leters " + sJoc2;
                else
                    labelJoc.Text = "Introduceti un cuvant care incepe cu literele " + sJoc2;
                buttonPlayFaza3.Visible = false;
                if(MeniuPrincipal.Variabile_globale.NrJucatori == 2)
                {
                    if(VerifInchis(textBoxP2.Text))
                    {
                        ultimulCuv = textBoxP2.Text;
                        textBoxP2.Text = "";
                        textBoxP2.Enabled = false;
                        textBoxP1.Enabled = true;
                        buttonPlayFaza4.Visible = true;
                    }
                    else
                    {
                        if(MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                            MessageBox.Show("You closed");
                        else
                            MessageBox.Show("Ai inchis");
                        labelFazanP1.Visible = true;
                        if(MeniuPrincipal.Variabile_globale.FazanP1 == 0)
                        {
                            labelFazanP1.Text = "F";
                            labelJoc.Text = "";
                        }
                        else if(MeniuPrincipal.Variabile_globale.FazanP1 == 1)
                        {
                            labelFazanP1.Text = "FA";
                            labelJoc.Text = "";
                        }
                        else if(MeniuPrincipal.Variabile_globale.FazanP1 == 2)
                        {
                            labelFazanP1.Text = "FAZ";
                            labelJoc.Text = "";
                        }
                        else if(MeniuPrincipal.Variabile_globale.FazanP1 == 3)
                        {
                            labelFazanP1.Text = "FAZA";
                            labelJoc.Text = "";
                        }
                        else if(MeniuPrincipal.Variabile_globale.FazanP1 == 4)
                        {
                            labelFazanP1.Text = "FAZAN";
                            if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                                MessageBox.Show(lab1.Text + " lose the game");
                            else
                                MessageBox.Show(lab1.Text + " a pierdut jocul");
                            Application.Exit();
                        }
                        textBoxP2.Text = "";
                        textBoxP2.Enabled = false;
                        buttonPlayFaza1.Visible = true;
                        buttonPlayFaza4.Visible = false;
                        MeniuPrincipal.Variabile_globale.FazanP1++;
                    }
                }
                    
                if(MeniuPrincipal.Variabile_globale.NrJucatori == 3 || MeniuPrincipal.Variabile_globale.NrJucatori == 4)
                {
                    if(VerifInchis(textBoxP2.Text))
                    {
                        ultimulCuv = textBoxP2.Text;
                        textBoxP2.Text = "";
                        textBoxP2.Enabled = false;
                        textBoxP3.Enabled = true;
                        buttonPlayFaza4.Visible = true;
                    }
                    else
                    {
                        if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                            MessageBox.Show("You closed");
                        else
                            MessageBox.Show("Ai inchis");
                        labelFazanP3.Visible = true;
                        if(MeniuPrincipal.Variabile_globale.FazanP3 == 0)
                        {
                            labelFazanP3.Text = "F";
                            labelJoc.Text = "";
                            MeniuPrincipal.Variabile_globale.FazanP3++;
                        }
                        else if(MeniuPrincipal.Variabile_globale.FazanP3 == 1)
                        {
                            labelFazanP3.Text = "FA";
                            labelJoc.Text = "";
                            MeniuPrincipal.Variabile_globale.FazanP3++;
                        }
                        else if(MeniuPrincipal.Variabile_globale.FazanP3 == 2)
                        {
                            labelFazanP3.Text = "FAZ";
                            labelJoc.Text = "";
                            MeniuPrincipal.Variabile_globale.FazanP3++;
                        }
                        else if(MeniuPrincipal.Variabile_globale.FazanP3 == 3)
                        {
                            labelFazanP3.Text = "FAZA";
                            labelJoc.Text = "";
                            MeniuPrincipal.Variabile_globale.FazanP3++;
                        }
                        else if(MeniuPrincipal.Variabile_globale.FazanP3 == 4)
                        {
                            labelFazanP3.Text = "FAZAN";
                            if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                                MessageBox.Show(lab3.Text + " lose the game");
                            else
                                MessageBox.Show(lab3.Text + " a pierdut jocul");
                            Application.Exit();
                        }
                    }
                }
            }
            else
            {
                if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                    MessageBox.Show("Introduce a word which begins with the leter " + sJoc);
                else
                    MessageBox.Show("Introduceti un cuvant care incepe cu litera " + sJoc);
                return;
            }
        }

        private void faza4()
        {
            if(MeniuPrincipal.Variabile_globale.NrJucatori == 2)
            {
                if(MeniuPrincipal.Variabile_globale.Faza4P2 == 1)
                {
                    if(textBoxP1.Text.Length <= 2)
                    {
                        textBoxP1.Text = "";
                        if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                            MessageBox.Show("Introduce a word with more than 2 letters");
                        else
                            MessageBox.Show("Introduceti un cuvant cu mai mult de 2 litere" );
                        return;
                    }
                    if(VerifInchis(textBoxP1.Text))
                    {
                        if(VerifFaza4(ultimulCuv, textBoxP1.Text))
                        {
                            ultimulCuv = textBoxP1.Text;
                            sJoc2 = textBoxP1.Text[textBoxP1.Text.Length - 2].ToString() + textBoxP1.Text[textBoxP1.Text.Length - 1].ToString();
                            if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                                labelJoc.Text = "Introduce a word which begins with the leters " + sJoc2;
                            else
                                labelJoc.Text = "Introduceti un cuvant care incepe cu literele " + sJoc2;
                            textBoxP1.Text = "";
                            textBoxP1.Enabled = false;
                            textBoxP2.Enabled = true;
                        }
                        else
                        {
                            if(MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                                MessageBox.Show("Introduce a word which begins with the leters " + sJoc2);
                            else
                                MessageBox.Show("Introduceti un cuvant care incepe cu literele " + sJoc2);
                            return;
                        }
                        MeniuPrincipal.Variabile_globale.Faza4P2 = 2;
                    }
                    else
                    {
                        if(MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                            MessageBox.Show("You closed");
                        else
                            MessageBox.Show("Ai inchis");
                        labelFazanP2.Visible = true;
                        if(MeniuPrincipal.Variabile_globale.FazanP2 == 0)
                        {
                            labelFazanP2.Text = "F";
                            labelJoc.Text = "";
                        }
                        else if(MeniuPrincipal.Variabile_globale.FazanP2 == 1)
                        {
                            labelFazanP2.Text = "FA";
                            labelJoc.Text = "";
                        }
                        else if(MeniuPrincipal.Variabile_globale.FazanP2 == 2)
                        {
                            labelFazanP2.Text = "FAZ";
                            labelJoc.Text = "";
                        }
                        else if(MeniuPrincipal.Variabile_globale.FazanP2 == 3)
                        {
                            labelFazanP2.Text = "FAZA";
                            labelJoc.Text = "";
                        }
                        else if(MeniuPrincipal.Variabile_globale.FazanP2 == 4)
                        {
                            labelFazanP2.Text = "FAZAN";
                            if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                                MessageBox.Show(lab2.Text + " lose the game");
                            else
                                MessageBox.Show(lab2.Text + " a pierdut jocul");
                            Application.Exit();
                        }
                        textBoxP1.Text = "";
                        textBoxP1.Enabled = false;
                        MeniuPrincipal.Variabile_globale.FazanP2++;
                        buttonPlayFaza1.Visible = true;
                        buttonPlayFaza4.Visible = false;
                    }
                }
                if(MeniuPrincipal.Variabile_globale.Faza4P2 == 2)
                {
                    if (textBoxP2.Text.Length <= 2)
                    {
                        textBoxP2.Text = "";
                        if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                            MessageBox.Show("Introduce a word with more than 2 letters");
                        else
                            MessageBox.Show("Introduceti un cuvant cu mai mult de 2 litere");
                        return;
                    }
                    if (VerifInchis(textBoxP2.Text))
                    {
                        if (VerifFaza4(ultimulCuv, textBoxP2.Text))
                        {
                            ultimulCuv = textBoxP2.Text;
                            sJoc2 = textBoxP2.Text[textBoxP2.Text.Length - 2].ToString() + textBoxP2.Text[textBoxP2.Text.Length - 1].ToString();
                            if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                                labelJoc.Text = "Introduce a word which begins with the leters " + sJoc2;
                            else
                                labelJoc.Text = "Introduceti un cuvant care incepe cu literele " + sJoc2;
                            textBoxP2.Text = "";
                            textBoxP2.Enabled = false;
                            textBoxP1.Enabled = true;
                        }
                        else
                        {
                            if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                                MessageBox.Show("Introduce a word which begins with the leters " + sJoc2);
                            else
                                MessageBox.Show("Introduceti un cuvant care incepe cu literele " + sJoc2);
                            return;
                        }
                        MeniuPrincipal.Variabile_globale.Faza4P2 = 1;
                    }
                    else
                    {
                        if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                            MessageBox.Show("You closed");
                        else
                            MessageBox.Show("Ai inchis");
                        labelFazanP1.Visible = true;
                        if (MeniuPrincipal.Variabile_globale.FazanP1 == 0)
                        {
                            labelFazanP1.Text = "F";
                            labelJoc.Text = "";
                        }
                        else if(MeniuPrincipal.Variabile_globale.FazanP1 == 1)
                        {
                            labelFazanP1.Text = "FA";
                            labelJoc.Text = "";
                        }
                        else if(MeniuPrincipal.Variabile_globale.FazanP1 == 2)
                        {
                            labelFazanP1.Text = "FAZ";
                            labelJoc.Text = "";
                        }
                        else if(MeniuPrincipal.Variabile_globale.FazanP1 == 3)
                        {
                            labelFazanP1.Text = "FAZA";
                            labelJoc.Text = "";
                        }
                        else if(MeniuPrincipal.Variabile_globale.FazanP1 == 4)
                        {
                            labelFazanP1.Text = "FAZAN";
                            if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                                MessageBox.Show(lab1.Text + " lose the game");
                            else
                                MessageBox.Show(lab1.Text + " a pierdut jocul");
                            Application.Exit();
                        }
                        textBoxP2.Text = "";
                        textBoxP2.Enabled = false;
                        MeniuPrincipal.Variabile_globale.FazanP1++;
                        buttonPlayFaza1.Visible = true;
                        buttonPlayFaza4.Visible = false;
                    }
                }
            }
                
            if(MeniuPrincipal.Variabile_globale.NrJucatori == 3)
            {
                if (MeniuPrincipal.Variabile_globale.Faza4P3 == 3)
                {
                    if (textBoxP3.Text.Length <= 2)
                    {
                        textBoxP3.Text = "";
                        if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                            MessageBox.Show("Introduce a word with more than 2 letters");
                        else
                            MessageBox.Show("Introduceti un cuvant cu mai mult de 2 litere");
                        return;
                    }
                    if (VerifInchis(textBoxP3.Text))
                    {
                        if(VerifFaza4(ultimulCuv, textBoxP3.Text))
                        {
                            ultimulCuv = textBoxP3.Text;
                            sJoc2 = textBoxP3.Text[textBoxP3.Text.Length - 2].ToString() + textBoxP3.Text[textBoxP3.Text.Length - 1].ToString();
                            if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                                labelJoc.Text = "Introduce a word which begins with the leters " + sJoc2;
                            else
                                labelJoc.Text = "Introduceti un cuvant care incepe cu literele " + sJoc2;
                            textBoxP3.Text = "";
                            textBoxP3.Enabled = false;
                            textBoxP1.Enabled = true;
                            MeniuPrincipal.Variabile_globale.Faza4P3 = 1;
                        }
                        else
                        {
                            if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                                MessageBox.Show("Introduce a word which begins with the leters " + sJoc2);
                            else
                                MessageBox.Show("Introduceti un cuvant care incepe cu literele " + sJoc2);
                            return;
                        }
                    }
                    else 
                    {
                        if(MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                            MessageBox.Show("You closed");
                        else
                            MessageBox.Show("Ai inchis");
                        labelFazanP1.Visible = true;
                        if(MeniuPrincipal.Variabile_globale.FazanP1 == 0)
                        {
                            labelFazanP1.Text = "F";
                            labelJoc.Text = "";
                        }
                        else if(MeniuPrincipal.Variabile_globale.FazanP1 == 1)
                        {
                            labelFazanP1.Text = "FA";
                            labelJoc.Text = "";
                        }
                        else if(MeniuPrincipal.Variabile_globale.FazanP1 == 2)
                        {
                            labelFazanP1.Text = "FAZ";
                            labelJoc.Text = "";
                        }
                        else if(MeniuPrincipal.Variabile_globale.FazanP1 == 3)
                        {
                            labelFazanP1.Text = "FAZA";
                            labelJoc.Text = "";
                        }
                        else if(MeniuPrincipal.Variabile_globale.FazanP1 == 4)
                        {
                            labelFazanP1.Text = "FAZAN";
                            if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                                MessageBox.Show(lab1.Text + " lose the game");
                            else
                                MessageBox.Show(lab1.Text + " a pierdut jocul");
                            Application.Exit();
                        }
                        textBoxP3.Text = "";
                        textBoxP3.Enabled = false;
                        MeniuPrincipal.Variabile_globale.FazanP1++;
                        buttonPlayFaza1.Visible = true;
                        buttonPlayFaza4.Visible = false;
                    }
                }
                if(MeniuPrincipal.Variabile_globale.Faza4P3 == 1)
                {
                    if (textBoxP1.Text.Length <= 2)
                    {
                        textBoxP1.Text = "";
                        if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                            MessageBox.Show("Introduce a word with more than 2 letters");
                        else
                            MessageBox.Show("Introduceti un cuvant cu mai mult de 2 litere");
                        return;
                    }
                    if (VerifInchis(textBoxP1.Text))
                    {
                        if(VerifFaza4(ultimulCuv, textBoxP1.Text))
                        {
                            ultimulCuv = textBoxP1.Text;
                            sJoc2 = textBoxP1.Text[textBoxP1.Text.Length - 2].ToString() + textBoxP1.Text[textBoxP1.Text.Length - 1].ToString();
                            if(MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                                labelJoc.Text = "Introduce a word which begins with the leters " + sJoc2;
                            else
                                labelJoc.Text = "Introduceti un cuvant care incepe cu literele " + sJoc2;
                            textBoxP1.Text = "";
                            textBoxP1.Enabled = false;
                            textBoxP2.Enabled = true;
                            MeniuPrincipal.Variabile_globale.Faza4P3 = 2;
                        }
                        else
                        {
                            if(MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                                MessageBox.Show("Introduce a word which begins with the leters " + sJoc2);
                            else
                                MessageBox.Show("Introduceti un cuvant care incepe cu literele " + sJoc2);
                            return;
                        }
                    }
                    else
                    {
                        if(MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                            MessageBox.Show("You closed");
                        else
                            MessageBox.Show("Ai inchis");
                        labelFazanP2.Visible = true;
                        if (MeniuPrincipal.Variabile_globale.FazanP2 == 0)
                        {
                            labelFazanP2.Text = "F";
                            labelJoc.Text = "";
                        }
                        else if (MeniuPrincipal.Variabile_globale.FazanP2 == 1)
                        {
                            labelFazanP2.Text = "FA";
                            labelJoc.Text = "";
                        }
                        else if (MeniuPrincipal.Variabile_globale.FazanP2 == 2)
                        {
                            labelFazanP2.Text = "FAZ";
                            labelJoc.Text = "";
                        }
                        else if (MeniuPrincipal.Variabile_globale.FazanP2 == 3)
                        {
                            labelFazanP2.Text = "FAZA";
                            labelJoc.Text = "";
                        }
                        else if (MeniuPrincipal.Variabile_globale.FazanP2 == 4)
                        { 
                            labelFazanP2.Text = "FAZAN";
                            if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                                MessageBox.Show(lab2.Text + " lose the game");
                            else
                                MessageBox.Show(lab2.Text + " a pierdut jocul");
                            Application.Exit();
                        }
                        textBoxP1.Text = "";
                        textBoxP1.Enabled = false;
                        MeniuPrincipal.Variabile_globale.FazanP2++;
                        buttonPlayFaza1.Visible = true;
                        buttonPlayFaza4.Visible = false;
                    }
                }
                if(MeniuPrincipal.Variabile_globale.Faza4P3 == 2)
                {
                    if (textBoxP2.Text.Length <= 2)
                    {
                        textBoxP2.Text = "";
                        if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                            MessageBox.Show("Introduce a word with more than 2 letters");
                        else
                            MessageBox.Show("Introduceti un cuvant cu mai mult de 2 litere");
                        return;
                    }
                    if (VerifInchis(textBoxP2.Text))
                    {
                        if (VerifFaza4(ultimulCuv, textBoxP2.Text))
                        {
                            ultimulCuv = textBoxP2.Text;
                            sJoc2 = textBoxP2.Text[textBoxP2.Text.Length - 2].ToString() + textBoxP2.Text[textBoxP2.Text.Length - 1].ToString();
                            if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                                labelJoc.Text = "Introduce a word which begins with the leters " + sJoc2;
                            else
                                labelJoc.Text = "Introduceti un cuvant care incepe cu literele " + sJoc2;
                            textBoxP2.Text = "";
                            textBoxP2.Enabled = false;
                            textBoxP3.Enabled = true;
                            MeniuPrincipal.Variabile_globale.Faza4P3 = 3;
                        }
                        else
                        {
                            if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                                MessageBox.Show("Introduce a word which begins with the leters " + sJoc2);
                            else
                                MessageBox.Show("Introduceti un cuvant care incepe cu literele " + sJoc2);
                            return;
                        }
                    }
                    else
                    {
                        if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                            MessageBox.Show("You closed");
                        else
                            MessageBox.Show("Ai inchis");
                        labelFazanP3.Visible = true;
                        if (MeniuPrincipal.Variabile_globale.FazanP3 == 0)
                        {
                            labelFazanP3.Text = "F";
                            labelJoc.Text = "";
                        }
                        else if (MeniuPrincipal.Variabile_globale.FazanP3 == 1)
                        {
                            labelFazanP3.Text = "FA";
                            labelJoc.Text = "";
                        }
                        else if (MeniuPrincipal.Variabile_globale.FazanP3 == 2)
                        {
                            labelFazanP3.Text = "FAZ";
                            labelJoc.Text = "";
                        }
                        else if (MeniuPrincipal.Variabile_globale.FazanP3 == 3)
                        {
                            labelFazanP3.Text = "FAZA";
                            labelJoc.Text = "";
                        }
                        else if (MeniuPrincipal.Variabile_globale.FazanP3 == 4)
                        {
                            labelFazanP3.Text = "FAZAN";
                            if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                                MessageBox.Show(lab3.Text + " lose the game");
                            else
                                MessageBox.Show(lab3.Text + " a pierdut jocul");
                            Application.Exit();
                        }
                        textBoxP2.Text = "";
                        textBoxP2.Enabled = false;
                        MeniuPrincipal.Variabile_globale.FazanP3++;
                        buttonPlayFaza1.Visible = true;
                        buttonPlayFaza4.Visible = false;
                    }
                }
            }

            if(MeniuPrincipal.Variabile_globale.NrJucatori == 4)
            {
                if(MeniuPrincipal.Variabile_globale.Faza4P4 == 3)
                {
                    if (textBoxP3.Text.Length <= 2)
                    {
                        textBoxP3.Text = "";
                        if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                            MessageBox.Show("Introduce a word with more than 2 letters");
                        else
                            MessageBox.Show("Introduceti un cuvant cu mai mult de 2 litere");
                        return;
                    }
                    if (VerifInchis(textBoxP3.Text))
                    {
                        if(VerifFaza4(ultimulCuv, textBoxP3.Text))
                        {
                            ultimulCuv = textBoxP3.Text;
                            sJoc2 = textBoxP3.Text[textBoxP3.Text.Length - 2].ToString() + textBoxP3.Text[textBoxP3.Text.Length - 1].ToString();
                            if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                                labelJoc.Text = "Introduce a word which begins with the leters " + sJoc2;
                            else
                                labelJoc.Text = "Introduceti un cuvant care incepe cu literele " + sJoc2;
                            textBoxP3.Text = "";
                            textBoxP3.Enabled = false;
                            textBoxP4.Enabled = true;
                            MeniuPrincipal.Variabile_globale.Faza4P4 = 4;
                        }
                        else
                        {
                            if(MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                                MessageBox.Show("Introduce a word which begins with the leters " + sJoc2);
                            else
                                MessageBox.Show("Introduceti un cuvant care incepe cu literele " + sJoc2);
                            return;
                        }
                    }
                    else
                    {
                        if(MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                            MessageBox.Show("You closed");
                        else
                            MessageBox.Show("Ai inchis");
                        labelFazanP4.Visible = true;
                        if(MeniuPrincipal.Variabile_globale.FazanP4 == 0)
                        {
                            labelFazanP4.Text = "F";
                            labelJoc.Text = "";
                        }
                        else if(MeniuPrincipal.Variabile_globale.FazanP4 == 1)
                        {
                            labelFazanP4.Text = "FA";
                            labelJoc.Text = "";
                        }
                        else if(MeniuPrincipal.Variabile_globale.FazanP4 == 2)
                        {
                            labelFazanP4.Text = "FAZ";
                            labelJoc.Text = "";
                        }
                        else if(MeniuPrincipal.Variabile_globale.FazanP4 == 3)
                        {
                            labelFazanP4.Text = "FAZA";
                            labelJoc.Text = "";
                        }
                        else if(MeniuPrincipal.Variabile_globale.FazanP4 == 4)
                        {
                            labelFazanP4.Text = "FAZAN";
                            if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                                MessageBox.Show(lab4.Text + " lose the game");
                            else
                                MessageBox.Show(lab4.Text + " a pierdut jocul");
                            Application.Exit();
                        }
                        textBoxP3.Text = "";
                        textBoxP3.Enabled = false;
                        MeniuPrincipal.Variabile_globale.FazanP4++;
                        buttonPlayFaza1.Visible = true;
                        buttonPlayFaza4.Visible = false;
                    }
                }
                if(MeniuPrincipal.Variabile_globale.Faza4P4 == 4)
                {
                    if (textBoxP4.Text.Length <= 2)
                    {
                        textBoxP4.Text = "";
                        if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                            MessageBox.Show("Introduce a word with more than 2 letters");
                        else
                            MessageBox.Show("Introduceti un cuvant cu mai mult de 2 litere");
                        return;
                    }
                    if (VerifInchis(textBoxP4.Text))
                    {
                        if (VerifFaza4(ultimulCuv, textBoxP4.Text))
                        {
                            ultimulCuv = textBoxP4.Text;
                            sJoc2 = textBoxP4.Text[textBoxP4.Text.Length - 2].ToString() + textBoxP4.Text[textBoxP4.Text.Length - 1].ToString();
                            if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                                labelJoc.Text = "Introduce a word which begins with the leters " + sJoc2;
                            else
                                labelJoc.Text = "Introduceti un cuvant care incepe cu literele " + sJoc2;
                            textBoxP4.Text = "";
                            textBoxP4.Enabled = false;
                            textBoxP1.Enabled = true;
                            MeniuPrincipal.Variabile_globale.Faza4P4 = 1;
                        }
                        else
                        {
                            if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                                MessageBox.Show("Introduce a word which begins with the leters " + sJoc2);
                            else
                                MessageBox.Show("Introduceti un cuvant care incepe cu literele " + sJoc2);
                            return;
                        }
                    }
                    else
                    {
                        if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                            MessageBox.Show("You closed");
                        else
                            MessageBox.Show("Ai inchis");
                        labelFazanP1.Visible = true;
                        if (MeniuPrincipal.Variabile_globale.FazanP1 == 0)
                        {
                            labelFazanP1.Text = "F";
                            labelJoc.Text = "";
                        }
                        else if (MeniuPrincipal.Variabile_globale.FazanP1 == 1)
                        {
                            labelFazanP1.Text = "FA";
                            labelJoc.Text = "";
                        }
                        else if (MeniuPrincipal.Variabile_globale.FazanP1 == 2)
                        {
                            labelFazanP1.Text = "FAZ";
                            labelJoc.Text = "";
                        }
                        else if (MeniuPrincipal.Variabile_globale.FazanP1 == 3)
                        {
                            labelFazanP1.Text = "FAZA";
                            labelJoc.Text = "";
                        }
                        else if (MeniuPrincipal.Variabile_globale.FazanP1 == 4)
                        {
                            labelFazanP1.Text = "FAZAN";
                            if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                                MessageBox.Show(lab1.Text + " lose the game");
                            else
                                MessageBox.Show(lab1.Text + " a pierdut jocul");
                            Application.Exit();
                        }
                        textBoxP4.Text = "";
                        textBoxP4.Enabled = false;
                        MeniuPrincipal.Variabile_globale.FazanP1++;
                        buttonPlayFaza1.Visible = true;
                        buttonPlayFaza4.Visible = false;
                    }
                }
                if(MeniuPrincipal.Variabile_globale.Faza4P4 == 1)
                {
                    if (textBoxP1.Text.Length <= 2)
                    {
                        textBoxP1.Text = "";
                        if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                            MessageBox.Show("Introduce a word with more than 2 letters");
                        else
                            MessageBox.Show("Introduceti un cuvant cu mai mult de 2 litere");
                        return;
                    }
                    if (VerifInchis(textBoxP1.Text))
                    {
                        if (VerifFaza4(ultimulCuv, textBoxP1.Text))
                        {
                            ultimulCuv = textBoxP1.Text;
                            sJoc2 = textBoxP1.Text[textBoxP1.Text.Length - 2].ToString() + textBoxP1.Text[textBoxP1.Text.Length - 1].ToString();
                            if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                                labelJoc.Text = "Introduce a word which begins with the leters " + sJoc2;
                            else
                                labelJoc.Text = "Introduceti un cuvant care incepe cu literele " + sJoc2;
                            textBoxP1.Text = "";
                            textBoxP1.Enabled = false;
                            textBoxP2.Enabled = true;
                            MeniuPrincipal.Variabile_globale.Faza4P4 = 2;
                        }
                        else
                        {
                            if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                                MessageBox.Show("Introduce a word which begins with the leters " + sJoc2);
                            else
                                MessageBox.Show("Introduceti un cuvant care incepe cu literele " + sJoc2);
                            return;
                        }
                    }
                    else
                    {
                        if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                            MessageBox.Show("You closed");
                        else
                            MessageBox.Show("Ai inchis");
                        labelFazanP2.Visible = true;
                        if (MeniuPrincipal.Variabile_globale.FazanP2 == 0)
                        {
                            labelFazanP2.Text = "F";
                            labelJoc.Text = "";
                        }
                        else if (MeniuPrincipal.Variabile_globale.FazanP2 == 1)
                        {
                            labelFazanP2.Text = "FA";
                            labelJoc.Text = "";
                        }
                        else if (MeniuPrincipal.Variabile_globale.FazanP2 == 2)
                        {
                            labelFazanP2.Text = "FAZ";
                            labelJoc.Text = "";
                        }
                        else if (MeniuPrincipal.Variabile_globale.FazanP2 == 3)
                        {
                            labelFazanP2.Text = "FAZA";
                            labelJoc.Text = "";
                        }
                        else if (MeniuPrincipal.Variabile_globale.FazanP2 == 4)
                        {
                            labelFazanP2.Text = "FAZAN";
                            if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                                MessageBox.Show(lab2.Text + " lose the game");
                            else
                                MessageBox.Show(lab2.Text + " a pierdut jocul");
                            Application.Exit();
                        }
                        textBoxP1.Text = "";
                        textBoxP1.Enabled = false;
                        MeniuPrincipal.Variabile_globale.FazanP2++;
                        buttonPlayFaza1.Visible = true;
                        buttonPlayFaza4.Visible = false;
                    }
                }
                if(MeniuPrincipal.Variabile_globale.Faza4P4 == 2)
                {
                    if (textBoxP2.Text.Length <= 2)
                    {
                        textBoxP2.Text = "";
                        if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                            MessageBox.Show("Introduce a word with more than 2 letters");
                        else
                            MessageBox.Show("Introduceti un cuvant cu mai mult de 2 litere");
                        return;
                    }
                    if (VerifInchis(textBoxP2.Text))
                    {
                        if (VerifFaza4(ultimulCuv, textBoxP2.Text))
                        {
                            ultimulCuv = textBoxP2.Text;
                            sJoc2 = textBoxP2.Text[textBoxP2.Text.Length - 2].ToString() + textBoxP2.Text[textBoxP2.Text.Length - 1].ToString();
                            if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                                labelJoc.Text = "Introduce a word which begins with the leters " + sJoc2;
                            else
                                labelJoc.Text = "Introduceti un cuvant care incepe cu literele " + sJoc2;
                            textBoxP2.Text = "";
                            textBoxP2.Enabled = false;
                            textBoxP3.Enabled = true;
                            MeniuPrincipal.Variabile_globale.Faza4P3 = 3;
                        }
                        else
                        {
                            if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                                MessageBox.Show("Introduce a word which begins with the leters " + sJoc2);
                            else
                                MessageBox.Show("Introduceti un cuvant care incepe cu literele " + sJoc2);
                            return;
                        }
                    }
                    else
                    {
                        if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                            MessageBox.Show("You closed");
                        else
                            MessageBox.Show("Ai inchis");
                        labelFazanP3.Visible = true;
                        if (MeniuPrincipal.Variabile_globale.FazanP3 == 0)
                        {
                            labelFazanP3.Text = "F";
                            labelJoc.Text = "";
                        }
                        else if (MeniuPrincipal.Variabile_globale.FazanP3 == 1)
                        {
                            labelFazanP3.Text = "FA";
                            labelJoc.Text = "";
                        }
                        else if (MeniuPrincipal.Variabile_globale.FazanP3 == 2)
                        {
                            labelFazanP3.Text = "FAZ";
                            labelJoc.Text = "";
                        }
                        else if (MeniuPrincipal.Variabile_globale.FazanP3 == 3)
                        {
                            labelFazanP3.Text = "FAZA";
                            labelJoc.Text = "";
                        }
                        else if (MeniuPrincipal.Variabile_globale.FazanP3 == 4)
                        {
                            labelFazanP3.Text = "FAZAN";
                            if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                                MessageBox.Show(lab3.Text + " lose the game");
                            else
                                MessageBox.Show(lab3.Text + " a pierdut jocul");
                            Application.Exit();
                        }
                        textBoxP2.Text = "";
                        textBoxP2.Enabled = false;
                        MeniuPrincipal.Variabile_globale.FazanP3++;
                        buttonPlayFaza1.Visible = true;
                        buttonPlayFaza4.Visible = false;
                    }
                }
            }
        }

        private void buttonPlayNr_Click(object sender, EventArgs e)
        {
            faza1();
        }

        private void buttonPlayFaza2_Click(object sender, EventArgs e)
        {
            faza2();
        }

        private void buttonPlayFaza3_Click(object sender, EventArgs e)
        {
            faza3();
        }

        private void buttonPlayFaza4_Click(object sender, EventArgs e)
        {
            faza4();
        }
    }
}
