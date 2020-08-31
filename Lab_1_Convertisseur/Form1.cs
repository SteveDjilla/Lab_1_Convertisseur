using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Lab_1_Convertisseur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ConvertionBinaire(int Entier, int Modulo, string chiffre, string Converti)
        {
            
            while( Entier != 0)
            {
                Modulo = Entier % 2;
                Entier = Entier / 2;
                Converti = Modulo.ToString() + Converti ; 

            }
            txtBinaire.Text = Converti;
        }

        private void ConvertionHexa(int Entier, int Modulo, string chiffre, string Converti)
        {

            while (Entier != 0)
            {
                Modulo = Entier % 16;
                Entier = Entier / 16;
                Converti = Modulo.ToString() + Converti;

            }
            txtHexadecimale.Text = Converti;
        }

        private void btnBinaire_Click(object sender, EventArgs e)
        {
            //premier commentaire
           //int numconvert = int.Parse(txtChiffre.Text);
          //txtBinaire.Text = Convert.ToString(numconvert, 2);

            int chiffreEntier = 0; int modulo = 0; string chiffre="" ;
            string converti ="";
            bool resultat = Int32.TryParse(txtChiffre.Text, out chiffreEntier);

            ConvertionBinaire(chiffreEntier, modulo, chiffre, converti);
        }

        private void btnDecimale_Click(object sender, EventArgs e)
        {
            int numconvert = int.Parse(txtChiffre.Text);
            txtDecimale.Text = Convert.ToString(numconvert);
        }

        private void btnHexa_Click(object sender, EventArgs e)
        {
            //int numconvert = int.Parse(txtChiffre.Text);
            //txtHexadecimale.Text = Convert.ToString(numconvert, 16);

            int chiffreEntier = 0; int modulo = 0; string chiffre = "";
            string converti = "";
            bool resultat = Int32.TryParse(txtChiffre.Text, out chiffreEntier);

            ConvertionHexa(chiffreEntier, modulo, chiffre, converti);
        }
    }
}
