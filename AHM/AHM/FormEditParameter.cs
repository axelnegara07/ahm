using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AHM
{
    public partial class FormEditParameter : Form
    {
        private FormConfiguration formConfiguration;
        private string connectionString;
        public FormEditParameter(FormConfiguration formConfiguration)
        {
            InitializeComponent();
            this.formConfiguration = formConfiguration;
            this.connectionString = formConfiguration.ConnectionString;
        }

        private void FormEditParameter_Load(object sender, EventArgs e)
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

            int selectedParameterId = formConfiguration.SelectedParameterId;
            DataRow parameterRow = ahmDataSet0.PART_ID.FindBypart_id_id(selectedParameterId);

            if (parameterRow != null)
            {
                txtParameterName.Text = parameterRow["part_id_name"].ToString();
                chkSendServer.Checked = Convert.ToInt32(parameterRow["send_server"]) == 1;
                cboTimes.SelectedItem = parameterRow["times"].ToString();
            }
            else
            {
                MessageBox.Show("Invalid parameter selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int selectedParameterId = formConfiguration.SelectedParameterId;
            DataRow parameterRow = ahmDataSet0.PART_ID.FindBypart_id_id(selectedParameterId);

            if (parameterRow != null)
            {
                int sendToIT = chkSendServer.Checked ? 1 : 0;
                int times = Convert.ToInt32(cboTimes.SelectedItem);

                parameterRow["part_id_name"] = txtParameterName.Text;
                parameterRow["send_server"] = sendToIT;
                parameterRow["times"] = times;

                pART_IDTableAdapter.Update(ahmDataSet0.PART_ID);

                formConfiguration.PopulateTreeView();

                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid parameter selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
