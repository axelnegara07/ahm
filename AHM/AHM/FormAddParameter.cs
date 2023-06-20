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
    public partial class FormAddParameter : Form
    {
        private FormConfiguration formConfiguration;
        private FormConParameter formConParameter;
        private string connectionString;
        public FormAddParameter(FormConParameter formConParameter, FormConfiguration formConfiguration)
        {
            InitializeComponent();
            this.formConParameter = formConParameter;
            this.formConfiguration = formConfiguration;
            this.connectionString = formConfiguration.ConnectionString;
        }

        private void FormAddParameter_Load(object sender, EventArgs e)
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

            var selectedNode = formConfiguration.GetSelectedNode();

            if (selectedNode.Level != 2)
            {
                MessageBox.Show("Please select a machine.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            string machineName = selectedNode?.Text;
            txtMachineName.Text = machineName;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtParameterName.Text))
            {
                MessageBox.Show("Please enter a parameter name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int sendToIT = chkSendServer.Checked ? 1 : 0;
            int times = Convert.ToInt32(cboTimes.SelectedItem);

            var newRow = ahmDataSet0.PART_ID.NewPART_IDRow();
            newRow.part_id_name = txtParameterName.Text;
            newRow.send_server = sendToIT;
            newRow.times = times;
            newRow.id_machine_id = formConfiguration.SelectedMachineId;
            ahmDataSet0.PART_ID.AddPART_IDRow(newRow);
            pART_IDTableAdapter.Update(ahmDataSet0.PART_ID);

            formConfiguration.PopulateTreeView();

            this.Close();
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMachineName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
