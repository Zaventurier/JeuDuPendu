using System;

namespace JeuDuPendu
{
    partial class frmPendu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMot = new System.Windows.Forms.TextBox();
            this.lblResultat = new System.Windows.Forms.Label();
            this.grpTestLettres = new System.Windows.Forms.GroupBox();
            this.lblLettres = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.cboLettre = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxMot = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TesterMot = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnRejouer = new System.Windows.Forms.Button();
            this.imgPendu = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.grpTestLettres.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPendu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMot);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(376, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "mot à chercher";
            // 
            // txtMot
            // 
            this.txtMot.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMot.Location = new System.Drawing.Point(8, 23);
            this.txtMot.Margin = new System.Windows.Forms.Padding(4);
            this.txtMot.MaxLength = 15;
            this.txtMot.Name = "txtMot";
            this.txtMot.Size = new System.Drawing.Size(331, 47);
            this.txtMot.TabIndex = 0;
            this.txtMot.TextChanged += new System.EventHandler(this.txtMot_TextChanged);
            this.txtMot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMot_KeyPress);
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultat.Location = new System.Drawing.Point(16, 283);
            this.lblResultat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(0, 39);
            this.lblResultat.TabIndex = 4;
            // 
            // grpTestLettres
            // 
            this.grpTestLettres.Controls.Add(this.lblLettres);
            this.grpTestLettres.Controls.Add(this.btnTest);
            this.grpTestLettres.Controls.Add(this.cboLettre);
            this.grpTestLettres.Location = new System.Drawing.Point(16, 102);
            this.grpTestLettres.Margin = new System.Windows.Forms.Padding(4);
            this.grpTestLettres.Name = "grpTestLettres";
            this.grpTestLettres.Padding = new System.Windows.Forms.Padding(4);
            this.grpTestLettres.Size = new System.Drawing.Size(376, 137);
            this.grpTestLettres.TabIndex = 3;
            this.grpTestLettres.TabStop = false;
            this.grpTestLettres.Text = "lettres testées";
            // 
            // lblLettres
            // 
            this.lblLettres.AutoSize = true;
            this.lblLettres.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLettres.Location = new System.Drawing.Point(8, 78);
            this.lblLettres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLettres.Name = "lblLettres";
            this.lblLettres.Size = new System.Drawing.Size(350, 28);
            this.lblLettres.TabIndex = 2;
            this.lblLettres.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            this.lblLettres.Click += new System.EventHandler(this.lblLettres_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(88, 23);
            this.btnTest.Margin = new System.Windows.Forms.Padding(4);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(77, 37);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "TEST";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // cboLettre
            // 
            this.cboLettre.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLettre.FormattingEnabled = true;
            this.cboLettre.Location = new System.Drawing.Point(8, 23);
            this.cboLettre.Margin = new System.Windows.Forms.Padding(4);
            this.cboLettre.Name = "cboLettre";
            this.cboLettre.Size = new System.Drawing.Size(71, 35);
            this.cboLettre.TabIndex = 0;
            this.cboLettre.SelectedIndexChanged += new System.EventHandler(this.cboLettre_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(785, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Jeu du Pendu - Version 1.0.5 en date du 12 Janvier 2021 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(785, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "- Ce jeu se joue à 2 minimum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(785, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(335, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "- L\'un des joueurs choisit un mot qui se verra chiffré";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(785, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(459, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "- Le second devra deviner le mot tout en testant les lettres de son choix";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(785, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(466, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "- Si il trouve le mot avant que le pendu ne s\'affiche il gagne, sinon il perd";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(785, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(251, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "- Le mot doit faire 15 lettres maximum !";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(785, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(388, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "- Une fois le mot trouvé, recliquez une fois sur le bouton test";
            // 
            // textBoxMot
            // 
            this.textBoxMot.Location = new System.Drawing.Point(13, 37);
            this.textBoxMot.Name = "textBoxMot";
            this.textBoxMot.Size = new System.Drawing.Size(112, 22);
            this.textBoxMot.TabIndex = 12;
            this.textBoxMot.TextChanged += new System.EventHandler(this.textBoxMot_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TesterMot);
            this.groupBox2.Controls.Add(this.textBoxMot);
            this.groupBox2.Location = new System.Drawing.Point(16, 262);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(376, 137);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tester un mot";
            // 
            // TesterMot
            // 
            this.TesterMot.Location = new System.Drawing.Point(149, 37);
            this.TesterMot.Margin = new System.Windows.Forms.Padding(4);
            this.TesterMot.Name = "TesterMot";
            this.TesterMot.Size = new System.Drawing.Size(77, 37);
            this.TesterMot.TabIndex = 13;
            this.TesterMot.Text = "TEST";
            this.TesterMot.UseVisualStyleBackColor = true;
            this.TesterMot.Click += new System.EventHandler(this.TesterMot_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(785, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(363, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "- Le joueur à la possibilité de tester le mot de son choix :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(818, 331);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "- Il n\'a qu\'UNE seule chance :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(840, 371);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(217, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "- Si il trouve le mot : c\'est gagné !";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(840, 409);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 17);
            this.label11.TabIndex = 17;
            this.label11.Text = "- Sinon, il perd !";
            // 
            // btnQuitter
            // 
            this.btnQuitter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitter.Location = new System.Drawing.Point(563, 331);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(61, 57);
            this.btnQuitter.TabIndex = 18;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnRejouer
            // 
            this.btnRejouer.Image = global::JeuDuPendu.Properties.Resources.playagain;
            this.btnRejouer.Location = new System.Drawing.Point(494, 331);
            this.btnRejouer.Margin = new System.Windows.Forms.Padding(4);
            this.btnRejouer.Name = "btnRejouer";
            this.btnRejouer.Size = new System.Drawing.Size(61, 57);
            this.btnRejouer.TabIndex = 2;
            this.btnRejouer.UseVisualStyleBackColor = true;
            this.btnRejouer.Click += new System.EventHandler(this.btnRejouer_Click);
            // 
            // imgPendu
            // 
            this.imgPendu.BackgroundImage = global::JeuDuPendu.Properties.Resources.pendu0;
            this.imgPendu.Location = new System.Drawing.Point(405, 15);
            this.imgPendu.Margin = new System.Windows.Forms.Padding(4);
            this.imgPendu.Name = "imgPendu";
            this.imgPendu.Size = new System.Drawing.Size(333, 308);
            this.imgPendu.TabIndex = 1;
            this.imgPendu.TabStop = false;
            this.imgPendu.Click += new System.EventHandler(this.imgPendu_Click);
            // 
            // frmPendu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 490);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.grpTestLettres);
            this.Controls.Add(this.btnRejouer);
            this.Controls.Add(this.imgPendu);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPendu";
            this.Text = "Jeu du Pendu 1.0.5";
            this.Load += new System.EventHandler(this.frmPendu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpTestLettres.ResumeLayout(false);
            this.grpTestLettres.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPendu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void txtMot_TextChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMot;
        private System.Windows.Forms.PictureBox imgPendu;
        private System.Windows.Forms.Button btnRejouer;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.GroupBox grpTestLettres;
        private System.Windows.Forms.Label lblLettres;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.ComboBox cboLettre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxMot;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button TesterMot;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnQuitter;
    }
}

