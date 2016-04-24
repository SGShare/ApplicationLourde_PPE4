using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationLourde_PPE4
{
    public partial class FormVisite : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        
        public FormVisite()
        {
            InitializeComponent();
            chargedgv();
        }

        public void chargedgv()
        {
            bindingSource1.DataSource = controleur.Vmodele.Dv_visite;
            DGV_visite.DataSource = bindingSource1;

            int vwidth = DGV_visite.RowHeadersWidth;
            for (int i = 0; i < DGV_visite.Columns.Count; i++) // pour gérer la taille des colonnes
            {
                if (DGV_visite.Columns[i].Visible)
                    vwidth = vwidth +
                    DGV_visite.Columns[i].GetPreferredWidth(DataGridViewAutoSizeColumnMode.AllCells, false);
            }
            DGV_visite.Width = vwidth;
            if (DGV_visite.ScrollBars.Equals(ScrollBars.Both) | DGV_visite.ScrollBars.Equals(ScrollBars.Vertical))
            {
                DGV_visite.Width += 20;
            }
            DGV_visite.Refresh();

            cbdepartement.Items.Clear();
            // creation d’une liste des departements
            List<KeyValuePair<int, string>> DepList = new List<KeyValuePair<int, string>>();
            DepList.Add(new KeyValuePair<int, string>(0, "tous les departements"));
            cbdepartement.Items.Add("tous les departements");
            // on parcourt le dataView des departements Dv_departement de la classe modele pour compléter la FList
            for (int i = 0; i < controleur.Vmodele.Dv_departement.ToTable().Rows.Count; i++)
            {
                DepList.Add(new KeyValuePair<int,
                string>((int)controleur.Vmodele.Dv_departement.ToTable().Rows[i][0],
                controleur.Vmodele.Dv_departement.ToTable().Rows[i][1].ToString()));
            }
            // on lie la liste à la comboBox
            cbdepartement.DataSource = DepList;
            cbdepartement.ValueMember = "Key";
            cbdepartement.DisplayMember = "Value";
            cbdepartement.Text = cbdepartement.Items[0].ToString();
            cbdepartement.DropDownStyle = ComboBoxStyle.DropDownList;

            cb_debutperiode.Items.Clear();
            // creation de la liste du debut de periode
            List<KeyValuePair<int, string>> DebutList = new List<KeyValuePair<int, string>>();
            DebutList.Add(new KeyValuePair<int, string>(0, "touts les debuts de periode"));
            cbdepartement.Items.Add("touts les debuts de periode");
            // on parcourt le dataView des periodes Dv_periode de la classe modele pour compléter la FList
            for (int i = 0; i < controleur.Vmodele.Dv_debutperiode.ToTable().Rows.Count; i++)
            {
                DebutList.Add(new KeyValuePair<int,
                string>((int)controleur.Vmodele.Dv_debutperiode.ToTable().Rows[i][1],
                controleur.Vmodele.Dv_debutperiode.ToTable().Rows[i][2].ToString()));
            }
            // on lie la liste à la comboBox
            cb_debutperiode.DataSource = DebutList;
            cb_debutperiode.ValueMember = "Key";
            cb_debutperiode.DisplayMember = "Value";
            cb_debutperiode.Text = cb_debutperiode.Items[0].ToString();
            cb_debutperiode.DropDownStyle = ComboBoxStyle.DropDownList;

            cb_finperiode.Items.Clear();
            // creation de la liste de fin de periode
            List<KeyValuePair<int, string>> FinList = new List<KeyValuePair<int, string>>();
            DebutList.Add(new KeyValuePair<int, string>(0, "toutes les fins de periode"));
            cbdepartement.Items.Add("toutes les fins de periode");
            // on parcourt le dataView des periodes Dv_periode de la classe modele pour compléter la FList
            for (int i = 0; i < controleur.Vmodele.Dv_finperiode.ToTable().Rows.Count; i++)
            {
                DebutList.Add(new KeyValuePair<int,
                string>((int)controleur.Vmodele.Dv_finperiode.ToTable().Rows[i][1],
                controleur.Vmodele.Dv_finperiode.ToTable().Rows[i][2].ToString()));
            }
            // on lie la liste à la comboBox
            cb_finperiode.DataSource = FinList;
            cb_finperiode.ValueMember = "Key";
            cb_finperiode.DisplayMember = "Value";
            cb_finperiode.Text = cb_finperiode.Items[0].ToString();
            cb_finperiode.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
