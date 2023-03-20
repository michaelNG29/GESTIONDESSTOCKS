using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTIONDESSTOCKS
{
    public partial class AjouterProduitForm : Form
    {
        public AjouterProduitForm()
        {
            InitializeComponent();
        }
        // importation de la classe permettant l'ajout des produit
        AjoutProdStock produit = new AjoutProdStock();
        private void AjouterProduitForm_Load(object sender, EventArgs e)
        {
            comboBoxetat.SelectedIndex = 0;
        }

        private void textBoxcdf_TextCharged(Object sender, EventArgs e)
        {
            conversionCDF_USD();
        }
        private void conversionCDF_USD()
        {
            if (textBoxcdf.Text.Trim()==string.Empty)
            {
                MessageBox.Show("Prix unitaire CDF est requis", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxcdf.Focus();
            }
            else
            {
                int tempcdf;
                bool isDecimal = int.TryParse(textBoxcdf.Text.Trim(),out tempcdf);
                if (!isDecimal)
                {
                    MessageBox.Show("Valeur prix unitaire cdf est numerique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxcdf.Focus();
                }
                else
                {
                    try
                    {
                        int taux = Convert.ToInt32(comboxTaux.Text.Trim());
                        decimal usd = Convert.ToDecimal(Convert.ToDecimal(textBoxcdf.Text.Trim()) / taux);
                        textBoxusd.Text = Math.Round(usd, 2, MidpointRounding.AwayFromZero).ToString();
                    }
                    catch(Exception e)
                    {
                        MessageBox.Show("Veillez remplir le taux du jour", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void textBoxqte_TextChanged(object sender, EventArgs e)
        {
            conversionqte_qtecri();
        }
        private void conversionqte_qtecri()
        {
            if (textBoxcdf.Text.Trim() == string.Empty)
            {
                MessageBox.Show("La quantite du produit est requise", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxcdf.Focus();
            }
            else
            {
                int tempProd;
                bool isnumeric = int.TryParse(textBoxqte.Text.Trim(), out tempProd);
                if (!isnumeric)
                {
                    MessageBox.Show("La quantite du produit est requise", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxqte.Focus();
                    textBoxqte.Clear();
                }
                else
                {
                        int qteProd = Convert.ToInt32(textBoxqte.Text.Trim());
                    int resultat = qteProd / 100;
                    textBoxqtecrit.Text = resultat.ToString();
                }
            }
        }

        //bouton d'ajout des produits
        private void btnajouter_Click(object sender, EventArgs e)
        {
            //creation des variables
            string designation = textBoxdesignation.Text.Trim();
            decimal cdf = Convert.ToDecimal(textBoxcdf.Text.Trim());
            decimal usd = Convert.ToDecimal(textBoxusd.Text.Trim());
            int stock = Convert.ToInt32(textBoxqte.Text.Trim());
            int qtecrit = Convert.ToInt32(textBoxqtecrit.Text.Trim());
            int taux = Convert.ToInt32(comboxTaux.Text.Trim());
            bool etat = true;

            //verification de l'index de comboBoxetatproduit
            if(comboBoxetat.SelectedIndex == 0)
            {
                etat = true;
            }
            else
            {
                etat = false;
            }

            if (!produit.verifProduit(designation))
            {

            //insertion des prod
            if (produit.AjouterProduit(designation,cdf,usd,stock,qtecrit,taux,etat))
            {
                MessageBox.Show("Produit Ajouter en stock avec succes", "ajouter produit", MessageBoxButtons.OK,MessageBoxIcon.Information);
                textBoxcdf.Clear();
                textBoxqte.Clear();
                comboBoxetat.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Erreur", "ajouter produit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            }
            else
            {
                MessageBox.Show("Ce nom de produit saisi existe deja dans le stock, veullez choisir autre nom produit", "Ancien Produit", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void comboxTaux_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            { 
                e.Handled = true;
                MessageBox.Show("veuillez saisir seulement la valeur numerique comme 1,2,3...!");
            }
        }

        private void comboBoxetat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("veuillez saisir seulement la valeur numerique comme 1,2,3...!");
            }
        }

        private void btnannuler_Click(object sender, EventArgs e)
        {
            textBoxdesignation.Text = "";
            textBoxcdf.Text = "";
            textBoxqtecrit.Text = "";
            textBoxusd.Text = "";
            comboBoxetat.SelectedIndex = 0;
        }
    }
}
  