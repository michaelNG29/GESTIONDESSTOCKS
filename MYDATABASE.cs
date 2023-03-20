using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace GESTIONDESSTOCKS
{
    internal class MYDATABASE
    {
        //Connexion a la base de donnees
        private MySqlConnection con = new MySqlConnection("Data Source = localhost; port = 3306; username =root; password=; database=genuisstock");

        //Methode de visibilite de notre objet connection a la base de donnee
        public MySqlConnection GetConnection
        {
            get
            {
                return con;
            }
        }

        //Ouverture de la connection a la base de donnee
        public void openConnection()
        {
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        //fermeture de la connection a la base de donnee
        public void closeConeection()
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
