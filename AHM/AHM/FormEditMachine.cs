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
    public partial class FormEditMachine : Form
    {
        private FormConfiguration formConfiguration;
        private string connectionString;
        public FormEditMachine(FormConfiguration formConfiguration)
        {
            InitializeComponent();
            this.formConfiguration = formConfiguration;
            this.connectionString = formConfiguration.ConnectionString;
        }

        private void FormEditMachine_Load(object sender, EventArgs e)
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

            int selectedMachineId = formConfiguration.SelectedMachineId;
            DataRow machineRow = ahmDataSet0.MACHINE.FindBymachine_id(selectedMachineId);

            if (machineRow != null)
            {
                txtMachineName.Text = machineRow["machine_name"].ToString();
                cboMachineCode.Text = machineRow["machine_code"].ToString();
            }
            else
            {
                MessageBox.Show("Invalid machine selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int selectedMachineId = formConfiguration.SelectedMachineId;
            DataRow machineRow = ahmDataSet0.MACHINE.FindBymachine_id(selectedMachineId);

            if (machineRow != null)
            {
                machineRow["machine_name"] = txtMachineName.Text;
                machineRow["machine_code"] = cboMachineCode.Text;
                mACHINETableAdapter.Update(ahmDataSet0.MACHINE);

                formConfiguration.PopulateTreeView();

                this.Close();

            }
            else
            {
                MessageBox.Show("Invalid machine selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
