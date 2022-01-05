/**
 * Jeu du pendu
 * author : Emds
 * date : 02/07/2020
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace JeuDuPendu
{
    public partial class frmPendu : Form
    {
        string mot = "";
        char[] resultat = new char[15] { '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-'};
        string mot2 = "";
        int compteur = 0;
        bool erreur = true;
        

        /// <summary>
        /// Initialisation des objets graphiques
        /// </summary>
        public frmPendu()

        {
            InitializeComponent();
            imgPendu.Image = (Image)Properties.Resources.ResourceManager.GetObject("pendu0");
        }


        /// <summary>
        /// Rempli le combo avec les lettres de l'alphabet
        /// </summary>
        private void RemplirCboLettres()
        {
            // vide le combo
            cboLettre.Items.Clear();
            // rempli le combo avec les lettres de l'alphabet
            for (int k = 0; k < 26; k++)
            {
                cboLettre.Items.Add((char)('A' + k));
            }
            cboLettre.SelectedIndex = 0;
        }

        /// <summary>
        /// Evénement chargement de la fenêtre
        /// création des boutons des lettres de l'alphabet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPendu_Load(object sender, EventArgs e)
        {
            RemplirCboLettres();
        }

        private void txtMot_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //txtMot.Text = txtMot.Text.Length.ToString();
                int nbrlettre = txtMot.Text.Length;
                mot = txtMot.Text;
                txtMot.Text = "";
                lblLettres.Text = "";
                for (int i = 0; i < nbrlettre ; i++)
                {
                    txtMot.Text += "-";
                }
            }


        }

        private void cboLettre_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            erreur = true;
            for (int i = 0; i < mot.Length; i++)
            {
                if (mot[i] == Char.Parse(cboLettre.Text))
                {
                    resultat[i] = Char.Parse(cboLettre.Text);
                    erreur = false;
                }

            }
            if (erreur)
            {
            compteur = compteur + 1;
            imgPendu.Image = (Image)Properties.Resources.ResourceManager.GetObject("pendu" + compteur);
                if (compteur == 10)
                {
                    MessageBox.Show("Vous avez perdu :( ! Vous pouvez retenter votre chance en cliquant sur le bouton rejouer !");
                }
            }



            lblLettres.Text += cboLettre.Text;
            txtMot.Text = "";
            for (int i = 0; i < mot.Length; i++)
            {
                txtMot.Text += resultat[i].ToString();
            }
        }

        private void lblLettres_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRejouer_Click(object sender, EventArgs e)
        {
            //Reset de toutes les variables
            cboLettre.Text = "";
            lblLettres.Text = "";
            mot = "";
            txtMot.Text = "";
            imgPendu.Image = (Image)Properties.Resources.ResourceManager.GetObject("pendu0"); ;
        }

        private void imgPendu_Click(object sender, EventArgs e)
        {

        }
    }
}
