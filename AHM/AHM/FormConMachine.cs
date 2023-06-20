using AHM.AhmDataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AHM
{
    public partial class FormConMachine : System.Windows.Forms.Form
    {
        private FormConfiguration formConfiguration;
        private string connectionString;
        public FormConMachine(FormConfiguration formConfiguration)
        {
            InitializeComponent();
            this.formConfiguration = formConfiguration;
            this.connectionString = formConfiguration.ConnectionString;
        }

        private void FormConMachine_Load(object sender, EventArgs e)
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

        }

        private void btnAddMachine_Click(object sender, EventArgs e)
        {
            FormAddMachine formAddMachine = new FormAddMachine(this, formConfiguration);
            this.Close();
            formAddMachine.ShowDialog();
        }



        private void btnDeleteMachine_Click(object sender, EventArgs e)
        {
            var selectedNode = formConfiguration.GetSelectedNode();
            if (selectedNode == null)
            {
                MessageBox.Show("Mohon pilih Machine yang ingin dihapus");
                return;
            }

            if (selectedNode.Level != 2)
            {
                MessageBox.Show("Mohon pilih Machine yang ingin dihapus");
                return;
            }

            if (MessageBox.Show($"Apakah Anda yakin ingin menghapus Machine {selectedNode.Text}?", "Konfirmasi Hapus Machine", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var machineRow = ahmDataSet0.MACHINE.FirstOrDefault(r => r["machine_name"].ToString() == selectedNode.Text);

                if (machineRow == null)
                {
                    MessageBox.Show("Machine tidak ditemukan");
                    return;
                }

                var partIdsForMachine = ahmDataSet0.PART_ID.Select($"id_machine_id = {machineRow["machine_id"]}");

                foreach (var partIdRow in partIdsForMachine)
                {
                    partIdRow.Delete();
                }

                machineRow.Delete();

                mACHINETableAdapter.Update(ahmDataSet0.MACHINE);
                pART_IDTableAdapter.Update(ahmDataSet0.PART_ID);

                selectedNode.Remove();

                MessageBox.Show("Machine berhasil dihapus");
                this.Close();
            }
        }
    }
}
