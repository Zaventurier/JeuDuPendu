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
            this.btnRejouer = new System.Windows.Forms.Button();
            this.imgPendu = new System.Windows.Forms.PictureBox();
            this.grpTestLettres = new System.Windows.Forms.GroupBox();
            this.lblLettres = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.cboLettre = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPendu)).BeginInit();
            this.grpTestLettres.SuspendLayout();
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
            // btnRejouer
            // 
            this.btnRejouer.Image = global::JeuDuPendu.Properties.Resources.playagain;
            this.btnRejouer.Location = new System.Drawing.Point(331, 266);
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
            // frmPendu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 334);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.grpTestLettres);
            this.Controls.Add(this.btnRejouer);
            this.Controls.Add(this.imgPendu);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPendu";
            this.Text = "Jeu du Pendu [En développement]";
            this.Load += new System.EventHandler(this.frmPendu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPendu)).EndInit();
            this.grpTestLettres.ResumeLayout(false);
            this.grpTestLettres.PerformLayout();
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
    }
}

