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
    public partial class FormReguli : Form
    {
        public FormReguli()
        {
            InitializeComponent();
        }

        private void Engleza()
        {
            labelReguliTitlu.Text = "Rules";
            this.Text = "Rules";
            labelReguli.Text = "At the beginning the first player says the alphabet" + "\n" + "in mind until the second player says STOP" + "\n" + "The letter will be written in the box under the" + "\n" + "first palyer name" + "\n" + "The second player has to write in his box a word" + "\n" + "that starts with the letter written by the first" + "\n" + "palyer in his box" + "\n" + "The third player has to write down in his box a" + "\n" + "word that starts with the last tow letters from" + "\n" + "the second player word" + "\n" + "So on, every player has to write down in their" + "\n" + "boxes a word that starts with the last two letters" + "\n" + "from the previous player word until a palyer gives" + "\n" + "up or there are none words left that can be formed" + "\n" + "In this case the player that can no longer form a" + "\n" + "word, will get a letter from the word FAZAN" + "\n" + "If a player gets all the letters from the word" + "\n" + "If a player gets all the letters from the word" + "\n" + "FAZAN, he loses the game" + "\n" + "The winners are chosen according to how many" + "\n" + "letters they have received, the one who received" + "\n" + "the fewest letters wins the game";
        }

        private void Romana()
        {
            labelReguliTitlu.Text = "Reguli";
            this.Text = "Reguli";
            labelReguli.Text = "La început primul jucător spune în gând alfabetul" + "\n" + "pana cand urmatorul jucator zice STOP" + "\n" + "Se introduce litera in caseta de sub numele" + "\n" + "primului jucator" + "\n" + "Urmatorul jucator trebuie sa introduca in caseta" + "\n" + "lui un cuvant care incepe cu litera introdusa de" + "\n" + "primul jucator" + "\n" + "Urmatorul jucator trebuie sa introduca un cuvant" + "\n" + "care incepe cu ultimele 2 litere din cuvantul" + "\n" + "jucatorului anterior" + "\n" + "Tot asa fiecare jucator trebuie sa introduca un" + "\n" + "cuvant care incepe cu ultimele 2 litere din" + "\n" + "cuvantul jucatorului anterior pana cand un" + "\n" + "jucator se da batut sau nu mai exista niciun" + "\n" + "cuvant care se poate forma" + "\n" + "In acest caz acest jucator va primii cate o litera," + "\n" + "pe rand, din cuvantul FAZAN" + "\n" + "Daca un jucator ajunge la cuvantul FAZAN" + "\n" + "acesta a pierdut jocul" + "\n" + "Castigatorii sunt alesi in functie de cate litere au" + "\n" + "primit, cel care a primit cele mai putine litere" + "\n" + "castiga jocul";
        }

        private void FormReguli_Load(object sender, EventArgs e)
        {
            if (MeniuPrincipal.Variabile_globale.limbaGlobala == 0)
                Engleza();
            else
                Romana();
        }
    }
}
