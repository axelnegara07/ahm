using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AHM.AhmDataSet1;

namespace AHM
{
    public partial class FormModifyPlant : Form
    {
        private FormConfiguration formConfiguration;
        private string connectionString;
        public FormModifyPlant(FormConfiguration formConfiguration)
        {
            InitializeComponent();
            this.formConfiguration = formConfiguration;
            this.connectionString = formConfiguration.ConnectionString;
        }

        private void FormModifyPlant_Load(object sender, EventArgs e)
        {
            this.pART_IDTableAdapter.Connection.ConnectionString = connectionString;
            this.mACHINETableAdapter.Connection.ConnectionString = connectionString;
            this.lINETableAdapter.Connection.ConnectionString = connectionString;
            this.pLANTTableAdapter.Connection.ConnectionString = connectionString;
            this.cONFIGURATIONTableAdapter.Connection.ConnectionString = connectionString;

            this.pART_IDTableAdapter.Fill(this.ahmDataSet0.PART_ID);
            this.mACHINETableAdapter.Fill(this.ahmDataSet0.MACHINE);
            this.lINETableAdapter.Fill(this.ahmDataSet0.LINE);
            this.pLANTTableAdapter.Fill(this.ahmDataSet0.PLANT);
            this.cONFIGURATIONTableAdapter.Fill(this.ahmDataSet0.CONFIGURATION);

            int selectedPlantId = formConfiguration.SelectedPlantId;
            DataRow plantRow = ahmDataSet0.PLANT.FindByplant_id(selectedPlantId);

            if (formConfiguration.GetSelectedNode().Level != 0)
            {
                MessageBox.Show("Please select a plant.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            if (plantRow != null)
            {
                txtPlantName.Text = plantRow["plant_code"].ToString();
                cboVid.Text = plantRow["vid"].ToString();
            }
            else
            {
                MessageBox.Show("Invalid plant selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPlantName.Text))
            {
                MessageBox.Show("Please enter a plant name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int selectedPlantId = formConfiguration.SelectedPlantId;
            DataRow plantRow = ahmDataSet0.PLANT.FindByplant_id(selectedPlantId);

            if (plantRow != null)
            {
                plantRow["plant_code"] = txtPlantName.Text;
                plantRow["vid"] = cboVid.Text;
                pLANTTableAdapter.Update(ahmDataSet0.PLANT);

                formConfiguration.PopulateTreeView();

                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid plant selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
