﻿/**
 * Jeu du pendu
 * author : Emds
 * date : 02/07/2020
 */
using System;
using System.Windows.Forms;

namespace JeuDuPendu
{
    public partial class frmPendu : Form
    {
        /// <summary>
        /// Initialisation des objets graphiques
        /// </summary>
        public frmPendu()
        {
            InitializeComponent();
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
                txtMot.Text = "";
                for (int i = 0; i < nbrlettre ; i++)
                {
                    txtMot.Text += "-";
                }
            }

        }

        private void cboLettre_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMot.Text = cboLettre.Text;

        }
    }
}
