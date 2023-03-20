namespace GESTIONDESSTOCKS
{
    partial class AjouterProduitForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboxTaux = new System.Windows.Forms.ComboBox();
            this.comboBoxetat = new System.Windows.Forms.ComboBox();
            this.textBoxdesignation = new System.Windows.Forms.TextBox();
            this.textBoxcdf = new System.Windows.Forms.TextBox();
            this.textBoxqte = new System.Windows.Forms.TextBox();
            this.textBoxusd = new System.Windows.Forms.TextBox();
            this.textBoxqtecrit = new System.Windows.Forms.TextBox();
            this.btnannuler = new System.Windows.Forms.Button();
            this.btnajouter = new System.Windows.Forms.Button();
            this.labelMenu = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.labelMenu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 64);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(204, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "GENUIS|STOCK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Taux du jour:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Designation Produit:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Prix unitaire CDF:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Quantite:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Etat Produit:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(444, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "USD:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(425, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Qte Crit:";
            // 
            // comboxTaux
            // 
            this.comboxTaux.FormattingEnabled = true;
            this.comboxTaux.Location = new System.Drawing.Point(211, 113);
            this.comboxTaux.Name = "comboxTaux";
            this.comboxTaux.Size = new System.Drawing.Size(135, 28);
            this.comboxTaux.TabIndex = 11;
            this.comboxTaux.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboxTaux_KeyPress);
            // 
            // comboBoxetat
            // 
            this.comboBoxetat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxetat.FormattingEnabled = true;
            this.comboBoxetat.Items.AddRange(new object[] {
            "Active",
            "Desactive"});
            this.comboBoxetat.Location = new System.Drawing.Point(211, 318);
            this.comboBoxetat.Name = "comboBoxetat";
            this.comboBoxetat.Size = new System.Drawing.Size(135, 28);
            this.comboBoxetat.TabIndex = 12;
            this.comboBoxetat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxetat_KeyPress);
            // 
            // textBoxdesignation
            // 
            this.textBoxdesignation.Location = new System.Drawing.Point(211, 163);
            this.textBoxdesignation.Name = "textBoxdesignation";
            this.textBoxdesignation.Size = new System.Drawing.Size(445, 26);
            this.textBoxdesignation.TabIndex = 13;
            // 
            // textBoxcdf
            // 
            this.textBoxcdf.Location = new System.Drawing.Point(211, 216);
            this.textBoxcdf.Name = "textBoxcdf";
            this.textBoxcdf.Size = new System.Drawing.Size(135, 26);
            this.textBoxcdf.TabIndex = 14;
            this.textBoxcdf.TextChanged += new System.EventHandler(this.textBoxcdf_TextCharged);
            // 
            // textBoxqte
            // 
            this.textBoxqte.Location = new System.Drawing.Point(211, 267);
            this.textBoxqte.Name = "textBoxqte";
            this.textBoxqte.Size = new System.Drawing.Size(135, 26);
            this.textBoxqte.TabIndex = 15;
            this.textBoxqte.TextChanged += new System.EventHandler(this.textBoxqte_TextChanged);
            // 
            // textBoxusd
            // 
            this.textBoxusd.Location = new System.Drawing.Point(556, 210);
            this.textBoxusd.Name = "textBoxusd";
            this.textBoxusd.Size = new System.Drawing.Size(100, 26);
            this.textBoxusd.TabIndex = 16;
            // 
            // textBoxqtecrit
            // 
            this.textBoxqtecrit.Location = new System.Drawing.Point(556, 267);
            this.textBoxqtecrit.Name = "textBoxqtecrit";
            this.textBoxqtecrit.ReadOnly = true;
            this.textBoxqtecrit.Size = new System.Drawing.Size(100, 26);
            this.textBoxqtecrit.TabIndex = 17;
            // 
            // btnannuler
            // 
            this.btnannuler.BackColor = System.Drawing.Color.Red;
            this.btnannuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnannuler.Location = new System.Drawing.Point(451, 405);
            this.btnannuler.Name = "btnannuler";
            this.btnannuler.Size = new System.Drawing.Size(205, 53);
            this.btnannuler.TabIndex = 18;
            this.btnannuler.Text = "Annuler";
            this.btnannuler.UseVisualStyleBackColor = false;
            this.btnannuler.Click += new System.EventHandler(this.btnannuler_Click);
            // 
            // btnajouter
            // 
            this.btnajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouter.ForeColor = System.Drawing.Color.Coral;
            this.btnajouter.Location = new System.Drawing.Point(36, 405);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(205, 53);
            this.btnajouter.TabIndex = 19;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.UseVisualStyleBackColor = false;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.ForeColor = System.Drawing.Color.White;
            this.labelMenu.Location = new System.Drawing.Point(12, 22);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(129, 20);
            this.labelMenu.TabIndex = 1;
            this.labelMenu.Text = "Ajouter Produit";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(605, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 53);
            this.button3.TabIndex = 20;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(915, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(0, 53);
            this.button4.TabIndex = 21;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(548, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(51, 53);
            this.button5.TabIndex = 22;
            this.button5.Text = "-";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // AjouterProduitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(682, 478);
            this.Controls.Add(this.btnajouter);
            this.Controls.Add(this.btnannuler);
            this.Controls.Add(this.textBoxqtecrit);
            this.Controls.Add(this.textBoxusd);
            this.Controls.Add(this.textBoxqte);
            this.Controls.Add(this.textBoxcdf);
            this.Controls.Add(this.textBoxdesignation);
            this.Controls.Add(this.comboBoxetat);
            this.Controls.Add(this.comboxTaux);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "AjouterProduitForm";
            this.Text = "Ajouter Produit";
            this.Load += new System.EventHandler(this.AjouterProduitForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboxTaux;
        private System.Windows.Forms.ComboBox comboBoxetat;
        private System.Windows.Forms.TextBox textBoxdesignation;
        private System.Windows.Forms.TextBox textBoxcdf;
        private System.Windows.Forms.TextBox textBoxqte;
        private System.Windows.Forms.TextBox textBoxusd;
        private System.Windows.Forms.TextBox textBoxqtecrit;
        private System.Windows.Forms.Button btnannuler;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Button button5;
    }
}