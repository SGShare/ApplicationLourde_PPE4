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
        private MySqlDataAdapter mySqlDataAdapterPPE4 = new MySqlDataAdapter();
        private DataSet dataSetPPE4 = new DataSet();
        public DataView dv_identification = new DataView(), dv_visite = new DataView(), dv_contrevisite = new DataView(), dv_departement = new DataView(), dv_debutperiode = new DataView(), dv_finperiode = new DataView();

       


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

        public DataView Dv_departement
        {
            get { return dv_departement; }
            set { dv_departement = value; }
        }
        public DataView Dv_contrevisite
        {
            get { return dv_contrevisite; }
            set { dv_contrevisite = value; }
        }

        public DataView Dv_visite
        {
            get { return dv_visite; }
            set { dv_visite = value; }
        }

        public DataView Dv_identification
        {
            get { return dv_identification; }
            set { dv_identification = value; }
        }

        public DataView Dv_debutperiode
        {
            get { return dv_debutperiode; }
            set { dv_debutperiode = value; }
        }

        public DataView Dv_finperiode
        {
            get { return dv_finperiode; }
            set { dv_finperiode = value; }
        }
        #endregion


        public void seconnecter()
        {
            string myConnectionString = "Database=bd_ppe4_GaubertEtCo;Data Source=192.168.219.4;User Id=root;";
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
        public void import()
        {
            if (!connopen) return;
            mySqlDataAdapterPPE4.SelectCommand = new MySqlCommand("select id_inspecteur, motdepasse from inspecteur; select id_visite, date_visite, heure, nbetoilesplus, commentaire from visite; select id_contrevisite, date_contrevisite, heure, nbetoilesmoins, commentaire from contre_visite; select nom_departement from departement order by num_departement ASC; select date_debut from semaine; select date_fin from semaine; ", myConnection);
            try
            {
                dataSetPPE4.Clear();
                mySqlDataAdapterPPE4.Fill(dataSetPPE4);
                MySqlCommand vcommand = myConnection.CreateCommand();

                /*vcommand.CommandText = "SELECT AUTO_INCREMENT as last_id FROM INFORMATION_SCHEMA.TABLES WHERE table_name = 'personne'";
                UInt64 der_personne = (UInt64)vcommand.ExecuteScalar();
                dataSetPPE4.Tables[1].Columns[0].AutoIncrement = true;
                dataSetPPE4.Tables[1].Columns[0].AutoIncrementSeed = Convert.ToInt64(der_personne);
                dataSetPPE4.Tables[1].Columns[0].AutoIncrementStep = 1;*/

                dv_identification = dataSetPPE4.Tables[0].DefaultView; // requete login
                dv_visite = dataSetPPE4.Tables[1].DefaultView; // requete gestion visite
                dv_contrevisite = dataSetPPE4.Tables[2].DefaultView; // requete gestion contre visite
                dv_departement = dataSetPPE4.Tables[3].DefaultView; // requete affichage departement 
                dv_debutperiode = dataSetPPE4.Tables[4].DefaultView; // requete debut periode
                dv_finperiode = dataSetPPE4.Tables[5].DefaultView; // requete fin periode 

                chargement = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur chargement dataset : " + err, "PBS formation/personne", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errgrave = true;
            }
        }
    }

}
