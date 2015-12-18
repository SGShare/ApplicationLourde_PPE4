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
    public partial class FormInsertionBDD : Form
    {
        public FormInsertionBDD()
        {
            InitializeComponent();
            
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
           controleur.init();
            controleur.Vmodele.seconnecter();
            if (controleur.Vmodele.Connopen == false)
            {
                MessageBox.Show("Erreur ouverture bdd : ", "PBS Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                controleur.Vmodele.import();
                if (controleur.Vmodele.Chargement == true)
                {
                    
                }
            }
            controleur.Vmodele.sedeconnecter();
           
           
        }

        private void FormInsertionBDD_FormClosed(object sender, FormClosedEventArgs e)
        {
            controleur.Vmodele.sedeconnecter();
        }
    }
}
