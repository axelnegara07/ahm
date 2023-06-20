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
    public partial class FormAddMachine : System.Windows.Forms.Form
    {
        private FormConfiguration formConfiguration;
        private FormConMachine formConMachine;
        private string connectionString;

        public FormAddMachine(FormConMachine formConMachine, FormConfiguration formConfiguration)
        {
            InitializeComponent();
            this.formConMachine = formConMachine;
            this.formConfiguration = formConfiguration;
            this.connectionString = formConfiguration.ConnectionString;
        }

        private void FormAddMachine_Load(object sender, EventArgs e)
        {
            this.pART_IDTableAdapter.Connection.ConnectionString = connectionString;
            this.mACHINETableAdapter.Connection.ConnectionString = connectionString;
            this.lINETableAdapter.Connection.ConnectionString = connectionString;
            this.pLANTTableAdapter.Connection.ConnectionString = connectionString;
            this.cONFIGURATIONTableAdapter.Connection.ConnectionString = connectionString;

            this.pART_IDTableAdapter.Fill(this.ahmDataSet0.PART_ID);
            this.mACHINETableAdapter.FillByIdLineNull(this.ahmDataSet0.MACHINE);
            this.lINETableAdapter.Fill(this.ahmDataSet0.LINE);
            this.pLANTTableAdapter.Fill(this.ahmDataSet0.PLANT);
            this.cONFIGURATIONTableAdapter.Fill(this.ahmDataSet0.CONFIGURATION);

            if (formConfiguration.GetSelectedNode().Level != 1)
            {
                MessageBox.Show("Please select a line.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMachineName.Text))
            {
                MessageBox.Show("Please enter a machine name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(cboMachineCode.Text))
            {
                MessageBox.Show("Please enter a machine no.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var newRow = ahmDataSet0.MACHINE.NewMACHINERow();
            newRow.machine_name = txtMachineName.Text;
            newRow.machine_code = cboMachineCode.Text;
            newRow.id_line_id = formConfiguration.SelectedLineId;
            ahmDataSet0.MACHINE.AddMACHINERow(newRow);
            mACHINETableAdapter.Update(ahmDataSet0.MACHINE);

            formConfiguration.PopulateTreeView();

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboMachineCode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
