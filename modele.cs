using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLourde_PPE4
{
    class modele
    {
        private MySqlConnection myConnection;
        private bool connopen = false;
        private bool errgrave = false;
        private bool chargement = false;


        #region accesseur
        public MySqlConnection MyConnection
        {
            get { return myConnection; }
            set { myConnection = value; }
        }

        public bool Connopen
        {
            get { return connopen; }
            set { connopen = value; }
        }

        public bool Errgrave
        {
            get { return errgrave; }
            set { errgrave = value; }
        }

        public bool Chargement
        {
            get { return chargement; }
            set { chargement = value; }
        }
        #endregion


        public void seconnecter()
        {
            string myConnectionString = "Database=bd_ppe4_lldj;Data Source=localhost;User Id=root;";
            myConnection = new MySqlConnection(myConnectionString);
            try
            {
                myConnection.Open();
                connopen = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur ouverture bdd : " + err, "PBS connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connopen = false;
                errgrave = true;
            }
        }

        public void sedeconnecter()
        {
            if (!connopen)
                return;
            try
            {
                myConnection.Close();
                myConnection.Dispose();
                connopen = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur fermeture bdd : " + err, "PBS deconnection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errgrave = true;
            }
        }
    }

}
