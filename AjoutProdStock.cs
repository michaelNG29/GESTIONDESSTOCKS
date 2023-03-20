using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace GESTIONDESSTOCKS
{
    internal class AjoutProdStock
    {
        //importation de la classe mere mydatabase
        MYDATABASE db = new MYDATABASE();

        //creation de la fonction d'ajout des produits en stock
        public bool AjouterProduit(string designation, decimal pu_cdf, decimal pu_usd, int qte, int qte_crit, int taux, Boolean etat)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO produit(designation,pu_cdf,pu_usd,stock,qte_crit,taux,isactive) VALUES (@designation,@pu_cdf,@pu_usd,@qte,@qte_crit,@taux,@etat)", db.GetConnection);

            //@designation,@pu_cdf,@pu_usd,@qte,@qte_crit,@taux,@etat
            cmd.Parameters.Add("@designation", MySqlDbType.VarChar).Value = designation;
            cmd.Parameters.Add("@pu_cdf", MySqlDbType.Decimal).Value = pu_cdf;
            cmd.Parameters.Add("@pu_usd", MySqlDbType.Decimal).Value = pu_usd;
            cmd.Parameters.Add("@qte", MySqlDbType.Int32).Value = qte;
            cmd.Parameters.Add("@qte_crit", MySqlDbType.Int32).Value = qte_crit;
            cmd.Parameters.Add("@taux", MySqlDbType.VarChar).Value = taux;
            cmd.Parameters.Add("@etat", MySqlDbType.VarChar).Value = etat;

            db.openConnection();
            
            if(cmd.ExecuteNonQuery() == 1)
            {
                db.closeConeection();
                return true;
            }
            else
            {
                db.closeConeection();
                return false;
            }
        }
        //verification des produits en stock
        public bool verifProduit(string designation)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `produit` WHERE `designation`=@designation",db.GetConnection);
            command.Parameters.Add("@designation", MySqlDbType.VarChar).Value = designation;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);
            if(table.Rows.Count > 0)
            {
                db.closeConeection();
                return true;

            }
            else
            {
                db.closeConeection();
                return false;
            }
        }
    }
}
