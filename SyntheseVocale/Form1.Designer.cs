
namespace SyntheseVocale
{
    partial class Form1
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
            this.richTextBoxReco = new System.Windows.Forms.RichTextBox();
            this.labelMotReconnu = new System.Windows.Forms.Label();
            this.buttonParler = new System.Windows.Forms.Button();
            this.labelImageAssociee = new System.Windows.Forms.Label();
            this.pictureBoxAssociee = new System.Windows.Forms.PictureBox();
            this.buttonQuitter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAssociee)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxReco
            // 
            this.richTextBoxReco.Location = new System.Drawing.Point(161, 112);
            this.richTextBoxReco.Name = "richTextBoxReco";
            this.richTextBoxReco.Size = new System.Drawing.Size(392, 432);
            this.richTextBoxReco.TabIndex = 0;
            this.richTextBoxReco.Text = "";
            // 
            // labelMotReconnu
            // 
            this.labelMotReconnu.AutoSize = true;
            this.labelMotReconnu.Location = new System.Drawing.Point(275, 40);
            this.labelMotReconnu.Name = "labelMotReconnu";
            this.labelMotReconnu.Size = new System.Drawing.Size(132, 25);
            this.labelMotReconnu.TabIndex = 1;
            this.labelMotReconnu.Text = "Mot reconnu";
            // 
            // buttonParler
            // 
            this.buttonParler.Location = new System.Drawing.Point(265, 585);
            this.buttonParler.Name = "buttonParler";
            this.buttonParler.Size = new System.Drawing.Size(159, 56);
            this.buttonParler.TabIndex = 2;
            this.buttonParler.Text = "Parler";
            this.buttonParler.UseVisualStyleBackColor = true;
            this.buttonParler.Click += new System.EventHandler(this.buttonParler_Click);
            // 
            // labelImageAssociee
            // 
            this.labelImageAssociee.AutoSize = true;
            this.labelImageAssociee.Location = new System.Drawing.Point(999, 40);
            this.labelImageAssociee.Name = "labelImageAssociee";
            this.labelImageAssociee.Size = new System.Drawing.Size(162, 25);
            this.labelImageAssociee.TabIndex = 3;
            this.labelImageAssociee.Text = "Image associée";
            // 
            // pictureBoxAssociee
            // 
            this.pictureBoxAssociee.Location = new System.Drawing.Point(901, 98);
            this.pictureBoxAssociee.Name = "pictureBoxAssociee";
            this.pictureBoxAssociee.Size = new System.Drawing.Size(361, 446);
            this.pictureBoxAssociee.TabIndex = 4;
            this.pictureBoxAssociee.TabStop = false;
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Location = new System.Drawing.Point(1004, 596);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(159, 56);
            this.buttonQuitter.TabIndex = 5;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 702);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.pictureBoxAssociee);
            this.Controls.Add(this.labelImageAssociee);
            this.Controls.Add(this.buttonParler);
            this.Controls.Add(this.labelMotReconnu);
            this.Controls.Add(this.richTextBoxReco);
            this.Name = "Form1";
            this.Text = "Reconnaissance Vocale 1 mot";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAssociee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxReco;
        private System.Windows.Forms.Label labelMotReconnu;
        private System.Windows.Forms.Button buttonParler;
        private System.Windows.Forms.Label labelImageAssociee;
        private System.Windows.Forms.PictureBox pictureBoxAssociee;
        private System.Windows.Forms.Button buttonQuitter;
    }
}

